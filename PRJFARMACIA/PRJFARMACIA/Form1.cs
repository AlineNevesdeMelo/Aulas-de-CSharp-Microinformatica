using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRJFARMACIA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            string nome = "";
            double compra = 0;
            if (!double.TryParse(txtvalor.Text, out compra))
            {
                //avisar
                MessageBox.Show("Informe um valor válido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; //Interrompe a execução
            }
            //verificar a faixa etária
            double descontoFaixa = 0;
            if (radioButton1.Checked)
            {
                descontoFaixa = 0;
            }
            else if (radioButton2.Checked)
            {
                descontoFaixa = 0.05;
            }
            else if (radioButton3.Checked)
            {
                descontoFaixa = 0.07;
            }
            else
            {
                // avisar
                MessageBox.Show("Escolha a faixa etária", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; //Interrompe a execução
            }
            // Verificar o cartão da loja
            double descontoCartao = 0;
            if (checkcartao.Checked)
            {
                descontoCartao = 0.05;
            }
            double valorDescontoIdade = compra * descontoFaixa;
            double valorDescontoCartao = compra * descontoCartao;
            double valorFinal = compra - valorDescontoIdade - valorDescontoCartao;
            // exibir os resultados
            lblresultado.Text = "Compra: R$ " + compra + "\nDesc. Faixa: R$ " + valorDescontoIdade + "\nDesc. Cartão: R$ " + valorDescontoCartao + "\nValor a Pagar: R$ " + valorFinal; ;
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnome.Text = "";
            txtvalor.Text = "";
            lblresultado.Text = "";
            checkcartao.Checked = false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
        }
    }
}
