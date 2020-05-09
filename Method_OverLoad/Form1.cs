using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Method_OverLoad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Metin");
            MessageBox.Show("Metin", "Başlık");
            MessageBox.Show("Metin", "Başlık", MessageBoxButtons.YesNo);
            MessageBox.Show("Metin", "Başlık", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }
        
        void Mesaj()
        {
            MessageBox.Show("Hello.");
        }

        void Mesaj(string str)
        {
            MessageBox.Show(str);
        }

        void Mesaj(string p, string n)
        {
            MessageBox.Show(p, n);
        }

        void Mesaj(string text, int sayi)
        {
            MessageBox.Show(text + sayi);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mesaj();
            Mesaj("Metin");
            Mesaj("Metin", "Başlık");
            Mesaj("Metin", 2);
        }
    }
}
// Method imzası: Methodun ismi, parametresi veya parametre adedidir.
// Metot isimleri aynı olabilir.(Parametrelerinin tipleri veya parametre sayıları        farklı olmak şartıyla). Bu işleme overload denir. Method, overload method olarak      versiyonlanmaktadır.