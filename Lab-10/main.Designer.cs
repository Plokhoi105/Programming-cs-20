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
            this.Del = new System.Windows.Forms.ToolStripButton();
            this.Clear = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Exit = new System.Windows.Forms.ToolStripButton();
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
            // bsource
            // 
//            this.bsource.CurrentChanged += new System.EventHandler(this.bsource_CurrentChanged);
            // 
            // ts
            // 
            this.ts.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add,
            this.Edit,
            this.toolStripSeparator1,
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
    }
}