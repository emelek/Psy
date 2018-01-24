using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PsyTest
{
    public partial class Form3 : Form
    {
        string path = @"C:\\Program psy\\results.txt";
        string img;
        int bx;
        int bxx;
        public Form3()
        {
            InitializeComponent();
        }
            
            public Form3(string img)
            {
                this.img = img;
            }
         

        

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (Program.counter > 34)
            {
                Application.Exit();
            }
            try
            {
                Program.counter += 1;
                this.Hide();
                if (Program.counter <= 18)
                {
                    Form3 f1 = new Form3();
                    f1.Show();
                }
                else
                {
                    Form4 f1 = new Form4();
                    f1.Show();
                }
                

                
            }
            catch
            {
                Application.Exit();
            }
            //запись в файл
            if (!File.Exists(path))
            {
                string line = "";
                File.WriteAllText(path, line);
            }



            string secondline = (Program.counter-1).ToString() + " " + bx.ToString() + " " + bxx.ToString() + Environment.NewLine;
            File.AppendAllText(path, secondline);
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
        }
        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            //File.AppendAllText(path, Environment.NewLine);
            Application.Exit();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            Application.Exit();
        }

        private void Form3_Load_1(object sender, EventArgs e)
        {

        }
        //Радио батоны ===============================================================================
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                bx = 1;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                bx = 2;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                bx = 3;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                bx = 4;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {
                bx = 5;
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked == true)
            {
                bx = 6;
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked == true)
            {
                bx = 7;
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked == true)
            {
                bx = 8;
            }
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked == true)
            {
                bx = 9;
            }
        }

        //Another group================================================================

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton18.Checked == true)
            {
                bxx = 1;
            }
        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton17.Checked == true)
            {
                bxx = 2;
            }
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton16.Checked == true)
            {
                bxx = 3;
            }
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton15.Checked == true)
            {
                bxx = 4;
            }
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton14.Checked == true)
            {
                bxx = 5;
            }
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton13.Checked == true)
            {
                bxx = 6;
            }
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton12.Checked == true)
            {
                bxx = 7;
            }
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton11.Checked == true)
            {
                bxx = 8;
            }
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton10.Checked == true)
            {
                bxx = 9;
            }
        }
    }
}
