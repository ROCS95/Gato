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
        public Form1()
        {
            InitializeComponent();
        }
        int turno;

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.turno = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button boton = sender as Button;
            this.jugar(boton);
        }

        private void jugar(Button boton)
        {
            if (turno%2 != 0)
            {
                boton.Text = "X";
                turno++;
            }
            else
            {
                boton.Text = "O";
                turno++;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button boton = sender as Button;
            this.jugar(boton);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button boton = sender as Button;
            this.jugar(boton);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button boton = sender as Button;
            this.jugar(boton);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button boton = sender as Button;
            this.jugar(boton);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button boton = sender as Button;
            this.jugar(boton);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button boton = sender as Button;
            this.jugar(boton);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button boton = sender as Button;
            this.jugar(boton);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button boton = sender as Button;
            this.jugar(boton);
        }
    }
}
