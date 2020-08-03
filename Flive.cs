using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.IO.Ports;
using System.IO;
using System.Threading;
using ThinkGearNET;
using System.Collections;

namespace cerebrum
{
    public partial class Flive : Form
    {
        private ThinkGearWrapper _thinkGearWrapper = new ThinkGearWrapper();
        
        private StreamWriter sw; 

        public int oldVatt = -1;
        public int oldVmed = -1;
        public int oldVa1 = -1;
        public int oldVa2 = -1;
        public int oldVb1 = -1;
        public int oldVb2 = -1;
        public int oldVg1 = -1;
        public int oldVg2 = -1;
        public int oldVde = -1;
        public int oldVth = -1;
        public int oldVraw= -1;
        public int r = 150;
        public int interv = 0;
        public string ora = "";

        int moduloA1 = 350000 / 100;
        int moduloA2 = 456000 / 100;
        int moduloB1 = 419000 / 100;
        int moduloB2 = 373000 / 100;
        int moduloG1 = 154000 / 100;
        int moduloG2 = 830000 / 100;
        int moduloD =  3725000 / 100;
        int moduloT =  1750000 / 100;

        public Flive()
        {
            InitializeComponent();
        }

        private void Bclose_Click(object sender, EventArgs e)
        {
            _thinkGearWrapper.EnableBlinkDetection(false);
            _thinkGearWrapper.Disconnect();
            if (Breg.Text == "ferma registrazione")
                sw.Close();
            Close();
        }

        private void Bdisatt_Click(object sender, EventArgs e)
        {
            _thinkGearWrapper.Disconnect();
            Bconn.Enabled = true;
            Bdisatt.Enabled = false;
        }

        public void CancellaRett(int col1, int h1, int col2, int h2)
        {
            System.Drawing.Graphics graphicsObj;
            graphicsObj = this.CreateGraphics();
            Pen myPenCanc = new Pen(Flive.ActiveForm.BackColor, 1);
            Brush myBrushCanc = new SolidBrush(Flive.ActiveForm.BackColor);
            Rectangle myRectangleCanc = new Rectangle(col1, h1, col2, 380); //h2
            graphicsObj.DrawRectangle(myPenCanc, myRectangleCanc);
            graphicsObj.FillRectangle(myBrushCanc, myRectangleCanc);
        }

        void _thinkGearWrapper_ThinkGearChanged(object sender, ThinkGearChangedEventArgs e)
        {
            int att, med, a1, a2, b1, b2, g1, g2, de, th, raw, ps;
            int h, a1Iniz, a2Iniz, b1Iniz, b2Iniz, g1Iniz, g2Iniz, deIniz, thIniz, rawIniz;
            int spess = 3;
            bool ok;

            // update the textbox and sleep for a tiny bit
            BeginInvoke(new MethodInvoker(delegate
                {
                    //if (ora != DateTime.Now.ToLongTimeString())
                    Ltimer.Text = DateTime.Now.ToString("HH:mm:ss:ff tt"); 
                    interv++;
                    if (interv >= Convert.ToUInt16(CBint.SelectedItem.ToString())) 
                    {
                        interv = 0;

                        ora = DateTime.Now.ToLongTimeString();
                        //Lora.Text = ora;

                        System.Drawing.Graphics graphicsObj;
                        graphicsObj = this.CreateGraphics();

                        ps = (int)e.ThinkGearState.PoorSignal;
                        if (ps > 0)
                            Lpoor.ForeColor = Color.FromKnownColor(KnownColor.Red);
                        else
                            Lpoor.ForeColor = Color.FromKnownColor(KnownColor.Black);
                        ok = (ps == 0);

                        if (ok)
                        {

                            if (CBatt.Checked)
                            {
                                att = (int)e.ThinkGearState.Attention;
                                if (oldVatt == -1)
                                    oldVatt = att;
                                else
                                {
                                    Pen myPenRed = new Pen(System.Drawing.Color.Red, spess);
                                    graphicsObj.DrawLine(myPenRed, r, Patt.Top + oldVatt, r + 1, Patt.Top + att);
                                    oldVatt = att;
                                    Latt.Text = "attenzione :" + String.Format("{0,7:N0}", att);
                                }
                            }
                            if (CBmed.Checked)
                            {
                                med = (int)e.ThinkGearState.Meditation;
                                if (oldVmed == -1)
                                    oldVmed = med;
                                else
                                {
                                    Pen myPenMed = new Pen(System.Drawing.Color.Fuchsia, spess);
                                    graphicsObj.DrawLine(myPenMed, r, Patt.Top + oldVmed, r + 1, Patt.Top + med);
                                    oldVmed = med;
                                    Lmed.Text = "meditazione:" + String.Format("{0,7:N0}", med);
                                }
                            }

                            if (CBalfa1.Checked)
                            {
                                a1Iniz = (int)e.ThinkGearState.Alpha1;
                                a1 = (int)(a1Iniz / moduloA1);
                                if (oldVa1 == -1)
                                    oldVa1 = a1;
                                else
                                {
                                    h = Palfa.Top + Palfa.Size.Height + 3;
                                    Pen myPenGreen = new Pen(System.Drawing.Color.DarkGreen, spess);
                                    graphicsObj.DrawLine(myPenGreen, r, h + oldVa1, r + 1, h + a1);
                                    oldVa1 = a1;
                                    La1.Text = "alfa 1:" + String.Format("{0,7:N0}", a1Iniz);
                                }
                            }
                            if (CBalfa2.Checked)
                            {
                                a2Iniz = (int)e.ThinkGearState.Alpha2;
                                a2 = (int)(a2Iniz / moduloA2);
                                if (oldVa2 == -1)
                                    oldVa2 = a2;
                                else
                                {
                                    h = Palfa.Top + Palfa.Size.Height + 3;
                                    Pen myPenGreen2 = new Pen(System.Drawing.Color.LightGreen, spess);
                                    graphicsObj.DrawLine(myPenGreen2, r, h + oldVa2, r + 1, h + a2);
                                    oldVa2 = a2;
                                    La2.Text = "alfa 2:" + String.Format("{0,7:N0}", a2Iniz);
                                }
                            }

                            if (CBbeta1.Checked)
                            {
                                b1Iniz = (int)e.ThinkGearState.Beta1;
                                b1 = (int)(b1Iniz / moduloB1);
                                if (oldVb1 == -1)
                                    oldVb1 = b1;
                                else
                                {
                                    h = Pbeta.Top + Pbeta.Size.Height + 3;
                                    Pen myPenB1 = new Pen(System.Drawing.Color.Purple, spess);
                                    graphicsObj.DrawLine(myPenB1, r, h + oldVb1, r + 1, h + b1);
                                    oldVb1 = b1;
                                    Lb1.Text = "beta 1:" + String.Format("{0,7:N0}", b1Iniz);
                                }
                            }
                            if (CBbeta2.Checked)
                            {
                                b2Iniz = (int)e.ThinkGearState.Beta2;
                                b2 = (int)(b2Iniz / moduloB2);
                                if (oldVb2 == -1)
                                    oldVb2 = b2;
                                else
                                {
                                    h = Pbeta.Top + Pbeta.Size.Height + 3;
                                    Pen myPenB2 = new Pen(System.Drawing.Color.Violet, spess);
                                    graphicsObj.DrawLine(myPenB2, r, h + oldVb2, r + 1, h + b2);
                                    oldVb2 = b2;
                                    Lb2.Text = "beta 2:" + String.Format("{0,7:N0}", b2Iniz);
                                }
                            }

                            if (CBgamma1.Checked)
                            {
                                g1Iniz = (int)e.ThinkGearState.Gamma1;
                                g1 = (int)(g1Iniz / moduloG1);
                                if (oldVg1 == -1)
                                    oldVg1 = g1;
                                else
                                {
                                    h = Pgamma.Top + Pgamma.Size.Height + 3;
                                    Pen myPenG1 = new Pen(System.Drawing.Color.Cyan, spess);
                                    graphicsObj.DrawLine(myPenG1, r, h + oldVg1, r + 1, h + g1);
                                    oldVg1 = g1;
                                    Lg1.Text = "gamma 1:" + String.Format("{0,7:N0}", g1Iniz);
                                }
                            }
                            if (CBgamma2.Checked)
                            {
                                g2Iniz = (int)e.ThinkGearState.Gamma2;
                                g2 = (int)(g2Iniz / moduloG2);
                                if (oldVg2 == -1)
                                    oldVg2 = g2;
                                else
                                {
                                    h = Pgamma.Top + Pgamma.Size.Height + 3;
                                    Pen myPenG2 = new Pen(System.Drawing.Color.DarkBlue, spess);
                                    graphicsObj.DrawLine(myPenG2, r, h + oldVg2, r + 1, h + g2);
                                    oldVg2 = g2;
                                    Lg2.Text = "gamma 2:" + String.Format("{0,7:N0}", g2Iniz);
                                }
                            }

                            if (CBde.Checked)
                            {
                                deIniz = (int)e.ThinkGearState.Delta;
                                de = (int)(deIniz / moduloD);
                                if (oldVde == -1)
                                    oldVde = de;
                                else
                                {
                                    h = Pdelta.Top + Pdelta.Size.Height + 3;
                                    Pen myPenDe = new Pen(System.Drawing.Color.DarkGoldenrod, spess);
                                    graphicsObj.DrawLine(myPenDe, r, h + oldVde, r + 1, h + de);
                                    oldVde = de;
                                    Ld.Text = "delta:" + String.Format("{0,7:N0}", deIniz);
                                }
                            }
                            if (CBth.Checked)
                            {
                                h = Pdelta.Top + Pdelta.Size.Height + 3;
                                thIniz = (int)e.ThinkGearState.Theta;
                                th = (int)(thIniz / moduloT);
                                if (oldVth == -1)
                                    oldVth = th;
                                else
                                {
                                    Pen myPenTh = new Pen(System.Drawing.Color.Gold, spess);
                                    graphicsObj.DrawLine(myPenTh, r, h + oldVth, r + 1, h + th);
                                    oldVth = th;
                                    Lt.Text = "theta:" + String.Format("{0,7:N0}", thIniz);
                                }
                            }
                            if (true)
                            {
                                h = Praw.Top + Praw.Size.Height + 3;
                                rawIniz = (int)e.ThinkGearState.Raw;
                                raw = (int)(rawIniz / (500 / 100));
                                if (oldVraw == -1)
                                    oldVraw = raw;
                                else
                                {
                                    Pen myPenRaw = new Pen(System.Drawing.Color.Red, 1);
                                    graphicsObj.DrawLine(myPenRaw, r, h + 50 + oldVraw, r + 1, h + 50 + raw); // + 50 perché lo zero è in mezzo
                                    oldVraw = raw;
                                    Lraw.Text = "raw:" + String.Format("{0,7:N0}", rawIniz);
                                }
                            }

                            r++;
                            if (r > Flive.ActiveForm.Width - 10)
                            {
                                //CancellaRett(0, Patt.Top, Flive.ActiveForm.Width, Flive.ActiveForm.Height+Patt.Top);
                                CancellaRett(0, Patt.Top - 5, Flive.ActiveForm.Width, Patt.Top + 105);
                                CancellaRett(0, Palfa.Top - 5, Flive.ActiveForm.Width, Palfa.Top + 105);
                                CancellaRett(0, Pbeta.Top - 5, Flive.ActiveForm.Width, Pbeta.Top + 105);
                                CancellaRett(0, Pgamma.Top - 5, Flive.ActiveForm.Width, Pgamma.Top + 105);
                                CancellaRett(0, Pdelta.Top - 5, Flive.ActiveForm.Width, Pdelta.Top + 105);
                                r = 150;
                            }
                        } //if ok
                    } //if ora
                    //---

                    ps = (int)e.ThinkGearState.PoorSignal;
                    if (ps > 0)
                        Lpoor.ForeColor = Color.FromKnownColor(KnownColor.Red);
                    else
                        Lpoor.ForeColor = Color.FromKnownColor(KnownColor.Black);
                    Lpoor.Text = "problemi segnale: " + e.ThinkGearState.PoorSignal;

                    if (Breg.Text == "ferma registrazione")
                    {
                        sw.WriteLine(System.DateTime.Now.ToLongTimeString());
                        sw.WriteLine(ps);
                        if (ps > 0)
                        {
                            if (ps == 200)
                                sw.WriteLine("segnale non ottimale - probabile mancato contatto con pelle");
                            else
                                sw.WriteLine("segnale non ottimale");
                        }
                        else
                        {
                            sw.WriteLine("at:" + e.ThinkGearState.Attention);
                            sw.WriteLine("me:" + e.ThinkGearState.Meditation);
                            sw.WriteLine("ra:" + e.ThinkGearState.Raw);
                            sw.WriteLine("a1:" + e.ThinkGearState.Alpha1);
                            sw.WriteLine("a2:" + e.ThinkGearState.Alpha2);
                            sw.WriteLine("b1:" + e.ThinkGearState.Beta1);
                            sw.WriteLine("b2:" + e.ThinkGearState.Beta2);
                            sw.WriteLine("g1:" + e.ThinkGearState.Gamma1);
                            sw.WriteLine("g2:" + e.ThinkGearState.Gamma2);
                            sw.WriteLine("de:" + e.ThinkGearState.Delta);
                            sw.WriteLine("th:" + e.ThinkGearState.Theta);
                        }
                    }

                }));
            Thread.Sleep(10);
        }

        private void Bconn_Click(object sender, EventArgs e)
        {
            _thinkGearWrapper = new ThinkGearWrapper();

            // setup the event
            _thinkGearWrapper.ThinkGearChanged += _thinkGearWrapper_ThinkGearChanged;

            // connect to the device on the specified COM port at 57600 baud
            if (!_thinkGearWrapper.Connect(cboPort.SelectedItem.ToString(), 57600, true))
                MessageBox.Show("impossibile connettersi al mindset");
            else
            {
                Bconn.Enabled = false;
                Bdisatt.Enabled = true;
                _thinkGearWrapper.EnableBlinkDetection(true);
            }
        }

        private void Flive_Load(object sender, EventArgs e)
        {
            string fn, line;
            int v, q;

            foreach (string port in SerialPort.GetPortNames())
                cboPort.Items.Add(port);
            cboPort.SelectedIndex = 0;

            //Flive.ActiveForm.Left = 0;
            //Flive.Width = Screen.PrimaryScreen.WorkingArea.Width;
            //MessageBox.Show("screen "+Convert.ToString(Screen.PrimaryScreen.WorkingArea.Width));
            //MessageBox.Show("form " + Convert.ToString(Flive.ActiveForm.Width));

            //legge limiti massimi calcolati da prg grafici:
            fn = "maxs.inf";
            if (File.Exists(fn))
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(fn);
                q = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    v = System.Convert.ToInt32(line) / 100;
                    switch (q)
                    {
                        case 0:
                            moduloA1 = v;
                            EmaxA1.Text = line;
                            break;
                        case 1:
                            moduloA2 = v;
                            EmaxA2.Text = line;
                            break;
                        case 2:
                            moduloB1 = v;
                            EmaxB1.Text = line;
                            break;
                        case 3:
                            moduloB2 = v;
                            EmaxB2.Text = line;
                            break;
                        case 4:
                            moduloG1 = v;
                            EmaxG1.Text = line;
                            break;
                        case 5:
                            moduloG2 = v;
                            EmaxG2.Text = line;
                            break;
                        case 6:
                            moduloD = v;
                            EmaxDe.Text = line;
                            break;
                        case 7:
                            moduloT = v;
                            EmaxTh.Text = line;
                            break;
                    }
                    q++;
                }
                sr.Close();
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.DrawLine(myPenRed, r++, 90 + oldVatt, r, 90 + att);
        }

        private void CBgamma_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Egamma1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Egamma2_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmaxDe_ModifiedChanged(object sender, EventArgs e)
        {
        }

        private void EmaxTh_ModifiedChanged(object sender, EventArgs e)
        {
        }

        private void EmaxDe_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmaxDe_Leave(object sender, EventArgs e)
        {
            moduloD = Convert.ToInt32((EmaxDe.Text)) / 100;
        }

        private void EmaxTh_Leave(object sender, EventArgs e)
        {
            moduloT = Convert.ToInt32((EmaxTh.Text)) / 100;
        }

        private void EmaxG1_Leave(object sender, EventArgs e)
        {
            moduloG1 = Convert.ToInt32((EmaxG1.Text)) / 100;
        }

        private void EmaxG2_Leave(object sender, EventArgs e)
        {
            moduloG2 = Convert.ToInt32((EmaxG2.Text)) / 100;
        }

        private void Breg_Click(object sender, EventArgs e)
        {
            if ((sender as Button).Text == "attiva registrazione")
            {
                string fn2 = "mind_reg";
                string fn = Microsoft.VisualBasic.Interaction.InputBox("nome del file da creare (senza estensione)", "informazione", fn2, GBconn.Left, GBconn.Top);
                if (fn != "")
                {
                    //InputBoxResult test = InputBox.Show("nome del file da creare (senza estensione)","informazione",fn,Breg.Top+Breg.Height,Breg.Left);
                    //if (test.ReturnCode == DialogResult.OK) 
                    Breg.Text = "ferma registrazione";
                    Breg.BackColor = Color.Crimson;

                    try
                    {
                        DateTime today = System.DateTime.Today;
                        //StreamWriter 
                        sw = new StreamWriter(fn + ".cdat");
                        sw.WriteLine("registrazione Mindwave del "
                            + String.Format("{0:dd MMM yyyy}", today)
                            + " ore " + DateTime.Now.ToShortTimeString());
                    }
                    finally
                    {

                    }
                }
            }
            else
            {
                Breg.BackColor = Color.SlateBlue;
                Breg.Text = "attiva registrazione";
                sw.Close();
            }
        }

        private void EmaxB1_Leave(object sender, EventArgs e)
        {
            moduloB1 = Convert.ToInt32((EmaxB1.Text)) / 100;
        }

        private void EmaxB2_Leave(object sender, EventArgs e)
        {
            moduloB2 = Convert.ToInt32((EmaxB2.Text)) / 100;
        }
    }
}