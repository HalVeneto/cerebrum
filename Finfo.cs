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
            int[] auth = { 63, 104, 99, 95, 94, 93, 87, 98, 93, 12, 43, 90, 92, 69, 86, 73 };
            string autore = "";
            int x;

            for (x = 0; x < auth.Length; x++)
                autore += char.ConvertFromUtf32(auth[x] + (x + 1) * 2);
            this.rtf.Clear();
            this.rtf.AppendText("cerebrum 2012\n");
            this.rtf.AppendText("v. 1.0\n");
            this.rtf.AppendText("by "+autore+"\n");
            this.rtf.AppendText("con supporto MindWave NeuroSky");
            
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}