using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {

        OpenFileDialog o = new OpenFileDialog();
        SaveFileDialog s = new SaveFileDialog();
        public Form2()
        {
            InitializeComponent();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            o.Filter = "txt files (*.txt)|*.txt";
            if (o.ShowDialog() == DialogResult.OK)
            {
                string filename = o.FileName;
                string fileText = System.IO.File.ReadAllText(filename);
                textBox1.Text = fileText;
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            s.Filter = "txt files (*.txt)|*.txt";
            if (s.ShowDialog() == DialogResult.OK)
            {
                string filename = s.FileName;
                System.IO.File.WriteAllText(filename, textBox1.Text);
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
