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

namespace trpo.containers
{
    public partial class CubeContainerEditor : Form
    {
        public CubeContainerEditor()
        {
            InitializeComponent();
        }

        CubeContainer edited = new();
        bool isEditor = false;
        string oldInvNum;
        public CubeContainer Edited
        {
            get { return edited; }
            init
            {
                isEditor = true;
                title.Text = "Изменение контейнера";
                invNumTB.Text = value.InvNum;
                typeTB.Text = value.Type;
                weightTB.Text = value.Weight.ToString();
                lenTB.Text = value.Length.ToString();
                widthTB.Text = value.Width.ToString();
                heightTB.Text = value.Height.ToString();
                oldInvNum = value.InvNum;
            }
        }
        public bool Saved { get; private set; } = false;

        private void saveButton_Click(object sender, EventArgs e)
        {
            decimal weight;
            int len, width, height;
            if (!checkInvNum())
            {
                MessageBox.Show("Инвентарный номер должен состоять из 5 десятичных цифр");
                invNumTB.Focus();
            }
            else if (!checkType())
            {
                MessageBox.Show("Тип контейнера не указан");
                typeTB.Focus();
            }
            else if (!checkWeight(out weight))
            {
                MessageBox.Show("Вес контейнера не указан или указан неправильно");
                weightTB.Focus();
            }
            else if (!checkLen(out len))
            {
                MessageBox.Show("Длина контейнера не указана или указана неправильно");
                lenTB.Focus();
            }
            else if (!checkWidth(out width))
            {
                MessageBox.Show("Ширина контейнера не указана или указана неправильно");
                widthTB.Focus();
            }
            else if (!checkHeight(out height))
            {
                MessageBox.Show("Высота контейнера не указана или указана неправильно");
                heightTB.Focus();
            }
            else
            {
                edited.InvNum = invNumTB.Text;
                edited.Type = typeTB.Text;
                edited.Weight = weight;
                edited.Width = width;
                edited.Height = height;
                edited.Length = len;

                try
                {
                    if (isEditor)
                    {
                        ContainerDataSource.UpdateCubeContainer(ref edited, oldInvNum);
                    }
                    else
                    {
                        ContainerDataSource.AddCubeContainer(ref edited);
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

        private bool checkInvNum()
        {
            return Regex.Match(invNumTB.Text, @"\d{5}").Success;
        }
        private bool checkWeight(out decimal parse)
        {
            if (Regex.Match(weightTB.Text, @"\d{1,3}").Success)
            {
                return decimal.TryParse(weightTB.Text, out parse);
            }
            parse = 0;
            return false;
        }
        private bool checkType()
        {
            return typeTB.Text.Length != 0;
        }
        private bool checkLen(out int parse)
        {
            return int.TryParse(lenTB.Text, out parse) && parse > 0;
        }
        private bool checkWidth(out int parse)
        {
            return int.TryParse(widthTB.Text, out parse) && parse > 0;
        }
        private bool checkHeight(out int parse)
        {
            return int.TryParse(heightTB.Text, out parse) && parse > 0;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
