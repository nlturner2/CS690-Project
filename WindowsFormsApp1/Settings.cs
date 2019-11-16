using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
