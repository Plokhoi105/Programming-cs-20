using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lr9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calc_Click(object sender, EventArgs e)
        {
            #region tb
            double x1min = double.Parse(X1min.Text);
            double x1max = double.Parse(X1max.Text);
            double x2min = double.Parse(X2min.Text);
            double x2max = double.Parse(X2max.Text);
            double dx1 = double.Parse(dX1.Text);
            double dx2 = double.Parse(dX2.Text);
            #endregion

            gv.ColumnCount = (int)Math.Truncate((x2max - x2min) / dx2) + 1;
            gv.RowCount = (int)Math.Truncate((x1max - x1min) / dx1) + 1;

            for (int i = 0; i < gv.RowCount; i++)
            {
                gv.Rows[i].HeaderCell.Value = (x1min + i * dx1).ToString("0.000");
                gv.RowHeadersWidth = 80;
            }
            for (int i = 0; i < gv.ColumnCount; i++)
            {
                gv.Columns[i].HeaderCell.Value = (x2min + i * dx2).ToString("0.000");
                gv.Columns[i].Width = 60;
            }

            int cl, rw;
            double x1, x2, y;

            rw = 0;
            x1 = x1min;
            double sum = 0;

            while (x1 <= x1max)
            {
                x2 = x2min;
                cl = 0;
                while (x2 <= x2max)
                {
                    y = Math.Pow(Math.Sin(x1 * (x2 / (x1 + 53 * Math.Pow(x2, 2)))), 2);
                    if (y < 0)
                    {
                        sum += y;
                    }
                    gv.Rows[rw].Cells[cl].Value = y.ToString("0.000");
                    x2 += dx2;
                    cl++;
                }
                x1 += dx1;
                rw++;
            }
            summ.Text = sum.ToString();

            double rowssum = 0;
            
            DataGridViewTextBoxColumn rsum;
            rsum = new DataGridViewTextBoxColumn();
            rsum.HeaderText = "sum of rows";
            gv.Columns.Add(rsum);
            int col = rsum.Index;


            for (int i = 0; i < gv.RowCount; i++)
            {
                for (int j = 0; j < gv.ColumnCount; j++)
                {
                    rowssum += Double.Parse(gv.Rows[i].Cells[j].Value.ToString());
                    gv.Rows[i].Cells[col].Value = rowssum;
                }
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            X1min.Text = "";
            X1max.Text = "";
            X2min.Text = "";
            X2max.Text = "";
            dX1.Text = "";
            dX2.Text = "";

            gv.Rows.Clear();

            for (int Cl = 0; Cl < gv.ColumnCount; Cl++)
            {
                gv.Columns[Cl].HeaderCell.Value = ""; 
            }
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Close the program?", "Exiting", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            { 
                Application.Exit(); 
            }
        }

    }
}
