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
    public partial class Fscritt : Form
    {
        private ThinkGearWrapper _thinkGearWrapper = new ThinkGearWrapper();
        public string[] nrs = {"1","2","3","4","5","6","7","8","9","0"};
        public UInt16 corr = 0;
        public int oldbl = 0;
        public int oldv = 0;
        public float loop = 0;
        public bool inattivo = false;
        public bool inattivo2 = false;
        public int vmin = -1500;
        public int vmax = 1500;
        public int v2 = 0;

        public void Numeri(UInt16 corr)
        {
            int z = 0;
            //this.Controls.Clear();

            //MessageBox.Show("corr:" + Convert.ToString(corr), "attenzione", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            foreach (string k in nrs)
            {
                
                Label makeLabel = new Label();
                
                makeLabel.Width = 30;
                makeLabel.Height = 44;
                if (z == corr)
                    makeLabel.ForeColor = Color.Red;
                else
                    makeLabel.ForeColor = Color.Black;
                makeLabel.Font = new Font("verdana", 26, FontStyle.Bold);
                makeLabel.Location = new Point(10 + 2 * z * makeLabel.Size.Width, 50);
                makeLabel.Name = "Lnr" + Convert.ToString(z);

                //MessageBox.Show(makeLabel.Name, "attenzione", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
                makeLabel.Text = k.ToString();
                //this.Controls.Add(makeLabel);
                panel1.Controls.Add(makeLabel);
                z++;
            }
        }

        public Fscritt()
        {
            InitializeComponent();
        }

        void _thinkGearWrapper_ThinkGearChanged(object sender, ThinkGearChangedEventArgs e)
        {
            int v, ps; //, v2;
            bool ok, rawOk;

            // update the textbox and sleep for a tiny bit
            BeginInvoke(new MethodInvoker(delegate
                {
                    
                    Lbl.Text = ""; v = 0;

                    ps = (int)e.ThinkGearState.PoorSignal;
                    if (ps > 0)
                    {
                        Lpoor.Text = "segnale non ok";
                        Lpoor.ForeColor = Color.FromKnownColor(KnownColor.Red);
                    }
                    else
                    {
                        Lpoor.Text = "segnale ok";
                        Lpoor.ForeColor = Color.FromKnownColor(KnownColor.Black);
                    }
                    ok = (ps == 0);
                    if (ok)
                    {

                        //legge delta
                        v2 = (int)e.ThinkGearState.Delta;
                        Lbl.Text = "de:" + Convert.ToString(v2);
                        if (v2 > 1000000) //delta ha valore alto = strizzata d'occhio?
                        {
                            if (!inattivo2) //se non è già in azione, scrivi carattere
                            {
                                if (Lnr.Text.Length > 10)
                                    Lnr.Text = ""; //così se esce a dx si vede...
                                Lnr.Text += Convert.ToString(corr + 1);
                                Fscritt.ActiveForm.Refresh();

                                inattivo2 = true;
                                inattivo = true;
                            }
                        } //if delta>1e6
                        else
                            inattivo2 = false; //riattiva delta

                        //leggi raw
                        v = (int)e.ThinkGearState.Raw;
                        Lval.Text = "raw: " + Convert.ToString(v);
                        rawOk = false;
                        if (v < 0)
                            rawOk = (v < -vmin);
                        else
                            if (v > 0)
                                rawOk = (v > vmax);
                        if (v > 0 && rawOk)  //se raw ha valore alto in + o in -
                        {
                            if (!inattivo) //se non è già in azione, sposta cursore
                            {
                                corr++;
                                if (corr > 9)
                                    corr = 0;
                                Numeri(corr);
                                Fscritt.ActiveForm.Refresh();
                                inattivo = true; //riattiva considerazione raw
                            }

                        } //if rawok
                        else
                            inattivo = false; //riattiva considerazione raw
                    } //if ok





                                /* if (Lnr.Text.Length > 10)
                                    Lnr.Text = ""; //così se esce a dx si vede...
                                Lnr.Text += Convert.ToString(corr);
                                inattivo = true;
                                inattivo2 = true;
                            }    
                            if (!inattivo2)
                            {
                                v2 = (int)e.ThinkGearState.Delta;
                                Lbl.Text = "de:" + Convert.ToString(v2);
                                Fscritt.ActiveForm.Refresh();
                                if (v2 > 1000000)
                                {
                                    if (Lnr.Text.Length > 10)
                                        Lnr.Text = ""; //così se esce a dx si vede...
                                    Lnr.Text += Convert.ToString(corr);
                                    inattivo = true;
                                    inattivo2 = true;
                                }
                            }
                            if (!inattivo)
                            {
                                v = (int)e.ThinkGearState.Raw;
                                Lval.Text = "raw: " + Convert.ToString(v);
                            }
                        } //if ok 
                                               
                    } //if true  */
                    



                    /*if (inattivo2 && ok)
                    {
                        inattivo2 = (v2 > 1000000);
                        if (!inattivo2)
                            inattivo = false;
                    }

                    if (inattivo && ok) 
                    {
                       if (v < 0)
                           inattivo = (v < -vmin);
                       else
                           if (v > 0)
                               inattivo = (v > vmax);
                   }

                   if (!inattivo && ok)
                   {
                        
                        ok = false;
                        if (v < 0)
                            if (v < vmin)
                                ok = true;
                            else
                                if (v > 0)
                                    if (v > vmax)
                                        ok = true;
                        if (ok) // (v > vmin || v < vmax) && v != 0)
                        {
                            corr++;
                            
                            //MessageBox.Show(" corr:" + Convert.ToString(corr));

                            if (corr > 9)
                                corr = 0;
                            oldv = v;
                            Numeri(corr);
                            Fscritt.ActiveForm.Refresh();
                            inattivo = true;
                        }

                    }
                    //Lbl.Text = "blink: " + Convert.ToString(bl);
                    */
                    
                }));
            Thread.Sleep(10);

            foreach (Control control in panel1.Controls)
            {
                if (control is Label)
                {
                    ((Label)control).ForeColor = Color.Black;
                    if (((Label)control).Name == "Lnr" + Convert.ToString(corr))
                    {
                        ((Label)control).ForeColor = Color.Red;
                    }
                }
            }
        } //thinkgearchanged

        private void Fscritt_Load(object sender, EventArgs e)
        {
            bool connesso = false;

            //Lgamma.Text = "";
            //Lbl.Text = "";
            foreach (string port in SerialPort.GetPortNames())
                cboPort.Items.Add(port);
            if (cboPort.Items.Count == 0)
            {
                MessageBox.Show("nessuna seriale attiva rilevata - impossibile procedere", "attenzione", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Close();
            }

            do 
            {
                //for (int p = 0; (p < cboPort.Items.Count && !connesso); p++)
                //{

                _thinkGearWrapper.Disconnect();
                Numeri(corr);
                //System.Windows.Forms.MessageBox.Show("passo 1", "Your Caption", MessageBoxButtons.OK);
                    if (cboPort.Items.Count>1)
                        cboPort.SelectedIndex = 1; // p;
                    else
                        cboPort.SelectedIndex = 0; 
                    Lconn.Text = "connessione in corso su porta " + cboPort.SelectedItem.ToString();
                    //System.Windows.Forms.MessageBox.Show(Lconn.Text, "Your Caption", MessageBoxButtons.OK);
                    _thinkGearWrapper = new ThinkGearWrapper();

                    // setup the event
                    _thinkGearWrapper.ThinkGearChanged += _thinkGearWrapper_ThinkGearChanged;

                    // connect to the device on the specified COM port at 57600 baud
                    if (_thinkGearWrapper.Connect(cboPort.SelectedItem.ToString(), 57600, true))
                    {
                        //MessageBox.Show("passo 2");

                        Lconn.Text = "connesso a porta " + cboPort.SelectedItem.ToString();
                        Lconn.ForeColor = Color.FromKnownColor(KnownColor.Blue);
                        _thinkGearWrapper.EnableBlinkDetection(true);
                        connesso = true;
                        //System.Windows.Forms.MessageBox.Show("connesso ok ", "Your Caption", MessageBoxButtons.OK);
                        //System.Windows.Forms.MessageBox.Show("3!", "attenzione", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        //break;
                    }
                    //System.Windows.Forms.MessageBox.Show("2!", "attenzione", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //} //for
 
            } while (!connesso);

           // MessageBox.Show("!", "attenzione", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            Numeri(corr);
            Lnr.Text = "";
        }

        private void Bclose_Click(object sender, EventArgs e)
        {
            _thinkGearWrapper.EnableBlinkDetection(false);
            _thinkGearWrapper.Disconnect();
            Close();
        } 
    }
}