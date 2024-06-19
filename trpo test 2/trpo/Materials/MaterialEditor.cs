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

namespace trpo.Materials
{
    public partial class MaterialEditor : Form
    {
        public MaterialEditor()
        {
            InitializeComponent();
        }
        public bool IsEditor { get; private set; } = false;

        Material material = new();
        public bool Saved { get; private set; }
        public Material Edited
        {
            get { return material; }
            set
            {
                material = value;
                matType.Text = material.Type;
                am.Text = material.AtomicMass.ToString();
                IsEditor = true;
                windowLabel.Text = "Редактирование материала";
            }
        }

        private void am_TextChanged(object sender, EventArgs e)
        {
            if (am.Text.Length > 0)
            {
                var isValid = Regex.IsMatch(am.Text, @"\A[0-9]{1,7}(?:[.,][0-9]{0,3})?\z");
                if (!isValid)
                {
                    am.Text = am.Text.Remove(am.Text.Length - 1, 1);
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            material.Type = matType.Text;
            material.AtomicMass = decimal.Parse(am.Text);
            try
            {
                if (IsEditor)
                {
                    MatereialDataSource.UpdateMaterial(ref material);
                }
                else
                {
                    MatereialDataSource.AddMaterial(ref material);
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
