using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            double soucet = 0;
            int pocet = 0;
            int pocitadlo = 1;
            foreach (Control ctrl in panel1.Controls)
            {
                if (ctrl is TextBox)
                {
                    int cislo = rnd.Next(5, 21);
                    (ctrl as TextBox).Text = cislo.ToString();
                    if (cislo % 7 == 0)
                    {
                        soucet += cislo;
                        pocet++;
                    }
                }
                else if (ctrl is RadioButton) (ctrl as RadioButton).Enabled = !(ctrl as RadioButton).Enabled;
                
                else
                {
                    if(ctrl is Button)
                    {
                        (ctrl as Button).Text = "T" + pocitadlo;
                        pocitadlo++;
                    }
                }
            }
            if (pocet == 0) label1.Text = "Žádné číslo není dělitelné 7";
            else label1.Text = (soucet / pocet).ToString();
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Lines[0]);
            int y = Convert.ToInt32(textBox1.Lines[1]);
            int soucin = x * y;
            while (x != y)
            {
                if (x > y) x -= y;
                else y -= x;
            }
            MessageBox.Show("NSD je " + x+Environment.NewLine+"NSN je "+soucin/x);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //druhy
            int soucet = 0;
            int pocet = 0;
            foreach (string radek in textBox1.Lines)
            {
                int cislo = Convert.ToInt32(radek);
                int c = cislo;
                if (cislo % 2 != 0)
                {
                    int cif = 0;
                    while (c > 0)
                    {
                        cif += c % 10;
                        c /= 10;
                    }
                    if (cif % 2 == 0)
                    {
                        soucet += cislo;
                        pocet++;
                    }
                }
            }
            label1.Text = " Součet je " + soucet + " Počet je " + pocet;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Lines[2]);
            Random rnd = new Random();
            for (int i = 0; i<n; i++)
            {
                double cislo = rnd.NextDouble() * 2000 - 1000;
                listBox1.Items.Add(cislo);
                //////
            }
        }
    }
}
