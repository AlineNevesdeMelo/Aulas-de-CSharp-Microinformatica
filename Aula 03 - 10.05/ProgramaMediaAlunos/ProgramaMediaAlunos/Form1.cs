using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaMediaAlunos
{
    public partial class Form1 : Form
    {
        String nome;
        Double nota1, nota2, nota3, nota4;
        Double media;

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnome.Text ="";
            txtnota1.Text = "";
            txtnota2.Text = "";
            txtnota3.Text = "";
            txtnota4.Text = "";
        }

        private void btnlimparlst_Click(object sender, EventArgs e)
        {
            aprovados.Items.Clear();
            reprovados.Items.Clear();
            lblqtap.Text = "0";
            lblqtrep.Text = "0";
        }

        private void btnmedia_Click(object sender, EventArgs e)
        {
            if (txtnome.Text == "" || txtnota1.Text == "" || txtnota2.Text == "" || txtnota3.Text == "" || txtnota4.Text == "")
            {
                MessageBox.Show("Informe as informações necessárias");
            }
            else
            { 
                nome = txtnome.Text;
                nota1 = Convert.ToDouble(txtnota1.Text);
                nota2 = Convert.ToDouble(txtnota2.Text);
                nota3 = Convert.ToDouble(txtnota3.Text);
                nota4 = Convert.ToDouble(txtnota4.Text);
                media = (nota1 + nota2 + nota3 + nota4) / 4;
                if (media >= 6)
                {
                    aprovados.Items.Add(nome + " - " + media);
                    lblqtap.Text = aprovados.Items.Count.ToString();
                }
                else
                {
                    reprovados.Items.Add(nome + " - " + media);
                    lblqtrep.Text = reprovados.Items.Count.ToString();
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
