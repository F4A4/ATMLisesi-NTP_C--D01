using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IlkProjem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                            MessageBox.Show("Hoşgeldiniz"); //mesaj box ta metin görüntüledik.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "butona basıldı"; textbox'ın text özelliğini değiştirdik.
            MessageBox.Show("hoşgeldin " + textBox1.Text); 
            //textbox'ın text özelliği (property'si)
            //string tipinde olduğu için herhangi bir tipe dönüştürmek zorunda kalmadık.
            //Çünkü messageBox yalnızca string gibi metinsel ifadeleri görüntüler. 
        }

        private void Form1_KapandiktanSonra(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Güle güle..");
        }
        
        //private void MouseFormUzerineGelince(object sender, EventArgs e)
        //{
        //    MessageBox.Show("Gıdıklandım");
        //}
    }
}
