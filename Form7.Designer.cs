namespace cerebrum
{
    partial class Finfo
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
            this.rtf = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtf
            // 
            this.rtf.BackColor = System.Drawing.Color.PaleTurquoise;
            this.rtf.BulletIndent = 5;
            this.rtf.Cursor = System.Windows.Forms.Cursors.No;
            this.rtf.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtf.Location = new System.Drawing.Point(25, 93);
            this.rtf.Name = "rtf";
            this.rtf.ReadOnly = true;
            this.rtf.Size = new System.Drawing.Size(236, 86);
            this.rtf.TabIndex = 1;
            this.rtf.Text = "cerebrum 2012\nv. 1.0\nby ...\ncon supporto MindWave NeuroSky";
            this.rtf.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Finfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.rtf);
            this.Name = "Finfo";
            this.Opacity = 0.8;
            this.Text = "info";
            this.Load += new System.EventHandler(this.Finfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtf;
    }
}