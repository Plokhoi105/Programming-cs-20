namespace lr11
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
            this.pMain = new System.Windows.Forms.Panel();
            this.pTools = new System.Windows.Forms.Panel();
            this.cbFigureType = new System.Windows.Forms.ComboBox();
            this.bDownFar = new System.Windows.Forms.Button();
            this.bUpFar = new System.Windows.Forms.Button();
            this.bUp = new System.Windows.Forms.Button();
            this.bCollapse = new System.Windows.Forms.Button();
            this.bLeftFar = new System.Windows.Forms.Button();
            this.bRight = new System.Windows.Forms.Button();
            this.bLeft = new System.Windows.Forms.Button();
            this.bRightFar = new System.Windows.Forms.Button();
            this.bDown = new System.Windows.Forms.Button();
            this.bExpand = new System.Windows.Forms.Button();
            this.bShow = new System.Windows.Forms.Button();
            this.bHide = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.cbfigures = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // pMain
            // 
            this.pMain.BackColor = System.Drawing.SystemColors.Window;
            this.pMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pMain.Location = new System.Drawing.Point(12, 12);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(450, 450);
            this.pMain.TabIndex = 0;
            // 
            // pTools
            // 
            this.pTools.Controls.Add(this.cbFigureType);
            this.pTools.Controls.Add(this.bDownFar);
            this.pTools.Controls.Add(this.bUpFar);
            this.pTools.Controls.Add(this.bUp);
            this.pTools.Controls.Add(this.bCollapse);
            this.pTools.Controls.Add(this.bLeftFar);
            this.pTools.Controls.Add(this.bRight);
            this.pTools.Controls.Add(this.bLeft);
            this.pTools.Controls.Add(this.bRightFar);
            this.pTools.Controls.Add(this.bDown);
            this.pTools.Controls.Add(this.bExpand);
            this.pTools.Controls.Add(this.bShow);
            this.pTools.Controls.Add(this.bHide);
            this.pTools.Controls.Add(this.bAdd);
            this.pTools.Controls.Add(this.cbfigures);
            this.pTools.Controls.Add(this.label1);
            this.pTools.Location = new System.Drawing.Point(468, 14);
            this.pTools.Name = "pTools";
            this.pTools.Size = new System.Drawing.Size(244, 448);
            this.pTools.TabIndex = 0;
            // 
            // cbFigureType
            // 
            this.cbFigureType.FormattingEnabled = true;
            this.cbFigureType.Items.AddRange(new object[] {
            "emblem"});
            this.cbFigureType.Location = new System.Drawing.Point(120, 116);
            this.cbFigureType.Name = "cbFigureType";
            this.cbFigureType.Size = new System.Drawing.Size(88, 24);
            this.cbFigureType.TabIndex = 15;
            // 
            // bDownFar
            // 
            this.bDownFar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDownFar.Location = new System.Drawing.Point(105, 397);
            this.bDownFar.Name = "bDownFar";
            this.bDownFar.Size = new System.Drawing.Size(30, 30);
            this.bDownFar.TabIndex = 14;
            this.bDownFar.Text = "↡";
            this.bDownFar.UseVisualStyleBackColor = true;
            this.bDownFar.Click += new System.EventHandler(this.bDownFar_Click);
            // 
            // bUpFar
            // 
            this.bUpFar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bUpFar.Location = new System.Drawing.Point(105, 217);
            this.bUpFar.Name = "bUpFar";
            this.bUpFar.Size = new System.Drawing.Size(30, 30);
            this.bUpFar.TabIndex = 13;
            this.bUpFar.Text = "↟";
            this.bUpFar.UseVisualStyleBackColor = true;
            this.bUpFar.Click += new System.EventHandler(this.bUpFar_Click);
            // 
            // bUp
            // 
            this.bUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bUp.Location = new System.Drawing.Point(105, 253);
            this.bUp.Name = "bUp";
            this.bUp.Size = new System.Drawing.Size(30, 30);
            this.bUp.TabIndex = 12;
            this.bUp.Text = "↑";
            this.bUp.UseVisualStyleBackColor = true;
            this.bUp.Click += new System.EventHandler(this.bUp_Click);
            // 
            // bCollapse
            // 
            this.bCollapse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCollapse.Location = new System.Drawing.Point(90, 325);
            this.bCollapse.Name = "bCollapse";
            this.bCollapse.Size = new System.Drawing.Size(60, 30);
            this.bCollapse.TabIndex = 11;
            this.bCollapse.Text = "-";
            this.bCollapse.UseVisualStyleBackColor = true;
            this.bCollapse.Click += new System.EventHandler(this.bCollapse_Click);
            // 
            // bLeftFar
            // 
            this.bLeftFar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLeftFar.Location = new System.Drawing.Point(18, 309);
            this.bLeftFar.Name = "bLeftFar";
            this.bLeftFar.Size = new System.Drawing.Size(30, 30);
            this.bLeftFar.TabIndex = 10;
            this.bLeftFar.Text = "↞";
            this.bLeftFar.UseVisualStyleBackColor = true;
            this.bLeftFar.Click += new System.EventHandler(this.bLeftFar_Click);
            // 
            // bRight
            // 
            this.bRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRight.Location = new System.Drawing.Point(156, 309);
            this.bRight.Name = "bRight";
            this.bRight.Size = new System.Drawing.Size(30, 30);
            this.bRight.TabIndex = 9;
            this.bRight.Text = "→";
            this.bRight.UseVisualStyleBackColor = true;
            this.bRight.Click += new System.EventHandler(this.bRight_Click);
            // 
            // bLeft
            // 
            this.bLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLeft.Location = new System.Drawing.Point(54, 309);
            this.bLeft.Name = "bLeft";
            this.bLeft.Size = new System.Drawing.Size(30, 30);
            this.bLeft.TabIndex = 8;
            this.bLeft.Text = "←";
            this.bLeft.UseVisualStyleBackColor = true;
            this.bLeft.Click += new System.EventHandler(this.bLeft_Click);
            // 
            // bRightFar
            // 
            this.bRightFar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRightFar.Location = new System.Drawing.Point(192, 309);
            this.bRightFar.Name = "bRightFar";
            this.bRightFar.Size = new System.Drawing.Size(30, 30);
            this.bRightFar.TabIndex = 7;
            this.bRightFar.Text = "↠";
            this.bRightFar.UseVisualStyleBackColor = true;
            this.bRightFar.Click += new System.EventHandler(this.bRightFar_Click);
            // 
            // bDown
            // 
            this.bDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDown.Location = new System.Drawing.Point(105, 361);
            this.bDown.Name = "bDown";
            this.bDown.Size = new System.Drawing.Size(30, 30);
            this.bDown.TabIndex = 6;
            this.bDown.Text = "↓";
            this.bDown.UseVisualStyleBackColor = true;
            this.bDown.Click += new System.EventHandler(this.bDown_Click);
            // 
            // bExpand
            // 
            this.bExpand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bExpand.Location = new System.Drawing.Point(90, 289);
            this.bExpand.Name = "bExpand";
            this.bExpand.Size = new System.Drawing.Size(60, 30);
            this.bExpand.TabIndex = 5;
            this.bExpand.Text = "+";
            this.bExpand.UseVisualStyleBackColor = true;
            this.bExpand.Click += new System.EventHandler(this.bExpand_Click);
            // 
            // bShow
            // 
            this.bShow.Location = new System.Drawing.Point(32, 174);
            this.bShow.Name = "bShow";
            this.bShow.Size = new System.Drawing.Size(176, 23);
            this.bShow.TabIndex = 4;
            this.bShow.Text = "Show";
            this.bShow.UseVisualStyleBackColor = true;
            this.bShow.Click += new System.EventHandler(this.bShow_Click);
            // 
            // bHide
            // 
            this.bHide.Location = new System.Drawing.Point(32, 145);
            this.bHide.Name = "bHide";
            this.bHide.Size = new System.Drawing.Size(176, 23);
            this.bHide.TabIndex = 3;
            this.bHide.Text = "Hide";
            this.bHide.UseVisualStyleBackColor = true;
            this.bHide.Click += new System.EventHandler(this.bHide_Click);
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(32, 116);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(84, 23);
            this.bAdd.TabIndex = 2;
            this.bAdd.Text = "Add";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // cbfigures
            // 
            this.cbfigures.FormattingEnabled = true;
            this.cbfigures.Location = new System.Drawing.Point(32, 57);
            this.cbfigures.Name = "cbfigures";
            this.cbfigures.Size = new System.Drawing.Size(176, 24);
            this.cbfigures.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Components";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 476);
            this.Controls.Add(this.pTools);
            this.Controls.Add(this.pMain);
            this.Name = "Form1";
            this.Text = "Circle demo";
            this.pTools.ResumeLayout(false);
            this.pTools.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.Panel pTools;
        private System.Windows.Forms.Button bDownFar;
        private System.Windows.Forms.Button bUpFar;
        private System.Windows.Forms.Button bUp;
        private System.Windows.Forms.Button bCollapse;
        private System.Windows.Forms.Button bLeftFar;
        private System.Windows.Forms.Button bRight;
        private System.Windows.Forms.Button bLeft;
        private System.Windows.Forms.Button bRightFar;
        private System.Windows.Forms.Button bDown;
        private System.Windows.Forms.Button bExpand;
        private System.Windows.Forms.Button bShow;
        private System.Windows.Forms.Button bHide;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.ComboBox cbfigures;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFigureType;
    }
}

