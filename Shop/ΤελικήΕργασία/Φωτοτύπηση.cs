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
    public partial class Φωτοτύπηση : Form
    {
        public Φωτοτύπηση()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "---- επιλέξτε διαμόρφωση" | textBox1.Text == "" | comboBox2.Text == "---- επιλέξτε" | comboBox3.Text == "---- επιλέξτε τύπο")
            {
                MessageBox.Show("Παρακαλώ συμπληρώστε όλα τα στοιχεία");
            }
            else
            {
                this.Close();
            }
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
