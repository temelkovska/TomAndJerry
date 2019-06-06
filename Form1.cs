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
    public partial class Form1 : Form
    {
        private Play playForm;
        private Instructions instructionsForm;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            this.Hide();
            playForm = new Play();
            playForm.Show();            
        }

        private void btnInstructions_Click(object sender, EventArgs e)
        {
            this.Hide();
            instructionsForm = new Instructions();
            instructionsForm.Show();
        }
    }
}
