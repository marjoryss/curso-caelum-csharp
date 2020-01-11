using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Conta Mauricio é c
            Conta c = new Conta();
            c.numero = 1;
            c.saldo = 2000.00;
            bool deuCerto = c.Saca(50.00);
            if (deuCerto)
                MessageBox.Show("Saque realizado");
            else
                MessageBox.Show("Saldo Insuficiente");
            c.Deposita(50.00);
            MessageBox.Show($"saldo Final: {c.saldo}");

            //Conta Guilherme é c2
            Conta c2 = new Conta();
            c2.numero = 1;
            c2.saldo = 5000.00;
            bool deuCerto2 = c2.Saca(50.00);
            if (deuCerto2)
                MessageBox.Show("Saque realizado");
            else
                MessageBox.Show("Saldo Insuficiente");
            c2.Deposita(50.00);
            MessageBox.Show($"saldo Final: {c.saldo}");

            c.saldo -= 200.0;
            c2.saldo += 200.0;

            MessageBox.Show($"Mauricio:{c.saldo}");
            MessageBox.Show($"Guilherme:{c2.saldo}");

            if (c == c2) MessageBox.Show("As contas são iguais");
            else MessageBox.Show("As contas são Diferentes");
            

                         
        }

        private void button4_Click(object sender, EventArgs e)
        {










        }
    }
}
