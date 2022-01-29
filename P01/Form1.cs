using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     

        private void button10_Click(object sender, EventArgs e)
        {
            string zprava = "";
            foreach (char pis in textBox1.Text)
            {
                if (pis != ' ' && pis != '!' && pis != '?' && pis != ',' && pis != '.')
                    zprava += (char)(pis + 3);
                else zprava += pis;
            }
            MessageBox.Show(zprava);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string pismena = "QERTYUIOPASDFGHJKLZXCVBNM .,?!";
            int i = 0;
            foreach (Control ctrl in panel1.Controls)
            {
                if (ctrl is Button) (ctrl as Button).Text = pismena[i].ToString();
                i++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }
    }
}
