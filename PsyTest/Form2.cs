using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace PsyTest
{
    public partial class Form2 : Form
    {

        string installPath = @"C:\\Program psy\\";


        string path = @"C:\\Program psy\\test.txt";
        string sex = "";
        public Form2()
        {
           Thread.Sleep(1000);
           InitializeComponent(); 
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Directory.CreateDirectory(installPath);
            }

            catch
            {
 
            }

            if (sex == "")
            {
                MessageBox.Show("Не забудьте указать ваш пол");
                return;
            }
            try
            {
                int age = int.Parse(textBox1.Text);
                if ((age > 100) || (age < 0)) 
                {
                    MessageBox.Show("Ошибка ввода возраста! \nПодумайте хорошенько");
                    textBox1.Clear();
                    return;
                }
            
           
            
            if (!File.Exists(path))
            {
                string line = "";
                File.WriteAllText(path, line);
            }

            

            string secondline = age.ToString() + " " + sex + Environment.NewLine;
            File.AppendAllText(path, secondline);
                    
            this.Hide();
            Form3 f2 = new Form3();
            f2.Show();
            }
            catch
            {
                MessageBox.Show("Ошибка ввода возраста! \nПодумайте хорошенько");
                textBox1.Clear();
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                
                sex = "m";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                
                sex = "w";
            }
        }

        
    }
}
