using System;
using System.Windows.Forms;
namespace jvZ
{
    public partial class JanelaPrincipal : Form
    {
     
        private decimal Resultado { get; set; }
        private decimal Valor { get; set; }
        private Operacao OperacaoSelecionada { get; set; }
        private enum Operacao
        {
            Adicao,
            Subtracao,
            Multiplicacao,
            Divisao
        }
        public JanelaPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximumSize = new Size(255, 288);
            this.MinimumSize = new Size(255, 288);
        }

        private void nVirgula_Click(object sender, EventArgs e)
        {
            if (!txtResultado.Text.Contains(","))
                txtResultado.Text += ",";
        }

        private void n0_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {
        }


        private void n1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void n2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void n3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void n4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void n5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void n6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void n7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void n8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void n9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
        }

        private void nMais_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Adicao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            lblOperacao.Text = "+";
        }

        private void nMenos_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Subtracao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            lblOperacao.Text = "-";
        }

        private void nMultiplicacao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Multiplicacao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            lblOperacao.Text = "X";
        }

        private void nDivisao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Divisao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            lblOperacao.Text = "/";
        }

        private void nIgual_Click(object sender, EventArgs e)
        {
            switch (OperacaoSelecionada)
            {
                case Operacao.Adicao:
                    Resultado = Valor + Convert.ToDecimal(txtResultado.Text);
                    break;
                case Operacao.Subtracao:
                    Resultado = Valor - Convert.ToDecimal(txtResultado.Text);
                    break;
                case Operacao.Multiplicacao:
                    Resultado = Valor * Convert.ToDecimal(txtResultado.Text);
                    break;
                case Operacao.Divisao:
                    Resultado = Valor / Convert.ToDecimal(txtResultado.Text);
                    break;
            }
            txtResultado.Text = Convert.ToString(Resultado);
            lblOperacao.Text = "=";
            lblOperacao.Text = " ";
        }

      
    }
}
