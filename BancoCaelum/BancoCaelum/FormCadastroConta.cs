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
    public partial class FormCadastroConta : Form
    {
        private Form1 FormPrincipal;

        public FormCadastroConta(Form1 formPrincipal)
        {
            this.FormPrincipal = formPrincipal;
            InitializeComponent();
        }

        private void FormCadastroConta_Click(object sender, EventArgs e)
        {
            Conta novaConta = new ContaCorrente();
            novaConta.Titular = new Cliente(textTitular.Text);
            novaConta.Numero = Convert.ToInt32(textNumero.Text);

            this.FormPrincipal.AdicionaConta(novaConta);
            this.Close();
        }
    }
}
