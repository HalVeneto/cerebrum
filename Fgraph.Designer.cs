namespace cerebrum
{
    partial class Fgraph
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Bclose = new System.Windows.Forms.Button();
            this.flist = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.pb = new System.Windows.Forms.ProgressBar();
            this.GBtipo = new System.Windows.Forms.GroupBox();
            this.Lmed_ = new System.Windows.Forms.Label();
            this.RBlinee = new System.Windows.Forms.RadioButton();
            this.Latt_ = new System.Windows.Forms.Label();
            this.RBbarre = new System.Windows.Forms.RadioButton();
            this.Patt = new System.Windows.Forms.Panel();
            this.Palfa = new System.Windows.Forms.Panel();
            this.Pbarre = new System.Windows.Forms.Panel();
            this.Lt = new System.Windows.Forms.Label();
            this.Ld = new System.Windows.Forms.Label();
            this.Lb2 = new System.Windows.Forms.Label();
            this.Lb1 = new System.Windows.Forms.Label();
            this.Lg2 = new System.Windows.Forms.Label();
            this.Lg1 = new System.Windows.Forms.Label();
            this.La2 = new System.Windows.Forms.Label();
            this.La1 = new System.Windows.Forms.Label();
            this.Lmed = new System.Windows.Forms.Label();
            this.Latt = new System.Windows.Forms.Label();
            this.La2_ = new System.Windows.Forms.Label();
            this.La1_ = new System.Windows.Forms.Label();
            this.Pbeta = new System.Windows.Forms.Panel();
            this.Lb2_ = new System.Windows.Forms.Label();
            this.Lb1_ = new System.Windows.Forms.Label();
            this.Pgamma = new System.Windows.Forms.Panel();
            this.Lg2_ = new System.Windows.Forms.Label();
            this.Lg1_ = new System.Windows.Forms.Label();
            this.Pdelta = new System.Windows.Forms.Panel();
            this.Lt_ = new System.Windows.Forms.Label();
            this.Ld_ = new System.Windows.Forms.Label();
            this.GBtipo.SuspendLayout();
            this.Pbarre.SuspendLayout();
            this.SuspendLayout();
            // 
            // Bclose
            // 
            this.Bclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Bclose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Bclose.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.Bclose.FlatAppearance.BorderSize = 3;
            this.Bclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bclose.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bclose.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Bclose.Location = new System.Drawing.Point(929, 18);
            this.Bclose.Name = "Bclose";
            this.Bclose.Size = new System.Drawing.Size(75, 63);
            this.Bclose.TabIndex = 17;
            this.Bclose.Text = "chiudi";
            this.Bclose.UseVisualStyleBackColor = false;
            this.Bclose.Click += new System.EventHandler(this.Bclose_Click);
            // 
            // flist
            // 
            this.flist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.flist.FullRowSelect = true;
            this.flist.GridLines = true;
            this.flist.Location = new System.Drawing.Point(104, 12);
            this.flist.MultiSelect = false;
            this.flist.Name = "flist";
            this.flist.ShowGroups = false;
            this.flist.Size = new System.Drawing.Size(376, 327);
            this.flist.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.flist.TabIndex = 20;
            this.flist.UseCompatibleStateImageBehavior = false;
            this.flist.View = System.Windows.Forms.View.Details;
            this.flist.DoubleClick += new System.EventHandler(this.flist_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "nome file";
            this.columnHeader1.Width = 256;
            // 
            // pb
            // 
            this.pb.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pb.Location = new System.Drawing.Point(0, 530);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(1016, 11);
            this.pb.TabIndex = 22;
            // 
            // GBtipo
            // 
            this.GBtipo.Controls.Add(this.Lmed_);
            this.GBtipo.Controls.Add(this.RBlinee);
            this.GBtipo.Controls.Add(this.Latt_);
            this.GBtipo.Controls.Add(this.RBbarre);
            this.GBtipo.Location = new System.Drawing.Point(12, 24);
            this.GBtipo.Name = "GBtipo";
            this.GBtipo.Size = new System.Drawing.Size(86, 65);
            this.GBtipo.TabIndex = 34;
            this.GBtipo.TabStop = false;
            this.GBtipo.Text = "tipo di grafico";
            // 
            // Lmed_
            // 
            this.Lmed_.AutoSize = true;
            this.Lmed_.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lmed_.ForeColor = System.Drawing.Color.Fuchsia;
            this.Lmed_.Location = new System.Drawing.Point(56, -4);
            this.Lmed_.Name = "Lmed_";
            this.Lmed_.Size = new System.Drawing.Size(80, 13);
            this.Lmed_.TabIndex = 42;
            this.Lmed_.Text = "/meditazione";
            // 
            // RBlinee
            // 
            this.RBlinee.AutoSize = true;
            this.RBlinee.Checked = true;
            this.RBlinee.Location = new System.Drawing.Point(6, 42);
            this.RBlinee.Name = "RBlinee";
            this.RBlinee.Size = new System.Drawing.Size(56, 17);
            this.RBlinee.TabIndex = 2;
            this.RBlinee.TabStop = true;
            this.RBlinee.Text = "a linee";
            this.RBlinee.UseVisualStyleBackColor = true;
            // 
            // Latt_
            // 
            this.Latt_.AutoSize = true;
            this.Latt_.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Latt_.ForeColor = System.Drawing.Color.Red;
            this.Latt_.Location = new System.Drawing.Point(-4, -4);
            this.Latt_.Name = "Latt_";
            this.Latt_.Size = new System.Drawing.Size(66, 13);
            this.Latt_.TabIndex = 41;
            this.Latt_.Text = "attenzione";
            // 
            // RBbarre
            // 
            this.RBbarre.AutoSize = true;
            this.RBbarre.Location = new System.Drawing.Point(6, 19);
            this.RBbarre.Name = "RBbarre";
            this.RBbarre.Size = new System.Drawing.Size(58, 17);
            this.RBbarre.TabIndex = 1;
            this.RBbarre.Text = "a barre";
            this.RBbarre.UseVisualStyleBackColor = true;
            // 
            // Patt
            // 
            this.Patt.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.Patt.Location = new System.Drawing.Point(0, 15);
            this.Patt.Name = "Patt";
            this.Patt.Size = new System.Drawing.Size(1009, 2);
            this.Patt.TabIndex = 35;
            this.Patt.Visible = false;
            // 
            // Palfa
            // 
            this.Palfa.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.Palfa.Location = new System.Drawing.Point(0, 115);
            this.Palfa.Name = "Palfa";
            this.Palfa.Size = new System.Drawing.Size(1009, 2);
            this.Palfa.TabIndex = 36;
            this.Palfa.Visible = false;
            // 
            // Pbarre
            // 
            this.Pbarre.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Pbarre.Controls.Add(this.Lt);
            this.Pbarre.Controls.Add(this.Ld);
            this.Pbarre.Controls.Add(this.Lb2);
            this.Pbarre.Controls.Add(this.Lb1);
            this.Pbarre.Controls.Add(this.Lg2);
            this.Pbarre.Controls.Add(this.Lg1);
            this.Pbarre.Controls.Add(this.La2);
            this.Pbarre.Controls.Add(this.La1);
            this.Pbarre.Controls.Add(this.Lmed);
            this.Pbarre.Controls.Add(this.Latt);
            this.Pbarre.Location = new System.Drawing.Point(0, 0);
            this.Pbarre.Name = "Pbarre";
            this.Pbarre.Size = new System.Drawing.Size(869, 14);
            this.Pbarre.TabIndex = 37;
            // 
            // Lt
            // 
            this.Lt.AutoSize = true;
            this.Lt.Location = new System.Drawing.Point(683, 0);
            this.Lt.Name = "Lt";
            this.Lt.Size = new System.Drawing.Size(31, 13);
            this.Lt.TabIndex = 42;
            this.Lt.Text = "theta";
            // 
            // Ld
            // 
            this.Ld.AutoSize = true;
            this.Ld.Location = new System.Drawing.Point(611, 0);
            this.Ld.Name = "Ld";
            this.Ld.Size = new System.Drawing.Size(30, 13);
            this.Ld.TabIndex = 41;
            this.Ld.Text = "delta";
            // 
            // Lb2
            // 
            this.Lb2.AutoSize = true;
            this.Lb2.Location = new System.Drawing.Point(540, 0);
            this.Lb2.Name = "Lb2";
            this.Lb2.Size = new System.Drawing.Size(37, 13);
            this.Lb2.TabIndex = 40;
            this.Lb2.Text = "beta 2";
            // 
            // Lb1
            // 
            this.Lb1.AutoSize = true;
            this.Lb1.Location = new System.Drawing.Point(474, 0);
            this.Lb1.Name = "Lb1";
            this.Lb1.Size = new System.Drawing.Size(37, 13);
            this.Lb1.TabIndex = 39;
            this.Lb1.Text = "beta 1";
            // 
            // Lg2
            // 
            this.Lg2.AutoSize = true;
            this.Lg2.Location = new System.Drawing.Point(389, 0);
            this.Lg2.Name = "Lg2";
            this.Lg2.Size = new System.Drawing.Size(50, 13);
            this.Lg2.TabIndex = 38;
            this.Lg2.Text = "gamma 2";
            // 
            // Lg1
            // 
            this.Lg1.AutoSize = true;
            this.Lg1.Location = new System.Drawing.Point(312, 0);
            this.Lg1.Name = "Lg1";
            this.Lg1.Size = new System.Drawing.Size(50, 13);
            this.Lg1.TabIndex = 37;
            this.Lg1.Text = "gamma 1";
            // 
            // La2
            // 
            this.La2.AutoSize = true;
            this.La2.Location = new System.Drawing.Point(243, 0);
            this.La2.Name = "La2";
            this.La2.Size = new System.Drawing.Size(33, 13);
            this.La2.TabIndex = 36;
            this.La2.Text = "alfa 2";
            // 
            // La1
            // 
            this.La1.AutoSize = true;
            this.La1.Location = new System.Drawing.Point(182, 0);
            this.La1.Name = "La1";
            this.La1.Size = new System.Drawing.Size(33, 13);
            this.La1.TabIndex = 35;
            this.La1.Text = "alfa 1";
            // 
            // Lmed
            // 
            this.Lmed.AutoSize = true;
            this.Lmed.Location = new System.Drawing.Point(91, 0);
            this.Lmed.Name = "Lmed";
            this.Lmed.Size = new System.Drawing.Size(46, 13);
            this.Lmed.TabIndex = 34;
            this.Lmed.Text = "meditaz.";
            // 
            // Latt
            // 
            this.Latt.AutoSize = true;
            this.Latt.Location = new System.Drawing.Point(16, 0);
            this.Latt.Name = "Latt";
            this.Latt.Size = new System.Drawing.Size(39, 13);
            this.Latt.TabIndex = 33;
            this.Latt.Text = "attenz.";
            // 
            // La2_
            // 
            this.La2_.AutoSize = true;
            this.La2_.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.La2_.ForeColor = System.Drawing.Color.LightGreen;
            this.La2_.Location = new System.Drawing.Point(53, 120);
            this.La2_.Name = "La2_";
            this.La2_.Size = new System.Drawing.Size(25, 13);
            this.La2_.TabIndex = 39;
            this.La2_.Text = "e 2";
            // 
            // La1_
            // 
            this.La1_.AutoSize = true;
            this.La1_.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.La1_.ForeColor = System.Drawing.Color.DarkGreen;
            this.La1_.Location = new System.Drawing.Point(8, 120);
            this.La1_.Name = "La1_";
            this.La1_.Size = new System.Drawing.Size(39, 13);
            this.La1_.TabIndex = 38;
            this.La1_.Text = "alfa 1";
            // 
            // Pbeta
            // 
            this.Pbeta.Location = new System.Drawing.Point(0, 215);
            this.Pbeta.Name = "Pbeta";
            this.Pbeta.Size = new System.Drawing.Size(1116, 2);
            this.Pbeta.TabIndex = 40;
            this.Pbeta.Visible = false;
            // 
            // Lb2_
            // 
            this.Lb2_.AutoSize = true;
            this.Lb2_.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb2_.ForeColor = System.Drawing.Color.Violet;
            this.Lb2_.Location = new System.Drawing.Point(53, 220);
            this.Lb2_.Name = "Lb2_";
            this.Lb2_.Size = new System.Drawing.Size(25, 13);
            this.Lb2_.TabIndex = 42;
            this.Lb2_.Text = "e 2";
            // 
            // Lb1_
            // 
            this.Lb1_.AutoSize = true;
            this.Lb1_.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb1_.ForeColor = System.Drawing.Color.Purple;
            this.Lb1_.Location = new System.Drawing.Point(8, 220);
            this.Lb1_.Name = "Lb1_";
            this.Lb1_.Size = new System.Drawing.Size(43, 13);
            this.Lb1_.TabIndex = 41;
            this.Lb1_.Text = "beta 1";
            // 
            // Pgamma
            // 
            this.Pgamma.Location = new System.Drawing.Point(0, 315);
            this.Pgamma.Name = "Pgamma";
            this.Pgamma.Size = new System.Drawing.Size(1116, 2);
            this.Pgamma.TabIndex = 43;
            this.Pgamma.Visible = false;
            // 
            // Lg2_
            // 
            this.Lg2_.AutoSize = true;
            this.Lg2_.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lg2_.ForeColor = System.Drawing.Color.DarkBlue;
            this.Lg2_.Location = new System.Drawing.Point(68, 320);
            this.Lg2_.Name = "Lg2_";
            this.Lg2_.Size = new System.Drawing.Size(25, 13);
            this.Lg2_.TabIndex = 45;
            this.Lg2_.Text = "e 2";
            // 
            // Lg1_
            // 
            this.Lg1_.AutoSize = true;
            this.Lg1_.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lg1_.ForeColor = System.Drawing.Color.Cyan;
            this.Lg1_.Location = new System.Drawing.Point(8, 320);
            this.Lg1_.Name = "Lg1_";
            this.Lg1_.Size = new System.Drawing.Size(57, 13);
            this.Lg1_.TabIndex = 44;
            this.Lg1_.Text = "gamma 1";
            // 
            // Pdelta
            // 
            this.Pdelta.Location = new System.Drawing.Point(0, 415);
            this.Pdelta.Name = "Pdelta";
            this.Pdelta.Size = new System.Drawing.Size(1116, 2);
            this.Pdelta.TabIndex = 46;
            // 
            // Lt_
            // 
            this.Lt_.AutoSize = true;
            this.Lt_.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lt_.ForeColor = System.Drawing.Color.Gold;
            this.Lt_.Location = new System.Drawing.Point(46, 420);
            this.Lt_.Name = "Lt_";
            this.Lt_.Size = new System.Drawing.Size(47, 13);
            this.Lt_.TabIndex = 48;
            this.Lt_.Text = "e theta";
            // 
            // Ld_
            // 
            this.Ld_.AutoSize = true;
            this.Ld_.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ld_.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.Ld_.Location = new System.Drawing.Point(8, 420);
            this.Ld_.Name = "Ld_";
            this.Ld_.Size = new System.Drawing.Size(35, 13);
            this.Ld_.TabIndex = 47;
            this.Ld_.Text = "delta";
            // 
            // Fgraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.Bclose;
            this.ClientSize = new System.Drawing.Size(1016, 541);
            this.Controls.Add(this.Lt_);
            this.Controls.Add(this.Ld_);
            this.Controls.Add(this.Pdelta);
            this.Controls.Add(this.Lg2_);
            this.Controls.Add(this.Lg1_);
            this.Controls.Add(this.Pgamma);
            this.Controls.Add(this.Lb2_);
            this.Controls.Add(this.Lb1_);
            this.Controls.Add(this.Pbeta);
            this.Controls.Add(this.La2_);
            this.Controls.Add(this.La1_);
            this.Controls.Add(this.Pbarre);
            this.Controls.Add(this.Palfa);
            this.Controls.Add(this.Patt);
            this.Controls.Add(this.GBtipo);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.flist);
            this.Controls.Add(this.Bclose);
            this.KeyPreview = true;
            this.Name = "Fgraph";
            this.Text = "cerebrum - grafici";
            this.Load += new System.EventHandler(this.Fgraph_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Fgraph_Paint);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Fgraph_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Fgraph_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Fgraph_PreviewKeyDown);
            this.GBtipo.ResumeLayout(false);
            this.GBtipo.PerformLayout();
            this.Pbarre.ResumeLayout(false);
            this.Pbarre.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bclose;
        private System.Windows.Forms.ListView flist;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ProgressBar pb;
        private System.Windows.Forms.GroupBox GBtipo;
        private System.Windows.Forms.RadioButton RBlinee;
        private System.Windows.Forms.RadioButton RBbarre;
        private System.Windows.Forms.Panel Patt;
        private System.Windows.Forms.Panel Palfa;
        private System.Windows.Forms.Panel Pbarre;
        private System.Windows.Forms.Label Lt;
        private System.Windows.Forms.Label Ld;
        private System.Windows.Forms.Label Lb2;
        private System.Windows.Forms.Label Lb1;
        private System.Windows.Forms.Label Lg2;
        private System.Windows.Forms.Label Lg1;
        private System.Windows.Forms.Label La2;
        private System.Windows.Forms.Label La1;
        private System.Windows.Forms.Label Lmed;
        private System.Windows.Forms.Label Latt;
        private System.Windows.Forms.Label Lmed_;
        private System.Windows.Forms.Label Latt_;
        private System.Windows.Forms.Label La2_;
        private System.Windows.Forms.Label La1_;
        private System.Windows.Forms.Panel Pbeta;
        private System.Windows.Forms.Label Lb2_;
        private System.Windows.Forms.Label Lb1_;
        private System.Windows.Forms.Panel Pgamma;
        private System.Windows.Forms.Label Lg2_;
        private System.Windows.Forms.Label Lg1_;
        private System.Windows.Forms.Panel Pdelta;
        private System.Windows.Forms.Label Lt_;
        private System.Windows.Forms.Label Ld_;
    }
}