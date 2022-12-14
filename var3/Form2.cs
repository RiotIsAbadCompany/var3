using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace var3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Disel");
            comboBox1.Items.Add("Gaz-propanbutan");
            comboBox1.Items.Add("benzinaa95");
            comboBox1.Items.Add("a100bnezin");
            comboBox1.Items.Add("metan");
            comboBox2.Items.Add(5);
            comboBox2.Items.Add(10);
            comboBox2.Items.Add(20);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = ("New User");
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            listBox1.Items.Add(textBox2.Text);
            listBox1.Items.Add(textBox3.Text);
            listBox1.Items.Add(comboBox1.Text);
            listBox1.Items.Add(comboBox2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double litre;
            int n;
            double ostupka;
            double sum;
            litre = Convert.ToDouble(textBox2.Text);
            n = Convert.ToInt32(textBox3.Text);
            ostupka = Convert.ToDouble(comboBox2.Text);
            sum = (litre * n - ((litre * n) * (ostupka / 100))) * 1.2;
            textBox4.Text = sum.ToString();
            Form3 f = new Form3(textBox1.Text, textBox2.Text, textBox3.Text, comboBox1.Text, comboBox2.Text);
            f.Show();
        }
    }
}
