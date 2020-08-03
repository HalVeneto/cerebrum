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
    public partial class Fgamma : Form
    {
        private ThinkGearWrapper _thinkGearWrapper = new ThinkGearWrapper();
        public float moduloG1 = 3000;
        public float moduloA1 = 9999;

        public Fgamma()
        {
            InitializeComponent();
        }

        void _thinkGearWrapper_ThinkGearChanged(object sender, ThinkGearChangedEventArgs e)
        {
            float g1, a1, lasco;

            // update the textbox and sleep for a tiny bit
            BeginInvoke(new MethodInvoker(delegate
                {
                    g1 = e.ThinkGearState.Gamma1;
                    Lgamma1.Text = "gamma 1: " + String.Format("{0,10:N0}", g1);
                    //g2 = e.ThinkGearState.Gamma2;
                    //Lgamma2.Text = "gamma 2: " + String.Format("{0,10:N0}", g2);

                    a1 = e.ThinkGearState.Alpha1;
                    Lalfa1.Text = "alfa 1: " + String.Format("{0,10:N0}", a1);
                    //a2 = e.ThinkGearState.Alpha2;
                    //Lalfa2.Text = "alfa 2: " + String.Format("{0,10:N0}", a2);

                    //if (g1 != oldg1 && (g1 != 0) && g2 != 0 && oldg1 != 0 &&  oldg2 !=0 ) // || g2 != oldg2)
                    
                    {
                        //System.Windows.Forms.MessageBox.Show(Convert.ToString(g1) + "/" + Convert.ToString(oldg1), "Your Caption", MessageBoxButtons.OK);
                        lasco = (moduloG1 * 30 / 100);
                        if (g1 < (moduloG1 - lasco) )
                        {
                            if (imm.Left >= 0)
                                imm.Left--;
                            //Lcome.Text = "-";
                        }
                        else
                            if (g1 > (moduloG1 + lasco) )
                            {
                                if (imm.Left+imm.Width < Fgamma.ActiveForm.Width)
                                    imm.Left++;
                                //Lcome.Text = "+";
                            }

                        lasco = (moduloA1 * 30 / 100);
                        if (a1 < (moduloA1 - lasco) )
                        {
                            if (imm.Top >= 0)
                                imm.Top--;
                            //Lcome.Text = "-";
                        }
                        else
                            if (a1 > (moduloA1 + lasco) )
                            {
                                if (imm.Top + imm.Height < Fgamma.ActiveForm.Height)
                                    imm.Top++;
                                //Lcome.Text = "+";
                            }
                    }

                    //---

                    /*ps = (int)e.ThinkGearState.PoorSignal;
                    if (ps > 0)
                        Lpoor.ForeColor = Color.FromKnownColor(KnownColor.Red);
                    else
                        Lpoor.ForeColor = Color.FromKnownColor(KnownColor.Black);
                    Lpoor.Text = "problemi segnale: " + e.ThinkGearState.PoorSignal;*/

                }));
            Thread.Sleep(10);
        } //thinkgearchanged

        private void Fgamma_Load(object sender, EventArgs e)
        {
            bool connesso = false;

            foreach (string port in SerialPort.GetPortNames())
                cboPort.Items.Add(port);
            if (cboPort.Items.Count == 0)
            {
                MessageBox.Show("nessuna seriale attiva rilevata - impossibile procedere", "attenzione", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Close();
            }
            do
            {
                for (int p = 0; (p < cboPort.Items.Count && !connesso); p++)
                {
                    cboPort.SelectedIndex = 1; // p;
                    Lconn.Text = "connessione in corso su porta " + cboPort.SelectedItem.ToString();
                    //Fgamma.ActiveForm.Refresh();
                    //Thread.Sleep(10);
                    _thinkGearWrapper = new ThinkGearWrapper();

                    // setup the event
                    _thinkGearWrapper.ThinkGearChanged += _thinkGearWrapper_ThinkGearChanged;

                    // connect to the device on the specified COM port at 57600 baud
                    if (_thinkGearWrapper.Connect(cboPort.SelectedItem.ToString(), 57600, true))
                    {
                        Lconn.Text = "connesso a porta " + cboPort.SelectedItem.ToString(); 
                        Lconn.ForeColor = Color.FromKnownColor(KnownColor.Blue);
                        _thinkGearWrapper.EnableBlinkDetection(true);
                        connesso = true;
                        //System.Windows.Forms.MessageBox.Show("connesso", "Your Caption", MessageBoxButtons.OK);
                        break;
                    }

                } //for
            } while (!connesso);
            //System.Windows.Forms.MessageBox.Show("connesso", "Your Caption", MessageBoxButtons.OK);
            LlimitG2.Text = "limite gamma 1: " + Convert.ToString(moduloG1);
            LlimitA1.Text = "limite alfa 1: " + Convert.ToString(moduloA1);
            Lgamma1.Text = "";
        }

        private void Fgamma_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void Bclose_Click(object sender, EventArgs e)
        {
            _thinkGearWrapper.EnableBlinkDetection(false);
            _thinkGearWrapper.Disconnect();
            Close();
        }
    }
}