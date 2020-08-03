using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace cerebrum
{
    public partial class Fcsv : Form
    {
        public Fcsv()
        {
            InitializeComponent();
        }

        private void flist_DoubleClick(object sender, EventArgs e)
        {
            String fn, s, ss, line, tempo, lineTempo;
            int v, x, totr = 0;
            bool eof, ok;

            double valMax = Convert.ToDouble(Emax.Text);
            //flist.Visible = false;
            fn = flist.SelectedItems[0].Text;
            System.IO.StreamReader srIn = new System.IO.StreamReader(fn);
            System.IO.StreamWriter srOut = new System.IO.StreamWriter("out.csv");
            srOut.WriteLine("tempo;att.;med.;raw;alfa1;alfa2;beta 1;beta 2;gamma 1;gamma 2;delta;theta");
            totr = 0; tempo = "";
            while ((line = srIn.ReadLine()) != null) {
                totr++;

                ok = line.Trim() != "";
                if (ok)
                {
                    ok = line.Length > 2;
                    if (ok)
                        ok = line.Substring(2, 1) == ":"; //es. at:123 opp. 09:01:00:00
                    if (ok)
                        if (line.Length >= 6)
                        {
                            ok = line.Substring(5, 1) != ":";
                            if (!ok) //è un'orario di reg.
                            { 

                                //new:
                                lineTempo = line;
                                line = srIn.ReadLine(); //legge bontà segnale (deve essere 0)
                                if (line.Trim() != "0") //riga non ok
                                {
                                    line = srIn.ReadLine(); //legge riga "segnale non ottimale"
                                    srOut.Write(lineTempo + ";"); //ora di registrazione
                                    for (x = 1; x < 11; x++) //scrive rec. vuoto
                                        srOut.Write("0;");
                                    srOut.WriteLine("0");
                                    eof = true;
                                }
                                else
                                {

                                    if (tempo == lineTempo && CBragg.Checked) //salta le reg. con stesso secondo
                                    {
                                        for (x = 1; x < 13; x++) //12 le righe di un rec.
                                            line = srIn.ReadLine();
                                    }
                                    else
                                    {
                                        tempo = lineTempo;
                                        srOut.Write(lineTempo + ";"); //ora di registrazione
                                    }
                                } //else
                            } //if !ok
                        }

                    if (ok)
                    {
                        s = line.Substring(0, 3);
                        ss = line.Substring(3, line.Length - 3);
                        v = System.Convert.ToInt32(ss);

                        if (valMax == 0 || v <= valMax) //limite di range fissato
                            srOut.Write(v);
                        eof = false;
                        if (line.Length > 2)
                        {
                            if (s == "th:") //ultimo campo-valore del record-riga
                            {
                                srOut.WriteLine();
                                eof = true;
                            }
                        }
                        if (!eof)
                            srOut.Write(";");
                        
                    } //if ok
                } //if ok
            } //while
            srIn.Close();
            srOut.Close();
            MessageBox.Show("esportazione terminata.\nCreato file 'out.csv'", "informazione", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Bclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Fcsv_Load(object sender, EventArgs e)
        {
            int x;

            flist.Visible = true;
            string[] filePaths = Directory.GetFiles(@".", "*.cdat", SearchOption.AllDirectories);

            for (x = 0; x < filePaths.Length; x++)
                flist.Items.Add(filePaths[x]);
        }
    }
}