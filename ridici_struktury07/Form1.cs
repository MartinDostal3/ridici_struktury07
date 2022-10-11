using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ridici_struktury07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random rnd = new Random();
            int n = int.Parse(textBox1.Text);
            for(int i = 0; i < n; i++)
            {
                int nc = rnd.Next(-10, 51);
                listBox1.Items.Add(nc);

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool obsahuje = false;
            for(int i = 0; i < listBox1.Items.Count && !obsahuje; i++)
            {
                int cislo = int.Parse(listBox1.Items[i].ToString());
                if(cislo >= 20 && cislo <= 25)
                {
                    obsahuje = true;
                }
            }
            if(obsahuje)
            {
                MessageBox.Show("Ano, posloupnost obsahuje cislo z intervalu (20;25>.");
            }
            else
            {
                MessageBox.Show("Ne, posloupnost neobsahuje cislo z intervalu (20;25>.");
            }
        }
    }
}
