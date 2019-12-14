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

        private void Add_Click(object sender, EventArgs e)
        {
           Animals a = new Animals();

            Form1 f = new Form1(a);

            if (f.ShowDialog() == DialogResult.OK)
            {
                aInfo.Text += string.Format("{0}, {1}, {2}. Population: {3}. Num of paws: {5} [{6} | {7}] | Years of living: {8:0.00} years\r\n", a.Name, a.Country, a.Family, a.Population, a.Years, a.Paws, a.HasWings ? " has wings" : " no wings", a.IsPredator ? " predator" : " herbivorous", a.YearsofLiving());
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Close the program?", "ending task", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) Application.Exit();
        }
    
    }
}
