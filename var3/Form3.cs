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

namespace var3
{
    public partial class Form3 : Form
    {
        String a;

        public Form3(string b, string c, string d, string f, string a)
        {
            InitializeComponent();
            this.a = a + b + c + d + f;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter s = new StreamWriter(@"File.txt");
            s.Write(a);
            s.Close();
        }
    }
}
