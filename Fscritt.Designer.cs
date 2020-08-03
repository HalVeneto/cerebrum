namespace cerebrum
{
    partial class Fscritt
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
            this.cboPort = new System.Windows.Forms.ComboBox();
            this.Lconn = new System.Windows.Forms.Label();
            this.Bclose = new System.Windows.Forms.Button();
            this.Lval = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lnr = new System.Windows.Forms.Label();
            this.Lbl = new System.Windows.Forms.Label();
            this.Lcorr = new System.Windows.Forms.Label();
            this.Lpack = new System.Windows.Forms.Label();
            this.pb = new System.Windows.Forms.ProgressBar();
            this.Lpoor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboPort
            // 
            this.cboPort.FormattingEnabled = true;
            this.cboPort.Location = new System.Drawing.Point(376, 239);
            this.cboPort.Name = "cboPort";
            this.cboPort.Size = new System.Drawing.Size(121, 21);
            this.cboPort.TabIndex = 9;
            this.cboPort.Visible = false;
            // 
            // Lconn
            // 
            this.Lconn.AutoSize = true;
            this.Lconn.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lconn.ForeColor = System.Drawing.Color.Red;
            this.Lconn.Location = new System.Drawing.Point(1, 0);
            this.Lconn.Name = "Lconn";
            this.Lconn.Size = new System.Drawing.Size(118, 16);
            this.Lconn.TabIndex = 10;
            this.Lconn.Text = "connessione in corso...";
            // 
            // Bclose
            // 
            this.Bclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Bclose.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.Bclose.FlatAppearance.BorderSize = 3;
            this.Bclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bclose.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bclose.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Bclose.Location = new System.Drawing.Point(12, 284);
            this.Bclose.Name = "Bclose";
            this.Bclose.Size = new System.Drawing.Size(75, 63);
            this.Bclose.TabIndex = 23;
            this.Bclose.Text = "chiudi";
            this.Bclose.UseVisualStyleBackColor = false;
            this.Bclose.Click += new System.EventHandler(this.Bclose_Click);
            // 
            // Lval
            // 
            this.Lval.AutoSize = true;
            this.Lval.Location = new System.Drawing.Point(536, 9);
            this.Lval.Name = "Lval";
            this.Lval.Size = new System.Drawing.Size(24, 13);
            this.Lval.TabIndex = 24;
            this.Lval.Text = "raw";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(4, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(611, 204);
            this.panel1.TabIndex = 25;
            // 
            // Lnr
            // 
            this.Lnr.AutoSize = true;
            this.Lnr.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lnr.ForeColor = System.Drawing.Color.Blue;
            this.Lnr.Location = new System.Drawing.Point(110, 289);
            this.Lnr.Name = "Lnr";
            this.Lnr.Size = new System.Drawing.Size(110, 44);
            this.Lnr.TabIndex = 26;
            this.Lnr.Text = "label1";
            // 
            // Lbl
            // 
            this.Lbl.AutoSize = true;
            this.Lbl.Location = new System.Drawing.Point(536, 22);
            this.Lbl.Name = "Lbl";
            this.Lbl.Size = new System.Drawing.Size(31, 13);
            this.Lbl.TabIndex = 27;
            this.Lbl.Text = "lblink";
            // 
            // Lcorr
            // 
            this.Lcorr.AutoSize = true;
            this.Lcorr.Location = new System.Drawing.Point(536, 46);
            this.Lcorr.Name = "Lcorr";
            this.Lcorr.Size = new System.Drawing.Size(31, 13);
            this.Lcorr.TabIndex = 28;
            this.Lcorr.Text = "Lcorr";
            this.Lcorr.Visible = false;
            // 
            // Lpack
            // 
            this.Lpack.AutoSize = true;
            this.Lpack.Location = new System.Drawing.Point(536, 58);
            this.Lpack.Name = "Lpack";
            this.Lpack.Size = new System.Drawing.Size(33, 13);
            this.Lpack.TabIndex = 29;
            this.Lpack.Text = "lpack";
            this.Lpack.Visible = false;
            // 
            // pb
            // 
            this.pb.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pb.Location = new System.Drawing.Point(0, 348);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(627, 11);
            this.pb.TabIndex = 30;
            // 
            // Lpoor
            // 
            this.Lpoor.AutoSize = true;
            this.Lpoor.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lpoor.ForeColor = System.Drawing.Color.Red;
            this.Lpoor.Location = new System.Drawing.Point(1, 19);
            this.Lpoor.Name = "Lpoor";
            this.Lpoor.Size = new System.Drawing.Size(46, 16);
            this.Lpoor.TabIndex = 31;
            this.Lpoor.Text = "segnale";
            // 
            // Fscritt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 359);
            this.Controls.Add(this.Lpoor);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.Lpack);
            this.Controls.Add(this.Lcorr);
            this.Controls.Add(this.Lbl);
            this.Controls.Add(this.Lnr);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Lval);
            this.Controls.Add(this.Bclose);
            this.Controls.Add(this.Lconn);
            this.Controls.Add(this.cboPort);
            this.Name = "Fscritt";
            this.Text = "scrittura mentale";
            this.Load += new System.EventHandler(this.Fscritt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboPort;
        private System.Windows.Forms.Label Lconn;
        private System.Windows.Forms.Button Bclose;
        private System.Windows.Forms.Label Lval;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lnr;
        private System.Windows.Forms.Label Lbl;
        private System.Windows.Forms.Label Lcorr;
        private System.Windows.Forms.Label Lpack;
        private System.Windows.Forms.ProgressBar pb;
        private System.Windows.Forms.Label Lpoor;

    }
}