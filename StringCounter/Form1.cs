using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringCounter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void siticoneTextBox1_TextChanged(object sender, EventArgs e)
        {
            siticoneLabel1.Text = siticoneTextBox1.Text.Length.ToString() + " Characters";
        }
    }
}
