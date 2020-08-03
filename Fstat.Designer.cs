namespace cerebrum
{
    partial class Fstat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fstat));
            this.Bclose = new System.Windows.Forms.Button();
            this.flist = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.vlist = new System.Windows.Forms.ListView();
            this.pb = new System.Windows.Forms.ProgressBar();
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
            this.Bclose.Location = new System.Drawing.Point(12, 245);
            this.Bclose.Name = "Bclose";
            this.Bclose.Size = new System.Drawing.Size(75, 63);
            this.Bclose.TabIndex = 18;
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
            this.flist.Location = new System.Drawing.Point(134, 12);
            this.flist.MultiSelect = false;
            this.flist.Name = "flist";
            this.flist.ShowGroups = false;
            this.flist.Size = new System.Drawing.Size(262, 296);
            this.flist.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.flist.TabIndex = 19;
            this.flist.UseCompatibleStateImageBehavior = false;
            this.flist.View = System.Windows.Forms.View.Details;
            this.flist.DoubleClick += new System.EventHandler(this.flist_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "nome file";
            this.columnHeader1.Width = 256;
            // 
            // vlist
            // 
            this.vlist.FullRowSelect = true;
            this.vlist.GridLines = true;
            this.vlist.Location = new System.Drawing.Point(93, 12);
            this.vlist.MultiSelect = false;
            this.vlist.Name = "vlist";
            this.vlist.ShowGroups = false;
            this.vlist.Size = new System.Drawing.Size(279, 296);
            this.vlist.TabIndex = 20;
            this.vlist.UseCompatibleStateImageBehavior = false;
            this.vlist.View = System.Windows.Forms.View.Details;
            // 
            // pb
            // 
            this.pb.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pb.Location = new System.Drawing.Point(0, 309);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(408, 11);
            this.pb.TabIndex = 21;
            // 
            // Fstat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 320);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.vlist);
            this.Controls.Add(this.flist);
            this.Controls.Add(this.Bclose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Fstat";
            this.Text = "cerebrum - statistiche e resoconti";
            this.Load += new System.EventHandler(this.Fstat_Load);
            this.Activated += new System.EventHandler(this.Fstat_Activated);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Bclose;
        private System.Windows.Forms.ListView flist;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView vlist;
        private System.Windows.Forms.ProgressBar pb;
    }
}