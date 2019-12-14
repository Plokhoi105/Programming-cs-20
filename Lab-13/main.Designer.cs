namespace lr8
{
    partial class main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.gv = new System.Windows.Forms.DataGridView();
            this.bsource = new System.Windows.Forms.BindingSource(this.components);
            this.ts = new System.Windows.Forms.ToolStrip();
            this.Add = new System.Windows.Forms.ToolStripButton();
            this.Edit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Save = new System.Windows.Forms.ToolStripButton();
            this.Saveasbinary = new System.Windows.Forms.ToolStripButton();
            this.Open = new System.Windows.Forms.ToolStripButton();
            this.Openfrombinary = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Del = new System.Windows.Forms.ToolStripButton();
            this.Clear = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Exit = new System.Windows.Forms.ToolStripButton();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsource)).BeginInit();
            this.ts.SuspendLayout();
            this.SuspendLayout();
            // 
            // gv
            // 
            this.gv.AllowUserToAddRows = false;
            this.gv.AllowUserToDeleteRows = false;
            this.gv.AutoGenerateColumns = false;
            this.gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv.DataSource = this.bsource;
            this.gv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv.Location = new System.Drawing.Point(0, 0);
            this.gv.Name = "gv";
            this.gv.ReadOnly = true;
            this.gv.RowHeadersWidth = 51;
            this.gv.RowTemplate.Height = 24;
            this.gv.Size = new System.Drawing.Size(607, 405);
            this.gv.TabIndex = 2;
            // 
            // ts
            // 
            this.ts.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add,
            this.Edit,
            this.toolStripSeparator1,
            this.Save,
            this.Saveasbinary,
            this.Open,
            this.Openfrombinary,
            this.toolStripSeparator3,
            this.Del,
            this.Clear,
            this.toolStripSeparator2,
            this.Exit});
            this.ts.Location = new System.Drawing.Point(0, 0);
            this.ts.Name = "ts";
            this.ts.Size = new System.Drawing.Size(607, 27);
            this.ts.TabIndex = 3;
            this.ts.Text = "toolStrip1";
            // 
            // Add
            // 
            this.Add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Add.Image = ((System.Drawing.Image)(resources.GetObject("Add.Image")));
            this.Add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(29, 24);
            this.Add.Text = "add data ";
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Edit
            // 
            this.Edit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(29, 24);
            this.Edit.Text = "edit ";
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // Save
            // 
            this.Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Save.Image = ((System.Drawing.Image)(resources.GetObject("Save.Image")));
            this.Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(29, 24);
            this.Save.Text = "toolStripButton1";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Saveasbinary
            // 
            this.Saveasbinary.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Saveasbinary.Image = ((System.Drawing.Image)(resources.GetObject("Saveasbinary.Image")));
            this.Saveasbinary.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Saveasbinary.Name = "Saveasbinary";
            this.Saveasbinary.Size = new System.Drawing.Size(29, 24);
            this.Saveasbinary.Text = "toolStripButton2";
            this.Saveasbinary.Click += new System.EventHandler(this.Saveasbinary_Click);
            // 
            // Open
            // 
            this.Open.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Open.Image = ((System.Drawing.Image)(resources.GetObject("Open.Image")));
            this.Open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(29, 24);
            this.Open.Text = "toolStripButton3";
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Openfrombinary
            // 
            this.Openfrombinary.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Openfrombinary.Image = ((System.Drawing.Image)(resources.GetObject("Openfrombinary.Image")));
            this.Openfrombinary.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Openfrombinary.Name = "Openfrombinary";
            this.Openfrombinary.Size = new System.Drawing.Size(29, 24);
            this.Openfrombinary.Text = "toolStripButton4";
            this.Openfrombinary.Click += new System.EventHandler(this.Openfrombinary_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // Del
            // 
            this.Del.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Del.Image = ((System.Drawing.Image)(resources.GetObject("Del.Image")));
            this.Del.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Del.Name = "Del";
            this.Del.Size = new System.Drawing.Size(29, 24);
            this.Del.Text = "delete";
            this.Del.Click += new System.EventHandler(this.Del_Click);
            // 
            // Clear
            // 
            this.Clear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Clear.Image = ((System.Drawing.Image)(resources.GetObject("Clear.Image")));
            this.Clear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(29, 24);
            this.Clear.Text = "delete all";
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // Exit
            // 
            this.Exit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(29, 24);
            this.Exit.Text = "exit";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 405);
            this.Controls.Add(this.ts);
            this.Controls.Add(this.gv);
            this.Name = "main";
            this.Text = "main";
            this.Load += new System.EventHandler(this.main_Load);
            this.Resize += new System.EventHandler(this.main_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsource)).EndInit();
            this.ts.ResumeLayout(false);
            this.ts.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gv;
        private System.Windows.Forms.ToolStrip ts;
        private System.Windows.Forms.ToolStripButton Add;
        private System.Windows.Forms.ToolStripButton Edit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton Del;
        private System.Windows.Forms.ToolStripButton Clear;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton Exit;
        private System.Windows.Forms.BindingSource bsource;
        private System.Windows.Forms.ToolStripButton Save;
        private System.Windows.Forms.ToolStripButton Saveasbinary;
        private System.Windows.Forms.ToolStripButton Open;
        private System.Windows.Forms.ToolStripButton Openfrombinary;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}