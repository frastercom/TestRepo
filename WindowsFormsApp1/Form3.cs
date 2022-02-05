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
    public partial class Form3 : Form
    {
        OpenFileDialog o = new OpenFileDialog();
        SaveFileDialog s = new SaveFileDialog();
        public Form3()
        {
            InitializeComponent();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            o.Filter = "jpg files (*.jpg)|*.jpg";
            if (o.ShowDialog() == DialogResult.OK)
            {
                string filename = o.FileName;
                pictureBox1.Image = Image.FromFile(filename);
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            s.Filter = "jpg files (*.jpg)|*.jpg";
            if (s.ShowDialog() == DialogResult.OK)
            {
                string filename = s.FileName;
                pictureBox1.Image.Save(filename);
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
