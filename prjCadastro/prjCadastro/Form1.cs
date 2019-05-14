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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Declarar a classe de negocio
        clsCliente negCliente = new clsCliente();
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Criar as variáveis
            string sNome = "";
            string sCPF = "";
            string sRG = "";
            string sEstado = "";
            string sCidade = "";
            string sBairro = "";
            string sRua = "";
            string sNumero = "";
            string sTelefone = "";
            string sCelular = "";
            string sEmail = "";

            //atribuir valor para as variáveis
            sNome = txtNome.Text;
            sCPF = txtCPF.Text;
            sRG = txtRG.Text;
            sEstado = cbbEstado.Text;
            sCidade = txtCidade.Text;
            sBairro = txtBairro.Text;
            sRua = txtRua.Text;
            sNumero = txtNumero.Text;
            sTelefone = txtTelefone.Text;
            sCelular = txtCelular.Text;
            sEmail = txtEmail.Text;

            //Chamar o método da classe de cliente
            //Passar os parametros para o método
            //Declarar variável para receber o retorno
            string sRetorno = 
                negCliente.Cadastrar(sNome, sCPF, sRG, sEstado, sCidade, sBairro,
                sRua, sNumero, sTelefone, sCelular, sEmail);
            //Verificar se o cadastro foi realizado
            //com Sucesso
            if (sRetorno.IndexOf("Dados cadastrados com sucesso !!") >= 0)
                MessageBox.Show(sRetorno, "Cadastro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            //Caso não encontre a mensagem
            //Exibe o erro
            else {
                MessageBox.Show(sRetorno, "Cadastro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //Criar a variável do tipo Datatable
            //Para receber os dados de retorno da classe
            DataTable dtRetorno = negCliente.Consultar();
            //Popular o datagridview
            dgvConsulta.DataSource = dtRetorno;
        }

        private void dgvConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtRG_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtCidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRua_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void tabCadastrar_Click(object sender, EventArgs e)
        {

        }

        private void txtNomePesquisa_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
