using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoCaelum
{
    public partial class Form1 : Form
    {
        public Conta[] contas;

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(txtValor.Text);
            int indice = Convert.ToInt32(comboContas.SelectedIndex);
            Conta contaSelecionada = contas[indice];

            if (contaSelecionada.Saca(valor))
            {
                lblStatus.Text = ($"Saque realizado com sucesso!");
                lblStatus.BackColor = Color.Red;
                txtValor.Clear();
                atualizaSaldo();
            }
            else
            {
                lblStatus.Text = ($"Erro ao sacar!");
                lblStatus.BackColor = Color.Red;
                txtValor.Clear();
                atualizaSaldo();
            }

            

        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {

            double valor = Convert.ToDouble(txtValor.Text); //converter string em double(numero)  double.parse também converte.

            int indice = Convert.ToInt32(comboContas.SelectedIndex);
            Conta contaSelecionada = contas[indice];
            contaSelecionada.Deposita(valor);

            lblStatus.Text = ($"Depósito realizado com sucesso!");
            lblStatus.BackColor = Color.Green;
            txtValor.Clear();
            atualizaSaldo();

        }

        private void atualizaSaldo()
        {
            int indice = Convert.ToInt32(comboContas.SelectedIndex);
            Conta contaSelecionada = contas[indice]; 
            txtSaldo.Text = "R$ " + Convert.ToString(contaSelecionada.Saldo);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            contas = new Conta[3];
            this.contas[0] = new Conta();
            this.contas[0].Titular = new Cliente("Victor");
            this.contas[0].Numero = 1;

            this.contas[1] = new Conta();
            this.contas[1].Titular = new Cliente("Mauricio");
            this.contas[1].Numero = 2;

            this.contas[2] = new Conta();
            this.contas[2].Titular = new Cliente("Osni");
            this.contas[2].Numero = 3;

            foreach (Conta selecionada in contas) 
            {
                comboContas.Items.Add(selecionada.Titular.Nome);
            }

            foreach (Conta selecionada in contas)
            {
                comboContaDestino.Items.Add(selecionada.Titular.Nome);
            }


        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cadastrado com Sucesso!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Relatorio rel = new Relatorio();
            rel.TotalizadorDeContas(contas);

            MessageBox.Show($"Total do Banco é:{rel.totalBanco}");

        }
    

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            Conta selecionada = contas[indice];
            txtNumero.Text = Convert.ToString(selecionada.Numero);
            txtNome.Text = selecionada.Titular.Nome;
            txtSaldo.Text = Convert.ToString(selecionada.Saldo);

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            Conta selecionada = contas[indice];

            int indiceDestino = comboContaDestino.SelectedIndex;
            Conta selecionadaDestino = contas[indiceDestino];

            if (selecionada.Transfere(selecionadaDestino, Convert.ToDouble(txtValor.Text)))
            {
                MessageBox.Show("Transferencia Realizada!!!");
                txtValor.Clear();
                atualizaSaldo();

            }
            else
            {
                MessageBox.Show("Erro na transferencia");
            }
        }
    }
}
