using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lr8
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }
        private void main_Resize(object sender, EventArgs e)
        {
            int buttonsSize = 5 * Add.Width + 2 * ts.Width + 30;
            Exit.Margin = new Padding(Width - buttonsSize, 0, 0, 0);
        }
        private void main_Load(object sender, EventArgs e)
        {
            gv.AutoGenerateColumns = false;

            DataGridViewColumn column = new DataGridViewTextBoxColumn(); 
            column.DataPropertyName = "Name"; 
            column.Name = "name"; 
            gv.Columns.Add(column);

            column = new DataGridViewTextBoxColumn(); 
            column.DataPropertyName = "Country"; 
            column.Name = "country"; 
            gv.Columns.Add(column);

            column = new DataGridViewTextBoxColumn(); 
            column.DataPropertyName = "Family";
            column.Name = "family"; 
            gv.Columns.Add(column);

            column = new DataGridViewTextBoxColumn(); 
            column.DataPropertyName = "Population";
            column.Name = "population"; 
            gv.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Years"; 
            column.Name = "years"; 
            gv.Columns.Add(column);

            column = new DataGridViewTextBoxColumn(); 
            column.DataPropertyName = "Paws"; 
            column.Name = "paws"; 
            column.Width = 80; 
            gv.Columns.Add(column);

            column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = "HasWings"; 
            column.Name = "wings"; 
            column.Width = 60; 
            gv.Columns.Add(column);

            column = new DataGridViewCheckBoxColumn(); 
            column.DataPropertyName = "IsPredator"; 
            column.Name = "predator"; 
            column.Width = 60; 
            gv.Columns.Add(column);

            bsource.Add(new Animal("elephant", "africa", "Elephantidae", 1000000, 60, 4, false, false)); 

            EventArgs args = new EventArgs();
            OnResize(args);
        }
        private void Add_Click(object sender, EventArgs e)
        {
            Animal anim = new Animal();

            Form1 f = new Form1(anim); 
            if (f.ShowDialog() == DialogResult.OK)
            { 
                bsource.Add(anim); 
            }
        }
        private void Edit_Click(object sender, EventArgs e)
        {
            Animal anim = (Animal)bsource.List[bsource.Position];

            Form1 f = new Form1(anim); 
            if (f.ShowDialog() == DialogResult.OK) 
            { 
                bsource.List[bsource.Position] = anim; 
            }
        }
        private void Del_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete?", "Deleting", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK) 
            { 
                bsource.RemoveCurrent(); 
            }
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Очистити таблицю?\n\nВсі дані будуть втрачені", "Очищення даних", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) 
            { 
                bsource.Clear(); 
            }
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Close?", "Exiting", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) 
            { 
                Application.Exit(); 
            }
        }
    }
}
