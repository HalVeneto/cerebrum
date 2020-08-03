namespace cerebrum
{
    partial class Fgamma
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
            this.imm = new System.Windows.Forms.PictureBox();
            this.cboPort = new System.Windows.Forms.ComboBox();
            this.Lconn = new System.Windows.Forms.Label();
            this.Lgamma1 = new System.Windows.Forms.Label();
            this.Bclose = new System.Windows.Forms.Button();
            this.LlimitG2 = new System.Windows.Forms.Label();
            this.Lalfa1 = new System.Windows.Forms.Label();
            this.LlimitA1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imm)).BeginInit();
            this.SuspendLayout();
            // 
            // imm
            // 
            this.imm.Image = global::cerebrum.Properties.Resources.csr_bp_breach2;
            this.imm.Location = new System.Drawing.Point(135, 112);
            this.imm.Name = "imm";
            this.imm.Size = new System.Drawing.Size(256, 188);
            this.imm.TabIndex = 0;
            this.imm.TabStop = false;
            // 
            // cboPort
            // 
            this.cboPort.FormattingEnabled = true;
            this.cboPort.Location = new System.Drawing.Point(214, 48);
            this.cboPort.Name = "cboPort";
            this.cboPort.Size = new System.Drawing.Size(121, 21);
            this.cboPort.TabIndex = 8;
            this.cboPort.Visible = false;
            // 
            // Lconn
            // 
            this.Lconn.AutoSize = true;
            this.Lconn.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lconn.ForeColor = System.Drawing.Color.Red;
            this.Lconn.Location = new System.Drawing.Point(9, 11);
            this.Lconn.Name = "Lconn";
            this.Lconn.Size = new System.Drawing.Size(118, 16);
            this.Lconn.TabIndex = 9;
            this.Lconn.Text = "connessione in corso...";
            // 
            // Lgamma1
            // 
            this.Lgamma1.AutoSize = true;
            this.Lgamma1.Location = new System.Drawing.Point(12, 51);
            this.Lgamma1.Name = "Lgamma1";
            this.Lgamma1.Size = new System.Drawing.Size(50, 13);
            this.Lgamma1.TabIndex = 11;
            this.Lgamma1.Text = "gamma 2";
            // 
            // Bclose
            // 
            this.Bclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Bclose.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.Bclose.FlatAppearance.BorderSize = 3;
            this.Bclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bclose.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bclose.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Bclose.Location = new System.Drawing.Point(434, 11);
            this.Bclose.Name = "Bclose";
            this.Bclose.Size = new System.Drawing.Size(75, 63);
            this.Bclose.TabIndex = 18;
            this.Bclose.Text = "chiudi";
            this.Bclose.UseVisualStyleBackColor = false;
            this.Bclose.Click += new System.EventHandler(this.Bclose_Click);
            // 
            // LlimitG2
            // 
            this.LlimitG2.AutoSize = true;
            this.LlimitG2.Location = new System.Drawing.Point(12, 87);
            this.LlimitG2.Name = "LlimitG2";
            this.LlimitG2.Size = new System.Drawing.Size(50, 13);
            this.LlimitG2.TabIndex = 19;
            this.LlimitG2.Text = "gamma 2";
            // 
            // Lalfa1
            // 
            this.Lalfa1.AutoSize = true;
            this.Lalfa1.Location = new System.Drawing.Point(12, 38);
            this.Lalfa1.Name = "Lalfa1";
            this.Lalfa1.Size = new System.Drawing.Size(33, 13);
            this.Lalfa1.TabIndex = 20;
            this.Lalfa1.Text = "alfa 1";
            // 
            // LlimitA1
            // 
            this.LlimitA1.AutoSize = true;
            this.LlimitA1.Location = new System.Drawing.Point(12, 74);
            this.LlimitA1.Name = "LlimitA1";
            this.LlimitA1.Size = new System.Drawing.Size(33, 13);
            this.LlimitA1.TabIndex = 22;
            this.LlimitA1.Text = "alfa 1";
            // 
            // Fgamma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 427);
            this.Controls.Add(this.LlimitA1);
            this.Controls.Add(this.Lalfa1);
            this.Controls.Add(this.LlimitG2);
            this.Controls.Add(this.Bclose);
            this.Controls.Add(this.Lgamma1);
            this.Controls.Add(this.Lconn);
            this.Controls.Add(this.cboPort);
            this.Controls.Add(this.imm);
            this.Name = "Fgamma";
            this.Text = "cerebrum - attività con onde alfa e gamma";
            this.Load += new System.EventHandler(this.Fgamma_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Fgamma_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.imm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imm;
        private System.Windows.Forms.ComboBox cboPort;
        private System.Windows.Forms.Label Lconn;
        private System.Windows.Forms.Label Lgamma1;
        private System.Windows.Forms.Button Bclose;
        private System.Windows.Forms.Label LlimitG2;
        private System.Windows.Forms.Label Lalfa1;
        private System.Windows.Forms.Label LlimitA1;
    }
}