namespace cerebrum
{
    partial class Fdatireg
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
            this.vlist = new System.Windows.Forms.ListView();
            this.flist = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.Bclose = new System.Windows.Forms.Button();
            this.pb = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // vlist
            // 
            this.vlist.FullRowSelect = true;
            this.vlist.GridLines = true;
            this.vlist.Location = new System.Drawing.Point(12, 12);
            this.vlist.MultiSelect = false;
            this.vlist.Name = "vlist";
            this.vlist.ShowGroups = false;
            this.vlist.Size = new System.Drawing.Size(644, 388);
            this.vlist.TabIndex = 21;
            this.vlist.UseCompatibleStateImageBehavior = false;
            this.vlist.View = System.Windows.Forms.View.Details;
            // 
            // flist
            // 
            this.flist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.flist.FullRowSelect = true;
            this.flist.GridLines = true;
            this.flist.Location = new System.Drawing.Point(216, 59);
            this.flist.MultiSelect = false;
            this.flist.Name = "flist";
            this.flist.ShowGroups = false;
            this.flist.Size = new System.Drawing.Size(262, 296);
            this.flist.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.flist.TabIndex = 22;
            this.flist.UseCompatibleStateImageBehavior = false;
            this.flist.View = System.Windows.Forms.View.Details;
            this.flist.DoubleClick += new System.EventHandler(this.flist_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "nome file";
            this.columnHeader1.Width = 256;
            // 
            // Bclose
            // 
            this.Bclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Bclose.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.Bclose.FlatAppearance.BorderSize = 3;
            this.Bclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bclose.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bclose.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Bclose.Location = new System.Drawing.Point(662, 340);
            this.Bclose.Name = "Bclose";
            this.Bclose.Size = new System.Drawing.Size(75, 63);
            this.Bclose.TabIndex = 23;
            this.Bclose.Text = "chiudi";
            this.Bclose.UseVisualStyleBackColor = false;
            // 
            // pb
            // 
            this.pb.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pb.Location = new System.Drawing.Point(0, 401);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(746, 11);
            this.pb.TabIndex = 24;
            // 
            // Fdatireg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 412);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.Bclose);
            this.Controls.Add(this.flist);
            this.Controls.Add(this.vlist);
            this.Name = "Fdatireg";
            this.Text = "Fdatireg";
            this.Load += new System.EventHandler(this.Fdatireg_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView vlist;
        private System.Windows.Forms.ListView flist;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button Bclose;
        private System.Windows.Forms.ProgressBar pb;
    }
}