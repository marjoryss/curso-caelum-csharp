﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banco_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Conta conta = new Conta();
            Cliente guilherme = new Cliente();
            guilherme.RG = "12345678-9";
            conta.titular = guilherme;
            conta.titular.RG = "987654432-1";
            conta.titular.idade = 18;

            MessageBox.Show(guilherme.RG);
            if (conta.titular.EhMaiorDeIdade())
                label1.Text = "E maior de idade:";
            else
                label1.Text = "é menor de idade";

        }
    }
}
