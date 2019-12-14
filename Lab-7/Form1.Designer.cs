namespace alex
{
    partial class Main
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bCount = new System.Windows.Forms.Button();
            this.bClear = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            this.X1 = new System.Windows.Forms.TextBox();
            this.X2 = new System.Windows.Forms.TextBox();
            this.Y = new System.Windows.Forms.TextBox();
            this.average = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "X1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "X2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Average";
            // 
            // bCount
            // 
            this.bCount.Location = new System.Drawing.Point(16, 172);
            this.bCount.Name = "bCount";
            this.bCount.Size = new System.Drawing.Size(75, 23);
            this.bCount.TabIndex = 4;
            this.bCount.Text = "Count";
            this.bCount.UseVisualStyleBackColor = true;
            this.bCount.Click += new System.EventHandler(this.bCount_Click);
            // 
            // bClear
            // 
            this.bClear.Location = new System.Drawing.Point(97, 172);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(75, 23);
            this.bClear.TabIndex = 5;
            this.bClear.Text = "Clear";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // bExit
            // 
            this.bExit.Location = new System.Drawing.Point(178, 172);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(75, 23);
            this.bExit.TabIndex = 6;
            this.bExit.Text = "Exit";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // X1
            // 
            this.X1.Location = new System.Drawing.Point(149, 23);
            this.X1.Name = "X1";
            this.X1.Size = new System.Drawing.Size(100, 22);
            this.X1.TabIndex = 7;
            // 
            // X2
            // 
            this.X2.Location = new System.Drawing.Point(149, 57);
            this.X2.Name = "X2";
            this.X2.Size = new System.Drawing.Size(100, 22);
            this.X2.TabIndex = 8;
            // 
            // Y
            // 
            this.Y.Location = new System.Drawing.Point(149, 91);
            this.Y.Name = "Y";
            this.Y.ReadOnly = true;
            this.Y.Size = new System.Drawing.Size(100, 22);
            this.Y.TabIndex = 9;
            // 
            // average
            // 
            this.average.Location = new System.Drawing.Point(149, 125);
            this.average.Name = "average";
            this.average.ReadOnly = true;
            this.average.Size = new System.Drawing.Size(100, 22);
            this.average.TabIndex = 10;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 213);
            this.Controls.Add(this.average);
            this.Controls.Add(this.Y);
            this.Controls.Add(this.X2);
            this.Controls.Add(this.X1);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.bCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "lr7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bCount;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.TextBox X1;
        private System.Windows.Forms.TextBox X2;
        private System.Windows.Forms.TextBox Y;
        private System.Windows.Forms.TextBox average;
    }
}

