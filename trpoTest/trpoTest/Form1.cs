using trpoTest.tableForms;

namespace trpoTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            employeeTable1.DataSource = Program.dataSource;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ZBRForm().Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            employeeTable1.FillTable();
        }
    }
}
