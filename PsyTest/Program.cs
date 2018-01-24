using System;
using System.Text;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace PsyTest
{
    
    static class Program
    {
        
        
       

        public static int counter=1;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            
            
            
        }
        
    }
}
