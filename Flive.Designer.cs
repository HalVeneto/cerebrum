namespace cerebrum
{
    partial class Flive
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
            this.GBconn = new System.Windows.Forms.GroupBox();
            this.cboPort = new System.Windows.Forms.ComboBox();
            this.Lporta = new System.Windows.Forms.Label();
            this.Bdisatt = new System.Windows.Forms.Button();
            this.Bconn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CBint = new System.Windows.Forms.ComboBox();
            this.Lint = new System.Windows.Forms.Label();
            this.Lpoor = new System.Windows.Forms.Label();
            this.Pbeta = new System.Windows.Forms.Panel();
            this.Patt = new System.Windows.Forms.Panel();
            this.Palfa = new System.Windows.Forms.Panel();
            this.Pgamma = new System.Windows.Forms.Panel();
            this.Pdelta = new System.Windows.Forms.Panel();
            this.Latt = new System.Windows.Forms.Label();
            this.La1 = new System.Windows.Forms.Label();
            this.Lb1 = new System.Windows.Forms.Label();
            this.Lg1 = new System.Windows.Forms.Label();
            this.Ld = new System.Windows.Forms.Label();
            this.La2 = new System.Windows.Forms.Label();
            this.Lg2 = new System.Windows.Forms.Label();
            this.Lb2 = new System.Windows.Forms.Label();
            this.Lt = new System.Windows.Forms.Label();
            this.Lmed = new System.Windows.Forms.Label();
            this.EmaxDe = new System.Windows.Forms.TextBox();
            this.EmaxTh = new System.Windows.Forms.TextBox();
            this.LmaxDeTh = new System.Windows.Forms.Label();
            this.CBde = new System.Windows.Forms.CheckBox();
            this.CBth = new System.Windows.Forms.CheckBox();
            this.CBgamma1 = new System.Windows.Forms.CheckBox();
            this.CBgamma2 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EmaxG1 = new System.Windows.Forms.TextBox();
            this.EmaxG2 = new System.Windows.Forms.TextBox();
            this.Breg = new System.Windows.Forms.Button();
            this.CBbeta1 = new System.Windows.Forms.CheckBox();
            this.CBbeta2 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EmaxB1 = new System.Windows.Forms.TextBox();
            this.EmaxB2 = new System.Windows.Forms.TextBox();
            this.Ltimer = new System.Windows.Forms.Label();
            this.CBalfa1 = new System.Windows.Forms.CheckBox();
            this.CBalfa2 = new System.Windows.Forms.CheckBox();
            this.CBatt = new System.Windows.Forms.CheckBox();
            this.CBmed = new System.Windows.Forms.CheckBox();
            this.EmaxA1 = new System.Windows.Forms.TextBox();
            this.EmaxA2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Praw = new System.Windows.Forms.Panel();
            this.Lraw = new System.Windows.Forms.Label();
            this.GBconn.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Bclose
            // 
            this.Bclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Bclose.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.Bclose.FlatAppearance.BorderSize = 3;
            this.Bclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bclose.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bclose.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Bclose.Location = new System.Drawing.Point(1044, 12);
            this.Bclose.Name = "Bclose";
            this.Bclose.Size = new System.Drawing.Size(75, 63);
            this.Bclose.TabIndex = 17;
            this.Bclose.Text = "chiudi";
            this.Bclose.UseVisualStyleBackColor = false;
            this.Bclose.Click += new System.EventHandler(this.Bclose_Click);
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
            this.GBconn.Location = new System.Drawing.Point(3, 3);
            this.GBconn.Name = "GBconn";
            this.GBconn.Size = new System.Drawing.Size(416, 72);
            this.GBconn.TabIndex = 18;
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
            this.Bdisatt.Location = new System.Drawing.Point(318, 22);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.CBint);
            this.panel1.Controls.Add(this.Lint);
            this.panel1.Controls.Add(this.Lpoor);
            this.panel1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Location = new System.Drawing.Point(862, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(176, 63);
            this.panel1.TabIndex = 24;
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
            // Pbeta
            // 
            this.Pbeta.BackColor = System.Drawing.Color.DarkTurquoise;
            this.Pbeta.Location = new System.Drawing.Point(3, 281);
            this.Pbeta.Name = "Pbeta";
            this.Pbeta.Size = new System.Drawing.Size(1116, 3);
            this.Pbeta.TabIndex = 27;
            // 
            // Patt
            // 
            this.Patt.BackColor = System.Drawing.Color.DarkTurquoise;
            this.Patt.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.Patt.Location = new System.Drawing.Point(3, 81);
            this.Patt.Name = "Patt";
            this.Patt.Size = new System.Drawing.Size(1116, 3);
            this.Patt.TabIndex = 25;
            // 
            // Palfa
            // 
            this.Palfa.BackColor = System.Drawing.Color.DarkTurquoise;
            this.Palfa.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Palfa.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.Palfa.Location = new System.Drawing.Point(7, 181);
            this.Palfa.Name = "Palfa";
            this.Palfa.Size = new System.Drawing.Size(1116, 3);
            this.Palfa.TabIndex = 28;
            // 
            // Pgamma
            // 
            this.Pgamma.BackColor = System.Drawing.Color.DarkTurquoise;
            this.Pgamma.Location = new System.Drawing.Point(7, 381);
            this.Pgamma.Name = "Pgamma";
            this.Pgamma.Size = new System.Drawing.Size(1116, 3);
            this.Pgamma.TabIndex = 29;
            // 
            // Pdelta
            // 
            this.Pdelta.BackColor = System.Drawing.Color.DarkTurquoise;
            this.Pdelta.Location = new System.Drawing.Point(7, 481);
            this.Pdelta.Name = "Pdelta";
            this.Pdelta.Size = new System.Drawing.Size(1116, 3);
            this.Pdelta.TabIndex = 30;
            // 
            // Latt
            // 
            this.Latt.AutoSize = true;
            this.Latt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Latt.ForeColor = System.Drawing.Color.Red;
            this.Latt.Location = new System.Drawing.Point(27, 90);
            this.Latt.Name = "Latt";
            this.Latt.Size = new System.Drawing.Size(66, 13);
            this.Latt.TabIndex = 31;
            this.Latt.Text = "attenzione";
            // 
            // La1
            // 
            this.La1.AutoSize = true;
            this.La1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.La1.ForeColor = System.Drawing.Color.DarkGreen;
            this.La1.Location = new System.Drawing.Point(27, 186);
            this.La1.Name = "La1";
            this.La1.Size = new System.Drawing.Size(39, 13);
            this.La1.TabIndex = 32;
            this.La1.Text = "alfa 1";
            // 
            // Lb1
            // 
            this.Lb1.AutoSize = true;
            this.Lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb1.ForeColor = System.Drawing.Color.Purple;
            this.Lb1.Location = new System.Drawing.Point(28, 286);
            this.Lb1.Name = "Lb1";
            this.Lb1.Size = new System.Drawing.Size(43, 13);
            this.Lb1.TabIndex = 33;
            this.Lb1.Text = "beta 1";
            // 
            // Lg1
            // 
            this.Lg1.AutoSize = true;
            this.Lg1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lg1.ForeColor = System.Drawing.Color.Cyan;
            this.Lg1.Location = new System.Drawing.Point(27, 386);
            this.Lg1.Name = "Lg1";
            this.Lg1.Size = new System.Drawing.Size(57, 13);
            this.Lg1.TabIndex = 34;
            this.Lg1.Text = "gamma 1";
            // 
            // Ld
            // 
            this.Ld.AutoSize = true;
            this.Ld.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ld.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.Ld.Location = new System.Drawing.Point(28, 486);
            this.Ld.Name = "Ld";
            this.Ld.Size = new System.Drawing.Size(35, 13);
            this.Ld.TabIndex = 35;
            this.Ld.Text = "delta";
            // 
            // La2
            // 
            this.La2.AutoSize = true;
            this.La2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.La2.ForeColor = System.Drawing.Color.LightGreen;
            this.La2.Location = new System.Drawing.Point(27, 199);
            this.La2.Name = "La2";
            this.La2.Size = new System.Drawing.Size(39, 13);
            this.La2.TabIndex = 36;
            this.La2.Text = "alfa 2";
            // 
            // Lg2
            // 
            this.Lg2.AutoSize = true;
            this.Lg2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lg2.ForeColor = System.Drawing.Color.DarkBlue;
            this.Lg2.Location = new System.Drawing.Point(28, 399);
            this.Lg2.Name = "Lg2";
            this.Lg2.Size = new System.Drawing.Size(57, 13);
            this.Lg2.TabIndex = 37;
            this.Lg2.Text = "gamma 2";
            // 
            // Lb2
            // 
            this.Lb2.AutoSize = true;
            this.Lb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb2.ForeColor = System.Drawing.Color.Violet;
            this.Lb2.Location = new System.Drawing.Point(28, 299);
            this.Lb2.Name = "Lb2";
            this.Lb2.Size = new System.Drawing.Size(43, 13);
            this.Lb2.TabIndex = 38;
            this.Lb2.Text = "beta 2";
            // 
            // Lt
            // 
            this.Lt.AutoSize = true;
            this.Lt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lt.ForeColor = System.Drawing.Color.Gold;
            this.Lt.Location = new System.Drawing.Point(27, 499);
            this.Lt.Name = "Lt";
            this.Lt.Size = new System.Drawing.Size(36, 13);
            this.Lt.TabIndex = 39;
            this.Lt.Text = "theta";
            // 
            // Lmed
            // 
            this.Lmed.AutoSize = true;
            this.Lmed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lmed.ForeColor = System.Drawing.Color.Fuchsia;
            this.Lmed.Location = new System.Drawing.Point(27, 104);
            this.Lmed.Name = "Lmed";
            this.Lmed.Size = new System.Drawing.Size(74, 13);
            this.Lmed.TabIndex = 40;
            this.Lmed.Text = "meditazione";
            // 
            // EmaxDe
            // 
            this.EmaxDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmaxDe.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.EmaxDe.Location = new System.Drawing.Point(7, 528);
            this.EmaxDe.Name = "EmaxDe";
            this.EmaxDe.Size = new System.Drawing.Size(56, 20);
            this.EmaxDe.TabIndex = 41;
            this.EmaxDe.Text = "3725000";
            this.EmaxDe.Leave += new System.EventHandler(this.EmaxDe_Leave);
            // 
            // EmaxTh
            // 
            this.EmaxTh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmaxTh.ForeColor = System.Drawing.Color.Gold;
            this.EmaxTh.Location = new System.Drawing.Point(7, 554);
            this.EmaxTh.Name = "EmaxTh";
            this.EmaxTh.Size = new System.Drawing.Size(56, 20);
            this.EmaxTh.TabIndex = 42;
            this.EmaxTh.Text = "1750000";
            this.EmaxTh.Leave += new System.EventHandler(this.EmaxTh_Leave);
            // 
            // LmaxDeTh
            // 
            this.LmaxDeTh.AutoSize = true;
            this.LmaxDeTh.Location = new System.Drawing.Point(6, 512);
            this.LmaxDeTh.Name = "LmaxDeTh";
            this.LmaxDeTh.Size = new System.Drawing.Size(29, 13);
            this.LmaxDeTh.TabIndex = 43;
            this.LmaxDeTh.Text = "max:";
            // 
            // CBde
            // 
            this.CBde.AutoSize = true;
            this.CBde.Checked = true;
            this.CBde.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBde.Location = new System.Drawing.Point(6, 485);
            this.CBde.Name = "CBde";
            this.CBde.Size = new System.Drawing.Size(15, 14);
            this.CBde.TabIndex = 44;
            this.CBde.UseVisualStyleBackColor = true;
            // 
            // CBth
            // 
            this.CBth.AutoSize = true;
            this.CBth.Checked = true;
            this.CBth.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBth.Location = new System.Drawing.Point(6, 499);
            this.CBth.Name = "CBth";
            this.CBth.Size = new System.Drawing.Size(15, 14);
            this.CBth.TabIndex = 45;
            this.CBth.UseVisualStyleBackColor = true;
            // 
            // CBgamma1
            // 
            this.CBgamma1.AutoSize = true;
            this.CBgamma1.Checked = true;
            this.CBgamma1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBgamma1.Location = new System.Drawing.Point(7, 386);
            this.CBgamma1.Name = "CBgamma1";
            this.CBgamma1.Size = new System.Drawing.Size(15, 14);
            this.CBgamma1.TabIndex = 46;
            this.CBgamma1.UseVisualStyleBackColor = true;
            // 
            // CBgamma2
            // 
            this.CBgamma2.AutoSize = true;
            this.CBgamma2.Checked = true;
            this.CBgamma2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBgamma2.Location = new System.Drawing.Point(7, 399);
            this.CBgamma2.Name = "CBgamma2";
            this.CBgamma2.Size = new System.Drawing.Size(15, 14);
            this.CBgamma2.TabIndex = 47;
            this.CBgamma2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 416);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "max:";
            // 
            // EmaxG1
            // 
            this.EmaxG1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmaxG1.ForeColor = System.Drawing.Color.Cyan;
            this.EmaxG1.Location = new System.Drawing.Point(6, 432);
            this.EmaxG1.Name = "EmaxG1";
            this.EmaxG1.Size = new System.Drawing.Size(56, 20);
            this.EmaxG1.TabIndex = 49;
            this.EmaxG1.Text = "154000";
            this.EmaxG1.Leave += new System.EventHandler(this.EmaxG1_Leave);
            // 
            // EmaxG2
            // 
            this.EmaxG2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmaxG2.ForeColor = System.Drawing.Color.Blue;
            this.EmaxG2.Location = new System.Drawing.Point(6, 455);
            this.EmaxG2.Name = "EmaxG2";
            this.EmaxG2.Size = new System.Drawing.Size(56, 20);
            this.EmaxG2.TabIndex = 50;
            this.EmaxG2.Text = "830000";
            this.EmaxG2.Leave += new System.EventHandler(this.EmaxG2_Leave);
            // 
            // Breg
            // 
            this.Breg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Breg.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.Breg.FlatAppearance.BorderSize = 3;
            this.Breg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Breg.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Breg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Breg.Location = new System.Drawing.Point(745, 12);
            this.Breg.Name = "Breg";
            this.Breg.Size = new System.Drawing.Size(111, 63);
            this.Breg.TabIndex = 51;
            this.Breg.Text = "attiva registrazione";
            this.Breg.UseVisualStyleBackColor = false;
            this.Breg.Click += new System.EventHandler(this.Breg_Click);
            // 
            // CBbeta1
            // 
            this.CBbeta1.AutoSize = true;
            this.CBbeta1.Checked = true;
            this.CBbeta1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBbeta1.Location = new System.Drawing.Point(6, 286);
            this.CBbeta1.Name = "CBbeta1";
            this.CBbeta1.Size = new System.Drawing.Size(15, 14);
            this.CBbeta1.TabIndex = 52;
            this.CBbeta1.UseVisualStyleBackColor = true;
            // 
            // CBbeta2
            // 
            this.CBbeta2.AutoSize = true;
            this.CBbeta2.Checked = true;
            this.CBbeta2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBbeta2.Location = new System.Drawing.Point(6, 299);
            this.CBbeta2.Name = "CBbeta2";
            this.CBbeta2.Size = new System.Drawing.Size(15, 14);
            this.CBbeta2.TabIndex = 53;
            this.CBbeta2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "max:";
            // 
            // EmaxB1
            // 
            this.EmaxB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmaxB1.ForeColor = System.Drawing.Color.Purple;
            this.EmaxB1.Location = new System.Drawing.Point(7, 332);
            this.EmaxB1.Name = "EmaxB1";
            this.EmaxB1.Size = new System.Drawing.Size(56, 20);
            this.EmaxB1.TabIndex = 55;
            this.EmaxB1.Text = "419000";
            this.EmaxB1.Leave += new System.EventHandler(this.EmaxB1_Leave);
            // 
            // EmaxB2
            // 
            this.EmaxB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmaxB2.ForeColor = System.Drawing.Color.Violet;
            this.EmaxB2.Location = new System.Drawing.Point(7, 355);
            this.EmaxB2.Name = "EmaxB2";
            this.EmaxB2.Size = new System.Drawing.Size(56, 20);
            this.EmaxB2.TabIndex = 56;
            this.EmaxB2.Text = "373000";
            this.EmaxB2.Leave += new System.EventHandler(this.EmaxB2_Leave);
            // 
            // Ltimer
            // 
            this.Ltimer.AutoSize = true;
            this.Ltimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ltimer.Location = new System.Drawing.Point(638, 35);
            this.Ltimer.Name = "Ltimer";
            this.Ltimer.Size = new System.Drawing.Size(64, 16);
            this.Ltimer.TabIndex = 57;
            this.Ltimer.Text = "00:00:00";
            // 
            // CBalfa1
            // 
            this.CBalfa1.AutoSize = true;
            this.CBalfa1.Checked = true;
            this.CBalfa1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBalfa1.Location = new System.Drawing.Point(6, 186);
            this.CBalfa1.Name = "CBalfa1";
            this.CBalfa1.Size = new System.Drawing.Size(15, 14);
            this.CBalfa1.TabIndex = 58;
            this.CBalfa1.UseVisualStyleBackColor = true;
            // 
            // CBalfa2
            // 
            this.CBalfa2.AutoSize = true;
            this.CBalfa2.Checked = true;
            this.CBalfa2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBalfa2.Location = new System.Drawing.Point(6, 199);
            this.CBalfa2.Name = "CBalfa2";
            this.CBalfa2.Size = new System.Drawing.Size(15, 14);
            this.CBalfa2.TabIndex = 59;
            this.CBalfa2.UseVisualStyleBackColor = true;
            // 
            // CBatt
            // 
            this.CBatt.AutoSize = true;
            this.CBatt.Checked = true;
            this.CBatt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBatt.Location = new System.Drawing.Point(6, 90);
            this.CBatt.Name = "CBatt";
            this.CBatt.Size = new System.Drawing.Size(15, 14);
            this.CBatt.TabIndex = 60;
            this.CBatt.UseVisualStyleBackColor = true;
            // 
            // CBmed
            // 
            this.CBmed.AutoSize = true;
            this.CBmed.Checked = true;
            this.CBmed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBmed.Location = new System.Drawing.Point(6, 104);
            this.CBmed.Name = "CBmed";
            this.CBmed.Size = new System.Drawing.Size(15, 14);
            this.CBmed.TabIndex = 61;
            this.CBmed.UseVisualStyleBackColor = true;
            // 
            // EmaxA1
            // 
            this.EmaxA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmaxA1.ForeColor = System.Drawing.Color.DarkGreen;
            this.EmaxA1.Location = new System.Drawing.Point(6, 233);
            this.EmaxA1.Name = "EmaxA1";
            this.EmaxA1.Size = new System.Drawing.Size(56, 20);
            this.EmaxA1.TabIndex = 62;
            // 
            // EmaxA2
            // 
            this.EmaxA2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmaxA2.ForeColor = System.Drawing.Color.LightGreen;
            this.EmaxA2.Location = new System.Drawing.Point(6, 255);
            this.EmaxA2.Name = "EmaxA2";
            this.EmaxA2.Size = new System.Drawing.Size(56, 20);
            this.EmaxA2.TabIndex = 63;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 64;
            this.label3.Text = "max:";
            // 
            // Praw
            // 
            this.Praw.BackColor = System.Drawing.Color.DarkTurquoise;
            this.Praw.Location = new System.Drawing.Point(7, 581);
            this.Praw.Name = "Praw";
            this.Praw.Size = new System.Drawing.Size(1116, 3);
            this.Praw.TabIndex = 65;
            // 
            // Lraw
            // 
            this.Lraw.AutoSize = true;
            this.Lraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lraw.ForeColor = System.Drawing.Color.Red;
            this.Lraw.Location = new System.Drawing.Point(6, 587);
            this.Lraw.Name = "Lraw";
            this.Lraw.Size = new System.Drawing.Size(27, 13);
            this.Lraw.TabIndex = 66;
            this.Lraw.Text = "raw";
            // 
            // Flive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1131, 686);
            this.Controls.Add(this.Lraw);
            this.Controls.Add(this.Praw);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EmaxA2);
            this.Controls.Add(this.EmaxA1);
            this.Controls.Add(this.CBmed);
            this.Controls.Add(this.CBatt);
            this.Controls.Add(this.CBalfa2);
            this.Controls.Add(this.CBalfa1);
            this.Controls.Add(this.Ltimer);
            this.Controls.Add(this.EmaxB2);
            this.Controls.Add(this.EmaxB1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CBbeta2);
            this.Controls.Add(this.CBbeta1);
            this.Controls.Add(this.Breg);
            this.Controls.Add(this.EmaxG2);
            this.Controls.Add(this.EmaxG1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBgamma2);
            this.Controls.Add(this.CBgamma1);
            this.Controls.Add(this.CBth);
            this.Controls.Add(this.CBde);
            this.Controls.Add(this.LmaxDeTh);
            this.Controls.Add(this.EmaxTh);
            this.Controls.Add(this.EmaxDe);
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
            this.Controls.Add(this.Pdelta);
            this.Controls.Add(this.Pgamma);
            this.Controls.Add(this.Palfa);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GBconn);
            this.Controls.Add(this.Bclose);
            this.Controls.Add(this.Patt);
            this.Controls.Add(this.Pbeta);
            this.Name = "Flive";
            this.Text = "cerebrum - rappresentazione grafica \"live\"";
            this.Load += new System.EventHandler(this.Flive_Load);
            this.GBconn.ResumeLayout(false);
            this.GBconn.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bclose;
        private System.Windows.Forms.GroupBox GBconn;
        private System.Windows.Forms.ComboBox cboPort;
        private System.Windows.Forms.Label Lporta;
        private System.Windows.Forms.Button Bdisatt;
        private System.Windows.Forms.Button Bconn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox CBint;
        private System.Windows.Forms.Label Lint;
        private System.Windows.Forms.Label Lpoor;
        private System.Windows.Forms.Panel Pbeta;
        private System.Windows.Forms.Panel Patt;
        private System.Windows.Forms.Panel Palfa;
        private System.Windows.Forms.Panel Pgamma;
        private System.Windows.Forms.Panel Pdelta;
        private System.Windows.Forms.Label Latt;
        private System.Windows.Forms.Label La1;
        private System.Windows.Forms.Label Lb1;
        private System.Windows.Forms.Label Lg1;
        private System.Windows.Forms.Label Ld;
        private System.Windows.Forms.Label La2;
        private System.Windows.Forms.Label Lg2;
        private System.Windows.Forms.Label Lb2;
        private System.Windows.Forms.Label Lt;
        private System.Windows.Forms.Label Lmed;
        private System.Windows.Forms.TextBox EmaxDe;
        private System.Windows.Forms.TextBox EmaxTh;
        private System.Windows.Forms.Label LmaxDeTh;
        private System.Windows.Forms.CheckBox CBde;
        private System.Windows.Forms.CheckBox CBth;
        private System.Windows.Forms.CheckBox CBgamma1;
        private System.Windows.Forms.CheckBox CBgamma2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EmaxG1;
        private System.Windows.Forms.TextBox EmaxG2;
        private System.Windows.Forms.Button Breg;
        private System.Windows.Forms.CheckBox CBbeta1;
        private System.Windows.Forms.CheckBox CBbeta2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EmaxB1;
        private System.Windows.Forms.TextBox EmaxB2;
        private System.Windows.Forms.Label Ltimer;
        private System.Windows.Forms.CheckBox CBalfa1;
        private System.Windows.Forms.CheckBox CBalfa2;
        private System.Windows.Forms.CheckBox CBatt;
        private System.Windows.Forms.CheckBox CBmed;
        private System.Windows.Forms.TextBox EmaxA1;
        private System.Windows.Forms.TextBox EmaxA2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel Praw;
        private System.Windows.Forms.Label Lraw;
    }
}