using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChordGenerator
{
    public partial class Form1 : Form
    {
        class global
        {
            public static string[,] datachord = new string[24, 3] {
                { "C", "Major", "C-Major.jpg" },
                { "C", "Minor", "C-Minor.jpg" },
                { "Db", "Major", "Db-Major.jpg" },
                { "Db", "Minor", "Db-Minor.jpg" },
                { "D", "Major", "D-Major.jpg" },
                { "D", "Minor", "D-Minor.jpg" },
                { "Eb", "Major", "Eb-Major.jpg" },
                { "Eb", "Minor", "Eb-Minor.jpg" },
                { "E", "Major", "E-Major.jpg" },
                { "E", "Minor", "E-Minor.jpg" },
                { "F", "Major", "F-Major.jpg" },
                { "F", "Minor", "F-Minor.jpg" },
                { "F#", "Major", "F#-Major.jpg" },
                { "F#", "Minor", "F#-Minor.jpg" },
                { "G", "Major", "G-Major.jpg" },
                { "G", "Minor", "G-Minor.jpg" },
                { "Ab", "Major", "Ab-Major.jpg" },
                { "Ab", "Minor", "Ab-Minor.jpg" },
                { "A", "Major", "A-Major.jpg" },
                { "A", "Minor", "A-Minor.jpg" },
                { "Bb", "Major", "Bb-Major.jpg" },
                { "Bb", "Minor", "Bb-Minor.jpg" },
                { "B", "Major", "B-Major.jpg" },
                { "B", "Minor", "B-Minor.jpg" } };
        }
        class chord
        {
            
            private string chord1;
            private string chord2;

            public void setchord1(string val)
            {
                this.chord1 = val;
            }
            public string getchord1()
            {
                return chord1;
            }
            public void setchord2(string val)
            {
                this.chord2 = val;
            }
            public string getchord2()
            {
                return chord2;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile (@"Chord Picture\Default-Image.jpg");
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Chord value is not completed");return;
            }
            if (comboBox2.Text == "")
            {
                MessageBox.Show("Chord value is not completed"); return;
            }
            chord finalchord = new chord();
            finalchord.setchord1(comboBox1.SelectedItem.ToString());
            finalchord.setchord2(comboBox2.SelectedItem.ToString());
            string switch1 = finalchord.getchord1();
            string switch2 = finalchord.getchord2();
            int konter = 0;
            for (konter = 0; konter <= 24; konter ++)
            {
                if (global.datachord[konter,0] == switch1 && global.datachord[konter,1] == switch2)
                    {
                    pictureBox1.Image = Image.FromFile(@"Chord Picture\"+ global.datachord[konter,2]); break;
                }
            }
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"Chord Picture\Default-Image.jpg");
            comboBox1.Text = "";
            comboBox2.Text = "";
        }
    }
}
