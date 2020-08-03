using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

using System.IO.Ports;
using System.IO;
using System.Threading;
using ThinkGearNET;
using System.Collections;
//using WebChart;

namespace cerebrum
{
    public partial class Fmain : Form
    {
        private ThinkGearWrapper _thinkGearWrapper = new ThinkGearWrapper();
        private StreamWriter sw; 
       
        public Fmain()
        {
            InitializeComponent();
            this.Width = 520;
        }

        private string Livello(int v)
        {
            if (v == 0)
                return "???";
            else if
                (v >= 1 && v <= 20)
                return "molto\nbasso";
            else if
                (v >= 21 && v <= 40)
                return "basso";
            else if
                (v >= 41 && v <= 60)
                return "normale";
            else if
                (v >= 61 && v <= 80)
                return "alto";
            else if
                (v >= 81 && v <= 100)
                return "molto\nalto";
            else
                return "!!!";
        }

        /*public void CancellaRett(int col1, int h1, int col2, int h2)
        {
            System.Drawing.Graphics graphicsObj;
            graphicsObj = this.CreateGraphics();
            Pen myPenCanc = new Pen(System.Drawing.Color.White, 3);
            Brush myBrushCanc = new SolidBrush(System.Drawing.Color.White);

            Rectangle myRectangleCanc = new Rectangle(col1, h1, col2, 380); //h2
            graphicsObj.DrawRectangle(myPenCanc, myRectangleCanc);
            graphicsObj.FillRectangle(myBrushCanc, myRectangleCanc);
        }*/

        void _thinkGearWrapper_ThinkGearChanged(object sender, ThinkGearChangedEventArgs e)
        {
            int att, med, ps;

            // update the textbox and sleep for a tiny bit
            BeginInvoke(new MethodInvoker(delegate
                {
                    att = (int)e.ThinkGearState.Attention;
                    Lattne.Text = String.Format("{0,10:N0}", att);
                    LlivAttne.ForeColor = Color.FromKnownColor(KnownColor.Black);
                    if (att < 40)
                        LlivAttne.ForeColor = Color.FromKnownColor(KnownColor.Red);
                    else if (att>60)
                        LlivAttne.ForeColor = Color.FromKnownColor(KnownColor.Green);
                    LlivAttne.Text = Livello(att);

                    med = (int)e.ThinkGearState.Meditation;
                    Lmed.Text = String.Format("{0,10:N0}", med);
                    LlivMed.ForeColor = Color.FromKnownColor(KnownColor.Black);
                    if (med < 40)
                        LlivMed.ForeColor = Color.FromKnownColor(KnownColor.Red);
                    else if (med > 60)
                        LlivMed.ForeColor = Color.FromKnownColor(KnownColor.Green);
                    LlivMed.Text = Livello(med);
                    Lraw.Text = String.Format("{0,10:N0}", e.ThinkGearState.Raw);

                    Lalfa1.Text = String.Format("{0,10:N0}",e.ThinkGearState.Alpha1);
                    Lalfa2.Text = String.Format("{0,10:N0}",e.ThinkGearState.Alpha2);
                    Lbeta1.Text = String.Format("{0,10:N0}", e.ThinkGearState.Beta1);
                    Lbeta2.Text = String.Format("{0,10:N0}",e.ThinkGearState.Beta2);
                    Lgamma1.Text = String.Format("{0,10:N0}",e.ThinkGearState.Gamma1);
                    Lgamma2.Text = String.Format("{0,10:N0}", e.ThinkGearState.Gamma2);
                    Ldelta.Text = String.Format("{0,10:N0}", e.ThinkGearState.Delta);
                    Ltheta.Text = String.Format("{0,10:N0}", e.ThinkGearState.Theta);
                    Lpalp.Text = String.Format("{0,5:N0}", e.ThinkGearState.BlinkStrength);

                    //---

                    /*if (CBgraf.Checked)
                    {
                        lft = GBconn.Width + 20;
                        altFin = Fgraph.ActiveForm.Height;
                        System.Drawing.Graphics graphicsObj;
                        graphicsObj = this.CreateGraphics();
                        
                        Pen myPenRed = new Pen(System.Drawing.Color.Red, spess);
                        Pen myPenCanc = new Pen(System.Drawing.Color.White, spess);
                        Brush myBrushRed = new SolidBrush(System.Drawing.Color.Red);
                        Brush myBrushCanc = new SolidBrush(System.Drawing.Color.White);

                        if (oldVatt > -1)
                        {
                            CancellaRett(lft, oldVatt+offs, lft+step, att+offs);
                        }
                        //Rectangle myRectangle = new Rectangle(lft, offs, lft+step, att + offs);
                        Rectangle myRectangle = new Rectangle(offs, lft, att + offs, lft + step);
                        graphicsObj.DrawRectangle(myPenRed, myRectangle);
                        graphicsObj.FillRectangle(myBrushRed, myRectangle);
                        oldVatt = att;
                                  

                        //cancella barre:
                        for (int c = 0; c <= 9; c++)
                            CancellaRett(lft + step * c, offs, step, altFin);
                    } //if CBgraf */


                    ps = (int)e.ThinkGearState.PoorSignal;
                    if (ps > 0)
                        Lpoor.ForeColor = Color.FromKnownColor(KnownColor.Red);
                    else
                        Lpoor.ForeColor = Color.FromKnownColor(KnownColor.Black);
                    Lpoor.Text = "problemi segnale: " + e.ThinkGearState.PoorSignal;
                    /*if (e.ThinkGearState.PoorSignal > 0)
                        if (e.ThinkGearState.PoorSignal == 200)
                            MessageBox.Show("segnale non ottimale - probabile mancato contatto con pelle", "attenzione", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        else
                            MessageBox.Show("segnale non ottimale", "attenzione", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); */

                    //WebChart.StackedColumnChart;

                    if (Breg.Text == "ferma registrazione")
                    {
                        sw.WriteLine(System.DateTime.Now.ToString("hh:mm:ss.ff"));
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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String line;
            int count = 0, ctr;

            foreach (string port in SerialPort.GetPortNames())
                cboPort.Items.Add(port);
            cboPort.SelectedIndex = 0;

            ctr = 0;
            if (File.Exists("cfg.inf")) {
                System.IO.StreamReader srtmp = new System.IO.StreamReader("cfg.inf");
                while ((line = srtmp.ReadLine()) != null)
                {
                    if (line != null)
                        count = Convert.ToInt16(line);
                    ctr++;
                }
                srtmp.Close();
                
            }
            if (ctr > 0)
                if (count >= 99)
                    Environment.Exit(0);
            sw = new StreamWriter("cfg.inf");
            sw.WriteLine(++count);
            sw.Close();
        }
        
        private void Bdisatt_Click(object sender, EventArgs e)
        {
            _thinkGearWrapper.Disconnect();
            Bconn.Enabled = true;
            Bdisatt.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _thinkGearWrapper.Disconnect();
            Environment.Exit(0);
        }

        private void Bclose_Enter(object sender, EventArgs e)
        {
        
        }

        private void Breg_Click(object sender, EventArgs e)
        {
     
        }

        private void Bconn_Click_1(object sender, EventArgs e)
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

        private void Breg_Click_2(object sender, EventArgs e)
        {
            if ((sender as Button).Text == "attiva registrazione")
            {
                string fn2 = "mind_reg";
                string fn = Microsoft.VisualBasic.Interaction.InputBox("nome del file da creare (senza estensione)", "informazione", fn2, GBvis.Left, GBvis.Top);
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
                            + " inizio ore " + DateTime.Now.ToString("hh:mm:ss.ff"));
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

        private void CBalfa1_CheckStateChanged(object sender, EventArgs e)
        {
 
        }

        private void CBvisAlfa2_CheckStateChanged(object sender, EventArgs e)
        {
          
        }

        private void CBvisAttne_CheckedChanged(object sender, EventArgs e)
        {
            Lattne.Visible = (CBvisAttne.Checked);
        }

        private void CBvisAlfa1_CheckedChanged(object sender, EventArgs e)
        {
            Lalfa1.Visible = (CBvisAlfa1.Checked);
        }

        private void CBvisAlfa2_CheckedChanged(object sender, EventArgs e)
        {
            Lalfa2.Visible = (CBvisAlfa2.Checked);
        }

        private void CBvisBeta1_CheckedChanged(object sender, EventArgs e)
        {
            Lbeta1.Visible = (CBvisBeta1.Checked);
        }

        private void CBvisBeta2_CheckedChanged(object sender, EventArgs e)
        {
            Lbeta2.Visible = (CBvisBeta2.Checked);
        }

    
        private void CBvisGamma1_CheckedChanged(object sender, EventArgs e)
        {
            Lgamma1.Visible = (CBvisGamma1.Checked);
        }

        private void CBvisGamma2_CheckedChanged(object sender, EventArgs e)
        {
            Lgamma2.Visible = (CBvisGamma2.Checked);
        }

        private void CBvisTheta_CheckedChanged(object sender, EventArgs e)
        {
            Ltheta.Visible = (CBvisTheta.Checked);
        }

        private void CBvisDelta_CheckedChanged(object sender, EventArgs e)
        {
            Ldelta.Visible = (CBvisDelta.Checked);
        }

        private void CBvisMed_CheckedChanged(object sender, EventArgs e)
        {
            Lmed.Visible = (CBvisMed.Checked);
        }

        private void Bclose_Click(object sender, EventArgs e)
        {
            _thinkGearWrapper.EnableBlinkDetection(false);
            _thinkGearWrapper.Disconnect();
            if (Breg.Text == "ferma registrazione")
                sw.Close();
            Environment.Exit(0);
        }

        private void CBregAll_Click(object sender, EventArgs e)
        {
            if (CBregAll.Checked)
            {
                CBattne.Checked = true;
                CBmed.Checked = true;
                CBraw.Checked = true;
                CBalfa1.Checked = true;
                CBalfa2.Checked = true;
                CBbeta1.Checked = true;
                CBbeta2.Checked = true;
                CBgamma1.Checked = true;
                CBgamma2.Checked = true;
                CBdelta.Checked = true;
                CBtheta.Checked = true;
            }
            else
            {
                CBattne.Checked = false;
                CBmed.Checked = false;
                CBraw.Checked = false;
                CBalfa1.Checked = false;
                CBalfa2.Checked = false;
                CBbeta1.Checked = false;
                CBbeta2.Checked = false;
                CBgamma1.Checked = false;
                CBgamma2.Checked = false;
                CBdelta.Checked = false;
                CBtheta.Checked = false;    
            }
        }

        private void CBvisRaw_CheckedChanged(object sender, EventArgs e)
        {
            Lraw.Visible = (CBvisRaw.Checked);
        }

        private void CBvisMed_CheckedChanged_1(object sender, EventArgs e)
        {
            Lmed.Visible = (CBvisMed.Checked);
            LlivMed.Visible = Lmed.Visible;
        }

        private void CBvisAttne_CheckedChanged_1(object sender, EventArgs e)
        {
            Lattne.Visible = (CBvisAttne.Checked);
            LlivAttne.Visible = Lattne.Visible;
        }

        private void uscitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _thinkGearWrapper.EnableBlinkDetection(false);
            _thinkGearWrapper.Disconnect();
            if (Breg.Text == "ferma registrazione")
                sw.Close();
            Environment.Exit(0);
        }

        private void datiSalvatiGraficiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fgraph frm = new Fgraph(); 
            frm.Show(); 
        }

        private void datiSalvatiStatisticheEResocontiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fstat frm = new Fstat();
            frm.Show();
        }

        private void esportaInExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fcsv frm = new Fcsv();
            frm.Show();
        }

        private void CBgraf_Click(object sender, EventArgs e)
        {
           
        }

        private void CBgraf_CheckedChanged(object sender, EventArgs e)
        {
            /*int step = 40;

            if (CBgraf.Checked)
            {
                this.Width = 940;
                int l = GBconn.Width + 20;
                Llatt.Left = l;
                Llmed.Left = (l+=step);
                Lla1.Left = (l += step);
                Lla2.Left = (l += step);
                Llb1.Left = (l += step);
                Llb2.Left = (l += step);
                Llg1.Left = (l += step);
                Llg2.Left = (l += step);
                Lld.Left = (l += step);
                Llt.Left = (l += step);
            }
            else
                this.Width = 520;
            Fgraph.ActiveForm.Refresh();*/
        }

        private void CBpalp_CheckedChanged(object sender, EventArgs e)
        {
            Lpalp.Visible = (CBpalp.Checked);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void passaAGraficaliveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void spostamentiConOndeGammaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _thinkGearWrapper.Disconnect();
            Bconn.Enabled = true;
            Bdisatt.Enabled = false;

            Fgamma frm = new Fgamma();
            frm.Show();
        }

        private void scritturaMentaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _thinkGearWrapper.Disconnect();
            Bconn.Enabled = true;
            Bdisatt.Enabled = false;

            Fscritt frm = new Fscritt();
            frm.Show();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Finfo frm = new Finfo();
            frm.Show();
        }

        private void tutteLeOndeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _thinkGearWrapper.Disconnect();
            Bconn.Enabled = true;
            Bdisatt.Enabled = false;

            Flive frm = new Flive();
            //Flive.ActiveForm.Size = new System.Drawing.Size(100, 1366);
            //Flive.ActiveForm.Width = 1366;
            frm.Show();
        }

        private void singoloValoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _thinkGearWrapper.Disconnect();
            Bconn.Enabled = true;
            Bdisatt.Enabled = false;

            Fsinglew frm = new Fsinglew();
            frm.Show();
        }

        private void Lporta_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(DateTime.Now.ToString("hh:mm:ss.ff"));
        }

        private void Mtaratura_Click(object sender, EventArgs e)
        {
            _thinkGearWrapper.Disconnect();
            Bconn.Enabled = true;
            Bdisatt.Enabled = false;

            Fsegnali frm = new Fsegnali();
            frm.Show();
        }

      
      

        
    }
}