using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace String_Metodlari_2
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kelime = textBox1.Text;

            
            int a = kelime.Split(' ').Length; /* boşluk karakterine göre kesme işlemi yaptık 
                                               * ve kesilen kelime sayısınıda length özelliği ile öğrendik. */

            label3.Text = a.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string kelime2 = textBox2.Text;

            string[] parça; // Sınırları belli olmayan dizi tanımladık

            parça = kelime2.Split(' '); // boşluk karakterine göre parçaladık ve kelimeleri diziye atadık.

            for (int i = 0; i < parça.Length; i++)
            {
                listBox1.Items.Add(parça[i].ToString());  // listboxa kelimeleri yazdırdık.
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            string kelime3 = textBox3.Text;

            string[] parça2;

            parça2=kelime3.Split(' ',','); // farklı karakterlere göre bölme işlemi yaptırdık.

            for (int i = 0; i < parça2.Length; i++)
            {
                listBox2.Items.Add(parça2[i].ToString());
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] parça3;

            char[] karakterler = {' ', ','}; // karakterlerimizi bir diziye atadık

            parça3 = textBox4.Text.Split(karakterler); // dizimizi parametre göstererek bölme işlemi yaptırdık.


            for (int i = 0; i < parça3.Length; i++)
            {
                listBox3.Items.Add(parça3[i].ToString());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string[] parça4;

            char[] karakterler2 = { ' ', ',' };

            parça4 = textBox5.Text.Split(karakterler2,StringSplitOptions.RemoveEmptyEntries); // yazmış olduğumuz kod ile boşluk olan ifadeyi kelime olarak almayı önledik.

            for (int i = 0; i < parça4.Length; i++)
            {
                listBox4.Items.Add(parça4[i].ToString());
            }

        }
    }
}
