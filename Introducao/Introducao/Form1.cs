using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Introducao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = "Marjory";

            double saldo = 100.50;

            int numero = 1;

            double saque = 100;

            if (saldo >= saque)
            {
                saldo = saldo - saque;
                MessageBox.Show($"Saque realizado, saldo de: {saldo}");
            }

            else
            {
                MessageBox.Show("Saldo Insuficiente");
            }

            MessageBox.Show($"O nome do cliente é: {nome} e o saldo é {saldo}");

            //casting fazer conversão 
            //Double pode ser numero inteiros e quebrados
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idadeFelipe = 33;
            int idadeIvone = 49;
            int idadeMagda = 26;

            int mediaIdades = (idadeFelipe + idadeIvone + idadeMagda) / 3;

            MessageBox.Show($"A média de idade é: {mediaIdades}");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //int pi = 3.14;

            // não compila, pois 3,14 nao cabe dentro de um inteiro, para esse caso necessário fazer casting
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double pi = 3.14;
            int piQuebrado = (int)pi;
            MessageBox.Show("piQuebrado = " + piQuebrado);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int a = 1;
            int b = 2;
            int c = -15;

            double delta;
            double a1;
            double a2;

            delta = b * b - 4 * a * c;
            a1 = (-b + Math.Sqrt(delta)) / (2 * a);
            a2 = (-b - Math.Sqrt(delta)) / (2 * a);

            MessageBox.Show($"a1{a1}");
            MessageBox.Show($"a2{a2}");

        }

        private void button6_Click(object sender, EventArgs e)
        {
            double saldo = 100.0;
            double valorSaque = 10.0;

            if (saldo >= valorSaque)
            {
                saldo -= valorSaque;
                MessageBox.Show("Saque Realizado com sucesso");
            }

            else
            {
                MessageBox.Show("Saldo Insuficiente");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double saldo = 5.0;
            double valorSaque = 10.0;

            if (saldo >= valorSaque)
            {
                saldo -= valorSaque;
                MessageBox.Show("Saque realizado com sucesso");

            }

            else
            {
                MessageBox.Show("Saldo Insuficiente");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

            double saldo = 500.0;
            if (saldo < 0.0)
            {
                MessageBox.Show("Você esta no negativo!");
            }

            else if (saldo < 1000000.0)
            {
                MessageBox.Show("Você é um bom cliente");
            }
            else
            {
                MessageBox.Show("Você é milionário");
            }

        }
    }
}