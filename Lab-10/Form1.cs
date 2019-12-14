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
    public partial class Form1 : Form
    {
        public Animal animal;
        public Form1(Animal a)
        {
            animal = a;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            animal.Name = tName.Text.Trim();
            animal.Country = tCountry.Text.Trim();
            animal.Family = tFamily.Text.Trim();
            animal.Population = int.Parse(tPopulation.Text.Trim());
            animal.Years = double.Parse(tYears.Text.Trim());
            animal.Paws = int.Parse(tPaws.Text.Trim());
            animal.HasWings = checkWings.Checked;
            animal.IsPredator = checkPredator.Checked;

            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (animal != null) 
            { 
                tName.Text = animal.Name; 
                tCountry.Text = animal.Country; 
                tFamily.Text = animal.Family;
                tPopulation.Text = animal.Population.ToString();
                tYears.Text = animal.Years.ToString("0.00");
                tPaws.Text = animal.Paws.ToString(); 
                checkWings.Checked = animal.HasWings;
                checkPredator.Checked = animal.IsPredator;
            }
        }
    
    }


}
