using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.IO;
using System.Threading;

namespace cerebrum
{
    public partial class Fgraph : Form
    {

        public bool secondoFile = false;
        public string passo_ = "5";
        public int passo = 5; //distanza tra un punto e l'altro delle linee


        public Fgraph()
        {
            InitializeComponent();
        }

        private void Bclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        /*public static void pausa(int secondi)
        {
            DateTime adesso, inizio;
            adesso = inizio = DateTime.Now;
            inizio.AddSeconds(secondi);
            while (adesso < inizio) { adesso = DateTime.Now; }
        }*/

        public static void Barra(Rectangle myRectangle)
        {

            //Rectangle myRectangle = new Rectangle(20, 0, 50, v);
              /*              graphicsObj.DrawRectangle(myPenRed, myRectangle);
                            graphicsObj.FillRectangle(myBrushRed, myRectangle);
                            daY = v;
                            pausa(2);
                            graphicsObj.DrawRectangle(Canc, myRectangle);
                            graphicsObj.FillRectangle(myBrushCanc, myRectangle);*/
        }

        /*private void Scala100(ref int v)
        {
            v = v + 1; 
        }*/

        public void Massimo(int v, ref int mass)
        {
            if (v > mass)
            {
                mass = v;
                //MessageBox.Show(Convert.ToString(v), "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);  
            }
        }

        public void CancellaRett(int col1, int h1, int col2, int h2)
        {
            System.Drawing.Graphics graphicsObj;
            graphicsObj = this.CreateGraphics();
            Pen myPenCanc = new Pen(System.Drawing.Color.White, 3);
            Brush myBrushCanc = new SolidBrush(System.Drawing.Color.White);

            Rectangle myRectangleCanc = new Rectangle(col1, h1, col2, h2); //380
            graphicsObj.DrawRectangle(myPenCanc, myRectangleCanc);
            graphicsObj.FillRectangle(myBrushCanc, myRectangleCanc);
        }

        private void flist_DoubleClick(object sender, EventArgs e)
        {
            String fn, s, ss, line;
            int v, totr = 0;
            bool ok; //, primoAt=true;
            int oldVatt, oldVmed, oldVa1, oldVa2, oldVg1, oldVg2, oldVb1, oldVb2, oldVd, oldVt;
            int offs = 20;
            string ora = "";
            
            if (! secondoFile)
                if (RBlinee.Checked)
                {
                    passo_ = Microsoft.VisualBasic.Interaction.InputBox("passo", "informazione", passo_, 100, 100);
                    passo = Convert.ToInt32(passo_);
                }
            GBtipo.Hide();
            if (RBlinee.Checked)
            {
                Pbarre.Visible = false;
                Patt.Visible = true;
                Palfa.Visible = true;
                Pbeta.Visible = true;
                Pgamma.Visible = true;
                Pdelta.Visible = true;
                Latt_.Visible = true; Lmed_.Visible = true;
                La1_.Visible = true; La2_.Visible = true;
                Lb1_.Visible = true; Lb2_.Visible = true;
                Lg1_.Visible = true; Lg2_.Visible = true;
                Ld_.Visible = true; Lt_.Visible = true;

            }
            if (RBbarre.Checked)
            {
                Pbarre.Visible = true;
                Patt.Visible = false; 
                Palfa.Visible = false; 
                Pbeta.Visible = false;
                Pgamma.Visible = false;
                Pdelta.Visible = false;
                Latt_.Visible = false; Lmed_.Visible = false;
                La1_.Visible = false; La2_.Visible = false;
                Lb1_.Visible = false; Lb2_.Visible = false;
                Lg1_.Visible = false; Lg2_.Visible = false;
                Ld_.Visible = false; Lt_.Visible = false;
            }

            flist.Visible = false;
            Latt.Visible = true;
            Lmed.Visible = true;
            La1.Visible = true; La2.Visible = true;
            Lg1.Visible = true; Lg2.Visible = true;
            Lb1.Visible = true; Lb2.Visible = true;
            Ld.Visible = true; 
            Lt.Visible = true;
            Latt.Left = 20; Lmed.Left = 20 + 55; 
            La1.Left = 20 + 55 * 2; La2.Left = 20 + 55 * 3;
            Lg1.Left = 20 + 55 * 4; Lg2.Left = 20 + 55 * 5;
            Lb1.Left = 20 + 55 * 6; Lb2.Left = 20 + 55 * 7;
            Ld.Left = 20 + 55 * 8; 
            Lt.Left = 20 + 55 * 9;
            Fgraph.ActiveForm.Refresh();
            //Latt.Location.X = 20; Lmed.Location.X= 20 + 55; La1.Location.X= 20 + 55 * 2; 

            stats st = new stats();
            st.at_min = int.MaxValue;
            st.me_min = int.MaxValue;
            st.a1_min = int.MaxValue;
            st.a2_min = int.MaxValue;
            st.b1_min = int.MaxValue;
            st.b2_min = int.MaxValue;
            st.g1_min = int.MaxValue;
            st.g2_min = int.MaxValue;
            st.de_min = int.MaxValue;
            st.th_min = int.MaxValue;

            fn = flist.SelectedItems[0].Text;
            System.IO.StreamReader srtmp = new System.IO.StreamReader(fn);
            totr = 0;
            while ((line = srtmp.ReadLine()) != null)
                totr++;
            srtmp.Close();
            pb.Minimum = 0; pb.Maximum = totr; pb.Value = 0;
            System.IO.StreamReader sr = new System.IO.StreamReader(fn);
            totr = 0;
            while ((line = sr.ReadLine()) != null)
            {
                //MessageBox.Show(line, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ok = line.Trim() != "";
                if (ok)
                {
                    ok = line.Length > 2;
                    if (ok)
                        ok = line.Substring(2, 1) == ":";
                    if (ok)
                        if (line.Length >= 6)
                            ok = line.Substring(5, 1) != ":";
                }
                //if ( && line.Length > 2 && line.Substring(2, 1) == ":" && line.Substring(5,1) != ":") //5,1: è un orario
                if (ok)
                {
                    s = line.Substring(0, 2);
                    ss = line.Substring(3, line.Length - 3);
                    v = System.Convert.ToInt32(ss);
                    switch (s)
                    {
                        case "at":
                            st.at_tot += v;
                            st.at_nr++;
                            if (v < st.at_min)
                                st.at_min = v;
                            if (v > st.at_max)
                                st.at_max = v;
                            break;
                        case "me":
                            st.me_tot += v;
                            st.me_nr++;
                            if (v < st.me_min)
                                st.me_min = v;
                            if (v > st.me_max)
                                st.me_max = v;
                            break;
                        case "a1":
                            st.a1_tot += v;
                            st.a1_nr++;
                            if (v < st.a1_min)
                                st.a1_min = v;
                            if (v > st.a1_max)
                                st.a1_max = v;
                            break;
                        case "a2":
                            st.a2_tot += v;
                            st.a2_nr++;
                            if (v < st.a2_min)
                                st.a2_min = v;
                            if (v > st.a2_max)
                                st.a2_max = v;
                            break;
                        case "b1":
                            st.b1_tot += v;
                            st.b1_nr++;
                            if (v < st.b1_min)
                                st.b1_min = v;
                            if (v > st.b1_max)
                                st.b1_max = v;
                            break;
                        case "b2":
                            st.b2_tot += v;
                            st.b2_nr++;
                            if (v < st.b2_min)
                                st.b2_min = v;
                            if (v > st.b2_max)
                                st.b2_max = v;
                            break;
                        case "g1":
                            st.g1_tot += v;
                            st.g1_nr++;
                            if (v < st.g1_min)
                                st.g1_min = v;
                            if (v > st.g1_max)
                                st.g1_max = v;
                            break;
                        case "g2":
                            st.g2_tot += v;
                            st.g2_nr++;
                            if (v < st.g2_min)
                                st.g2_min = v;
                            if (v > st.g2_max)
                                st.g2_max = v;
                            break;
                        case "de":
                            st.de_tot += v;
                            st.de_nr++;
                            if (v < st.de_min)
                                st.de_min = v;
                            if (v > st.de_max)
                                st.de_max = v;
                            break;
                        case "th":
                            st.th_tot += v;
                            st.th_nr++;
                            if (v < st.th_min)
                                st.th_min = v;
                            if (v > st.th_max)
                                st.th_max = v;
                            break;
                    }
                    //pb.Value = ++totr;
                } //if
                pb.Value = ++totr;
            } //while
            pb.Value = pb.Maximum;
            sr.Close();

            /*mass = 0;
            Massimo(st.at_max,ref mass);
            Massimo(st.me_max, ref mass);
            Massimo(st.a1_max, ref mass);
            Massimo(st.a2_max, ref mass);
            Massimo(st.b1_max, ref mass);
            Massimo(st.b2_max, ref mass);
            Massimo(st.g1_max, ref mass);
            Massimo(st.g2_max, ref mass);
            Massimo(st.de_max, ref mass);
            Massimo(st.th_max, ref mass);*/

            int altFin=Fgraph.ActiveForm.Height;
            /*double m=(double)st.at_max;
            double moduloAtt = altFin / m;
            //int moduloMed = altFin / st.me_max;
            MessageBox.Show(Convert.ToString(altFin), "h fin", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            MessageBox.Show(Convert.ToString(st.at_max), "max att", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);  
            MessageBox.Show(Convert.ToString(moduloAtt), "mod att", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);*/
            //per barre:
            if (RBlinee.Checked)
                altFin = 100;
            int moduloA1 = st.a1_max / altFin;
            int moduloA2 = st.a2_max / altFin;
            int moduloB1 = st.b1_max / altFin;
            int moduloB2 = st.b2_max / altFin;
            int moduloG1 = st.g1_max / altFin;
            int moduloG2 = st.g2_max / altFin;
            int moduloD = st.de_max / altFin;
            int moduloT = st.th_max / altFin;
            //per linee:
            //int moduloA1lin = 350000 / 100;
            //int moduloA2lin = 456000 / 100;
            /*int moduloB1l = 419000 / 100;
            int moduloB2l = 373000 / 100;
            int moduloG1l = 154000 / 100;
            int moduloG2l = 830000 / 100;
            int moduloDl =  3725000 / 100;
            int moduloTl =  1750000 / 100;*/

            //---

            uint spess = 2; 
            System.Drawing.Graphics graphicsObj;
            graphicsObj = this.CreateGraphics();
            Pen myPenRed = new Pen(System.Drawing.Color.Red, spess);
            Pen myPenBlue = new Pen(System.Drawing.Color.Blue, spess);
            Pen myPenA1 = new Pen(System.Drawing.Color.DarkGreen, spess);
            Pen myPenA2 = new Pen(System.Drawing.Color.LightGreen, spess);
            Pen myPenViolet = new Pen(System.Drawing.Color.Violet, spess);
            Pen myPenPurple = new Pen(System.Drawing.Color.Purple, spess);
            Pen myPenCyan = new Pen(System.Drawing.Color.Cyan, spess);
            Pen myPenDarkBlue = new Pen(System.Drawing.Color.DarkBlue, spess);
            Pen myPenYellow = new Pen(System.Drawing.Color.Yellow, spess);
            Pen myPenYG = new Pen(System.Drawing.Color.YellowGreen, spess);
            Pen myPenT = new Pen(System.Drawing.Color.Tomato, spess);
            Pen myPenDarkGolden = new Pen(System.Drawing.Color.DarkGoldenrod, spess);
            Pen myPenGold = new Pen(System.Drawing.Color.Gold, spess);
            Pen myPenCanc = new Pen(System.Drawing.Color.White, spess);
            Brush myBrushRed = new SolidBrush(System.Drawing.Color.Red);
            Brush myBrushBlue = new SolidBrush(System.Drawing.Color.Blue);
            Brush myBrushGreen = new SolidBrush(System.Drawing.Color.Green);
            Brush myBrushYellow= new SolidBrush(System.Drawing.Color.Yellow);
            Brush myBrushViolet = new SolidBrush(System.Drawing.Color.Violet);
            Brush myBrushYG = new SolidBrush(System.Drawing.Color.YellowGreen);
            Brush myBrushT = new SolidBrush(System.Drawing.Color.Tomato);
            Brush myBrushCanc = new SolidBrush(System.Drawing.Color.White);

// -------------------- a barre ---------------------------------

            if (RBbarre.Checked)
            {
                fn = flist.SelectedItems[0].Text;
                System.IO.StreamReader srg = new System.IO.StreamReader(fn);
                totr = 0;
                oldVatt = -1; oldVmed = -1;
                oldVa1 = -1; oldVa2 = -1;
                oldVg1 = -1; oldVg2 = -1;
                oldVb1 = -1; oldVb2 = -1;
                oldVd = -1; oldVt = -1;
                pb.Value = 0;
                while ((line = srg.ReadLine()) != null)
                {
                    pb.Value = ++totr;
                    if (totr % 300 == 0) //pulisce schermo ogni tanto
                        for (int c = 0; c <= 9; c++)
                            CancellaRett(20 + 55 * c, offs, 50, altFin);
                    ok = line.Trim() != "";
                    if (ok)
                    {
                        ok = line.Length > 2;
                        if (ok)
                            ok = line.Substring(2, 1) == ":";
                        if (ok)
                            if (line.Length >= 6)
                                ok = line.Substring(5, 1) != ":";
                    }
                    if (ok)
                    {
                        s = line.Substring(0, 2);
                        ss = line.Substring(3, line.Length - 3);
                        v = System.Convert.ToInt32(ss);
                        v *= 2; //per aumentare
                        switch (s)
                        {
                            case "at":
                                //double vv = v * moduloAtt;
                                //v=(int)vv;
                                if (oldVatt > -1)
                                {
                                    //cancella il pezzo di rettangolo "in più"...
                                    /*Rectangle myRectangleCanc = new Rectangle(20, oldVatt+offs, 50, v+offs);
                                    graphicsObj.DrawRectangle(myPenCanc, myRectangleCanc);
                                    graphicsObj.FillRectangle(myBrushCanc, myRectangleCanc);*/
                                    CancellaRett(20, oldVatt + offs, 50, v + offs);
                                }
                                Rectangle myRectangle = new Rectangle(20, offs, 50, v + offs);
                                graphicsObj.DrawRectangle(myPenRed, myRectangle);
                                graphicsObj.FillRectangle(myBrushRed, myRectangle);
                                oldVatt = v;
                             break;
                            case "me":
                                //v *= moduloMed;
                                if (oldVmed > -1)
                                    CancellaRett(75, oldVatt + offs, 50, v + offs);
                                Rectangle myRectangleBlue = new Rectangle(75, offs, 50, v + offs);
                                graphicsObj.DrawRectangle(myPenBlue, myRectangleBlue);
                                graphicsObj.FillRectangle(myBrushBlue, myRectangleBlue);
                                oldVmed = v;
                                //Thread.Sleep(1);
                                //graphicsObj.DrawRectangle(myPenCanc, myRectangleBlue);
                                //graphicsObj.FillRectangle(myBrushCanc, myRectangleBlue);
                                break;
                            case "a1":
                                v = v / moduloA1;
                                if (oldVa1 > -1)
                                    CancellaRett(75 + 55, oldVa1 + offs, 50, v + offs);
                                Rectangle myRectangleGreen = new Rectangle(75 + 55, offs, 50, v + offs);
                                graphicsObj.DrawRectangle(myPenA1, myRectangleGreen);
                                graphicsObj.FillRectangle(myBrushGreen, myRectangleGreen);
                                oldVa1 = v;
                                break;
                            case "a2":
                                v = v / moduloA2;
                                if (oldVa2 > -1)
                                    CancellaRett(20 + 55 * 3, oldVa2 + offs, 50, v + offs);
                                Rectangle myRectangleGreen2 = new Rectangle(20 + 55 * 3, offs, 50, v + offs);
                                graphicsObj.DrawRectangle(myPenA2, myRectangleGreen2);
                                graphicsObj.FillRectangle(myBrushGreen, myRectangleGreen2);
                                oldVa2 = v;
                                break;
                            case "g1":
                                v = v / moduloG1;
                                if (oldVg1 > -1)
                                    CancellaRett(20 + 55 * 4, oldVa1 + offs, 50, v + offs);
                                Rectangle myRectangleYellow = new Rectangle(20 + 55 * 4, offs, 50, v + offs);
                                graphicsObj.DrawRectangle(myPenYellow, myRectangleYellow);
                                graphicsObj.FillRectangle(myBrushYellow, myRectangleYellow);
                                oldVg1 = v;
                                break;
                            case "g2":
                                v = v / moduloG2;
                                if (oldVg2 > -1)
                                    CancellaRett(20 + 55 * 5, oldVg2 + offs, 50, v + offs);
                                Rectangle myRectangleYellow2 = new Rectangle(20 + 55 * 5, offs, 50, v + offs);
                                graphicsObj.DrawRectangle(myPenYellow, myRectangleYellow2);
                                graphicsObj.FillRectangle(myBrushYellow, myRectangleYellow2);
                                oldVg2 = v;
                                break;
                            case "b1":
                                v = v / moduloB1;
                                if (oldVb1 > -1)
                                    CancellaRett(20 + 55 * 6, oldVb1 + offs, 50, v + offs);
                                Rectangle myRectangleViolet = new Rectangle(20 + 55 * 6, offs, 50, v + offs);
                                graphicsObj.DrawRectangle(myPenViolet, myRectangleViolet);
                                graphicsObj.FillRectangle(myBrushViolet, myRectangleViolet);
                                oldVb1 = v;
                                break;
                            case "b2":
                                v = v / moduloB2;
                                if (oldVb2 > -1)
                                    CancellaRett(20 + 55 * 7, oldVb2 + offs, 50, v + offs);
                                Rectangle myRectangleViolet2 = new Rectangle(20 + 55 * 7, offs, 50, v + offs);
                                graphicsObj.DrawRectangle(myPenViolet, myRectangleViolet2);
                                graphicsObj.FillRectangle(myBrushViolet, myRectangleViolet2);
                                oldVb2 = v;
                                break;
                            case "de":
                                v = v / moduloD;
                                if (oldVd > -1)
                                    CancellaRett(20 + 55 * 8, oldVd + offs, 50, v + offs);
                                Rectangle myRectangleYG = new Rectangle(20 + 55 * 8, offs, 50, v + offs);
                                graphicsObj.DrawRectangle(myPenYG, myRectangleYG);
                                graphicsObj.FillRectangle(myBrushYG, myRectangleYG);
                                oldVd = v;
                                break;
                            case "th":
                                v = v / moduloT;
                                if (oldVt > -1)
                                    CancellaRett(20 + 55 * 9, oldVt + offs, 50, v + offs);
                                Rectangle myRectangleT = new Rectangle(20 + 55 * 9, offs, 50, v + offs);
                                graphicsObj.DrawRectangle(myPenT, myRectangleT);
                                graphicsObj.FillRectangle(myBrushT, myRectangleT);
                                oldVt = v;
                                break;
                        } //switch s
                    } //if ok
                } //while

                //cancella barre:
                for (int c = 0; c <= 9; c++)
                    CancellaRett(20 + 55 * c, offs, 50, altFin);
                srg.Close();
            } //if RBbarre

// ---------------------- a linee --------------------------

            if (RBlinee.Checked)
            {
                fn = flist.SelectedItems[0].Text;
                int r = offs; //riga iniziale
                System.IO.StreamReader srg = new System.IO.StreamReader(fn);
                oldVatt = -1; oldVmed = -1;
                oldVa1 = -1; oldVa2 = -1;
                oldVb1 = -1; oldVb2 = -1;
                oldVg1 = -1; oldVg2 = -1;
                oldVd = -1; oldVt = -1;
                pb.Minimum = 0; pb.Maximum = totr * passo; pb.Value = 0; 
                totr = 0;
                ora = "";

                while ((line = srg.ReadLine()) != null)
                {
                    ok = true;
                    if (line.Length == 8 && line.Substring(5, 1) == ":")
                        if (ora == line)
                        {
                            ok = false;
                            //salta il "record" con stesso secondo
                            for (v = 1; v < 12; v++)
                                line = srg.ReadLine();
                        }
                        else
                        {
                            ok = true;
                            ora = line;
                        }
                    if (ok) 
                        ok = line.Trim() != "";
                    if (ok)
                    {
                        ok = line.Length > 2;
                        if (ok)
                            ok = line.Substring(2, 1) == ":";
                        if (ok)
                            if (line.Length >= 6)
                                ok = line.Substring(5, 1) != ":";
                    }
                    if (ok)
                    {
                        s = line.Substring(0, 2);
                        if (s == "at")
                        {
                            totr += passo;
                            pb.Value = totr;
                        }
                        ss = line.Substring(3, line.Length - 3);
                        v = System.Convert.ToInt32(ss);
                        switch (s)
                        {
                            case "at":
                                if (oldVatt == -1)
                                    oldVatt = v;
                                else
                                {
                                    graphicsObj.DrawLine(myPenRed, totr, Patt.Top + oldVatt, totr + passo, Patt.Top + v);
                                    oldVatt = v;
                                }
                                break;
                            case "me":
                                if (oldVmed == -1)
                                    oldVmed = v;
                                else
                                {
                                    Pen myPenMed = new Pen(System.Drawing.Color.Fuchsia, spess);
                                    graphicsObj.DrawLine(myPenMed, totr, Patt.Top + oldVmed, totr + passo, Patt.Top + v);
                                    oldVmed = v;
                                    //CBatt.Text = "att./med.:" + String.Format("{0,7:N0}", att) + String.Format("{0,7:N0}", v);
                                }
                                break;
                            case "a1":
                                v = (int)(v / moduloA1);
                                if (oldVa1 == -1)
                                    oldVa1 = v;
                                else
                                {
                                    graphicsObj.DrawLine(myPenA1, totr, Palfa.Top + oldVa1, totr + passo, Palfa.Top + v);
                                    oldVa1 = v;
                                }
                                break;
                            case "a2":
                                v = (int)(v / moduloA2);
                                if (oldVa2 == -1)
                                    oldVa2 = v;
                                else
                                {
                                    graphicsObj.DrawLine(myPenA2, totr, Palfa.Top + oldVa2, totr + passo, Palfa.Top + v);
                                    oldVa2 = v;
                                }
                                break;
                            case "b1":
                                v = (int)(v / moduloB1);
                                if (oldVb1 == -1)
                                    oldVb1 = v;
                                else
                                {
                                    graphicsObj.DrawLine(myPenPurple, totr, Pbeta.Top + oldVb1, totr + passo, Pbeta.Top + v);
                                    oldVb1 = v;
                                    //CBatt.Text = "att./med.:" + String.Format("{0,7:N0}", att) + String.Format("{0,7:N0}", v);
                                }
                                break;
                            case "b2":
                                v = (int)(v / moduloB2);
                                if (oldVb2 == -1)
                                    oldVb2 = v;
                                else
                                {
                                    graphicsObj.DrawLine(myPenViolet, totr, Pbeta.Top + oldVb2, totr + passo, Pbeta.Top + v);
                                    oldVb2 = v;
                                    //CBatt.Text = "att./med.:" + String.Format("{0,7:N0}", att) + String.Format("{0,7:N0}", v);
                                }
                                break;
                            case "g1":
                                v = (int)(v / moduloG1);
                                if (oldVg1 == -1)
                                    oldVg1 = v;
                                else
                                {
                                    graphicsObj.DrawLine(myPenCyan, totr, Pgamma.Top + oldVg1, totr + passo, Pgamma.Top + v);
                                    oldVg1 = v;
                                    //CBatt.Text = "att./med.:" + String.Format("{0,7:N0}", att) + String.Format("{0,7:N0}", v);
                                }
                                break;
                            case "g2":
                                v = (int)(v / moduloG2);
                                if (oldVg2 == -1)
                                    oldVg2 = v;
                                else
                                {
                                    graphicsObj.DrawLine(myPenDarkBlue, totr, Pgamma.Top + oldVg2, totr + passo, Pgamma.Top + v);
                                    oldVg2 = v;
                                }
                                break;
                            case "de":
                                v = (int)(v / moduloD);
                                if (oldVd == -1)
                                    oldVd = v;
                                else
                                {
                                    graphicsObj.DrawLine(myPenDarkGolden, totr, Pdelta.Top + oldVd, totr + passo, Pdelta.Top + v);
                                    oldVd = v;
                                }
                                break;
                            case "th":
                                v = (int)(v / moduloT);
                                if (oldVt == -1)
                                    oldVt = v;
                                else
                                {
                                    //if ((totr % (passo*2)) == 0)
                                        graphicsObj.DrawLine(myPenGold, totr, Pdelta.Top + oldVt, totr + passo, Pdelta.Top + v);
                                    //else
                                        //graphicsObj.DrawLine(myPenCyan, totr, Pdelta.Top + oldVt, totr + passo, Pdelta.Top + v);
                                    oldVt = v;
                                }
                                break;
                        } //switch s
                    } //if ok
                    if (totr > Fgraph.ActiveForm.Width)
                    {
                        if (MessageBox.Show("continuare?", "informazione",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        {
                            sr.Close();
                            Close();
                            return;
                        }
                        CancellaRett(0, Patt.Top, Fgraph.ActiveForm.Width, Fgraph.ActiveForm.Height);
                        totr = 0;
                    }
                } //while
            } //if RBlinee
            
            pb.Hide();

            /* if (MessageBox.Show("confrontare con altri dati simili?", "informazione",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                Close();
                return;
            }
            flist.Visible = true;
            secondoFile = true; */
      
        }

        private void Fgraph_Load(object sender, EventArgs e)
        {
            int x;

            flist.Visible = true;
            string[] filePaths = Directory.GetFiles(@".", "*.cdat", SearchOption.AllDirectories);

            for (x = 0; x < filePaths.Length; x++)
                flist.Items.Add(filePaths[x]);

            Latt_.Visible = false;
            Lmed_.Visible = false;
            La1_.Visible = false; La2_.Visible = false;
            Lb1_.Visible = false; Lb2_.Visible = false;
            Lg1_.Visible = false; Lg2_.Visible = false;
            Ld_.Visible = false; Lt_.Visible = false;
        }

        private void Fgraph_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Graphics graphicsObj;
            graphicsObj = this.CreateGraphics();
            Pen myPen = new Pen(System.Drawing.Color.Red, 3);
            /*Rectangle myRectangle = new Rectangle(20, 0, 50, altezza);
            graphicsObj.DrawRectangle(myPen, myRectangle);
            Brush myBrush = new SolidBrush(System.Drawing.Color.Red);
            e.Graphics.FillRectangle(myBrush, myRectangle);*/
            //e.Graphics.DrawRectangle(new Pen(Color.Blue, 3), RcDraw);
            //MessageBox.Show((RcDraw.Height), "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
        }

        private void La1_Click(object sender, EventArgs e)
        {

        }

        private void Fgraph_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)27)
                Application.Exit();
        }

        private void Fgraph_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void Fgraph_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
    }
}