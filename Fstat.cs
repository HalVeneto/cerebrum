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
    public partial class Fstat : Form
    {
        public Fstat()
        {
            InitializeComponent();
        }

        private void Fstat_Activated(object sender, EventArgs e)
        {
          
        }

        private void Bclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Fstat_Load(object sender, EventArgs e)
        {
            int x;

            vlist.Visible=false; flist.Visible=true;
            string[] filePaths = Directory.GetFiles(@".", "*.cdat", SearchOption.AllDirectories);

            for (x = 0; x < filePaths.Length; x++)
                flist.Items.Add(filePaths[x]);
        }

        private void MostraVoce(ListViewItem itm, String des, int min, long max, long tot, long nr)
        {
            itm.Text = des;
            if (itm.Name != "*") //flag per non far scrivere zeri
            {
                itm.SubItems.Add(String.Format("{0,10:N0}", min));
                itm.SubItems.Add(String.Format("{0,10:N0}", max));
                if (nr > 0)
                    itm.SubItems.Add(String.Format("{0,10:N0}", tot / nr));
            }
        }

        private void flist_DoubleClick(object sender, EventArgs e)
        {
            String fn, s, ss, line;
            int v, totr = 0;
            bool ok;

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

            flist.Visible = false;
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
            pb.Hide();

            vlist.Items.Clear();

            // Set the view to show details.
            vlist.View = View.Details;
            // Allow the user to edit item text.
            vlist.LabelEdit = true;
            // Allow the user to rearrange columns.
            vlist.AllowColumnReorder = true;
            // Display check boxes.
            vlist.CheckBoxes = false;
            // Select the item and subitems when selection is made.
            vlist.FullRowSelect = true;
            // Display grid lines.
            vlist.GridLines = true;
            // Sort the items in the list in ascending order.
            //vlist.Sorting = SortOrder.Ascending;

            ListViewItem itemTit = new ListViewItem();
            itemTit.Name = "*"; //flag
            line = fn;
            //string tit = Microsoft.VisualBasic.Interaction.InputBox("titolo", "informazione", line, vlist.Left, vlist.Top);
            MostraVoce(itemTit, "file: " + fn, 0, 0, 0, 0);

            ListViewItem item1 = new ListViewItem();
            /*item1.Text = "attenzione";
            item1.SubItems.Add(String.Format("{0,10:N0}", st.at_min));
            item1.SubItems.Add(String.Format("{0,10:N0}", st.at_max));
            item1.SubItems.Add(String.Format("{0,10:N0}", st.at_tot / st.at_nr));*/
            MostraVoce(item1, "attenzione", st.at_min, st.at_max, st.at_tot, st.at_nr);

            ListViewItem item2 = new ListViewItem();
            MostraVoce(item2, "meditazione", st.me_min, st.me_max, st.me_tot, st.me_nr);

            ListViewItem item3 = new ListViewItem();
            MostraVoce(item3, "alfa 1", st.a1_min, st.a1_max, st.a1_tot, st.a1_nr);

            ListViewItem item4 = new ListViewItem();
            MostraVoce(item4, "alfa 2", st.a2_min, st.a2_max, st.a2_tot, st.a2_nr);

            ListViewItem item5 = new ListViewItem();
            item5.Text = "beta 1";
            MostraVoce(item5, "beta 1", st.b1_min, st.b1_max, st.b1_tot, st.b1_nr);

            ListViewItem item6 = new ListViewItem();
            MostraVoce(item6, "beta 2", st.b2_min, st.b2_max, st.b2_tot, st.b2_nr);

            ListViewItem item7 = new ListViewItem();
            MostraVoce(item7, "gamma 1", st.g1_min, st.g1_max, st.g1_tot, st.g1_nr);

            ListViewItem item8 = new ListViewItem();
            MostraVoce(item8, "gamma 2", st.g2_min, st.g2_max, st.g2_tot, st.g2_nr);

            ListViewItem item9 = new ListViewItem();
            MostraVoce(item9, "delta", st.de_min, st.de_max, st.de_tot, st.de_nr);

            ListViewItem item10 = new ListViewItem();
            item10.Text = "theta";
            MostraVoce(item10, "theta", st.th_min, st.th_max, st.th_tot, st.th_nr);
          
            vlist.Columns.Add("voce", 80, HorizontalAlignment.Left);
            vlist.Columns.Add("min.", 60, HorizontalAlignment.Right);
            vlist.Columns.Add("max", 70, HorizontalAlignment.Right);
            vlist.Columns.Add("media", 60, HorizontalAlignment.Right);

            vlist.Items.AddRange(new ListViewItem[] { itemTit, item1, item2, item3, item4, item5, item6, item7, item8, item9, item10 });

            vlist.Visible = true;
        } //dblclick
    } //fstat
}