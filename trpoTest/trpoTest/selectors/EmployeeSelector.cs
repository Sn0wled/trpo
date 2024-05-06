using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trpoTest.selectors
{
    public partial class EmployeeSelector : Form
    {
        public event EventHandler Selected;
        public string SelectedTabNum => employeeTable1.SelectedTabNum;
        public EmployeeSelector()
        {
            InitializeComponent();
            employeeTable1.DataSource = Program.dataSource;
        }

        public void CheckSave()
        {
            if (employeeTable1.HasSelected)
            {
                saveButton.Enabled = true;
            }
            else
            {
                saveButton.Enabled = false;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Selected?.Invoke(this, EventArgs.Empty);
            Close();
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
