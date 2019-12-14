using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            int buttonsSize = 9 * Add.Width + 3 * toolStripSeparator1.Width;
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
        private void Save_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Текстові файли (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.Title = "Зберегти дані у текстовому форматі";
            saveFileDialog.InitialDirectory = Application.StartupPath;

            StreamWriter sw;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                sw = new StreamWriter(saveFileDialog.FileName, false, Encoding.UTF8);
                try
                {
                    foreach (Animal animal in bsource.List)
                    {
                        sw.Write(animal.Name + "\t" + animal.Country + "\t" + animal.Family + "\t" + animal.Population + "\t" + animal.Years + "\t" + animal.Paws + "\t" + animal.HasWings + "\t" + animal.IsPredator + "\t\n");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Сталась помилка: \n{0}", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sw.Close();
                }
            }
        }
        private void Saveasbinary_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Файли даних (*.towns)|*.towns|All files (*.*)|*.*";
            saveFileDialog.Title = "Зберегти дані у бінарному форматі";
            saveFileDialog.InitialDirectory = Application.StartupPath;
            BinaryWriter bw;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                bw = new BinaryWriter(saveFileDialog.OpenFile());
                try
                {
                    foreach (Animal animal in bsource.List)
                    {
                        bw.Write(animal.Name);
                        bw.Write(animal.Country);
                        bw.Write(animal.Family);
                        bw.Write(animal.Population);
                        bw.Write(animal.Years);
                        bw.Write(animal.Paws);
                        bw.Write(animal.HasWings);
                        bw.Write(animal.IsPredator);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Сталась помилка: \n{0}", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    bw.Close();
                }
            }
        }

        private void Open_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Текстові файли (*.txt)|*.txt|All files (*.*)|*.*"; 
            openFileDialog.Title = "Прочитати дані у текстовому форматі"; 
            openFileDialog.InitialDirectory = Application.StartupPath;

            StreamReader sr;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                bsource.Clear();
                sr = new StreamReader(openFileDialog.FileName, Encoding.UTF8);
                string s;

                try 
                { 
                    while ((s = sr.ReadLine()) != null) 
                    { 
                        string[] split = s.Split('\t');
                        Animal animal = new Animal(split[0], split[1], split[2], int.Parse(split[3]), int.Parse(split[4]), double.Parse(split[5]), bool.Parse(split[6]), bool.Parse(split[7])); bsource.Add(animal);
                    } 
                } 
                catch (Exception ex) 
                { 
                    MessageBox.Show("Сталась помилка: \n{0}", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error); 
                } 
                finally 
                { 
                    sr.Close();
                }
            }
        }

        private void Openfrombinary_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Файли даних (*.towns)|*.towns|All files (*.*)|*.*"; 
            openFileDialog.Title = "Прочитати дані у бінарному форматі";
            openFileDialog.InitialDirectory = Application.StartupPath;
            
            BinaryReader br;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                bsource.Clear(); br = new BinaryReader(openFileDialog.OpenFile()); try
                {
                    Animal animal; 
                    while (br.BaseStream.Position < br.BaseStream.Length)
                    { 
                        animal = new Animal(); 
                        for (int i = 1; i <= 8; i++) 
                        { 
                            switch (i) 
                            { 
                                case 1: animal.Name = br.ReadString(); 
                                    break; 
                                case 2: animal.Country = br.ReadString();
                                    break; 
                                case 3: animal.Family = br.ReadString(); 
                                    break;
                                case 4: animal.Population = br.ReadInt32(); 
                                    break; 
                                case 5: animal.Years = br.ReadDouble();
                                    break;
                                case 6: animal.Paws = br.ReadInt32(); 
                                    break; 
                                case 7: animal.HasWings = br.ReadBoolean();
                                    break;
                                case 8: animal.IsPredator = br.ReadBoolean();
                                    break; 
                            } 
                        }
                        bsource.Add(animal);
                    }
                }
                catch (Exception ex) 
                { 
                    MessageBox.Show("Сталась помилка: \n{0}", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error); 
                }
                finally 
                { 
                    br.Close(); 
                }
            }
        }
    }
}

