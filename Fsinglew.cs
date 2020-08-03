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
    public partial class Fsinglew : Form
    {
        private ThinkGearWrapper _thinkGearWrapper = new ThinkGearWrapper();

        public int oldVraw = -1;
        public int oldVbl = -1;
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
        public int r = 0;
        public int interv = 0;
        public string ora = "";
        float moduloGen = 100;
        float max;
        double Vmax = 1E-100, Vmin = 1E+100;

        public Fsinglew()
        {
            InitializeComponent();
        }

        public void MinMax(ref int valore) 
        {
            if (valore > Vmax)
                Vmax=valore;
            if (valore < Vmin)
                Vmin = valore;
        }

        void _thinkGearWrapper_ThinkGearChanged(object sender, ThinkGearChangedEventArgs e)
        {
            int raw, bl, att, med, a1, a2, b1, b2, g1, g2, de, th, ps;
            int h, rawIniz, blIniz, attIniz, medIniz, a1Iniz, a2Iniz, b1Iniz, b2Iniz, g1Iniz, g2Iniz, deIniz, thIniz;
            int spess = 2;

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

                        /*bl = (int)e.ThinkGearState.BlinkStrength;
                        if (bl > 0)
                            Locchi.Text="occhi:" + Convert.ToString(bl);*/

                        if (CBraw.Checked)
                        {
                            rawIniz = (int)e.ThinkGearState.Raw;
                            MinMax(ref rawIniz);
                            raw = (int)(rawIniz * moduloGen);
                            if (oldVraw == -1)
                                oldVraw = raw;
                            else
                            {
                                Pen myPenRed = new Pen(System.Drawing.Color.Red, spess);
                                graphicsObj.DrawLine(myPenRed, r, Pini.Top + 200 + oldVraw, r + 1, Pini.Top + 200 + raw); // + 200 perché può essere negativo (val. appross.)
                                oldVraw = raw;
                                CBraw.Text = "raw: " + String.Format("{0,7:N0}", rawIniz);
                            }
                        }


                        if (CBocchi.Checked)
                        {
                            blIniz = (int)e.ThinkGearState.BlinkStrength;
                            MinMax(ref blIniz);
                            bl = (int)(blIniz * moduloGen);
                            if (oldVbl == -1)
                                oldVbl = bl;
                            else
                            {
                                Pen myPenBlack = new Pen(System.Drawing.Color.Black, spess);
                                graphicsObj.DrawLine(myPenBlack, r, Pini.Top + oldVbl, r + 1, Pini.Top + bl);
                                oldVbl = bl;
                                CBocchi.Text = "occhi: " + String.Format("{0,7:N0}", blIniz);
                            }
                        }

                        if (CBatt.Checked)
                        {
                            attIniz = (int)e.ThinkGearState.Attention;
                            MinMax(ref attIniz);
                            /*if (attIniz < Vmin)
                                Vmin = attIniz;
                            if (attIniz > Vmax)
                                Vmax = attIniz;*/
                            att = (int)(attIniz * moduloGen);
                            if (oldVatt == -1)
                                oldVatt = att;
                            else
                            {
                                h = Pini.Top + Pini.Size.Height + 3;
                                Pen myPenRed = new Pen(System.Drawing.Color.Red, spess);
                                graphicsObj.DrawLine(myPenRed, r, h + oldVatt, r + 1, h + att);
                                oldVatt = att;
                                Latt.Text = "attenzione:" + String.Format("{0,7:N0}", attIniz);
                            }
                        }
                        if (CBmed.Checked)
                        {
                            medIniz = (int)e.ThinkGearState.Meditation;
                            MinMax(ref medIniz);
                            /*if (medIniz < Vmin)
                                Vmin = medIniz;
                            if (medIniz > Vmax)
                                Vmax = medIniz;*/
                            med = (int)(medIniz * moduloGen);
                            if (oldVmed == -1)
                                oldVmed = med;
                            else
                            {
                                h = Pini.Top + Pini.Size.Height + 3;
                                Pen myPenMed = new Pen(System.Drawing.Color.Fuchsia, spess);
                                graphicsObj.DrawLine(myPenMed, r, h + oldVmed, r + 1, h + med);
                                oldVmed = med;
                                Lmed.Text = "meditazione:" + String.Format("{0,7:N0}", medIniz);
                            }
                        }

                        if (CBalfa1.Checked)
                        {
                            a1Iniz = (int)e.ThinkGearState.Alpha1;
                            MinMax(ref a1Iniz);
                            a1 = (int)(a1Iniz * moduloGen);
                            if (oldVa1 == -1)
                                oldVa1 = a1;
                            else
                            {
                                h = Pini.Top + Pini.Size.Height + 3;
                                Pen myPenGreen = new Pen(System.Drawing.Color.DarkGreen, spess);
                                graphicsObj.DrawLine(myPenGreen, r, h + oldVa1, r + 1, h + a1);
                                oldVa1 = a1;
                                La1.Text = "alfa 1: " + String.Format("{0,7:N0}", a1Iniz);
                            }
                        }
                        if (CBalfa2.Checked)
                        {
                            a2Iniz = (int)e.ThinkGearState.Alpha2;
                            MinMax(ref a2Iniz);
                            a2 = (int)(a2Iniz * moduloGen);
                            if (oldVa2 == -1)
                                oldVa2 = a2;
                            else
                            {
                                h = Pini.Top + Pini.Size.Height + 3;
                                Pen myPenGreen2 = new Pen(System.Drawing.Color.LightGreen, spess);
                                graphicsObj.DrawLine(myPenGreen2, r, h + oldVa2, r + 1, h + a2);
                                oldVa2 = a2;
                                La2.Text = "alfa 2:" + String.Format("{0,7:N0}", a2Iniz);
                            }
                        }

                        if (CBbeta1.Checked)
                        {
                            b1Iniz = (int)e.ThinkGearState.Beta1;
                            MinMax(ref b1Iniz);
                            b1 = (int)(b1Iniz * moduloGen);
                            if (oldVb1 == -1)
                                oldVb1 = b1;
                            else
                            {
                                h = Pini.Top + Pini.Size.Height + 3;
                                Pen myPenB1 = new Pen(System.Drawing.Color.Purple, spess);
                                graphicsObj.DrawLine(myPenB1, r, h + oldVb1, r + 1, h + b1);
                                oldVb1 = b1;
                                Lb1.Text = "beta 1:" + String.Format("{0,7:N0}", b1Iniz);
                            }
                        }
                        if (CBbeta2.Checked)
                        {
                            b2Iniz = (int)e.ThinkGearState.Beta2;
                            MinMax(ref b2Iniz);
                            b2 = (int)(b2Iniz * moduloGen);
                            if (oldVb2 == -1)
                                oldVb2 = b2;
                            else
                            {
                                h = Pini.Top + Pini.Size.Height + 3;
                                Pen myPenB2 = new Pen(System.Drawing.Color.Violet, spess);
                                graphicsObj.DrawLine(myPenB2, r, h + oldVb2, r + 1, h + b2);
                                oldVb2 = b2;
                                Lb2.Text = "beta 2:" + String.Format("{0,7:N0}", b2Iniz);
                            }
                        }

                        if (CBgamma1.Checked)
                        {
                            g1Iniz = (int)e.ThinkGearState.Gamma1;
                            MinMax(ref g1Iniz);
                            g1 = (int)(g1Iniz * moduloGen);
                            if (oldVg1 == -1)
                                oldVg1 = g1;
                            else
                            {
                                h = Pini.Top + Pini.Size.Height + 3;
                                Pen myPenG1 = new Pen(System.Drawing.Color.Cyan, spess);
                                graphicsObj.DrawLine(myPenG1, r, h + oldVg1, r + 1, h + g1);
                                oldVg1 = g1;
                                Lg1.Text = "gamma 1:" + String.Format("{0,7:N0}", g1Iniz);
                            }
                        }
                        if (CBgamma2.Checked)
                        {
                            g2Iniz = (int)e.ThinkGearState.Gamma2;
                            MinMax(ref g2Iniz);
                            g2 = (int)(g2Iniz * moduloGen);
                            if (oldVg2 == -1)
                                oldVg2 = g2;
                            else
                            {
                                h = Pini.Top + Pini.Size.Height + 3;
                                Pen myPenG2 = new Pen(System.Drawing.Color.DarkBlue, spess);
                                graphicsObj.DrawLine(myPenG2, r, h + oldVg2, r + 1, h + g2);
                                oldVg2 = g2;
                                Lg2.Text = "gamma 2:" + String.Format("{0,7:N0}", g2Iniz);
                            }
                        }

                        if (CBde.Checked)
                        {
                            deIniz = (int)e.ThinkGearState.Delta;
                            MinMax(ref deIniz);
                            de = (int)(deIniz * moduloGen);
                            if (oldVde == -1)
                                oldVde = de;
                            else
                            {
                                h = Pini.Top + Pini.Size.Height + 3;
                                Pen myPenDe = new Pen(System.Drawing.Color.DarkGoldenrod, spess);
                                graphicsObj.DrawLine(myPenDe, r, h + oldVde, r + 1, h + de);
                                oldVde = de;
                                Ld.Text = "delta:" + String.Format("{0,7:N0}", deIniz);
                            }
                        }
                        if (CBth.Checked)
                        {
                            h = Pini.Top + Pini.Size.Height + 3;
                            thIniz = (int)e.ThinkGearState.Theta;
                            MinMax(ref thIniz);
                            th = (int)(thIniz * moduloGen);
                            if (oldVth == -1)
                                oldVth = th;
                            else
                            {
                                Pen myPenTh = new Pen(System.Drawing.Color.Indigo, spess);
                                graphicsObj.DrawLine(myPenTh, r, h + oldVth, r + 1, h + th);
                                oldVth = th;
                                Lt.Text = "theta:" + String.Format("{0,7:N0}", thIniz);
                            }
                        }

                        Lmin.Text = "Min.: " + Convert.ToString(Vmin);
                        Lmax.Text = "Max: " + Convert.ToString(Vmax);

                        r++;
                        if (r > Fsinglew.ActiveForm.Width - 10)
                        {
                            //CancellaRett(0, Patt.Top, Flive.ActiveForm.Width, Flive.ActiveForm.Height+Patt.Top);
                            CancellaRett(0, Pini.Top - 5, Fsinglew.ActiveForm.Width, Fsinglew.ActiveForm.Height);
                            r = 0;
                        }
                    } //if ora
                    //---

                    ps = (int)e.ThinkGearState.PoorSignal;
                    if (ps > 0)
                        Lpoor.ForeColor = Color.FromKnownColor(KnownColor.Red);
                    else
                        Lpoor.ForeColor = Color.FromKnownColor(KnownColor.Black);
                    Lpoor.Text = "problemi segnale: " + e.ThinkGearState.PoorSignal;

                    /*if (Breg.Text == "ferma registrazione")
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
                    }*/

                }));
            Thread.Sleep(10);
        } //thinkgearwrapp

        private void Limite(string dicosa)
        {
            string fn, line;
            int q, x;
            float v;

            //MessageBox.Show("zero");

            //legge limiti massimi calcolati da prg grafici:
            fn = "maxs.inf";
            if (File.Exists(fn))
            {
                q = 0;
                switch (dicosa)
                {
                    case "a1":
                        q = 0;
                        break;
                    case "a2":
                        q = 1;
                        break;
                    case "b1":
                        q = 2;
                        break;
                    case "b2":
                        q = 3;
                        break;
                    case "g1":
                        q = 4;
                        break;
                    case "g2":
                        q = 5;
                        break;
                    case "de":
                        q = 6;
                        break;
                    case "th":
                        q = 7;
                        break;
                    case "at":
                        q = 8;
                        break;
                    case "me":
                        q = 9;
                        break;
                }
                if (dicosa == "ra") //raw
                    line = "2000";
                else
                    if (dicosa == "bl") //blink
                        line = "255";
                    else
                    {

                        line = "";
                        System.IO.StreamReader sr = new System.IO.StreamReader(fn);
                        for (x = 0; x <= q; x++)
                            line = sr.ReadLine();
                        sr.Close();
                    } //else
                v = System.Convert.ToInt32(line);
                moduloGen = (Fsinglew.ActiveForm.Height - Pini.Top - 100) / v;
                Emax.Text = line;
            }
        }

        private void Fsinglew_Load(object sender, EventArgs e)
        {
            foreach (string port in SerialPort.GetPortNames())
                cboPort.Items.Add(port);
            cboPort.SelectedIndex = 0;            
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
            Pen myPenCanc = new Pen(Fsinglew.ActiveForm.BackColor, 1);
            Brush myBrushCanc = new SolidBrush(Fsinglew.ActiveForm.BackColor);
            Rectangle myRectangleCanc = new Rectangle(col1, h1, col2, h2); 
            graphicsObj.DrawRectangle(myPenCanc, myRectangleCanc);
            graphicsObj.FillRectangle(myBrushCanc, myRectangleCanc);
            myPenCanc.Dispose();
            myBrushCanc.Dispose();
            graphicsObj.Dispose();
        }

        private void Bclose_Click(object sender, EventArgs e)
        {
            _thinkGearWrapper.EnableBlinkDetection(false);
            _thinkGearWrapper.Disconnect();
            //if (Breg.Text == "ferma registrazione")
                //sw.Close();
            Close();
        }

        private void Fsinglew_Shown(object sender, EventArgs e)
        {
            max = Convert.ToInt32(Emax.Text);
            moduloGen = (Fsinglew.ActiveForm.Height - Pini.Top - 100) / max;
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

        private void Emax_Leave(object sender, EventArgs e)
        {
            //int h1, h2, x, v;
            //float mod, modV;

            max = Convert.ToInt32(Emax.Text);

            //MessageBox.Show("-->"+Emax.Text);
            
            moduloGen = (Fsinglew.ActiveForm.Height - Pini.Top - 100) / max;

            /*System.Drawing.Graphics graphicsObj;
            graphicsObj = this.CreateGraphics();
            CancellaRett(0, Pini.Top - 5, Fsinglew.ActiveForm.Width, Fsinglew.ActiveForm.Height);
            h1 = Pini.Top + Pini.Size.Height + 3 + 10;
            h2 = Fsinglew.ActiveForm.Height - h1 - 10;
            mod = (h2 - h1) / 10;
            modV = 0;
            Pen myPenLinea = new Pen(System.Drawing.Color.Gray, 1);
            for (x = 1; x <= 11; x++)
            { 
                graphicsObj.DrawLine(myPenLinea, 0, h1, Fsinglew.ActiveForm.Width, h1);

                Label makeLabel = new Label();
                makeLabel.Width = 35;
                makeLabel.Height = 13;
                makeLabel.ForeColor = Color.Blue;
                makeLabel.Font = new Font("verdana", 8, FontStyle.Regular);
                makeLabel.Location = new Point(5, h1);
                makeLabel.Name = "Lscala" + Convert.ToString(x);
                makeLabel.Text = (modV).ToString();
                this.Controls.Add(makeLabel);

                h1 = (int)(h1 + mod);
                modV += max / 10;
            }
            myPenLinea.Dispose();
            graphicsObj.Dispose();*/
        }

        private void Bazz_Click(object sender, EventArgs e)
        {
            Lmax.Text = ""; Lmin.Text = ""; Locchi.Text = "";
            Vmin = 1E+100; Vmax = 1E-100;
        }

        private void CBatt_Click(object sender, EventArgs e)
        {
            Limite("at");
        }

        private void CBalfa1_Click(object sender, EventArgs e)
        {
            Limite("a1");
        }

        private void CBbeta1_Click(object sender, EventArgs e)
        {
            Limite("b1");
        }

        private void CBgamma1_Click(object sender, EventArgs e)
        {
            Limite("g1");
        }

        private void CBde_Click(object sender, EventArgs e)
        {
            Limite("de");
        }

        private void CBmed_Click(object sender, EventArgs e)
        {
            Limite("me");
        }

        private void CBalfa2_Click(object sender, EventArgs e)
        {
            Limite("a2");
        }

        private void CBbeta2_Click(object sender, EventArgs e)
        {
            Limite("b2");
        }

        private void CBgamma2_Click(object sender, EventArgs e)
        {
            Limite("g2");
        }

        private void CBth_Click(object sender, EventArgs e)
        {
            Limite("th");
        }

        private void CBraw_Click(object sender, EventArgs e)
        {
            Limite("ra");
            //moduloGen = (Fsinglew.ActiveForm.Height - Pini.Top - 100) / (500/100);
            //Emax.Text = "500";
        }

        private void CBocchi_Click(object sender, EventArgs e)
        {
            Limite("bl");
        }

    }
}