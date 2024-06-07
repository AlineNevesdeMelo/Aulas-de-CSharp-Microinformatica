using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjTABUADA
{
    public partial class Form1 : Form
    {
        int i, n;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnclean_Click(object sender, EventArgs e)
        {
            lsttab.Items.Clear();
            txtnum.Text = "";
            txtnum.Focus();

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AcceptButton = btncalc;
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            try
            {
                n = int.Parse(txtnum.Text);
                for (i = 1; i <= 10; i++)
                {
                    lsttab.Items.Add($"{n} x {i} = {n * i}");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Informe um valor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Ocorreu um erro: {erro.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
