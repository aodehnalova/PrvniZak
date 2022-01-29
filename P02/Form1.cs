using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string pismena = "0123456789";
            int i = 0;
            foreach (Control ctrl in panel1.Controls)
            {
                if (ctrl is Button) (ctrl as Button).Text = pismena[i].ToString();
                i++;
            }
        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            int  cifra = (sender as Button).Text[0] - 48;
            string[] morseovka = { "-----", ".----", "..---", "...--", "....-", ".....", "-....", "--...", "---..", "-----." };
            textBox1.Text += morseovka[cifra]+" ";
        }
    }
}
