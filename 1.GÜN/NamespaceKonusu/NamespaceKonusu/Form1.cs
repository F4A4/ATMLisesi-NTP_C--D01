using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MatematikselIslemler;
using NamespaceKonusu;
using yenideneme;

namespace NamespaceKonusu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Toplama.Islem();
            GorselIslemler.Efekt.Islem();

            Class3.ders();
            Sinavar.gece.ders();

        }
    }
}
