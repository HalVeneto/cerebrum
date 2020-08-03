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
    public partial class Fdatireg : Form
    {
        public Fdatireg()
        {
            InitializeComponent();
        }

        private void Fdatireg_Load(object sender, EventArgs e)
        {
            int x;

            vlist.Visible = false; flist.Visible = true;
            string[] filePaths = Directory.GetFiles(@".", "*.cdat", SearchOption.AllDirectories);

            for (x = 0; x < filePaths.Length; x++)
                flist.Items.Add(filePaths[x]);
        }

        private void flist_DoubleClick(object sender, EventArgs e)
        {
            /*String fn, s, ss, line;
            int v, totr = 0;
            bool ok;
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

            flist.Visible = false;
            fn = flist.SelectedItems[0].Text;
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
                if (ok)
                {
                    s = line.Substring(0, 2);
                    ss = line.Substring(3, line.Length - 3);
                    v = System.Convert.ToInt32(ss);
                    switch (s)
                    {
                        case "at":


                            ListViewItem itm = new ListViewItem();
                            itm.Text = "...";
                            itm.SubItems.Add(String.Format("{0,10:N0}", v));

                            break;
                        case "me":
                            itm.Text = "...";
                            itm.SubItems.Add(String.Format("{0,10:N0}", v));
 
                            break;
                        case "a1":
                         
                            break;
                        case "a2":
                         
                            break;
                        case "b1":
                         
                            break;
                        case "b2":
                         
                            break;
                        case "g1":
                         
                            break;
                        case "g2":
                         
                            break;
                        case "de":
                         
                            break;
                        case "th":

                            break;
                    }
                    //pb.Value = ++totr;
                } //if
                pb.Value = ++totr;
            } //while
            pb.Value = pb.Maximum;
            sr.Close();
            pb.Hide();




            //ListViewItem itm = new ListViewItem();
            //itemTit.Name = "*"; //flag

            ListViewItem itm = new ListViewItem();

            if (itm.Name != "*") //flag per non far scrivere zeri
            {
                itm.SubItems.Add(String.Format("{0,10:N0}", min));
                itm.SubItems.Add(String.Format("{0,10:N0}", max));
                if (nr > 0)
                    itm.SubItems.Add(String.Format("{0,10:N0}", tot / nr));
            }


            vlist.Columns.Add("voce", 80, HorizontalAlignment.Left);
            vlist.Columns.Add("min.", 60, HorizontalAlignment.Right);
            vlist.Columns.Add("max", 70, HorizontalAlignment.Right);
            vlist.Columns.Add("media", 60, HorizontalAlignment.Right);

            vlist.Items.AddRange(new ListViewItem[] { itemTit, item1, item2, item3, item4, item5, item6, item7, item8, item9, item10 });

            vlist.Visible = true; */
        }
    }
}