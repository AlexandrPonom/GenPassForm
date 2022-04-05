using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace GenPass{
    public partial class Form1 : Form{
        public Form1(){InitializeComponent();}
        private void button1_Click(object sender, EventArgs e){
            string sPas = ""; textBox3.Text = "";
            if (checkBox1.Checked == true){sPas += "qwertyuioplkjhgfdsazxcvbnm";}
            if (checkBox2.Checked == true){sPas += "QAZXSWEDCVFRTGBNHYUJMKIOLP";}
            if (checkBox3.Checked == true){sPas += "1234567890";}
            if (checkBox4.Checked == true){sPas += "!$^:;*-_=+";}
            for (int j = 1; j < Convert.ToInt32(textBox2.Text) + 1; j++){
                string[] arr = new string[sPas.Length];
                Random rnd = new Random();
                for (int i = 1; i < Convert.ToInt32(textBox1.Text) + 1; i++){
                    int count = 0;
                    count = rnd.Next(0, arr.Length);
                    textBox3.Text += sPas[count].ToString();
                }
                textBox3.Text += Environment.NewLine;
            }
        }
        private void trackBar1_Scroll(object sender, EventArgs e){textBox1.Text = ""; textBox1.Text += trackBar1.Value;}
        private void button2_Click(object sender, EventArgs e){textBox3.Text = "";}
        private void trackBar2_Scroll(object sender, EventArgs e){textBox2.Text = ""; textBox2.Text += trackBar2.Value;}
    }
}