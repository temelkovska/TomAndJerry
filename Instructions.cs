using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TomAndJerry
{
    public partial class Instructions : Form
    {
        private Form1 form;

        public Instructions()
        {
            InitializeComponent();
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            form = new Form1();
            form.Show();
        }
    }
}
