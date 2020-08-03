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
using System.Diagnostics;

namespace cerebrum
{

    public partial class Fsegnali : Form
    {

        private ThinkGearWrapper _thinkGearWrapper = new ThinkGearWrapper();

        public bool taratura = false, test = false, cresce=false;
        public int r, oldVraw, rawMin = 1000000, rawMax = -1000000, blink = 0;
        public long livello = 100;
        public Stopwatch myStopWatch = new Stopwatch();
        public TimeSpan ts;

        public Fsegnali()
        {
            InitializeComponent();
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
            int raw, rawInScala, ps;
            bool ok;
            //DateTime tmp;
            

            // update the textbox and sleep for a tiny bit
            BeginInvoke(new MethodInvoker(delegate
                {
                    Ltimer.Text = DateTime.Now.ToString("HH:mm:ss:ff tt"); 
                    //Lctr.Text = Convert.ToString(blink); //per debug

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
                        raw = (int)e.ThinkGearState.Raw;
                        rawInScala = (int)(raw / 10);
                        if (oldVraw == -1)
                            oldVraw = rawInScala;
                        else
                        {
                            Pen myPenRed = new Pen(System.Drawing.Color.Red, 1);
                            graphicsObj.DrawLine(myPenRed, r, Lmin.Top + 130 + oldVraw, r + 1, Lmin.Top + 130 + rawInScala);
                            oldVraw = rawInScala;   
                        }
                        if (taratura)
                        {
                            if (raw > rawMax)
                                rawMax = raw;
                            if (raw < rawMin)
                                rawMin = raw;
                            Lmin.Text = String.Format("{0,8:N0}", rawMin);
                            Lmax.Text = String.Format("{0,8:N0}", rawMax);
                        }
                        if (test)
                        {
                            if (myStopWatch.IsRunning)
                                Lsec.Text = "secs: " + Convert.ToString(myStopWatch.Elapsed.Seconds);
                            else
                                Lsec.Text = "";
                            Lctr.Text = Convert.ToString(blink);

                            if (blink > 0)
                            {
                                ts = myStopWatch.Elapsed;
                                if (myStopWatch.IsRunning && ts.Seconds > 3) 
                                {
                                    switch (blink)
                                    {
                                        case 1:
                                            imm1.Show();
                                            Fsegnali.ActiveForm.Refresh();
                                            Thread.Sleep(3000);
                                            imm1.Hide();
                                            break;
                                        case 2:
                                            Lbl.Text = "ok!";
                                            imm2.Show();
                                            Fsegnali.ActiveForm.Refresh();
                                            Thread.Sleep(3000);
                                            imm2.Hide();
                                            break;
                                        case 3:
                                            imm3.Show();
                                            Fsegnali.ActiveForm.Refresh();
                                            Thread.Sleep(3000);
                                            imm3.Hide();
                                            break;
                                        default:                                           
                                            Lbl.Text = Convert.ToString(blink) + "non gestito";
                                            Fsegnali.ActiveForm.Refresh();
                                            Thread.Sleep(3000);
                                            break;
                                    } //switch
                                    blink = 0;
                                    cresce = false;
                                    livello = 100;
                                    Lbl.Text = "";
                                    raw = 0;
                                    myStopWatch.Stop();  // Arresta il cronometro
                                } //if ts.seconds
                            } //if > 0

                            if ((blink == 0) && ((raw > (rawMax + 400)) || (raw < (rawMin - 400))))
                            {
                                imm0.Show();
                                Limm0.Text = Convert.ToString(raw);
                                Fsegnali.ActiveForm.Refresh();
                                Thread.Sleep(3000);
                                imm0.Hide();
                                blink = 0;
                                livello = 100;
                                cresce = false;
                            }
                            else
                                if (raw > rawMax + livello) //solo i picchi positivi così non considera andamento onda
                                {
                                    if (blink == 0)
                                    {
                                        myStopWatch.Reset();
                                        myStopWatch.Start();  //riavvia il cronometro
                                    }
                                    if (myStopWatch.IsRunning && !cresce)
                                        blink++;
                                    cresce = true;
                                    livello = raw - rawMax; //differenza massima di altezza raggiunta la 1° volta; default 100
                                }
                                else
                                    cresce = false;
                        }
                        Lraw.Text = String.Format("{0,8:N0}", raw);

                        r++;
                        if (r > Flive.ActiveForm.Width - 20)
                        {
                            CancellaRett(0, Lmin.Top - 5, Flive.ActiveForm.Width, Lmin.Top + 120);
                            r = GBtarat.Left + GBtarat.Width + 20;
                        }
                    } //if ok

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
                taratura = true;
                BfineTarat.Enabled = true;
                r = GBtarat.Left + GBtarat.Width + 20;
                _thinkGearWrapper.EnableBlinkDetection(true);
            }
        }

        private void Bdisatt_Click(object sender, EventArgs e)
        {
            _thinkGearWrapper.Disconnect();
            Bconn.Enabled = true;
            Bdisatt.Enabled = false;
        }

        private void Fsegnali_Load(object sender, EventArgs e)
        {  

            foreach (string port in SerialPort.GetPortNames())
                cboPort.Items.Add(port);
            cboPort.SelectedIndex = 0;

        }

        private void Btara_Click(object sender, EventArgs e)
        {
            if (taratura) //se già attiva, resetta
            {
                Lmin.Text = ""; rawMin = 1000000;
                Lmax.Text = ""; rawMax = -1000000;
                CancellaRett(0, Lmin.Top - 5, Flive.ActiveForm.Width, Lmin.Top + 190); //105
            }
            /* else
            {
                taratura = true;
                BfineTarat.Enabled = true;
                r = GBtarat.Left + GBtarat.Width + 20;
                _thinkGearWrapper.EnableBlinkDetection(true);
            }*/
        }

        private void BfineTarat_Click(object sender, EventArgs e)
        {
            taratura = false;
            test = true;
            Bscritt.Enabled = true;
            GBtest.Show();
        }

        private void Imm1_Click(object sender, EventArgs e)
        {

        }

        private void Lmax__Click(object sender, EventArgs e)
        {

        }

        private void imm1_Click_1(object sender, EventArgs e)
        {

        }
    }
}