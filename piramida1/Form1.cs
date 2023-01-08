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
    public partial class sd : Form
    {
        public sd()
        {
            InitializeComponent();
        }
        int produkt1;
        int kaloria;
        double suma=0;
        private int clickCounter = 0;
        private void button1_Click(object sender, EventArgs e)//losowanie i baza produktów
        {
            Random random = new Random();
            produkt1 = random.Next(1, 42);

            switch (produkt1)
            {
                case 1:
                    customPictureBox1.ImageLocation = "C:\\Users\\rysio\\Desktop\\proba_01\\piramida1\\baza_produktów\\czekolada.jpg";
                    kaloria = 545;
                    break;
                case 2:
                    customPictureBox1.ImageLocation = "C:\\Users\\rysio\\Desktop\\proba_01\\piramida1\\baza_produktów\\cukierki.jpg";
                    kaloria = 535;
                    break;
                case 3:
                    customPictureBox1.ImageLocation = "C:\\Users\\rysio\\Desktop\\proba_01\\piramida1\\baza_produktów\\paluszki.jpg";
                    kaloria = 412;
                    break;
                case 4:
                    customPictureBox1.ImageLocation = "C:\\Users\\rysio\\Desktop\\proba_01\\piramida1\\baza_produktów\\chipsy.jpg";
                    kaloria = 536;
                    break;
                case 5:
                    customPictureBox1.ImageLocation = "C:\\Users\\rysio\\Desktop\\proba_01\\piramida1\\baza_produktów\\orzeszki.jpg";
                    kaloria = 567;
                    break;
                case 6:
                    customPictureBox1.ImageLocation = "C:\\Users\\rysio\\Desktop\\proba_01\\piramida1\\baza_produktów\\guma_do_żucia.jpg";
                    kaloria = 360;
                    break;
                case 7:
                    customPictureBox1.ImageLocation = "C:\\Users\\rysio\\Desktop\\proba_01\\piramida1\\baza_produktów\\cola.jpg";
                    kaloria = 42;
                    break;
                case 8:
                    customPictureBox1.ImageLocation = "C:\\Users\\rysio\\Desktop\\proba_01\\piramida1\\baza_produktów\\mleko.jpg";
                    kaloria = 51;
                    break;
                case 9:
                    customPictureBox1.ImageLocation = "C:\\Users\\rysio\\Desktop\\proba_01\\piramida1\\baza_produktów\\twarog.jpg";
                    kaloria = 133;
                    break;
                case 10:
                    customPictureBox1.ImageLocation = "C:\\Users\\rysio\\Desktop\\proba_01\\piramida1\\baza_produktów\\ser_zolty.jpg";
                    kaloria = 357;
                    break;
                case 11:
                    customPictureBox1.ImageLocation = "C:\\Users\\rysio\\Desktop\\proba_01\\piramida1\\baza_produktów\\mozarella.jpg";
                    kaloria = 254;
                    break;
                case 12:
                    customPictureBox1.ImageLocation = "C:\\Users\\rysio\\Desktop\\proba_01\\piramida1\\baza_produktów\\serek_wiejski.jpg";
                    kaloria = 97;
                    break;
                case 13:
                    customPictureBox1.ImageLocation = "C:\\Users\\rysio\\Desktop\\proba_01\\piramida1\\baza_produktów\\almette.jpg";
                    kaloria = 233;
                    break;
                case 14:
                    customPictureBox1.ImageLocation = "C:\\Users\\rysio\\Desktop\\proba_01\\piramida1\\baza_produktów\\kurczak.jpg";
                    kaloria = 158;
                    break;
                case 15:
                    customPictureBox1.ImageLocation = "C:\\Users\\rysio\\Desktop\\proba_01\\piramida1\\baza_produktów\\schabowy.jpg";
                    kaloria = 174;
                    break;
                case 16:
                    customPictureBox1.ImageLocation = "C:\\Users\\rysio\\Desktop\\proba_01\\piramida1\\baza_produktów\\filet_rybny.jpg";
                    kaloria = 78;
                    break;
                case 17:
                    customPictureBox1.ImageLocation = "C:\\Users\\rysio\\Desktop\\proba_01\\piramida1\\baza_produktów\\sucha_krakowska.jpg";
                    kaloria = 326;
                    break;
                case 18:
                    customPictureBox1.ImageLocation = "C:\\Users\\rysio\\Desktop\\proba_01\\piramida1\\baza_produktów\\jajka.jpg";
                    kaloria = 155;
                    break;
                case 19:
                    customPictureBox1.ImageLocation = "C:\\Users\\rysio\\Desktop\\proba_01\\piramida1\\baza_produktów\\salami.jpg";
                    kaloria = 336;
                    break;
                case 20:
                    customPictureBox1.ImageLocation = "C:\\Users\\rysio\\Desktop\\proba_01\\piramida1\\baza_produktów\\olej_slonecznikowy.jpg";
                    kaloria = 884;
                    break;
                case 21:
                    customPictureBox1.ImageLocation = "C:\\Users\\rysio\\Desktop\\proba_01\\piramida1\\baza_produktów\\olej_rzepakowy.jpg";
                    kaloria = 900;
                    break;
                case 22:
                    customPictureBox1.ImageLocation = "C:\\Users\\rysio\\Desktop\\proba_01\\piramida1\\baza_produktów\\tran.jpg";
                    kaloria = 900;
                    break;
                case 23:
                    customPictureBox1.ImageLocation = "C:\\Users\\rysio\\Desktop\\proba_01\\piramida1\\baza_produktów\\maslo.jpg";
                    kaloria = 721;
                    break;
                case 24:
                    customPictureBox1.ImageLocation = "C:\\Users\\rysio\\Desktop\\proba_01\\piramida1\\baza_produktów\\chleb_wieloziarnisty.jpg";
                    kaloria = 262;
                    break;
                case 25:
                    customPictureBox1.ImageLocation = "C:\\Users\\rysio\\Desktop\\proba_01\\piramida1\\baza_produktów\\bulka.jpg";
                    kaloria = 310;
                    break;
                case 26:
                    customPictureBox1.ImageLocation = "C:\\Users\\rysio\\Desktop\\proba_01\\piramida1\\baza_produktów\\ziemniaki.jpg";
                    kaloria = 77;
                    break;
                case 27:
                    customPictureBox1.ImageLocation = "C:\\Users\\rysio\\Desktop\\proba_01\\piramida1\\baza_produktów\\marchew.jpg";
                    kaloria = 27;
                    break;
                case 28:
                    customPictureBox1.ImageLocation = "C:\\Users\\rysio\\Desktop\\proba_01\\piramida1\\baza_produktów\\kalafior.jpg";
                    kaloria = 22;
                    break;
                case 29:
                    customPictureBox1.ImageLocation = "C:\\Users\\rysio\\Desktop\\proba_01\\piramida1\\baza_produktów\\jablko.jpg";
                    kaloria = 52;
                    break;
                case 30:
                    customPictureBox1.ImageLocation = "C:\\Users\\rysio\\Desktop\\proba_01\\piramida1\\baza_produktów\\kukurydza.jpg";
                    kaloria = 102;
                    break;
                case 31:
                    customPictureBox1.ImageLocation = "C:\\Users\\rysio\\Desktop\\proba_01\\piramida1\\baza_produktów\\pietruszka.jpg";
                    kaloria = 38;
                    break;
                case 32:
                    customPictureBox1.ImageLocation = "C:\\Users\\rysio\\Desktop\\proba_01\\piramida1\\baza_produktów\\pomidor.jpg";
                    kaloria = 15;
                    break;
                case 33:
                    customPictureBox1.ImageLocation = "C:\\Users\\rysio\\Desktop\\proba_01\\piramida1\\baza_produktów\\banany.jpg";
                    kaloria = 95;
                    break;
                case 34:
                    customPictureBox1.ImageLocation = "C:\\Users\\rysio\\Desktop\\proba_01\\piramida1\\baza_produktów\\śliwka.jpg";
                    kaloria = 45;
                    break;
                case 35:
                    customPictureBox1.ImageLocation = "C:\\Users\\rysio\\Desktop\\proba_01\\piramida1\\baza_produktów\\winogrono.jpg";
                    kaloria = 69;
                    break;
                case 36:
                    customPictureBox1.ImageLocation = "C:\\Users\\rysio\\Desktop\\proba_01\\piramida1\\baza_produktów\\dzem.jpg";
                    kaloria = 278;
                    break;
                case 37:
                    customPictureBox1.ImageLocation = "C:\\Users\\rysio\\Desktop\\proba_01\\piramida1\\baza_produktów\\sok_pomaranczowy.jpg";
                    kaloria = 45;
                    break;
                case 38:
                    customPictureBox1.ImageLocation = "C:\\Users\\rysio\\Desktop\\proba_01\\piramida1\\baza_produktów\\sok_jablkowy.jpg";
                    kaloria = 45;
                    break;
                case 39:
                    customPictureBox1.ImageLocation = "C:\\Users\\rysio\\Desktop\\proba_01\\piramida1\\baza_produktów\\woda.jpg";
                    kaloria = 0;
                    break;
                case 40:
                    customPictureBox1.ImageLocation = "C:\\Users\\rysio\\Desktop\\proba_01\\piramida1\\baza_produktów\\bioszot.jpg";
                    kaloria = 33;
                    break;
                case 41:
                    customPictureBox1.ImageLocation = "C:\\Users\\rysio\\Desktop\\proba_01\\piramida1\\baza_produktów\\izotonik.jpg";
                    kaloria = 24;
                    break;
            }



            this.clickCounter++;
            if (this.clickCounter > 6) // arbitrary number
            {
                suma = 0;
                this.clickCounter = 0;
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


        private void score_Click(object sender, EventArgs e)//licznik punktow
        {

                double liczba;
                double punkty = 0;
 
            
                liczba = Convert.ToDouble(textBox1.Text);
                if (liczba == kaloria)
                {
                    punkty = 10;
                    suma = punkty + suma;
                    label4.Text = Convert.ToString(suma);
                }

                if (liczba > (kaloria - (kaloria / 10)) && liczba < (kaloria + (kaloria / 10)) && liczba != kaloria)
                {
                    punkty = 5;
                    suma = punkty + suma;
                    label4.Text = Convert.ToString(suma);
                }
            
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
    }
    
    

