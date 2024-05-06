using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trpoTest.buttons
{
    public partial class ButtonsForTable : UserControl
    {
        public event EventHandler CreateClicked
        {
            add
            {
                createButton.Click += value;
            }
            remove
            {
                createButton.Click -= value;
            }
        }
        public event EventHandler DeleteClicked
        {
            add
            {
                deleteButton.Click += value;
            }
            remove
            {
                deleteButton.Click -= value;
            }
        }
        public event EventHandler EditClicked
        {
            add
            {
                editButton.Click += value;
            }
            remove
            {
                editButton.Click -= value;
            }
        }

        public ButtonsForTable()
        {
            InitializeComponent();
        }

        public void CheckEditDel(object? check)
        {
            if (check == null)
            {
                editButton.Enabled = false;
                deleteButton.Enabled = false;
            }
            else
            {
                editButton.Enabled = true;
                deleteButton.Enabled = true;
            }
        }

        public void CheckAdd(bool PrevEmpty)
        {
            if (PrevEmpty)
            {
                createButton.Enabled = false;
            }
            else
            {
                createButton.Enabled = true;
            }
        }
    }
}
