namespace cerebrum
{
    partial class Fsegnali
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fsegnali));
            this.GBconn = new System.Windows.Forms.GroupBox();
            this.cboPort = new System.Windows.Forms.ComboBox();
            this.Lporta = new System.Windows.Forms.Label();
            this.Bdisatt = new System.Windows.Forms.Button();
            this.Bconn = new System.Windows.Forms.Button();
            this.Ltimer = new System.Windows.Forms.Label();
            this.Lpoor = new System.Windows.Forms.Label();
            this.GBtarat = new System.Windows.Forms.GroupBox();
            this.Lmax = new System.Windows.Forms.Label();
            this.Lraw = new System.Windows.Forms.Label();
            this.Lraw_ = new System.Windows.Forms.Label();
            this.BfineTarat = new System.Windows.Forms.Button();
            this.Lmin = new System.Windows.Forms.Label();
            this.Lmax_ = new System.Windows.Forms.Label();
            this.Lmin_ = new System.Windows.Forms.Label();
            this.Btara = new System.Windows.Forms.Button();
            this.GBtest = new System.Windows.Forms.GroupBox();
            this.Lbl = new System.Windows.Forms.Label();
            this.Limm0 = new System.Windows.Forms.Label();
            this.imm3 = new System.Windows.Forms.PictureBox();
            this.imm2 = new System.Windows.Forms.PictureBox();
            this.imm0 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Lctr = new System.Windows.Forms.Label();
            this.Lsec = new System.Windows.Forms.Label();
            this.Bscritt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.imm1 = new System.Windows.Forms.PictureBox();
            this.GBconn.SuspendLayout();
            this.GBtarat.SuspendLayout();
            this.GBtest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imm3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imm2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imm0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imm1)).BeginInit();
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
            this.GBconn.Location = new System.Drawing.Point(12, 12);
            this.GBconn.Name = "GBconn";
            this.GBconn.Size = new System.Drawing.Size(416, 72);
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
            // Ltimer
            // 
            this.Ltimer.AutoSize = true;
            this.Ltimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ltimer.Location = new System.Drawing.Point(434, 46);
            this.Ltimer.Name = "Ltimer";
            this.Ltimer.Size = new System.Drawing.Size(64, 16);
            this.Ltimer.TabIndex = 58;
            this.Ltimer.Text = "00:00:00";
            // 
            // Lpoor
            // 
            this.Lpoor.AutoSize = true;
            this.Lpoor.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Lpoor.Location = new System.Drawing.Point(545, 22);
            this.Lpoor.Margin = new System.Windows.Forms.Padding(1, 0, 3, 0);
            this.Lpoor.Name = "Lpoor";
            this.Lpoor.Size = new System.Drawing.Size(44, 13);
            this.Lpoor.TabIndex = 59;
            this.Lpoor.Text = "segnale";
            // 
            // GBtarat
            // 
            this.GBtarat.Controls.Add(this.Lmax);
            this.GBtarat.Controls.Add(this.Lraw);
            this.GBtarat.Controls.Add(this.Lraw_);
            this.GBtarat.Controls.Add(this.BfineTarat);
            this.GBtarat.Controls.Add(this.Lmin);
            this.GBtarat.Controls.Add(this.Lmax_);
            this.GBtarat.Controls.Add(this.Lmin_);
            this.GBtarat.Controls.Add(this.Btara);
            this.GBtarat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBtarat.Location = new System.Drawing.Point(12, 90);
            this.GBtarat.Name = "GBtarat";
            this.GBtarat.Size = new System.Drawing.Size(222, 96);
            this.GBtarat.TabIndex = 60;
            this.GBtarat.TabStop = false;
            this.GBtarat.Text = "taratura";
            // 
            // Lmax
            // 
            this.Lmax.AutoSize = true;
            this.Lmax.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lmax.Location = new System.Drawing.Point(156, 45);
            this.Lmax.Name = "Lmax";
            this.Lmax.Size = new System.Drawing.Size(28, 14);
            this.Lmax.TabIndex = 73;
            this.Lmax.Text = "max";
            // 
            // Lraw
            // 
            this.Lraw.AutoSize = true;
            this.Lraw.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lraw.Location = new System.Drawing.Point(156, 31);
            this.Lraw.Name = "Lraw";
            this.Lraw.Size = new System.Drawing.Size(28, 14);
            this.Lraw.TabIndex = 72;
            this.Lraw.Text = "raw";
            // 
            // Lraw_
            // 
            this.Lraw_.AutoSize = true;
            this.Lraw_.Location = new System.Drawing.Point(94, 32);
            this.Lraw_.Name = "Lraw_";
            this.Lraw_.Size = new System.Drawing.Size(27, 13);
            this.Lraw_.TabIndex = 71;
            this.Lraw_.Text = "raw";
            // 
            // BfineTarat
            // 
            this.BfineTarat.Enabled = false;
            this.BfineTarat.Location = new System.Drawing.Point(6, 64);
            this.BfineTarat.Name = "BfineTarat";
            this.BfineTarat.Size = new System.Drawing.Size(199, 27);
            this.BfineTarat.TabIndex = 70;
            this.BfineTarat.Text = "passa al test";
            this.BfineTarat.UseVisualStyleBackColor = true;
            this.BfineTarat.Click += new System.EventHandler(this.BfineTarat_Click);
            // 
            // Lmin
            // 
            this.Lmin.AutoSize = true;
            this.Lmin.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lmin.Location = new System.Drawing.Point(156, 19);
            this.Lmin.Name = "Lmin";
            this.Lmin.Size = new System.Drawing.Size(49, 14);
            this.Lmin.TabIndex = 68;
            this.Lmin.Text = "minimo";
            // 
            // Lmax_
            // 
            this.Lmax_.AutoSize = true;
            this.Lmax_.Location = new System.Drawing.Point(94, 45);
            this.Lmax_.Name = "Lmax_";
            this.Lmax_.Size = new System.Drawing.Size(54, 13);
            this.Lmax_.TabIndex = 67;
            this.Lmax_.Text = "massimo";
            this.Lmax_.Click += new System.EventHandler(this.Lmax__Click);
            // 
            // Lmin_
            // 
            this.Lmin_.AutoSize = true;
            this.Lmin_.Location = new System.Drawing.Point(94, 19);
            this.Lmin_.Name = "Lmin_";
            this.Lmin_.Size = new System.Drawing.Size(45, 13);
            this.Lmin_.TabIndex = 66;
            this.Lmin_.Text = "minimo";
            // 
            // Btara
            // 
            this.Btara.Location = new System.Drawing.Point(6, 19);
            this.Btara.Name = "Btara";
            this.Btara.Size = new System.Drawing.Size(82, 39);
            this.Btara.TabIndex = 65;
            this.Btara.Text = "reset";
            this.Btara.UseVisualStyleBackColor = true;
            this.Btara.Click += new System.EventHandler(this.Btara_Click);
            // 
            // GBtest
            // 
            this.GBtest.Controls.Add(this.imm1);
            this.GBtest.Controls.Add(this.label4);
            this.GBtest.Controls.Add(this.Bscritt);
            this.GBtest.Controls.Add(this.Lbl);
            this.GBtest.Controls.Add(this.Limm0);
            this.GBtest.Controls.Add(this.imm3);
            this.GBtest.Controls.Add(this.imm2);
            this.GBtest.Controls.Add(this.imm0);
            this.GBtest.Controls.Add(this.label3);
            this.GBtest.Controls.Add(this.label2);
            this.GBtest.Controls.Add(this.label1);
            this.GBtest.Font = new System.Drawing.Font("Nina", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBtest.Location = new System.Drawing.Point(12, 187);
            this.GBtest.Name = "GBtest";
            this.GBtest.Size = new System.Drawing.Size(619, 134);
            this.GBtest.TabIndex = 61;
            this.GBtest.TabStop = false;
            this.GBtest.Text = "test";
            this.GBtest.Visible = false;
            // 
            // Lbl
            // 
            this.Lbl.AutoSize = true;
            this.Lbl.Location = new System.Drawing.Point(297, 113);
            this.Lbl.Name = "Lbl";
            this.Lbl.Size = new System.Drawing.Size(16, 13);
            this.Lbl.TabIndex = 7;
            this.Lbl.Text = "...";
            // 
            // Limm0
            // 
            this.Limm0.AutoSize = true;
            this.Limm0.Location = new System.Drawing.Point(7, 113);
            this.Limm0.Name = "Limm0";
            this.Limm0.Size = new System.Drawing.Size(16, 13);
            this.Limm0.TabIndex = 6;
            this.Limm0.Text = "...";
            // 
            // imm3
            // 
            this.imm3.Image = ((System.Drawing.Image)(resources.GetObject("imm3.Image")));
            this.imm3.Location = new System.Drawing.Point(407, 32);
            this.imm3.Name = "imm3";
            this.imm3.Size = new System.Drawing.Size(101, 78);
            this.imm3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imm3.TabIndex = 5;
            this.imm3.TabStop = false;
            this.imm3.Visible = false;
            // 
            // imm2
            // 
            this.imm2.Image = ((System.Drawing.Image)(resources.GetObject("imm2.Image")));
            this.imm2.Location = new System.Drawing.Point(300, 32);
            this.imm2.Name = "imm2";
            this.imm2.Size = new System.Drawing.Size(100, 78);
            this.imm2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imm2.TabIndex = 4;
            this.imm2.TabStop = false;
            this.imm2.Visible = false;
            // 
            // imm0
            // 
            this.imm0.Image = ((System.Drawing.Image)(resources.GetObject("imm0.Image")));
            this.imm0.Location = new System.Drawing.Point(10, 32);
            this.imm0.Name = "imm0";
            this.imm0.Size = new System.Drawing.Size(158, 78);
            this.imm0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imm0.TabIndex = 3;
            this.imm0.TabStop = false;
            this.imm0.Visible = false;
            this.imm0.Click += new System.EventHandler(this.Imm1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(422, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "3 blink (+100)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "2 blink (+100)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "corrugamento fronte  (+/-400)";
            // 
            // Lctr
            // 
            this.Lctr.AutoSize = true;
            this.Lctr.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Lctr.Location = new System.Drawing.Point(545, 46);
            this.Lctr.Margin = new System.Windows.Forms.Padding(1, 0, 3, 0);
            this.Lctr.Name = "Lctr";
            this.Lctr.Size = new System.Drawing.Size(46, 13);
            this.Lctr.TabIndex = 62;
            this.Lctr.Text = "ctrblinks";
            // 
            // Lsec
            // 
            this.Lsec.AutoSize = true;
            this.Lsec.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Lsec.Location = new System.Drawing.Point(545, 71);
            this.Lsec.Margin = new System.Windows.Forms.Padding(1, 0, 3, 0);
            this.Lsec.Name = "Lsec";
            this.Lsec.Size = new System.Drawing.Size(29, 13);
            this.Lsec.TabIndex = 64;
            this.Lsec.Text = "secs";
            // 
            // Bscritt
            // 
            this.Bscritt.Enabled = false;
            this.Bscritt.Location = new System.Drawing.Point(514, 32);
            this.Bscritt.Name = "Bscritt";
            this.Bscritt.Size = new System.Drawing.Size(99, 78);
            this.Bscritt.TabIndex = 71;
            this.Bscritt.Text = "passa alla scrittura";
            this.Bscritt.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 72;
            this.label4.Text = "1  blink (+100)";
            // 
            // imm1
            // 
            this.imm1.Image = ((System.Drawing.Image)(resources.GetObject("imm1.Image")));
            this.imm1.Location = new System.Drawing.Point(194, 32);
            this.imm1.Name = "imm1";
            this.imm1.Size = new System.Drawing.Size(100, 78);
            this.imm1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imm1.TabIndex = 73;
            this.imm1.TabStop = false;
            this.imm1.Visible = false;
            this.imm1.Click += new System.EventHandler(this.imm1_Click_1);
            // 
            // Fsegnali
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 415);
            this.Controls.Add(this.Lsec);
            this.Controls.Add(this.Lctr);
            this.Controls.Add(this.GBtest);
            this.Controls.Add(this.GBtarat);
            this.Controls.Add(this.Lpoor);
            this.Controls.Add(this.Ltimer);
            this.Controls.Add(this.GBconn);
            this.Name = "Fsegnali";
            this.Text = "cerebrum - identificazione segnali";
            this.Load += new System.EventHandler(this.Fsegnali_Load);
            this.GBconn.ResumeLayout(false);
            this.GBconn.PerformLayout();
            this.GBtarat.ResumeLayout(false);
            this.GBtarat.PerformLayout();
            this.GBtest.ResumeLayout(false);
            this.GBtest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imm3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imm2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imm0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imm1)).EndInit();
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
        private System.Windows.Forms.Label Lpoor;
        private System.Windows.Forms.GroupBox GBtarat;
        private System.Windows.Forms.Label Lraw;
        private System.Windows.Forms.Label Lraw_;
        private System.Windows.Forms.Button BfineTarat;
        private System.Windows.Forms.Label Lmin;
        private System.Windows.Forms.Label Lmax_;
        private System.Windows.Forms.Label Lmin_;
        private System.Windows.Forms.Button Btara;
        private System.Windows.Forms.Label Lmax;
        private System.Windows.Forms.GroupBox GBtest;
        private System.Windows.Forms.PictureBox imm0;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox imm2;
        private System.Windows.Forms.PictureBox imm3;
        private System.Windows.Forms.Label Limm0;
        private System.Windows.Forms.Label Lbl;
        private System.Windows.Forms.Label Lctr;
        private System.Windows.Forms.Label Lsec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Bscritt;
        private System.Windows.Forms.PictureBox imm1;
    }
}