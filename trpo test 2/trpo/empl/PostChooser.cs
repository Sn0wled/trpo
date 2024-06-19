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
    public partial class PostChooser : Form
    {
        public PostChooser()
        {
            InitializeComponent();
        }
        public bool Choosen { get; private set; }
        public Post Selected { get; private set; }

        public int? PostId { private get; set; } = null;
        

        private void searchTB_TextChanged(object sender, EventArgs e)
        {
            if (searchTB.Text.Length == 0) return;
            foreach (DataGridViewRow row in postDataGrid.Rows)
            {
                if (row.Cells[0].Value.ToString().StartsWith(searchTB.Text))
                {
                    row.Selected = true;
                    break;
                }
            }
        }

        private void chooseButton_Click(object sender, EventArgs e)
        {
            if (postDataGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Должность не выбрана");
            }
            else
            {
                Selected = postDataGrid.SelectedRows[0].DataBoundItem as Post;
                Choosen = true;
                Close();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PostChooser_Load(object sender, EventArgs e)
        {
            postBindingSource.DataSource = new SortableList<Post>(PostDatasource.GetAll());
            if (PostId != null)
            {
                foreach (DataGridViewRow row in postDataGrid.Rows)
                {
                    if ((row.DataBoundItem as Post).Id == PostId)
                    {
                        row.Selected = true;
                        break;
                    }
                }
            }
        }
    }
}
