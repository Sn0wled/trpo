using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using trpo_test_2.colections;
using trpo_test_2.models;

namespace trpo.empl
{
    public partial class EmployeeEditor : Form
    {
        public EmployeeEditor()
        {
            InitializeComponent();
        }
        int? postId = null;
        Employee edited = new();
        public bool Saved { get; private set; } = false;
        bool isEditor = false;
        string oldTN;
        public Employee Edited
        {
            get
            {
                return edited;
            }
            set
            {
                windowLabel.Text = "Редактирование работника";
                isEditor = true;
                tabNumTB.Text = value.TabNum.ToString();
                lNameTB.Text = value.LName.ToString();
                fNameTB.Text = value.FName.ToString();
                pNameTB.Text = value.PName;
                postId = value.PostId;
                postButton.Text = value.PostName;
                addressTB.Text = value.Address;
                bDayDP.Value = value.BDay;
                INNTB.Text = value.INN;
                SNILSTB.Text = value.SNILS;
                passTB.Text = value.PassportSaN;
                pNumTB.Text = value.PNum;
                oldTN = value.TabNum;
            }
        }


        private void choosePost(object sender, EventArgs e)
        {
            PostChooser chooser = new();
            if (postId != null)
            {
                chooser.PostId = postId.Value;
            }
            chooser.ShowDialog();
            if (chooser.Choosen)
            {
                postId = chooser.Selected.Id;
                postButton.Text = chooser.Selected.Name;
            }
        }

        bool checkTabNum()
        {
            return Regex.Match(tabNumTB.Text, @"\d{6}").Success;
        }

        bool checkFName()
        {
            return Regex.Match(fNameTB.Text, @"\p{IsCyrillic}{2,50}").Success;
        }

        bool checkLName()
        {
            return Regex.Match(lNameTB.Text, @"\p{IsCyrillic}{2,50}").Success;
        }

        bool checkPName()
        {
            return Regex.Match(fNameTB.Text, @"(\p{IsCyrillic}){0,50}").Success;
        }

        bool checkAddress()
        {
            return addressTB.Text.Length != 0;
        }

        bool checkBDay()
        {
            DateTime now = DateTime.Today;
            int age = now.Year - bDayDP.Value.Year;
            if (bDayDP.Value > now.AddYears(-age)) age--;
            return age >= 14;
        }

        bool checkINN()
        {
            return Regex.Match(INNTB.Text, @"\d{12}").Success;
        }
        bool checkSNILS()
        {
            return Regex.Match(SNILSTB.Text, @"\d{11}").Success;
        }
        bool checkPass()
        {
            return Regex.Match(passTB.Text, @"\d{10}").Success;
        }
        bool checkPost()
        {
            return postId != null;
        }

        bool checkPNum()
        {
            if (pNumTB.Text.Length == 0) return true;
            return Regex.Match(pNumTB.Text, @"\d-\d{2}-\d{2}").Success;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!checkTabNum())
            {
                MessageBox.Show("Некорректый табельный номер");
                tabNumTB.Focus();
                return;
            }
            if (!checkLName())
            {
                MessageBox.Show("Некорректно указана фамилия");
                lNameTB.Focus();
                return;
            }
            if (!checkFName())
            {
                MessageBox.Show("Некорректно указано имя");
                fNameTB.Focus();
                return;
            }
            if (!checkPName())
            {
                MessageBox.Show("Некорректно указано отчество");
                pNameTB.Focus();
                return;
            }
            if (!checkPost())
            {
                MessageBox.Show("Не выбрана должность");
                return;
            }
            if (!checkBDay())
            {
                MessageBox.Show("Работнику не может быть меньше 14 лет");
                bDayDP.Focus();
                return;
            }
            if (!checkINN())
            {
                MessageBox.Show("Некорректный ИНН");
                INNTB.Focus();
                return;
            }
            if (!checkSNILS())
            {
                MessageBox.Show("Некорректный СНИЛС");
                SNILSTB.Focus();
                return;
            }
            if (!checkPass())
            {
                MessageBox.Show("Некорректные пасспортные данные");
                passTB.Focus();
                return;
            }
            if (!checkPNum())
            {
                MessageBox.Show("Некорректный номер телефона");
                pNumTB.Focus();
                return;
            }

            edited.TabNum = tabNumTB.Text;
            edited.FName = fNameTB.Text;
            edited.PNum = pNumTB.Text.Length == 0 ? null : pNumTB.Text;
            edited.LName = lNameTB.Text;
            edited.PName = pNameTB.Text.Length == 0 ? null : pNameTB.Text;
            edited.Address = addressTB.Text.Length == 0 ? null : addressTB.Text;
            edited.BDay = bDayDP.Value;
            edited.INN = INNTB.Text;
            edited.SNILS = SNILSTB.Text;
            edited.PassportSaN = passTB.Text;
            edited.PostId = postId!.Value;

            try
            {
                if (isEditor)
                {
                    EmployeeDatasource.Update(ref edited, oldTN);
                }
                else
                {
                    EmployeeDatasource.Add(ref edited);
                }
                Saved = true;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
