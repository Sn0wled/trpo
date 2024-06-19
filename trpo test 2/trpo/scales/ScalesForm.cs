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

namespace trpo.scales
{
    public partial class ScalesForm : Form
    {
        public ScalesForm()
        {
            InitializeComponent();
        }

        private void ScalesForm_Load(object sender, EventArgs e)
        {
            scalesBindingSource.DataSource = new SortableList<Scales>(ScalesDataSource.GetAll());
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            if (scaleDataGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Весы не выбраны");
                return;
            }
            else
            {
                bool confirm = MessageBox.Show("Подтвердите удаление", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes;
                if (confirm)
                {
                    try
                    {
                        Scales scales = scaleDataGrid.SelectedRows[0].DataBoundItem as Scales;
                        ScalesDataSource.Delete(scales);
                        scalesBindingSource.Remove(scales);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var editor = new ScalesEditor();
            editor.ShowDialog();
            if (editor.Saved)
            {
                scalesBindingSource.Add(editor.Edited);
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            if (scaleDataGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Не выбраны весы");
            }
            else
            {
                Scales edited = scaleDataGrid.SelectedRows[0].DataBoundItem as Scales;
                ScalesEditor editor = new() { Edited = edited };
                editor.ShowDialog();
                if (editor.Saved)
                {
                    scalesBindingSource.Remove(edited);
                    scalesBindingSource.Add(editor.Edited);
                    foreach (DataGridViewRow row in scaleDataGrid.Rows)
                    {
                        if (row.DataBoundItem == editor.Edited)
                        {
                            row.Selected = true;
                            break;
                        }
                    }
                }
            }
        }
    }
}
