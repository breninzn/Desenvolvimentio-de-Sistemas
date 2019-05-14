using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace prjCadastro
{
    public class clsCliente
    {
        //Criar variável DataTable
        DataTable dtCadastroCliente = new DataTable();

        //Criar o método CRIA DATATABLE
        private void CriarDataTable() {
            //Criar as colunas do datatable
            dtCadastroCliente.Columns.Add("Nome");
            dtCadastroCliente.Columns.Add("CPF");
            dtCadastroCliente.Columns.Add("RG");
            dtCadastroCliente.Columns.Add("Estado");
            dtCadastroCliente.Columns.Add("Cidade");
            dtCadastroCliente.Columns.Add("Bairro");
            dtCadastroCliente.Columns.Add("Rua");
            dtCadastroCliente.Columns.Add("Numero");
            dtCadastroCliente.Columns.Add("Telefone");
            dtCadastroCliente.Columns.Add("Celular");
            dtCadastroCliente.Columns.Add("Email");
        }

        //Criar o método de CONSULTAR

        public DataTable Consultar() {
            return dtCadastroCliente;
        }

        //Criar o método para CADASTRAR

        public string Cadastrar(string sNome, 
            string sCPF, string sRG, string sEstado,
            string sCidade, string sBairro,
            string sRua, string sNumero,
            string sTelefone, string sCelular,
            string sEmail) {
            try
            {
                //Verificar se o DataTable de cadastro está vazio
                if (dtCadastroCliente.Rows.Count == 0)
                {
                    //Caso o datatable de cadastro estiver vazio
                    //Chamar o método para criar o datatable
                    //Antes de popular as colunas
                    CriarDataTable();

                    //Depois de criar o datatable de cadastro
                    //Criar uma variavel do tipo DataRow
                    DataRow drLinha = dtCadastroCliente.NewRow();

                    //Popular as colunas do DataTable com as variáveis
                    //Primeiro é o nome da coluna
                    //depois o valor do parametro
                    drLinha["Nome"] = sNome;
                    drLinha["CPF"] = sCPF;
                    drLinha["RG"] = sRG;
                    drLinha["Estado"] = sEstado;
                    drLinha["Cidade"] = sCidade;
                    drLinha["Bairro"] = sBairro;
                    drLinha["Rua"] = sRua;
                    drLinha["Numero"] = sNumero;
                    drLinha["Telefone"] = sTelefone;
                    drLinha["Celular"] = sCelular;
                    drLinha["Email"] = sEmail;

                    //Adicionar uma nova linha 
                    //no DataTable de cadastro de cliente
                    dtCadastroCliente.Rows.Add(drLinha);
                }
                else {
                    //Depois de criar o datatable de cadastro
                    //Criar uma variavel do tipo DataRow
                    DataRow drLinha = dtCadastroCliente.NewRow();

                    //Popular as colunas do DataTable com as variáveis
                    //Primeiro é o nome da coluna
                    //depois o valor do parametro
                    drLinha["Nome"] = sNome;
                    drLinha["CPF"] = sCPF;
                    drLinha["RG"] = sRG;
                    drLinha["Estado"] = sEstado;
                    drLinha["Cidade"] = sCidade;
                    drLinha["Bairro"] = sBairro;
                    drLinha["Rua"] = sRua;
                    drLinha["Numero"] = sNumero;
                    drLinha["Telefone"] = sTelefone;
                    drLinha["Celular"] = sCelular;
                    drLinha["Email"] = sEmail;

                    //Adicionar uma nova linha 
                    //no DataTable de cadastro de cliente
                    dtCadastroCliente.Rows.Add(drLinha);
                }
                return "Dados cadastrados com sucesso !!";

            }
            catch (Exception erro)
            {

                return erro.Message;
            }                        
        }
    }
}
