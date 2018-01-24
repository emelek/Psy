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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f1 = new Form2();
            f1.Show();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            //if (Program.counter > 2)
            //{
                //File.AppendAllText(@"C:\Users\Сидоренко Михаил\Desktop\Psy.exxe\PsyTest\PsyTest\results.txt", Environment.NewLine);
            //}
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }        
    }
}
