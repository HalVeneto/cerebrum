namespace cerebrum
{
    partial class Fcsv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fcsv));
            this.flist = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.Bclose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Emax = new System.Windows.Forms.TextBox();
            this.CBragg = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // flist
            // 
            this.flist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.flist.FullRowSelect = true;
            this.flist.GridLines = true;
            this.flist.Location = new System.Drawing.Point(154, 28);
            this.flist.MultiSelect = false;
            this.flist.Name = "flist";
            this.flist.ShowGroups = false;
            this.flist.Size = new System.Drawing.Size(262, 311);
            this.flist.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.flist.TabIndex = 21;
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
            this.Bclose.Location = new System.Drawing.Point(12, 276);
            this.Bclose.Name = "Bclose";
            this.Bclose.Size = new System.Drawing.Size(75, 63);
            this.Bclose.TabIndex = 22;
            this.Bclose.Text = "chiudi";
            this.Bclose.UseVisualStyleBackColor = false;
            this.Bclose.Click += new System.EventHandler(this.Bclose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "scartare i valori al di sopra di (0=tieni tutto)";
            // 
            // Emax
            // 
            this.Emax.Location = new System.Drawing.Point(15, 29);
            this.Emax.Name = "Emax";
            this.Emax.Size = new System.Drawing.Size(100, 20);
            this.Emax.TabIndex = 24;
            this.Emax.Text = "0";
            // 
            // CBragg
            // 
            this.CBragg.AutoSize = true;
            this.CBragg.Location = new System.Drawing.Point(15, 78);
            this.CBragg.Name = "CBragg";
            this.CBragg.Size = new System.Drawing.Size(136, 17);
            this.CBragg.TabIndex = 25;
            this.CBragg.Text = "raggruppa per secondo";
            this.CBragg.UseVisualStyleBackColor = true;
            // 
            // Fcsv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 349);
            this.Controls.Add(this.CBragg);
            this.Controls.Add(this.Emax);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bclose);
            this.Controls.Add(this.flist);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Fcsv";
            this.Text = "cerebrum - esportazione in Excel/CSV";
            this.Load += new System.EventHandler(this.Fcsv_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView flist;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button Bclose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Emax;
        private System.Windows.Forms.CheckBox CBragg;
    }
}