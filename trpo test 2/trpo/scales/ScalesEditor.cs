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

namespace trpo.scales
{
    public partial class ScalesEditor : Form
    {
        public ScalesEditor()
        {
            InitializeComponent();
        }

        string oldInvNum;
        public bool Saved { get; private set; }
        Scales edited = new();
        bool isEditor = false;
        public Scales Edited
        {
            get
            {
                return edited;
            }
            init
            {
                isEditor = true;
                title.Text = "Изменение весов";
                invNumTB.Text = value.InvNum;
                brandTB.Text = value.Brand;
                calDateDP.Value = value.CalibrationDate.ToDateTime(TimeOnly.MinValue);
                maxWTB.Text = value.MaxWeight.ToString();
                errorTB.Text = value.Error.ToString();
                oldInvNum = value.InvNum;
            }
        }

        bool checkInvNum()
        {
            return Regex.Match(invNumTB.Text, @"\d{10}").Success;
        }
        bool checkBrand()
        {
            return brandTB.Text.Length != 0;
        }
        bool checkCalDate()
        {
            return calDateDP.Value <= DateTime.Now;
        }

        bool checkMaxW(out decimal parse)
        {
            bool rc = Regex.Match(maxWTB.Text, @"\d{1,7}(?:.\d{1,3})?").Success;
            if (rc)
            {
                return decimal.TryParse(maxWTB.Text, out parse);
            }
            else
            {
                parse = 0;
                return false;
            }
        }

        bool checkError(out decimal parse)
        {
            bool rc = Regex.Match(errorTB.Text, @"\d{1,7}(?:.\d{1,3})?").Success;
            if (rc)
            {
                return decimal.TryParse(errorTB.Text, out parse);
            }
            else
            {
                parse = 0;
                return false;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            decimal maxW, error;
            if (!checkInvNum())
            {
                MessageBox.Show("Введен некорректный инвентарный номер");
                invNumTB.Focus();
                return;
            }
            if (!checkBrand())
            {
                MessageBox.Show("Поле \"Марка\" не может быть пустым");
                brandTB.Focus();
                return;
            }
            if (!checkCalDate())
            {
                MessageBox.Show("Некорректная дата калибровки");
                calDateDP.Focus();
                return;
            }
            if (!checkMaxW(out maxW))
            {
                MessageBox.Show("Мааксимальный вес введен некорректно");
                maxWTB.Focus();
                return;
            }
            if (!checkError(out error))
            {
                MessageBox.Show("Введена некорректная погрешность");
            }

            edited.InvNum = invNumTB.Text;
            edited.Brand = brandTB.Text;
            edited.CalibrationDate = DateOnly.FromDateTime(calDateDP.Value);
            edited.MaxWeight = maxW;
            edited.Error = error;
            try
            {
                if (isEditor)
                {
                    ScalesDataSource.UpdateScales(ref edited, oldInvNum);
                }
                else
                {
                    ScalesDataSource.AddScales(ref edited);
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
