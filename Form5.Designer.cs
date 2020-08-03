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
            ((System.ComponentModel.ISupportInitialize)(this.imm)).BeginInit();
            this.SuspendLayout();
            // 
            // imm
            // 
            this.imm.Image = global::cerebrum.Properties.Resources.csr_bp_breach2;
            this.imm.Location = new System.Drawing.Point(128, 110);
            this.imm.Name = "imm";
            this.imm.Size = new System.Drawing.Size(260, 195);
            this.imm.TabIndex = 0;
            this.imm.TabStop = false;
            // 
            // Fgamma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 427);
            this.Controls.Add(this.imm);
            this.Name = "Fgamma";
            this.Text = "cerebrum - attività con onde gamma";
            ((System.ComponentModel.ISupportInitialize)(this.imm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imm;
    }
}