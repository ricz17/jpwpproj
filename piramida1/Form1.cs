using CustomPictureBoxControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace piramida1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int produkt1;
        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            produkt1 = random.Next(1, 7);

            switch (produkt1)
            {
                case 1:
                    customPictureBox1.ImageLocation = "C:\\Users\\rysio\\Desktop\\proba_01\\piramida1\\baza_produktów\\bulka.jpg";
                    break;
                case 2:
                    customPictureBox1.ImageLocation = "C:\\Users\\rysio\\Desktop\\proba_01\\piramida1\\baza_produktów\\dzem.jpg";
                    break;
                case 3:
                    customPictureBox1.ImageLocation = "C:\\Users\\rysio\\Desktop\\proba_01\\piramida1\\baza_produktów\\marchew.jpg";
                    break;
                case 4:
                    customPictureBox1.ImageLocation = "C:\\Users\\rysio\\Desktop\\proba_01\\piramida1\\baza_produktów\\kalafior.jpg";
                    break;
                case 5:
                    customPictureBox1.ImageLocation = "C:\\Users\\rysio\\Desktop\\proba_01\\piramida1\\baza_produktów\\kurczak.jpg";
                    break;
                case 6:
                    customPictureBox1.ImageLocation = "C:\\Users\\rysio\\Desktop\\proba_01\\piramida1\\baza_produktów\\mleko.jpg";
                    break;
            }
        }

        private void customPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
    }
    
    

