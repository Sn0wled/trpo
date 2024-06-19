using System.ComponentModel;
using System.Data;
using trpo.containers;
using trpo.empl;
using trpo.Materials;
using trpo.scales;
using trpo_test_2.colections;
using trpo_test_2.models;

namespace trpo
{
    public partial class Form1 : Form
    {
        SortableList<Zbm> zbmList;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void zbmBuildPlaceButton_Click(object sender, EventArgs e)
        {
            Form form = new ZbmBuildingPlace();
            form.ShowDialog();
        }

        private void materialButton_Click(object sender, EventArgs e)
        {
            MaterialsForm form = new MaterialsForm();
            form.ShowDialog();
        }

        private void contButton_Click(object sender, EventArgs e)
        {
            ContainersForm form = new ContainersForm();
            form.ShowDialog();
        }

        private void scalesButton_Click(object sender, EventArgs e)
        {
            Form form = new ScalesForm();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new EmployeeForm();
            form.ShowDialog();
        }
    }
}
