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

namespace trpo.Materials
{
    public partial class MaterialsForm : Form
    {
        public MaterialsForm()
        {
            InitializeComponent();
        }

        private void Materials_Load(object sender, EventArgs e)
        {
            materialBindingSource.DataSource = new SortableList<Material>(MatereialDataSource.GetAll());
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            MaterialEditor editor = new MaterialEditor();
            editor.ShowDialog();
            if (editor.Saved)
            {
                int index = materialBindingSource.Add(editor.Edited);
                matDataGrid.Rows[index].Selected = true;
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            if (matDataGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Материал не выбран");
            }
            else
            {
                Material edited = matDataGrid.SelectedRows[0].DataBoundItem as Material;
                MaterialEditor editor = new MaterialEditor() { Edited = edited };
                editor.ShowDialog();
                if (editor.Saved)
                {
                    materialBindingSource.Remove(edited);
                    int index = materialBindingSource.Add(editor.Edited);
                    matDataGrid.Rows[index].Selected = true;
                }
            }
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            if (matDataGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Материал не выбран");
            }
            else
            {
                bool confirm = MessageBox.Show("Подтвердите удаление", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes;
                Material deleted = matDataGrid.SelectedRows[0].DataBoundItem as Material;
                if (confirm)
                {
                    try
                    {
                        MatereialDataSource.DeleteMaterial(deleted);
                        materialBindingSource.Remove(deleted);
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
