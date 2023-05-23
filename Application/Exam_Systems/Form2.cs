using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam_Systems
{
    public partial class Form2 : Form
    {
        int SSN;
        string Course;
        public Form2()
        {
            InitializeComponent();
            comboBox1.Items.Add("DB");
            comboBox1.Items.Add("OS");
            comboBox1.Items.Add("SA1");
        }
        public int Ssn { set { SSN = value; } get { return SSN; } }
        public string crs { set { Course = value; } get { return Course; } }

        private void button1_Click(object sender, EventArgs e)
        {

            Ssn = int.Parse( textBox1.Text);
            crs= comboBox1.SelectedItem.ToString();
            DialogResult= DialogResult.OK;
            this.Close();
        }
    }
}
