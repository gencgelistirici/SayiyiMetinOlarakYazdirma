using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayiyiMetinOlarakYazdirma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSonuc_Click(object sender, EventArgs e)
        {
       
            try
            {
                int[] sayibasamaklari = new int[4];
                int i = 0;
                string metin = "";
                string[] bsmk = { "birler", "onlar", "yüzler", "binler" };
                string[,] basamaklarstring = { { "", "bir", "iki", "üç", "dört", "beş", "altı", "yedi", "sekiz", "dokuz" }, { "", "on", "yirmi", "otuz", "kırk", "elli", "altmış", "yetmiş", "seksen", "doksan" }, { "", "yüz", "iki yüz", "üç yüz", "dört yüz", "beş yüz", "altı yüz", "yedi yüz", "sekiz yüz", "dokuz yüz" }, { "", "bin", "iki bin", "üç bin", "dört bin", "beş bin", "altı bin", "yedi bin", "sekiz bin", "dokuz bin" } };
                int[] basamaklarint = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                int sayi = Convert.ToInt32(textBox1.Text);
                while (sayi > 0)
                {
                    sayibasamaklari[i] = sayi % 10;
                    listBox1.Items.Add(bsmk[i]+" basamağı:"+sayibasamaklari[i]);
                    sayi = sayi / 10;
                    i++;
                }
                for (i = sayibasamaklari.Length - 1; i >= 0; i--)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (sayibasamaklari[i] == basamaklarint[j])
                        {
                            metin += basamaklarstring[i, j] + " ";
                        }
                    }
                }
                lblsonuc.Text = metin;
            }
            catch (Exception)
            {
                listBox1.Items.Clear();
                string metin = textBox1.Text;
                bool durum = true;
                for (int i = 0; i < metin.Length; i++)
                {
                    if (Char.IsLetter(metin[i]))
                    {
                        MessageBox.Show("Lütfen sayı girişi yapınız");
                        durum = false;
                        break;
                    }
                }

                if (durum==true && metin.Length> 4)
                {
                    MessageBox.Show("Lütfen en az 4 basamaklı sayıları girerek işlem yapınız");
                }
            }
        }
    }
}
