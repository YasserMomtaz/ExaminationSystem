using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam_Systems
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form2 login = new Form2();
            DialogResult result = login.ShowDialog();
            if (result == DialogResult.OK)
            {
                Application.Run(new Form1(login.Ssn,login.crs));
            }
               
        }
    }
}
