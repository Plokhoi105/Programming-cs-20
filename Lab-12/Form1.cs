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
        Figure[] figures; 
        int FiguresCount = 0;
        int CurrentFigureIndex;
        public Form1()
        {
            figures = new Figure[100];
            //cbFigureType.SelectedIndex = 0;
            InitializeComponent();
        }
        private void bAdd_Click(object sender, EventArgs e)
        {
            if (FiguresCount >= 99) 
            { 
                MessageBox.Show("Досягнуто межі кількості об'єктів!"); 
                return; 
            }
            Graphics graphics = pMain.CreateGraphics(); 
            CurrentFigureIndex = FiguresCount;

            figures[CurrentFigureIndex] = new Emblem(graphics, pMain.Width / 5, pMain.Height / 2, 50); 
            figures[CurrentFigureIndex].Show();
            FiguresCount++;

            cbfigures.Items.Add(" emblem №" + (FiguresCount - 1).ToString()); 
            cbfigures.SelectedIndex = FiguresCount - 1;
        }
        private void bHide_Click(object sender, EventArgs e)
        {
            CurrentFigureIndex = cbfigures.SelectedIndex; 
            if ((CurrentFigureIndex > FiguresCount) || (CurrentFigureIndex < 0)) return;

            figures[CurrentFigureIndex].Hide();   
        }
        private void bShow_Click(object sender, EventArgs e)
        {
            CurrentFigureIndex = cbfigures.SelectedIndex; 
            if ((CurrentFigureIndex > FiguresCount) || (CurrentFigureIndex < 0)) return;

            figures[CurrentFigureIndex].Show(); 
        }
        private void bExpand_Click(object sender, EventArgs e)
        {
            CurrentFigureIndex = cbfigures.SelectedIndex; 
            if ((CurrentFigureIndex > FiguresCount) || (CurrentFigureIndex < 0)) return;

            figures[CurrentFigureIndex].Expand(5);   
        }
        private void bCollapse_Click(object sender, EventArgs e)
        {
            CurrentFigureIndex = cbfigures.SelectedIndex; 
            if ((CurrentFigureIndex > FiguresCount) || (CurrentFigureIndex < 0)) return;
            
            figures[CurrentFigureIndex].Collapse(5); 
        }
        private void bUp_Click(object sender, EventArgs e)
        {
            CurrentFigureIndex = cbfigures.SelectedIndex; 
            if ((CurrentFigureIndex > FiguresCount) || (CurrentFigureIndex < 0)) return;

            figures[CurrentFigureIndex].Move(0, -10); 
        }
        private void bUpFar_Click(object sender, EventArgs e)
        {
            CurrentFigureIndex = cbfigures.SelectedIndex; 
            if ((CurrentFigureIndex > FiguresCount) || (CurrentFigureIndex < 0)) return;

           for (int i = 0; i < 100; i++)     
            {         
                figures[CurrentFigureIndex].Move(0, -1);
                System.Threading.Thread.Sleep(5);
            } 
        }
        private void bRight_Click(object sender, EventArgs e)
        {
            CurrentFigureIndex = cbfigures.SelectedIndex;
            if ((CurrentFigureIndex > FiguresCount) || (CurrentFigureIndex < 0)) return;

            figures[CurrentFigureIndex].Move(10, 0); 
        }
        private void bRightFar_Click(object sender, EventArgs e)
        {
            CurrentFigureIndex = cbfigures.SelectedIndex; 
            if ((CurrentFigureIndex > FiguresCount) || (CurrentFigureIndex < 0)) return;

            for (int i = 0; i < 100; i++)     
            {         
                figures[CurrentFigureIndex].Move(1, 0);
                System.Threading.Thread.Sleep(5);    
            }   
        }
        private void bDown_Click(object sender, EventArgs e)
        {
            CurrentFigureIndex = cbfigures.SelectedIndex; 
            if ((CurrentFigureIndex > FiguresCount) || (CurrentFigureIndex < 0)) return;

            figures[CurrentFigureIndex].Move(0, 10); 
        }
        private void bDownFar_Click(object sender, EventArgs e)
        {
            CurrentFigureIndex = cbfigures.SelectedIndex; 
            if ((CurrentFigureIndex > FiguresCount) || (CurrentFigureIndex < 0)) return;
            for (int i = 0; i < 100; i++)     
            {        
                figures[CurrentFigureIndex].Move(0, 1);   
                System.Threading.Thread.Sleep(5);  
            }   
        }
        private void bLeft_Click(object sender, EventArgs e)
        {
            CurrentFigureIndex = cbfigures.SelectedIndex; 
            if ((CurrentFigureIndex > FiguresCount) || (CurrentFigureIndex < 0)) return;
            
            figures[CurrentFigureIndex].Move(-10, 0); 
        }
        private void bLeftFar_Click(object sender, EventArgs e)
        {
            CurrentFigureIndex = cbfigures.SelectedIndex; 
            if ((CurrentFigureIndex > FiguresCount) || (CurrentFigureIndex < 0)) return;

            for (int i = 0; i < 100; i++)     
            {         
                figures[CurrentFigureIndex].Move(-1, 0);   
                System.Threading.Thread.Sleep(5);   
            }   
        }
    }
}
