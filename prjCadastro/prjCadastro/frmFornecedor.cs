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
    public partial class frmFornecedor : Form
    {
        public frmFornecedor()
        {
            InitializeComponent();
        }
        clsFornecedor negFornecedor = new clsFornecedor();
        //Criar o método para cadastrar os fornecedores

        public void Cadastrar() {
            //criar as variaveis
            string sNome = "";
            string sTelefone = "";
            string sEndereco = "";
            string sCNPJ = "";
            string sIE = "";

            //atribuir os valores dos text box para as variaveis

            sNome = txtNome.Text;
            sEndereco = txtEndereco.Text;
            sCNPJ = txtCNPJ.Text;
            sIE = txtIe.Text;
            sTelefone = txtTelefone.Text;
            //chamar o método da classe de negocio
            //para cadastrar o fornecedor no dataBase

            string sRetorno = negFornecedor.Cadastrar(sNome, sEndereco, sTelefone, sCNPJ, sIE);
            //verificar se a mensagem é de cadastro com sucesso
            if (sRetorno.IndexOf("Cadastro realizado com sucesso") >= 0)
            {
                MessageBox.Show("Cadastro", sRetorno, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("ERRO", sRetorno, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Cadastrar();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            dgvConsulta.DataSource = negFornecedor.Consultar();
        }
    }
}
