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
        public Conta ContaForm { get; set; }

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

            this.ContaForm.Saca(valor);
            lblStatus.Text = ($"Saque realizado com sucesso!");
            lblStatus.BackColor = Color.Red;
            txtValor.Clear();
            atualizaSaldo();

        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            
            double valor = Convert.ToDouble(txtValor.Text); //converter string em double(numero)  double.parse também converte.
                                  
            this.ContaForm.Deposita(valor);

            lblStatus.Text = ($"Depósito realizado com sucesso!");
            lblStatus.BackColor = Color.Green;
            txtValor.Clear();
            atualizaSaldo();

        }

        private void atualizaSaldo()
        {
            txtSaldo.Text = "R$ " + Convert.ToString(ContaForm.Saldo);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ContaForm = new Conta();
            this.ContaForm.Numero = 1;
            this.ContaForm.Titular = new Cliente("Marjory");

            txtNome.Text = ContaForm.Titular.Nome;
            txtNumero.Text = Convert.ToString(ContaForm.Numero);

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cadastrado com Sucesso!");
        }
    }
}
