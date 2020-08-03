using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace cerebrum
{
    public partial class Finfo : Form
    {
        public Finfo()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Finfo_Load(object sender, EventArgs e)
        {
            //rtf.Clear;
            rtf.Lines[2] = "By Alighiero Arvati";
        }
    }
}