using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alex
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void bCount_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(X1.Text) || (String.IsNullOrEmpty(X2.Text))) { Y.Text = "no data!"; return; }

            double x1 = double.Parse(X1.Text); 
            double x2 = double.Parse(X2.Text);

            double y = (5 * Math.Sqrt(Math.Pow(x1, 3) + Math.Pow(x2, 5) - Math.Cos(x2))) / Math.Exp(x1);
            double mean = Average(x1, x2);

            Y.Text = y.ToString("0.####");
            average.Text = mean.ToString();
        }
        public double Average(double num1, double num2)
        {
            return (num1 + num2) / 2;
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            X1.Text = string.Empty;
            X2.Text = string.Empty; 
            Y.Text = string.Empty;
            average.Text = string.Empty;
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
