using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lr11
{
    public partial class Form1 : Form
    {
        Emblem[] emblems;
        int EmblemCount = 0;
        int CurrentEmblemIndex;

        public Form1()
        {
            emblems = new Emblem[100];
            InitializeComponent();
        }
        private void bAdd_Click(object sender, EventArgs e)
        {
            if (EmblemCount >= 99) 
            { 
                MessageBox.Show("Досягнуто межі кількості об'єктів!"); 
                return; 
            }
            Graphics graphics = pMain.CreateGraphics(); 
            CurrentEmblemIndex = EmblemCount;

            emblems[CurrentEmblemIndex] = new Emblem(graphics, pMain.Width / 5, pMain.Height / 2, 50); 
            emblems[CurrentEmblemIndex].Show();
            EmblemCount++;

            cbEmblems.Items.Add(" emblem №" + (EmblemCount - 1).ToString()); 
            cbEmblems.SelectedIndex = EmblemCount - 1;
        }
        private void bHide_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbEmblems.SelectedIndex; 
            if ((CurrentEmblemIndex > EmblemCount) || (CurrentEmblemIndex < 0)) return;

            emblems[CurrentEmblemIndex].Hide();   
        }
        private void bShow_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbEmblems.SelectedIndex; 
            if ((CurrentEmblemIndex > EmblemCount) || (CurrentEmblemIndex < 0)) return;

            emblems[CurrentEmblemIndex].Show(); 
        }
        private void bExpand_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbEmblems.SelectedIndex; 
            if ((CurrentEmblemIndex > EmblemCount) || (CurrentEmblemIndex < 0)) return;

            emblems[CurrentEmblemIndex].Expand(5);   
        }
        private void bCollapse_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbEmblems.SelectedIndex; 
            if ((CurrentEmblemIndex > EmblemCount) || (CurrentEmblemIndex < 0)) return;
            
            emblems[CurrentEmblemIndex].Collapse(5); 
        }
        private void bUp_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbEmblems.SelectedIndex; 
            if ((CurrentEmblemIndex > EmblemCount) || (CurrentEmblemIndex < 0)) return;

            emblems[CurrentEmblemIndex].Move(0, -10); 
        }
        private void bUpFar_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbEmblems.SelectedIndex; 
            if ((CurrentEmblemIndex > EmblemCount) || (CurrentEmblemIndex < 0)) return;

           for (int i = 0; i < 100; i++)     
            {         
                emblems[CurrentEmblemIndex].Move(0, -1);
                System.Threading.Thread.Sleep(5);
            } 
        }
        private void bRight_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbEmblems.SelectedIndex;
            if ((CurrentEmblemIndex > EmblemCount) || (CurrentEmblemIndex < 0)) return;

            emblems[CurrentEmblemIndex].Move(10, 0); 
        }
        private void bRightFar_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbEmblems.SelectedIndex; 
            if ((CurrentEmblemIndex > EmblemCount) || (CurrentEmblemIndex < 0)) return;

            for (int i = 0; i < 100; i++)     
            {         
                emblems[CurrentEmblemIndex].Move(1, 0);
                System.Threading.Thread.Sleep(5);    
            }   
        }
        private void bDown_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbEmblems.SelectedIndex; 
            if ((CurrentEmblemIndex > EmblemCount) || (CurrentEmblemIndex < 0)) return;

            emblems[CurrentEmblemIndex].Move(0, 10); 
        }
        private void bDownFar_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbEmblems.SelectedIndex; 
            if ((CurrentEmblemIndex > EmblemCount) || (CurrentEmblemIndex < 0)) return;
            for (int i = 0; i < 100; i++)     
            {        
                emblems[CurrentEmblemIndex].Move(0, 1);   
                System.Threading.Thread.Sleep(5);  
            }   
        }
        private void bLeft_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbEmblems.SelectedIndex; 
            if ((CurrentEmblemIndex > EmblemCount) || (CurrentEmblemIndex < 0)) return;
            
            emblems[CurrentEmblemIndex].Move(-10, 0); 
        }
        private void bLeftFar_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbEmblems.SelectedIndex; 
            if ((CurrentEmblemIndex > EmblemCount) || (CurrentEmblemIndex < 0)) return;

            for (int i = 0; i < 100; i++)     
            {         
                emblems[CurrentEmblemIndex].Move(-1, 0);   
                System.Threading.Thread.Sleep(5);   
            }   
        }
    }
}
