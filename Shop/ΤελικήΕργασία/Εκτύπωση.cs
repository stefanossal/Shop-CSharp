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
    public partial class Εκτύπωση : Form
    {
        public Εκτύπωση()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "---- επιλέξτε")
            {
                MessageBox.Show("Παρακαλώ συμπληρώστε το στοιχείο");
            }
            else
            {
                this.Close();
            }
        }
    }
}
