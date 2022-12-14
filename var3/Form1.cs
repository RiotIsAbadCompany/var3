using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace var3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> list = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                list.Add(rnd.Next(-10, 20));
            }
            list.Sort();
            list.Reverse();
            listBox1.DataSource = list;
            int num;
            int num2;
            int number;
            List<int> list2 = new List<int>();
            List<int> list3 = new List<int>();
            List<int> list4 = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {

                if (list[i] < 0 && list[i] > -10)
                {
                    list2.Add(list[i]);
                }
                else if (list[i] > 0 && list[i] >= 10)
                {
                    list3.Add(list[i]);
                }




                if (list[i] < 0)
                {
                    number = list[i] * -1;   
                    string first = number.ToString();
                    if (first.Length > 1)
                    {
                        num = int.Parse(first.Substring(0, 1));
                         num2 = int.Parse(first.Substring(1));
                          
                        //MessageBox.Show(first.Length.ToString());
                         if (num + num2 % 3 == 0)
                         {
                            MessageBox.Show(list[i].ToString());
                            list4.Add(list[i]);
                         }

                    }
                    else if (first.Length == 1)
                    {
                        //MessageBox.Show(first.Length.ToString());
                         num = int.Parse(first.Substring(0, 1));
                       //MessageBox.Show(num.ToString());
                         if(num%3 == 0)
                         {
                            MessageBox.Show(list[i].ToString());
                            list4.Add(list[i]);
                         }
                    }
                }
                else
                {
                    number = list[i];
                    string first = number.ToString();
                    if (first.Length > 1)
                    {
                        num = int.Parse(first.Substring(0, 1));
                         num2 = int.Parse(first.Substring(1));
                          
                       // MessageBox.Show(first.Length.ToString());
                         if (num + num2 % 3 == 0 )
                         {
                            MessageBox.Show(list[i].ToString());
                            list4.Add(list[i]);
                         }

                    }
                    else if (first.Length  <2)
                    {
                        //MessageBox.Show(first.Length.ToString());
                         num = int.Parse(first.Substring(0, 1));
                        //MessageBox.Show(num.ToString());
                         if(num%3 == 0 && num!=0)
                         {
                            MessageBox.Show(list[i].ToString());
                            list4.Add(list[i]);
                         }
                    }
                }
            }
            if(list4.Count == 0)
            {
                MessageBox.Show("no %3");
            }
            string combinedString = string.Join(",", list);
            string path = "C:\\New folder\\ff.txt";
           

            textBox1.Text = list2.Count.ToString();
            textBox2.Text = list3.Count.ToString();
            textBox3.Text = list4.Count.ToString();
            string result = "ednocifreni: " + textBox1.Text +"; "+"dvucifreni: " + textBox2.Text + "; " + "%3: " + textBox3.Text +"; listbox:" + combinedString;
            File.WriteAllText(path, result);
            MessageBox.Show(result);
        }
    }
}
