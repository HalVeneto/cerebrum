namespace cerebrum
{
    partial class Fsinglew
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
            this.GBconn = new System.Windows.Forms.GroupBox();
            this.cboPort = new System.Windows.Forms.ComboBox();
            this.Lporta = new System.Windows.Forms.Label();
            this.Bdisatt = new System.Windows.Forms.Button();
            this.Bconn = new System.Windows.Forms.Button();
            this.Ltimer = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CBint = new System.Windows.Forms.ComboBox();
            this.Lint = new System.Windows.Forms.Label();
            this.Lpoor = new System.Windows.Forms.Label();
            this.Bclose = new System.Windows.Forms.Button();
            this.Lmed = new System.Windows.Forms.Label();
            this.Lt = new System.Windows.Forms.Label();
            this.Lb2 = new System.Windows.Forms.Label();
            this.Lg2 = new System.Windows.Forms.Label();
            this.La2 = new System.Windows.Forms.Label();
            this.Ld = new System.Windows.Forms.Label();
            this.Lg1 = new System.Windows.Forms.Label();
            this.Lb1 = new System.Windows.Forms.Label();
            this.La1 = new System.Windows.Forms.Label();
            this.Latt = new System.Windows.Forms.Label();
            this.Pini = new System.Windows.Forms.Panel();
            this.CBraw = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Emax = new System.Windows.Forms.MaskedTextBox();
            this.CBatt = new System.Windows.Forms.RadioButton();
            this.CBgamma1 = new System.Windows.Forms.RadioButton();
            this.CBmed = new System.Windows.Forms.RadioButton();
            this.CBgamma2 = new System.Windows.Forms.RadioButton();
            this.CBalfa1 = new System.Windows.Forms.RadioButton();
            this.CBalfa2 = new System.Windows.Forms.RadioButton();
            this.CBbeta1 = new System.Windows.Forms.RadioButton();
            this.CBbeta2 = new System.Windows.Forms.RadioButton();
            this.CBde = new System.Windows.Forms.RadioButton();
            this.CBth = new System.Windows.Forms.RadioButton();
            this.Lmax = new System.Windows.Forms.Label();
            this.Lmin = new System.Windows.Forms.Label();
            this.Bazz = new System.Windows.Forms.Button();
            this.Locchi = new System.Windows.Forms.Label();
            this.CBocchi = new System.Windows.Forms.RadioButton();
            this.GBconn.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBconn
            // 
            this.GBconn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.GBconn.Controls.Add(this.cboPort);
            this.GBconn.Controls.Add(this.Lporta);
            this.GBconn.Controls.Add(this.Bdisatt);
            this.GBconn.Controls.Add(this.Bconn);
            this.GBconn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBconn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GBconn.Location = new System.Drawing.Point(2, 3);
            this.GBconn.Name = "GBconn";
            this.GBconn.Size = new System.Drawing.Size(399, 72);
            this.GBconn.TabIndex = 19;
            this.GBconn.TabStop = false;
            this.GBconn.Text = "connessione";
            // 
            // cboPort
            // 
            this.cboPort.FormattingEnabled = true;
            this.cboPort.Location = new System.Drawing.Point(101, 38);
            this.cboPort.Name = "cboPort";
            this.cboPort.Size = new System.Drawing.Size(121, 24);
            this.cboPort.TabIndex = 7;
            // 
            // Lporta
            // 
            this.Lporta.AutoSize = true;
            this.Lporta.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lporta.Location = new System.Drawing.Point(98, 19);
            this.Lporta.Name = "Lporta";
            this.Lporta.Size = new System.Drawing.Size(81, 16);
            this.Lporta.TabIndex = 6;
            this.Lporta.Text = "porte seriali:";
            // 
            // Bdisatt
            // 
            this.Bdisatt.Enabled = false;
            this.Bdisatt.Location = new System.Drawing.Point(304, 22);
            this.Bdisatt.Name = "Bdisatt";
            this.Bdisatt.Size = new System.Drawing.Size(88, 40);
            this.Bdisatt.TabIndex = 2;
            this.Bdisatt.Text = "disconnetti";
            this.Bdisatt.UseVisualStyleBackColor = true;
            this.Bdisatt.Click += new System.EventHandler(this.Bdisatt_Click);
            // 
            // Bconn
            // 
            this.Bconn.Location = new System.Drawing.Point(6, 22);
            this.Bconn.Name = "Bconn";
            this.Bconn.Size = new System.Drawing.Size(82, 40);
            this.Bconn.TabIndex = 1;
            this.Bconn.Text = "connetti";
            this.Bconn.UseVisualStyleBackColor = true;
            this.Bconn.Click += new System.EventHandler(this.Bconn_Click);
            // 
            // Ltimer
            // 
            this.Ltimer.AutoSize = true;
            this.Ltimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ltimer.Location = new System.Drawing.Point(411, 16);
            this.Ltimer.Name = "Ltimer";
            this.Ltimer.Size = new System.Drawing.Size(57, 13);
            this.Ltimer.TabIndex = 58;
            this.Ltimer.Text = "00:00:00";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.Bclose);
            this.panel2.Location = new System.Drawing.Point(494, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 71);
            this.panel2.TabIndex = 60;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.CBint);
            this.panel1.Controls.Add(this.Lint);
            this.panel1.Controls.Add(this.Lpoor);
            this.panel1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(176, 63);
            this.panel1.TabIndex = 60;
            // 
            // CBint
            // 
            this.CBint.FormattingEnabled = true;
            this.CBint.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.CBint.Location = new System.Drawing.Point(129, 37);
            this.CBint.Name = "CBint";
            this.CBint.Size = new System.Drawing.Size(39, 21);
            this.CBint.TabIndex = 19;
            this.CBint.Text = "5";
            // 
            // Lint
            // 
            this.Lint.AutoSize = true;
            this.Lint.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Lint.Location = new System.Drawing.Point(7, 40);
            this.Lint.Margin = new System.Windows.Forms.Padding(1, 0, 3, 0);
            this.Lint.Name = "Lint";
            this.Lint.Size = new System.Drawing.Size(116, 13);
            this.Lint.TabIndex = 18;
            this.Lint.Text = "intervallo da cosiderare";
            // 
            // Lpoor
            // 
            this.Lpoor.AutoSize = true;
            this.Lpoor.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Lpoor.Location = new System.Drawing.Point(7, 10);
            this.Lpoor.Margin = new System.Windows.Forms.Padding(1, 0, 3, 0);
            this.Lpoor.Name = "Lpoor";
            this.Lpoor.Size = new System.Drawing.Size(44, 13);
            this.Lpoor.TabIndex = 17;
            this.Lpoor.Text = "segnale";
            // 
            // Bclose
            // 
            this.Bclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Bclose.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.Bclose.FlatAppearance.BorderSize = 3;
            this.Bclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bclose.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bclose.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Bclose.Location = new System.Drawing.Point(185, 3);
            this.Bclose.Name = "Bclose";
            this.Bclose.Size = new System.Drawing.Size(75, 63);
            this.Bclose.TabIndex = 18;
            this.Bclose.Text = "chiudi";
            this.Bclose.UseVisualStyleBackColor = false;
            this.Bclose.Click += new System.EventHandler(this.Bclose_Click);
            // 
            // Lmed
            // 
            this.Lmed.AutoSize = true;
            this.Lmed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lmed.ForeColor = System.Drawing.Color.Fuchsia;
            this.Lmed.Location = new System.Drawing.Point(29, 95);
            this.Lmed.Name = "Lmed";
            this.Lmed.Size = new System.Drawing.Size(74, 13);
            this.Lmed.TabIndex = 71;
            this.Lmed.Text = "meditazione";
            // 
            // Lt
            // 
            this.Lt.AutoSize = true;
            this.Lt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lt.ForeColor = System.Drawing.Color.Gold;
            this.Lt.Location = new System.Drawing.Point(804, 95);
            this.Lt.Name = "Lt";
            this.Lt.Size = new System.Drawing.Size(36, 13);
            this.Lt.TabIndex = 70;
            this.Lt.Text = "theta";
            // 
            // Lb2
            // 
            this.Lb2.AutoSize = true;
            this.Lb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb2.ForeColor = System.Drawing.Color.Violet;
            this.Lb2.Location = new System.Drawing.Point(425, 96);
            this.Lb2.Name = "Lb2";
            this.Lb2.Size = new System.Drawing.Size(43, 13);
            this.Lb2.TabIndex = 69;
            this.Lb2.Text = "beta 2";
            // 
            // Lg2
            // 
            this.Lg2.AutoSize = true;
            this.Lg2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lg2.ForeColor = System.Drawing.Color.DarkBlue;
            this.Lg2.Location = new System.Drawing.Point(595, 94);
            this.Lg2.Name = "Lg2";
            this.Lg2.Size = new System.Drawing.Size(57, 13);
            this.Lg2.TabIndex = 68;
            this.Lg2.Text = "gamma 2";
            // 
            // La2
            // 
            this.La2.AutoSize = true;
            this.La2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.La2.ForeColor = System.Drawing.Color.LightGreen;
            this.La2.Location = new System.Drawing.Point(230, 96);
            this.La2.Name = "La2";
            this.La2.Size = new System.Drawing.Size(39, 13);
            this.La2.TabIndex = 67;
            this.La2.Text = "alfa 2";
            // 
            // Ld
            // 
            this.Ld.AutoSize = true;
            this.Ld.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ld.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.Ld.Location = new System.Drawing.Point(805, 82);
            this.Ld.Name = "Ld";
            this.Ld.Size = new System.Drawing.Size(35, 13);
            this.Ld.TabIndex = 66;
            this.Ld.Text = "delta";
            // 
            // Lg1
            // 
            this.Lg1.AutoSize = true;
            this.Lg1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lg1.ForeColor = System.Drawing.Color.Cyan;
            this.Lg1.Location = new System.Drawing.Point(594, 79);
            this.Lg1.Name = "Lg1";
            this.Lg1.Size = new System.Drawing.Size(57, 13);
            this.Lg1.TabIndex = 65;
            this.Lg1.Text = "gamma 1";
            // 
            // Lb1
            // 
            this.Lb1.AutoSize = true;
            this.Lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb1.ForeColor = System.Drawing.Color.Purple;
            this.Lb1.Location = new System.Drawing.Point(425, 81);
            this.Lb1.Name = "Lb1";
            this.Lb1.Size = new System.Drawing.Size(43, 13);
            this.Lb1.TabIndex = 64;
            this.Lb1.Text = "beta 1";
            // 
            // La1
            // 
            this.La1.AutoSize = true;
            this.La1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.La1.ForeColor = System.Drawing.Color.DarkGreen;
            this.La1.Location = new System.Drawing.Point(230, 81);
            this.La1.Name = "La1";
            this.La1.Size = new System.Drawing.Size(39, 13);
            this.La1.TabIndex = 63;
            this.La1.Text = "alfa 1";
            // 
            // Latt
            // 
            this.Latt.AutoSize = true;
            this.Latt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Latt.ForeColor = System.Drawing.Color.Red;
            this.Latt.Location = new System.Drawing.Point(29, 81);
            this.Latt.Name = "Latt";
            this.Latt.Size = new System.Drawing.Size(66, 13);
            this.Latt.TabIndex = 62;
            this.Latt.Text = "attenzione";
            // 
            // Pini
            // 
            this.Pini.BackColor = System.Drawing.Color.DarkTurquoise;
            this.Pini.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Pini.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.Pini.Location = new System.Drawing.Point(0, 115);
            this.Pini.Name = "Pini";
            this.Pini.Size = new System.Drawing.Size(1000, 3);
            this.Pini.TabIndex = 82;
            // 
            // CBraw
            // 
            this.CBraw.AutoSize = true;
            this.CBraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBraw.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.CBraw.Location = new System.Drawing.Point(910, 90);
            this.CBraw.Name = "CBraw";
            this.CBraw.Size = new System.Drawing.Size(45, 17);
            this.CBraw.TabIndex = 83;
            this.CBraw.Text = "raw";
            this.CBraw.UseVisualStyleBackColor = true;
            this.CBraw.Click += new System.EventHandler(this.CBraw_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(767, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 85;
            this.label1.Text = "scala massima:";
            // 
            // Emax
            // 
            this.Emax.Location = new System.Drawing.Point(870, 13);
            this.Emax.Name = "Emax";
            this.Emax.Size = new System.Drawing.Size(100, 20);
            this.Emax.TabIndex = 86;
            this.Emax.Text = "100";
            this.Emax.ModifiedChanged += new System.EventHandler(this.Emax_Leave);
            this.Emax.Leave += new System.EventHandler(this.Emax_Leave);
            // 
            // CBatt
            // 
            this.CBatt.AutoSize = true;
            this.CBatt.Checked = true;
            this.CBatt.Location = new System.Drawing.Point(8, 79);
            this.CBatt.Name = "CBatt";
            this.CBatt.Size = new System.Drawing.Size(14, 13);
            this.CBatt.TabIndex = 87;
            this.CBatt.TabStop = true;
            this.CBatt.UseVisualStyleBackColor = true;
            this.CBatt.Click += new System.EventHandler(this.CBatt_Click);
            // 
            // CBgamma1
            // 
            this.CBgamma1.AutoSize = true;
            this.CBgamma1.Location = new System.Drawing.Point(574, 78);
            this.CBgamma1.Name = "CBgamma1";
            this.CBgamma1.Size = new System.Drawing.Size(14, 13);
            this.CBgamma1.TabIndex = 88;
            this.CBgamma1.UseVisualStyleBackColor = true;
            this.CBgamma1.Click += new System.EventHandler(this.CBgamma1_Click);
            // 
            // CBmed
            // 
            this.CBmed.AutoSize = true;
            this.CBmed.Location = new System.Drawing.Point(8, 95);
            this.CBmed.Name = "CBmed";
            this.CBmed.Size = new System.Drawing.Size(14, 13);
            this.CBmed.TabIndex = 89;
            this.CBmed.UseVisualStyleBackColor = true;
            this.CBmed.Click += new System.EventHandler(this.CBmed_Click);
            // 
            // CBgamma2
            // 
            this.CBgamma2.AutoSize = true;
            this.CBgamma2.Location = new System.Drawing.Point(574, 94);
            this.CBgamma2.Name = "CBgamma2";
            this.CBgamma2.Size = new System.Drawing.Size(14, 13);
            this.CBgamma2.TabIndex = 90;
            this.CBgamma2.UseVisualStyleBackColor = true;
            this.CBgamma2.Click += new System.EventHandler(this.CBgamma2_Click);
            // 
            // CBalfa1
            // 
            this.CBalfa1.AutoSize = true;
            this.CBalfa1.Location = new System.Drawing.Point(209, 79);
            this.CBalfa1.Name = "CBalfa1";
            this.CBalfa1.Size = new System.Drawing.Size(14, 13);
            this.CBalfa1.TabIndex = 91;
            this.CBalfa1.UseVisualStyleBackColor = true;
            this.CBalfa1.Click += new System.EventHandler(this.CBalfa1_Click);
            // 
            // CBalfa2
            // 
            this.CBalfa2.AutoSize = true;
            this.CBalfa2.Location = new System.Drawing.Point(209, 95);
            this.CBalfa2.Name = "CBalfa2";
            this.CBalfa2.Size = new System.Drawing.Size(14, 13);
            this.CBalfa2.TabIndex = 92;
            this.CBalfa2.UseVisualStyleBackColor = true;
            this.CBalfa2.Click += new System.EventHandler(this.CBalfa2_Click);
            // 
            // CBbeta1
            // 
            this.CBbeta1.AutoSize = true;
            this.CBbeta1.Location = new System.Drawing.Point(403, 81);
            this.CBbeta1.Name = "CBbeta1";
            this.CBbeta1.Size = new System.Drawing.Size(14, 13);
            this.CBbeta1.TabIndex = 93;
            this.CBbeta1.UseVisualStyleBackColor = true;
            this.CBbeta1.Click += new System.EventHandler(this.CBbeta1_Click);
            // 
            // CBbeta2
            // 
            this.CBbeta2.AutoSize = true;
            this.CBbeta2.Location = new System.Drawing.Point(403, 96);
            this.CBbeta2.Name = "CBbeta2";
            this.CBbeta2.Size = new System.Drawing.Size(14, 13);
            this.CBbeta2.TabIndex = 94;
            this.CBbeta2.UseVisualStyleBackColor = true;
            this.CBbeta2.Click += new System.EventHandler(this.CBbeta2_Click);
            // 
            // CBde
            // 
            this.CBde.AutoSize = true;
            this.CBde.Location = new System.Drawing.Point(783, 81);
            this.CBde.Name = "CBde";
            this.CBde.Size = new System.Drawing.Size(14, 13);
            this.CBde.TabIndex = 95;
            this.CBde.UseVisualStyleBackColor = true;
            this.CBde.Click += new System.EventHandler(this.CBde_Click);
            // 
            // CBth
            // 
            this.CBth.AutoSize = true;
            this.CBth.Location = new System.Drawing.Point(783, 96);
            this.CBth.Name = "CBth";
            this.CBth.Size = new System.Drawing.Size(14, 13);
            this.CBth.TabIndex = 96;
            this.CBth.UseVisualStyleBackColor = true;
            this.CBth.Click += new System.EventHandler(this.CBth_Click);
            // 
            // Lmax
            // 
            this.Lmax.AutoSize = true;
            this.Lmax.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lmax.Location = new System.Drawing.Point(767, 37);
            this.Lmax.Name = "Lmax";
            this.Lmax.Size = new System.Drawing.Size(76, 16);
            this.Lmax.TabIndex = 97;
            this.Lmax.Text = "valore max:";
            // 
            // Lmin
            // 
            this.Lmin.AutoSize = true;
            this.Lmin.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lmin.Location = new System.Drawing.Point(767, 53);
            this.Lmin.Name = "Lmin";
            this.Lmin.Size = new System.Drawing.Size(73, 16);
            this.Lmin.TabIndex = 98;
            this.Lmin.Text = "valore min:";
            // 
            // Bazz
            // 
            this.Bazz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Bazz.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Bazz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bazz.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bazz.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Bazz.Location = new System.Drawing.Point(883, 44);
            this.Bazz.Name = "Bazz";
            this.Bazz.Size = new System.Drawing.Size(87, 21);
            this.Bazz.TabIndex = 99;
            this.Bazz.Text = "azzera estremi";
            this.Bazz.UseVisualStyleBackColor = false;
            this.Bazz.Click += new System.EventHandler(this.Bazz_Click);
            // 
            // Locchi
            // 
            this.Locchi.AutoSize = true;
            this.Locchi.Location = new System.Drawing.Point(411, 37);
            this.Locchi.Name = "Locchi";
            this.Locchi.Size = new System.Drawing.Size(36, 13);
            this.Locchi.TabIndex = 100;
            this.Locchi.Text = "occhi:";
            this.Locchi.Visible = false;
            // 
            // CBocchi
            // 
            this.CBocchi.AutoSize = true;
            this.CBocchi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBocchi.ForeColor = System.Drawing.Color.Black;
            this.CBocchi.Location = new System.Drawing.Point(910, 74);
            this.CBocchi.Name = "CBocchi";
            this.CBocchi.Size = new System.Drawing.Size(56, 17);
            this.CBocchi.TabIndex = 101;
            this.CBocchi.Text = "occhi";
            this.CBocchi.UseVisualStyleBackColor = true;
            this.CBocchi.Click += new System.EventHandler(this.CBocchi_Click);
            // 
            // Fsinglew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 552);
            this.Controls.Add(this.CBocchi);
            this.Controls.Add(this.Locchi);
            this.Controls.Add(this.Bazz);
            this.Controls.Add(this.Lmin);
            this.Controls.Add(this.Lmax);
            this.Controls.Add(this.CBth);
            this.Controls.Add(this.CBde);
            this.Controls.Add(this.CBbeta2);
            this.Controls.Add(this.CBbeta1);
            this.Controls.Add(this.CBalfa2);
            this.Controls.Add(this.CBalfa1);
            this.Controls.Add(this.CBgamma2);
            this.Controls.Add(this.CBmed);
            this.Controls.Add(this.CBgamma1);
            this.Controls.Add(this.CBatt);
            this.Controls.Add(this.Emax);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBraw);
            this.Controls.Add(this.Pini);
            this.Controls.Add(this.Lmed);
            this.Controls.Add(this.Lt);
            this.Controls.Add(this.Lb2);
            this.Controls.Add(this.Lg2);
            this.Controls.Add(this.La2);
            this.Controls.Add(this.Ld);
            this.Controls.Add(this.Lg1);
            this.Controls.Add(this.Lb1);
            this.Controls.Add(this.La1);
            this.Controls.Add(this.Latt);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Ltimer);
            this.Controls.Add(this.GBconn);
            this.Name = "Fsinglew";
            this.Text = "cerebrum - singola onda";
            this.Load += new System.EventHandler(this.Fsinglew_Load);
            this.Shown += new System.EventHandler(this.Fsinglew_Shown);
            this.GBconn.ResumeLayout(false);
            this.GBconn.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GBconn;
        private System.Windows.Forms.ComboBox cboPort;
        private System.Windows.Forms.Label Lporta;
        private System.Windows.Forms.Button Bdisatt;
        private System.Windows.Forms.Button Bconn;
        private System.Windows.Forms.Label Ltimer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox CBint;
        private System.Windows.Forms.Label Lint;
        private System.Windows.Forms.Label Lpoor;
        private System.Windows.Forms.Button Bclose;
        private System.Windows.Forms.Label Lmed;
        private System.Windows.Forms.Label Lt;
        private System.Windows.Forms.Label Lb2;
        private System.Windows.Forms.Label Lg2;
        private System.Windows.Forms.Label La2;
        private System.Windows.Forms.Label Ld;
        private System.Windows.Forms.Label Lg1;
        private System.Windows.Forms.Label Lb1;
        private System.Windows.Forms.Label La1;
        private System.Windows.Forms.Label Latt;
        private System.Windows.Forms.Panel Pini;
        private System.Windows.Forms.RadioButton CBraw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox Emax;
        private System.Windows.Forms.RadioButton CBatt;
        private System.Windows.Forms.RadioButton CBgamma1;
        private System.Windows.Forms.RadioButton CBmed;
        private System.Windows.Forms.RadioButton CBgamma2;
        private System.Windows.Forms.RadioButton CBalfa1;
        private System.Windows.Forms.RadioButton CBalfa2;
        private System.Windows.Forms.RadioButton CBbeta1;
        private System.Windows.Forms.RadioButton CBbeta2;
        private System.Windows.Forms.RadioButton CBde;
        private System.Windows.Forms.RadioButton CBth;
        private System.Windows.Forms.Label Lmax;
        private System.Windows.Forms.Label Lmin;
        private System.Windows.Forms.Button Bazz;
        private System.Windows.Forms.Label Locchi;
        private System.Windows.Forms.RadioButton CBocchi;
    }
}