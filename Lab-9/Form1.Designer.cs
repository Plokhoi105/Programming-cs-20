namespace lr9
{
    partial class Form1
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.X1min = new System.Windows.Forms.TextBox();
            this.X2min = new System.Windows.Forms.TextBox();
            this.X1max = new System.Windows.Forms.TextBox();
            this.X2max = new System.Windows.Forms.TextBox();
            this.dX1 = new System.Windows.Forms.TextBox();
            this.dX2 = new System.Windows.Forms.TextBox();
            this.gv = new System.Windows.Forms.DataGridView();
            this.Calc = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.summ = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "X1min";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "X2min";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "X1max";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(249, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "X2max";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(459, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "dX1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(459, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "dX2";
            // 
            // X1min
            // 
            this.X1min.Location = new System.Drawing.Point(91, 23);
            this.X1min.Name = "X1min";
            this.X1min.Size = new System.Drawing.Size(100, 22);
            this.X1min.TabIndex = 8;
            this.X1min.Text = "1";
            // 
            // X2min
            // 
            this.X2min.Location = new System.Drawing.Point(91, 57);
            this.X2min.Name = "X2min";
            this.X2min.Size = new System.Drawing.Size(100, 22);
            this.X2min.TabIndex = 9;
            this.X2min.Text = "-5";
            // 
            // X1max
            // 
            this.X1max.Location = new System.Drawing.Point(301, 23);
            this.X1max.Name = "X1max";
            this.X1max.Size = new System.Drawing.Size(100, 22);
            this.X1max.TabIndex = 10;
            this.X1max.Text = "12";
            // 
            // X2max
            // 
            this.X2max.Location = new System.Drawing.Point(301, 57);
            this.X2max.Name = "X2max";
            this.X2max.Size = new System.Drawing.Size(100, 22);
            this.X2max.TabIndex = 11;
            this.X2max.Text = "7";
            // 
            // dX1
            // 
            this.dX1.Location = new System.Drawing.Point(511, 23);
            this.dX1.Name = "dX1";
            this.dX1.Size = new System.Drawing.Size(100, 22);
            this.dX1.TabIndex = 12;
            this.dX1.Text = "0,7";
            // 
            // dX2
            // 
            this.dX2.Location = new System.Drawing.Point(511, 57);
            this.dX2.Name = "dX2";
            this.dX2.Size = new System.Drawing.Size(100, 22);
            this.dX2.TabIndex = 13;
            this.dX2.Text = "0,5";
            // 
            // gv
            // 
            this.gv.AllowUserToOrderColumns = true;
            this.gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv.Location = new System.Drawing.Point(12, 137);
            this.gv.Name = "gv";
            this.gv.RowHeadersWidth = 51;
            this.gv.RowTemplate.Height = 24;
            this.gv.Size = new System.Drawing.Size(615, 301);
            this.gv.TabIndex = 14;
            // 
            // Calc
            // 
            this.Calc.Location = new System.Drawing.Point(636, 28);
            this.Calc.Name = "Calc";
            this.Calc.Size = new System.Drawing.Size(79, 23);
            this.Calc.TabIndex = 15;
            this.Calc.Text = "Calculate";
            this.Calc.UseVisualStyleBackColor = true;
            this.Calc.Click += new System.EventHandler(this.Calc_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(636, 102);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(81, 23);
            this.Clear.TabIndex = 16;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(636, 415);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(81, 23);
            this.Exit.TabIndex = 17;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(373, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "sum of negative y\r\n";
            // 
            // summ
            // 
            this.summ.Location = new System.Drawing.Point(511, 91);
            this.summ.Name = "summ";
            this.summ.Size = new System.Drawing.Size(100, 22);
            this.summ.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 450);
            this.Controls.Add(this.summ);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Calc);
            this.Controls.Add(this.gv);
            this.Controls.Add(this.dX2);
            this.Controls.Add(this.dX1);
            this.Controls.Add(this.X2max);
            this.Controls.Add(this.X1max);
            this.Controls.Add(this.X2min);
            this.Controls.Add(this.X1min);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox X1min;
        private System.Windows.Forms.TextBox X2min;
        private System.Windows.Forms.TextBox X1max;
        private System.Windows.Forms.TextBox X2max;
        private System.Windows.Forms.TextBox dX1;
        private System.Windows.Forms.TextBox dX2;
        private System.Windows.Forms.DataGridView gv;
        private System.Windows.Forms.Button Calc;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox summ;
    }
}

