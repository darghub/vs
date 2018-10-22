using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        double a, b; char op;
        public Form1()
        {
            InitializeComponent();
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            b = Convert.ToDouble(affichage.Text);
            switch (op)
            {
                case '+': affichage.Text = "La somme de " + a + " et  " + b + " est : " + Convert.ToString(a + b); break;
                case '-': affichage.Text = Convert.ToString(a - b); break;
                case '*': affichage.Text = Convert.ToString(a * b); break;
                case '/': affichage.Text = Convert.ToString(a / b); break;


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            affichage.Text = affichage.Text + Convert.ToString(button1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            affichage.Text = affichage.Text + Convert.ToString(button2.Text);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            affichage.Text = affichage.Text + Convert.ToString(button3.Text);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            affichage.Text = affichage.Text + Convert.ToString(button4.Text);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            affichage.Text = affichage.Text + Convert.ToString(button5.Text);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            affichage.Text = affichage.Text + Convert.ToString(button6.Text);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            affichage.Text = affichage.Text + Convert.ToString(button7.Text);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            affichage.Text = affichage.Text + Convert.ToString(button8.Text);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            affichage.Text = affichage.Text + Convert.ToString(button9.Text);

        }

        private void button11_Click(object sender, EventArgs e)
        {
            affichage.Text = affichage.Text + Convert.ToString(button11.Text);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            // affichage.Text = affichage.Text + button13.Text;
            a = Convert.ToDouble(affichage.Text);
            affichage.Text = "";
            op = '+';
        }

        private void button12_Click(object sender, EventArgs e)
        {
            affichage.Text = "";

        }

        private void button18_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(affichage.Text);
            affichage.Text = "";
            op = '-';
        }

        private void button15_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(affichage.Text);
            affichage.Text = "";
            op = '*';
        }

        private void button19_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(affichage.Text);
            affichage.Text = "";
            op = '/';
        }




        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(affichage.Text);
                if (a % 2 == 0)
                    affichage.Text = "Le nombre " + a + " est paire";
                else
                    affichage.Text = "Le nombre " + a + " est impaire";
            }
            catch
            {
                affichage.Text = " Effacer l'ecran et saisir le nbr";

            }
        }
    
}}
