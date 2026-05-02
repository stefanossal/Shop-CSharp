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
    public partial class Form1 : Form
    {
        //Μετρητές
        int k = 0;
        int s = 0;
        int r = 0;
        int c = 0;
        int x = 0;
        int t = 0;
        int t2 = 0;
        int t3 = 0;
        int t4 = 0;
        int t5 = 0;
        int t6 = 0;
        int t7 = 0;
        int ph = 0;
        int sc = 0;
        int pr = 0;
        double ch1cost = 0;
        double ch2cost = 0;
        double ch3cost = 0;
        double ch4cost = 0;
        double ch5cost = 0;
        double ch6cost = 0;
        double chcost = 0;
        double chchange = 0;
        public Form1()
        {
            InitializeComponent();
            //Rounded icons
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(-1, -1, pictureBox5.Width + 1, pictureBox5.Height + 1);
            Region rg = new Region(gp);
            pictureBox5.Region = rg;
            pictureBox6.Region = rg;
            pictureBox7.Region = rg;
            pictureBox8.Region = rg;

            //Elevator buttons
            System.Drawing.Drawing2D.GraphicsPath grp = new System.Drawing.Drawing2D.GraphicsPath();
            grp.AddEllipse(-1, -1, pictureBox12.Width + 1, pictureBox12.Height + 1);
            Region reg = new Region(grp);
            pictureBox12.Region = reg;
            pictureBox13.Region = reg;
            pictureBox14.Region = reg;

        }

        //Κουμπί είσοδος
        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string title1 = "Βοήθεια";
            MessageBox.Show("Μπορείτε να μεταφερθείτε σε ένα χώρο πατώντας τα εικονίδια ή το μενού πάνω αριστερά.Όλα τα εικονίδια παραπέμπουν στους αντίστοιχους χώρους.Αν σας δυσκολεύουν πατήστε το μενού.",title1);
        }

        private void προβολήΒοήθειαςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(16);
        }

        //Tooltips για τα εικονίδια
        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;
            toolTip1.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;

            // Set up the ToolTip text for the pictureBoxes.
            toolTip1.SetToolTip(this.pictureBox4, "Βοήθεια");
            toolTip1.SetToolTip(this.pictureBox5, "Καφετέρια");
            toolTip1.SetToolTip(this.pictureBox6, "Βιβλιοθήκη");
            toolTip1.SetToolTip(this.pictureBox7, "Ηλεκτρονική παραγγελία");
            toolTip1.SetToolTip(this.pictureBox8, "Φωτοτυπικό/Σαρωτικό μηχάνημα");
            toolTip1.SetToolTip(this.pictureBox9, "Ασανσέρ");
            toolTip1.SetToolTip(this.pictureBox12, "Καφετέρια");
            toolTip1.SetToolTip(this.pictureBox13, "Βιβλιοθήκη");
            toolTip1.SetToolTip(this.pictureBox14, "Φωτοτυπικό/Σαρωτικό μηχάνημα");
            toolTip1.SetToolTip(this.pictureBox17, "Διακόπτης");
            toolTip1.SetToolTip(this.pictureBox19, "Αρχική Σελίδα");
            toolTip1.SetToolTip(this.pictureBox21, "Φωτοτυπικό/Σαρωτικό μηχάνημα");
            toolTip1.SetToolTip(this.pictureBox23, "Αρχική Σελίδα");
            toolTip1.SetToolTip(this.pictureBox24, "Power on");
            toolTip1.SetToolTip(this.pictureBox25, "Power off");
            toolTip1.SetToolTip(this.pictureBox26, "Φωτοτύπηση");
            toolTip1.SetToolTip(this.pictureBox27, "Σάρωση");
            toolTip1.SetToolTip(this.pictureBox28, "Start");
            toolTip1.SetToolTip(this.pictureBox29, "Εκτύπωση");
            toolTip1.SetToolTip(this.textBox1, "Αναζητήστε ένα βιβλίο");
            toolTip1.SetToolTip(this.pictureBox32, "Αναζήτηση");
            toolTip1.SetToolTip(this.pictureBox33, "Καλάθι");
            toolTip1.SetToolTip(this.pictureBox39, "Αρχική Σελίδα");
            toolTip1.SetToolTip(this.pictureBox40, "Πίσω");
            toolTip1.SetToolTip(this.pictureBox42, "Πίσω");
            toolTip1.SetToolTip(this.pictureBox47, "Πίσω");
            toolTip1.SetToolTip(this.pictureBox50, "Πίσω");
            toolTip1.SetToolTip(this.pictureBox53, "Πίσω");
            toolTip1.SetToolTip(this.pictureBox61, "Αφαίρεση από το καλάθι");
            toolTip1.SetToolTip(this.pictureBox62, "Αφαίρεση από το καλάθι");
            toolTip1.SetToolTip(this.pictureBox64, "Αφαίρεση από το καλάθι");
            toolTip1.SetToolTip(this.pictureBox69, "Αφαίρεση από το καλάθι");
            toolTip1.SetToolTip(this.pictureBox67, "Πίσω");
            toolTip1.SetToolTip(this.pictureBox31, "Αρχική σελίδα ηλεκτρονικής παραγγελίας");
            toolTip1.SetToolTip(this.pictureBox77, "Διακόπτης");
            toolTip1.SetToolTip(this.pictureBox75, "Πατήστε για να καθήσετε");
            toolTip1.SetToolTip(this.pictureBox79, "Αρχική Σελίδα");
            toolTip1.SetToolTip(this.pictureBox81, "Μενού");
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
        }

        private void ασανσέρToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
        }

        private void pictureBox10_MouseEnter(object sender, EventArgs e)
        {
            k = k + 1;
            if (k == 1)
            {
                MessageBox.Show("Βρίσκεστε στο Ασανσέρ.Επιλέξτε από τα κουμπιά σε ποιον όροφο θέλετε να πάτε.");
            }
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(3);
        }

        private void βιβλιοθήκηToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(3);
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(3);
        }
        
        private void pictureBox16_MouseEnter(object sender, EventArgs e)
        {
            s = s + 1;
            if (s == 1)
            {
                MessageBox.Show("Βρίσκεστε στη Βιβλιοθήκη.Για να ανάψετε το φως πατήστε τον διακόπτη πάνω αριστερά.");
            }
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            pictureBox15.Visible = true;
            pictureBox18.Visible = true;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            pictureBox15.Visible = false;
            pictureBox18.Visible = false;
            pictureBox16.Visible = true;
            pictureBox17.Visible = true;
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void pictureBox20_MouseEnter(object sender, EventArgs e)
        {
            c = c + 1;
            if (c == 1)
            {
                MessageBox.Show("Βρίσκεστε στο χώρο του Φωτοτυπικού/Σαρωτικού.Για να χρησιμοποιήσετε το μηχάνημα που βρίσκεται κάτω δεξιά,πατήστε πάνω του.");
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(4);
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(4);
        }

        private void φωτοτυπικόΣαρωτικόΜηχάνημαToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(4);
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(5);
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            pictureBox24.Visible = false;
            pictureBox25.Visible = true;
            panel1.Visible = true;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\ΣΤΕΦΑΝΟΣ\Desktop\ΤελικήΕργασία-ΑΑΥ\beep-08b.wav");
            player.Play();
            pictureBox28.Enabled = true;
     
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            pictureBox24.Visible = true;
            pictureBox25.Visible = false;
            panel1.Visible = false;
            pictureBox28.Enabled = false;

        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            Φωτοτύπηση pform = new Φωτοτύπηση();
            pform.Show();
            ph = ph + 1;
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            Σάρωση sform = new Σάρωση();
            sform.Show();
            sc = sc + 1;
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            if (ph >= 1 | sc >= 1 | pr >= 1)
            {
                MessageBox.Show("Η διαδικασία ξεκίνησε.");
                timer1.Enabled = true;
                ph = 0;
                sc = 0;
                pr = 0;
            }
            else
            {
                MessageBox.Show("Παρακαλώ επιλέξτε μία από τις 3 ενέργειες(Φωτοτύπηση,Σάρωση,Εκτύπωση) και έπειτα πατήστε το Start.");
            }
            
        }

        private void pictureBox22_MouseEnter(object sender, EventArgs e)
        {
            if(ph == 1)
            {
                pictureBox27.Enabled = false;
                pictureBox29.Enabled = false;
            }
            if(sc == 1)
            {
                pictureBox26.Enabled = false;
                pictureBox29.Enabled = false;
            }
            if(pr == 1)
            {
                pictureBox26.Enabled = false;
                pictureBox27.Enabled = false;
            }
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            Εκτύπωση prform = new Εκτύπωση();
            prform.Show();
            pr = pr + 1;
        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Για οποιαδήποτε ενέργεια επιλέγετε τα αντίστοιχα εικονίδια,διαμορφώνετε τις ρυθμίσεις και στη συνέχεια πατάτε το κουμπί Start");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            t = t + 1;
            if (t == 4)
            {
                MessageBox.Show("Η διαδικασία ολοκληρώθηκε");
                timer1.Stop();
                t = 0;
                pictureBox26.Enabled = true;
                pictureBox27.Enabled = true;
                pictureBox29.Enabled = true;
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(6);
        }

        private void ηλεκτρονικήΠαραγγελίαToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(6);
        }

        private void tabPage7_MouseEnter(object sender, EventArgs e)
        {
            x = x + 1;
            if (x == 1)
            {
                MessageBox.Show("Βρίσκεστε στη σελίδα ηλεκτρονικής παραγγελίας βιβλίων.Από εδώ μπορείτε να αναζητήσετε τα αγαπημένα σας βιβλία και να τα αγοράσετε.");
            }
        }

        //Αναζήτηση βιβλίων
        private void pictureBox32_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "Robotics" | textBox1.Text == "robotics" | textBox1.Text == "John Craig" | textBox1.Text == "Robotics John Craig")
            {
                panel3.Visible = false;
                panel4.Visible = false;
                panel5.Visible = false;
                panel6.Visible = false;
                pictureBox38.Visible = true;
                timer2.Enabled = true;
                label7.Text = "Αναζήτηση για : " + textBox1.Text;
            }
            else if(textBox1.Text == "Algorithms" | textBox1.Text == "algorithms" | textBox1.Text == "Thomas Cormen" | textBox1.Text == "Algorithms Thomas Cormen")
            {
                panel3.Visible = false;
                panel4.Visible = false;
                panel5.Visible = false;
                panel6.Visible = false;
                pictureBox38.Visible = true;
                timer3.Enabled = true;
                label7.Text = "Αναζήτηση για : " + textBox1.Text;
            }
            else if(textBox1.Text == "Deep Learning" | textBox1.Text == "deep learning" | textBox1.Text == "Ian Goodfellow" | textBox1.Text == "Deep Learning Ian Goodfellow")
            {
                panel3.Visible = false;
                panel4.Visible = false;
                panel5.Visible = false;
                panel6.Visible = false;
                pictureBox38.Visible = true;
                timer4.Enabled = true;
                label7.Text = "Αναζήτηση για : " + textBox1.Text;
            }
            else if(textBox1.Text == "Design Patterns" | textBox1.Text == "design patterns" | textBox1.Text == "Erich Gamma" | textBox1.Text == "Design Patterns Erich Gamma")
            {
                panel3.Visible = false;
                panel4.Visible = false;
                panel5.Visible = false;
                panel6.Visible = false;
                pictureBox38.Visible = true;
                timer5.Enabled = true;
                label7.Text = "Αναζήτηση για : " + textBox1.Text;
            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("Παρακαλώ εισάγετε το όνομα του βιβλίου ή του συγγραφέα.");
            }
            else
            {
                panel3.Visible = false;
                panel4.Visible = false;
                panel5.Visible = false;
                panel6.Visible = false;
                pictureBox38.Visible = true;
                timer6.Enabled = true;
                label7.Text = "Αρχική σελίδα";
                MessageBox.Show("Δεν βρέθηκαν αποτελέσματα.");
            }
           
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            t2 = t2 + 1;
            if (t2 == 2)
            {
                timer2.Stop();
                pictureBox38.Visible = false;
                panel3.Visible = true;
                panel3.Location = new System.Drawing.Point(252, 174);
                t2 = 0;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            t3 = t3 + 1;
            if (t3 == 2)
            {
                timer3.Stop();
                pictureBox38.Visible = false;
                panel4.Visible = true;
                panel4.Location = new System.Drawing.Point(252, 174);
                t3 = 0;
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            t4 = t4 + 1;
            if (t4 == 2)
            {
                timer4.Stop();
                pictureBox38.Visible = false;
                panel5.Visible = true;
                panel5.Location = new System.Drawing.Point(252, 174);
                t4 = 0;
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            t5 = t5 + 1;
            if (t5 == 2)
            {
                timer5.Stop();
                pictureBox38.Visible = false;
                panel6.Visible = true;
                panel6.Location = new System.Drawing.Point(252, 174);
                t5 = 0;
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            t6 = t6 + 1;
            if (t6 == 3)
            {
                timer6.Stop();
                pictureBox38.Visible = false;
                panel3.Visible = true;
                panel3.Location = new System.Drawing.Point(20, 174);
                panel4.Visible = true;
                panel4.Location = new System.Drawing.Point(252, 174);
                panel5.Visible = true;
                panel5.Location = new System.Drawing.Point(488, 174);
                panel6.Visible = true;
                panel6.Location = new System.Drawing.Point(722, 174);
                textBox1.Clear();
                t6 = 0;
            }
        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {
            label7.Text = "Αρχική σελίδα";
            panel3.Visible = true;
            panel3.Location = new System.Drawing.Point(20, 174);
            panel4.Visible = true;
            panel4.Location = new System.Drawing.Point(252, 174);
            panel5.Visible = true;
            panel5.Location = new System.Drawing.Point(488, 174);
            panel6.Visible = true;
            panel6.Location = new System.Drawing.Point(722, 174);
            textBox1.Clear();
        }

        private void pictureBox39_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void pictureBox40_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(6);
        }

        private void pictureBox33_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(7);
        }

        private void pictureBox42_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(6);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(8);
        }

        private void pictureBox47_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(6);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(9);
        }

        private void pictureBox50_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(6);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(10);
        }

        private void pictureBox53_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(6);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(11);
        }

        private void pictureBox60_MouseEnter(object sender, EventArgs e)
        {
            pictureBox60.Visible = false;
            pictureBox61.Visible = true;
        }

        private void pictureBox61_MouseLeave(object sender, EventArgs e)
        {
            pictureBox60.Visible = true;
            pictureBox61.Visible = false;
        }

        private void pictureBox63_MouseEnter(object sender, EventArgs e)
        {
            pictureBox63.Visible = false;
            pictureBox62.Visible = true;
        }

        private void pictureBox62_MouseLeave(object sender, EventArgs e)
        {
            pictureBox63.Visible = true;
            pictureBox62.Visible = false;
        }

        private void pictureBox66_MouseEnter(object sender, EventArgs e)
        {
            pictureBox66.Visible = false;
            pictureBox64.Visible = true;
        }

        private void pictureBox64_MouseLeave(object sender, EventArgs e)
        {
            pictureBox66.Visible = true;
            pictureBox64.Visible = false;
        }

        private void pictureBox70_MouseEnter(object sender, EventArgs e)
        {
            pictureBox70.Visible = false;
            pictureBox69.Visible = true;
        }

        private void pictureBox69_MouseLeave(object sender, EventArgs e)
        {
            pictureBox70.Visible = true;
            pictureBox69.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(7);
            pictureBox40.Visible = false;
            label16.Visible = false;
            label19.Visible = false;
            panel16.Visible = true;
            panel16.Location = new System.Drawing.Point(0, 180);
            button10.Visible = true;

        }

        private void pictureBox61_Click(object sender, EventArgs e)
        {
            pictureBox40.Visible = true;
            label16.Visible = true;
            label19.Visible = true;
            panel16.Visible = false;
            button10.Visible = false;
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            comboBox1.Text = "       - - - - - - - - - - - - ";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(7);
            pictureBox40.Visible = false;
            label16.Visible = false;
            label19.Visible = false;
            panel17.Visible = true;
            panel17.Location = new System.Drawing.Point(0, 180);
            button10.Visible = true;
        }

        private void pictureBox62_Click(object sender, EventArgs e)
        {
            pictureBox40.Visible = true;
            label16.Visible = true;
            label19.Visible = true;
            panel17.Visible = false;
            button10.Visible = false;
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            comboBox1.Text = "       - - - - - - - - - - - - ";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(7);
            pictureBox40.Visible = false;
            label16.Visible = false;
            label19.Visible = false;
            panel18.Visible = true;
            panel18.Location = new System.Drawing.Point(0, 180);
            button10.Visible = true;
        }

        private void pictureBox64_Click(object sender, EventArgs e)
        {
            pictureBox40.Visible = true;
            label16.Visible = true;
            label19.Visible = true;
            panel18.Visible = false;
            button10.Visible = false;
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            comboBox1.Text = "       - - - - - - - - - - - - ";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(7);
            pictureBox40.Visible = false;
            label16.Visible = false;
            label19.Visible = false;
            panel19.Visible = true;
            panel19.Location = new System.Drawing.Point(0, 180);
            button10.Visible = true;
        }

        private void pictureBox69_Click(object sender, EventArgs e)
        {
            pictureBox40.Visible = true;
            label16.Visible = true;
            label19.Visible = true;
            panel19.Visible = false;
            button10.Visible = false;
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            comboBox1.Text = "       - - - - - - - - - - - - ";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(12);
        }

        private void pictureBox67_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(7);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if(textBox2.Text == "" | textBox3.Text == "" | textBox4.Text == "" | textBox5.Text == "" | textBox6.Text == "" | textBox7.Text == "" | comboBox1.Text == "       - - - - - - - - - - - - ")
            {
                MessageBox.Show("Παρακαλώ συμπληρώστε όλα τα στοιχεία");
            }
            //Μήνυμα υποχρεωτικού πεδίου με κόκκινο χρώμα
            if(textBox2.Text == "")
            {
                label112.Visible = true;
            }
            if(textBox3.Text == "")
            {
                label113.Visible = true;
            }
            if (textBox4.Text == "")
            {
                label114.Visible = true;
            }
            if (textBox5.Text == "")
            {
                label115.Visible = true;
            }
            if (textBox6.Text == "")
            {
                label116.Visible = true;
            }
            if (textBox7.Text == "")
            {
                label117.Visible = true;
            }
            if (comboBox1.Text == "       - - - - - - - - - - - - ")
            {
                label118.Visible = true;
            }
            if (comboBox1.Text == "Πιστωτική κάρτα")
            {
                if(textBox8.Text == "" | textBox9.Text == "")
                {
                    MessageBox.Show("Παρακαλώ συμπληρώστε όλα τα στοιχεία της κάρτας");
                }
                if(textBox8.Text == "")
                {
                    label119.Visible = true;
                }
                if(textBox9.Text == "")
                {
                    label120.Visible = true;
                }
                else
                {
                    MessageBox.Show("Η παραγγελία σας κατοχυρώθηκε με επιτυχία!");
                    tabControl1.SelectTab(6);
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox7.Clear();
                    textBox8.Clear();
                    textBox9.Clear();
                    comboBox1.Text = "       - - - - - - - - - - - - ";
                    //Εξαφάνιση του μηνύματος για το υποχρεωτικό πεδίο
                    label112.Visible = false;
                    label113.Visible = false;
                    label114.Visible = false;
                    label115.Visible = false;
                    label116.Visible = false;
                    label117.Visible = false;
                    label118.Visible = false;
                    label119.Visible = false;
                    label120.Visible = false;
                    //Μεταφορά στην Αρχική σελίδα
                    panel3.Visible = true;
                    panel3.Location = new System.Drawing.Point(20, 174);
                    panel4.Visible = true;
                    panel4.Location = new System.Drawing.Point(252, 174);
                    panel5.Visible = true;
                    panel5.Location = new System.Drawing.Point(488, 174);
                    panel6.Visible = true;
                    panel6.Location = new System.Drawing.Point(722, 174);
                    label7.Text = "Αρχική σελίδα";
                    textBox1.Clear();
                    //Άδειασμα καλαθιού αγοράς
                    pictureBox40.Visible = true;
                    label16.Visible = true;
                    label19.Visible = true;
                    panel16.Visible = false;
                    panel17.Visible = false;
                    panel18.Visible = false;
                    panel19.Visible = false;
                    button10.Visible = false;
                }
            }
            if (comboBox1.Text == "Αντικαταβολή")
            {
                MessageBox.Show("Η παραγγελία σας κατοχυρώθηκε με επιτυχία!");
                tabControl1.SelectTab(6);
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
                textBox9.Clear();
                comboBox1.Text = "       - - - - - - - - - - - - ";
                //Εξαφάνιση του μηνύματος για το υποχρεωτικό πεδίο
                label112.Visible = false;
                label113.Visible = false;
                label114.Visible = false;
                label115.Visible = false;
                label116.Visible = false;
                label117.Visible = false;
                label118.Visible = false;
                label119.Visible = false;
                label120.Visible = false;
                //Μεταφορά στην Αρχική σελίδα
                panel3.Visible = true;
                panel3.Location = new System.Drawing.Point(20, 174);
                panel4.Visible = true;
                panel4.Location = new System.Drawing.Point(252, 174);
                panel5.Visible = true;
                panel5.Location = new System.Drawing.Point(488, 174);
                panel6.Visible = true;
                panel6.Location = new System.Drawing.Point(722, 174);
                label7.Text = "Αρχική σελίδα";
                textBox1.Clear();
                //Άδειασμα καλαθιού αγοράς
                pictureBox40.Visible = true;
                label16.Visible = true;
                label19.Visible = true;
                panel16.Visible = false;
                panel17.Visible = false;
                panel18.Visible = false;
                panel19.Visible = false;
                button10.Visible = false;
            }
        }

        private void tabPage13_MouseEnter(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Πιστωτική κάρτα")
            {
                label109.Visible = true;
                label110.Visible = true;
                label111.Visible = true;
                textBox8.Visible = true;
                textBox9.Visible = true;
                pictureBox72.Visible = true;
            }
            else
            {
                label109.Visible = false;
                label110.Visible = false;
                label111.Visible = false;
                textBox8.Visible = false;
                textBox9.Visible = false;
                pictureBox72.Visible = false;
            }

            //Εξαφάνιση του μηνύματος για το υποχρεωτικό πεδίο
            if (textBox2.Text != "")
            {
                label112.Visible = false;
            }
            if (textBox3.Text != "")
            {
                label113.Visible = false;
            }
            if (textBox4.Text != "")
            {
                label114.Visible = false;
            }
            if (textBox5.Text != "")
            {
                label115.Visible = false;
            }
            if (textBox6.Text != "")
            {
                label116.Visible = false;
            }
            if (textBox7.Text != "")
            {
                label117.Visible = false;
            }
            if (comboBox1.Text != "       - - - - - - - - - - - - ")
            {
                label118.Visible = false;
            }
            if (textBox8.Text != "")
            {
                label119.Visible = false;
            }
            if (textBox9.Text != "")
            {
                label120.Visible = false;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(13);
        }

        private void καφετέριαToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(13);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(13);
        }

        private void pictureBox76_MouseEnter(object sender, EventArgs e)
        {
            r = r + 1;
            if (r == 1)
            {
                MessageBox.Show("Βρίσκεστε στην καφετέρεια.Για να ανάψετε το φως πατήστε τον διακόπτη πάνω αριστερά και για να καθήσετε πατήστε το βελάκι.");
            }
        }

        private void pictureBox77_Click(object sender, EventArgs e)
        {
            pictureBox78.Visible = true;
            pictureBox76.Visible = false;
            pictureBox74.Visible = true;
            pictureBox75.Visible = true;
        }

        private void pictureBox78_Click(object sender, EventArgs e)
        {
            pictureBox78.Visible = false;
            pictureBox76.Visible = true;
            pictureBox74.Visible = false;
            pictureBox75.Visible = false;
        }

        private void pictureBox79_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void pictureBox75_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(14);
        }

        private void button12_MouseEnter(object sender, EventArgs e)
        {
            button12.BackColor = Color.Black;
            button12.ForeColor = Color.White;
        }

        private void button12_MouseLeave(object sender, EventArgs e)
        {
            button12.BackColor = Color.White;
            button12.ForeColor = Color.Black;
        }

        private void pictureBox81_Click(object sender, EventArgs e)
        {
            Μενού menuform = new Μενού();
            menuform.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(15);
            label123.Text = "Το συνολικό κόστος" + Environment.NewLine + "είναι : " + chcost + "€.";
        }

        private void pictureBox80_MouseEnter(object sender, EventArgs e)
        {
            if(Μενού.ch1 == true)
            {
                pictureBox82.Visible = true;
                pictureBox81.Visible = false;
                button12.Enabled = true;
                ch1cost = 2.00;
            }
            else
            {
                ch1cost = 0.00;
            }
            if(Μενού.ch2 == true)
            {
                pictureBox83.Visible = true;
                pictureBox81.Visible = false;
                button12.Enabled = true;
                ch2cost = 1.60;
            }
            else
            {
                ch2cost = 0.00;
            }
            if(Μενού.ch3 == true)
            {
                pictureBox84.Visible = true;
                pictureBox81.Visible = false;
                button12.Enabled = true;
                ch3cost = 1.50;
            }
            else
            {
                ch3cost = 0.00;
            }
            if(Μενού.ch6 == true)
            {
                pictureBox85.Visible = true;
                pictureBox81.Visible = false;
                button12.Enabled = true;
                ch6cost = 0.60;
            }
            else
            {
                ch6cost = 0.00;
            }
            if(Μενού.ch5 == true)
            {
                pictureBox86.Visible = true;
                pictureBox81.Visible = false;
                button12.Enabled = true;
                ch5cost = 1.50;
            }
            else
            {
                ch5cost = 0.00;
            }
            if(Μενού.ch4 == true)
            {
                pictureBox87.Visible = true;
                pictureBox81.Visible = false;
                button12.Enabled = true;
                ch6cost = 1.60;
            }
            else
            {
                ch4cost = 0.00;
            }
            chcost = ch1cost + ch2cost + ch3cost + ch4cost + ch5cost + ch6cost;
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != ',');
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox10.Text == "")
            {
                MessageBox.Show("Παρακαλώ συμπληρώστε το απαιτούμενο ποσό.");
            }
            else if(Convert.ToDouble(textBox10.Text) < chcost)
            {
                MessageBox.Show("Το απαιτούμενο ποσό δεν έχει συμπληρωθεί.");
            }
            else if(Convert.ToDouble(textBox10.Text) == chcost)
            {
                MessageBox.Show("Το απαιτούμενο ποσό συμπληρώθηκε.");
                label123.Text = "Καλή συνέχεια!";
                timer7.Enabled = true;  
            }
            else
            {
                MessageBox.Show("Το απαιτούμενο συμπληρώθηκε και έχετε και ρέστα.");
                chchange = Convert.ToDouble(textBox10.Text) - chcost;
                label123.Text = "Τα ρέστα σας είναι :" + Environment.NewLine + chchange + "€." + "Καλή συνέχεια!";
                timer7.Enabled = true;
            }
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            t7 = t7 + 1;
            if(t7 == 2)
            {
                timer7.Stop();
                MessageBox.Show("Μεταφέρεστε αυτόματα στην Αρχική σελίδα.");
                Μενού.ch1 = false;
                Μενού.ch2 = false;
                Μενού.ch3 = false;
                Μενού.ch4 = false;
                Μενού.ch5 = false;
                Μενού.ch6 = false;
                button12.Enabled = false;
                pictureBox81.Visible = true;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
                textBox10.Clear();
                tabControl1.SelectTab(1);
                t7 = 0;
            }
        }

        private void button14_MouseEnter(object sender, EventArgs e)
        {
            button14.BackColor = Color.Black;
            button14.ForeColor = Color.White;
        }

        private void button14_MouseLeave(object sender, EventArgs e)
        {
            button14.BackColor = Color.White;
            button14.ForeColor = Color.Black;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox91_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            pictureBox91.Visible = false;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            pictureBox91.Visible = true;  
        }

        private void label126_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void pictureBox92_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            panel21.Visible = true;
            panel22.Visible = false;
            panel23.Visible = false;
            panel24.Visible = false;
            panel25.Visible = false;
            panel26.Visible = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            panel21.Visible = true;
            panel22.Visible = true;
            panel23.Visible = false;
            panel24.Visible = false;
            panel25.Visible = false;
            panel26.Visible = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl1.SelectTab(4);
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl1.SelectTab(13);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            panel21.Visible = false;
            panel22.Visible = true;
            panel23.Visible = true;
            panel24.Visible = false;
            panel25.Visible = false;
            panel26.Visible = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            panel21.Visible = false;
            panel22.Visible = false;
            panel23.Visible = true;
            panel24.Visible = true;
            panel25.Visible = false;
            panel26.Visible = false;
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl1.SelectTab(3);
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl1.SelectTab(6);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            panel21.Visible = false;
            panel22.Visible = false;
            panel23.Visible = true;
            panel24.Visible = true;
            panel25.Visible = true;
            panel26.Visible = false;
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl1.SelectTab(2);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            panel21.Visible = false;
            panel22.Visible = false;
            panel23.Visible = true;
            panel24.Visible = true;
            panel25.Visible = true;
            panel26.Visible = true;
        }
    }
}