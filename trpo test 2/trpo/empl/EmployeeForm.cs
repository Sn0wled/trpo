using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using trpo_test_2.colections;
using trpo_test_2.models;

namespace trpo.empl
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            employeeBindingSource.DataSource = new SortableList<Employee>(EmployeeDatasource.GetAll());
            searchParam.SelectedIndex = 0;
        }

        void FindAt(string val, int num)
        {
            foreach (DataGridViewRow row in empDataGrid.Rows)
            {
                if (row.Cells[num].Value.ToString().StartsWith(val))
                {
                    row.Selected = true;
                    return;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (searchTB.Text.Length == 0) return;
            FindAt(searchTB.Text, searchParam.SelectedIndex);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            EmployeeEditor editor = new();
            editor.ShowDialog();
            if (editor.Saved)
            {
                int i = employeeBindingSource.Add(editor.Edited);
                empDataGrid.Rows[i].Selected = true;
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            if (empDataGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Не выбран сотрудник");
            }
            else
            {
                Employee emp = empDataGrid.SelectedRows[0].DataBoundItem as Employee;
                EmployeeEditor editor = new() { Edited = emp };
                editor.ShowDialog();
                if (editor.Saved)
                {
                    employeeBindingSource.Remove(emp);
                    int i = employeeBindingSource.Add(editor.Edited);
                    empDataGrid.Rows[i].Selected = true;
                }
            }
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            if (empDataGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Сотрудник не выбран");
            }
            else
            {
                bool confirm = MessageBox.Show("Подтвердите удаление", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes;
                Employee deleted = empDataGrid.SelectedRows[0].DataBoundItem as Employee;
                if (confirm)
                {
                    try
                    {
                        EmployeeDatasource.Delete(deleted.TabNum);
                        employeeBindingSource.Remove(deleted);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }
        }
    }
}
