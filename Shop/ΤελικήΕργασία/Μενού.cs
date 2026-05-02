using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ΤελικήΕργασία
{
    public partial class Μενού : Form
    {
        int ti1 = 0;
        public static bool ch1 = false;
        public static bool ch2 = false;
        public static bool ch3 = false;
        public static bool ch4 = false;
        public static bool ch5 = false;
        public static bool ch6 = false;
        public Μενού()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!checkBox1.Checked && !checkBox2.Checked && !checkBox3.Checked && !checkBox4.Checked && !checkBox5.Checked && !checkBox6.Checked)
            {
                MessageBox.Show("Παρακαλώ επιλέξτε κάτι.");
            }
            else
            {
                this.Close();
                MessageBox.Show("Η παραγγελία σας θα είναι έτοιμη σε πολύ λίγο.");
                timer1.Enabled = true;
            }
            
        }

        private void Μενού_MouseEnter(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
            }
            if (checkBox2.Checked == true)
            {
                checkBox1.Enabled = false;
                checkBox3.Enabled = false;
            }
            if (checkBox3.Checked == true)
            {
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
            }
            if (checkBox4.Checked == true)
            {
                checkBox5.Enabled = false;
                checkBox6.Enabled = false;
            }
            if (checkBox5.Checked == true)
            {
                checkBox4.Enabled = false;
                checkBox6.Enabled = false;
            }
            if (checkBox6.Checked == true)
            {
                checkBox4.Enabled = false;
                checkBox5.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ti1 = ti1 + 1;
            if(ti1 == 4)
            {
                timer1.Stop();
                MessageBox.Show("Η παραγγελία σας είναι έτοιμη.");
                if(checkBox1.Checked == true)
                {
                    ch1 = true;
                }
                if(checkBox2.Checked == true)
                {
                    ch2 = true;
                }
                if(checkBox3.Checked == true)
                {
                    ch3 = true;
                }
                if(checkBox4.Checked == true)
                {
                    ch4 = true;
                }
                if (checkBox5.Checked == true)
                {
                    ch5 = true;
                }
                if (checkBox6.Checked == true)
                {
                    ch6 = true;
                }
                ti1 = 0;
            }
            
        }
    }
}
