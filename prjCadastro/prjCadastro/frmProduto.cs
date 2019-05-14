using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjCadastro
{
    public partial class frmProduto : Form
    {
        public frmProduto()
        {
            InitializeComponent();
        }

        public void Limpar(Control controle)
        {
            foreach (Control item in controle.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void txtUnidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmProduto_Load(object sender, EventArgs e)
        {

        }
        clsProduto negProduto = new clsProduto();
        private void btnSalvar_Click(object sender, EventArgs e)
        {

            //Criar as variáveis
            decimal dEstoque = 0;
            decimal dVenda = 0;
            decimal dCompra = 0;
            decimal dLucro = 0;
            string sProduto = "";
            string sUnidade = "";

            //atribuir valor para as variáveis
            try
            {
                dEstoque = Convert.ToDecimal(txtEstoque.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Campo estoque não pode conter letras");
                txtEstoque.Text = "";
                txtEstoque.Focus();
                return;
            }

            try
            {
                dVenda = Convert.ToDecimal(txtVenda.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Campo venda não pode conter letras");
                txtVenda.Text = "";
                txtVenda.Focus();
                return;
            }

            try
            {
                dCompra = Convert.ToDecimal(txtCompra.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Campo compra não pode conter letras");
                txtCompra.Text = "";
                txtCompra.Focus();
                return;
            }

            try
            {
                dLucro = Convert.ToDecimal(txtLucro.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Campo lucro não pode conter letras");
                txtLucro.Text = "";
                txtLucro.Focus();
                return;
            }

            sProduto = txtProduto.Text;
            sUnidade = txtUnidade.Text;

            //Chamar o método da classe de cliente
            //Passar os parametros para o método
            //Declarar variável para receber o retorno
            string sRetorno =
                negProduto.Cadastrar(sProduto, dEstoque, dCompra, dVenda, dLucro, sUnidade);
            //Verificar se o cadastro foi realizado
            //com Sucesso
            if (sRetorno.IndexOf("Dados cadastrados com sucesso !!") >= 0)
            {
                MessageBox.Show(sRetorno, "Cadastro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                Limpar(tabCadastrar);
            }
            //Caso não encontre a mensagem
            //Exibe o erro
            else
            {
                MessageBox.Show(sRetorno, "Cadastro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //Criar a variável do tipo Datatable
            //Para receber os dados de retorno da classe
            DataTable dtRetorno = negProduto.Consultar();
            //Popular o datagridview
            dgvConsulta.DataSource = dtRetorno;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Limpar(tabCadastrar);
        }
        
            
    

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    }
