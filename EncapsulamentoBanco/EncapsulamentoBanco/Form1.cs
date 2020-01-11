using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncapsulamentoBanco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta Marjory = new Conta();
            Marjory.Deposita(100);

            MessageBox.Show($"Saldo é:{Marjory.Saldo}");

            Marjory.Saca(50);

            MessageBox.Show($"Saldo é:{Marjory.Saldo}");

        }
    }
}
