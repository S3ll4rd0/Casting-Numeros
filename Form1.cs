using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CastingNumeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int ent = Convert.ToInt32(textBox1.Text);
            int doble = ent * 2;
            double mitad = ent / 2;

            textBox3.Text = doble.ToString();
            textBox4.Text = mitad.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double real = Convert.ToDouble(textBox2.Text);
            double doble = real * 2;
            double mitad = real / 2;

            textBox3.Text = doble.ToString();
            textBox4.Text = mitad.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
