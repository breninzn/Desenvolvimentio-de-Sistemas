using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

    namespace prjCadastro
{
    public class clsFornecedor
    {
        DataTable dtFornecedor = new DataTable();

        //Criar o método CRIA DATATABLE
        private void CriarDataTable()
        {
            //Criar as colunas do datatable
            dtFornecedor.Columns.Add("Nome");
            dtFornecedor.Columns.Add("CNPJ");
            dtFornecedor.Columns.Add("IE");
            dtFornecedor.Columns.Add("Telefone");
            dtFornecedor.Columns.Add("Endereco");

        }

        //Criar o método de CONSULTAR

        public DataTable Consultar()
        {
            return dtFornecedor;
        }

        //Criar o método para CADASTRAR

        public string Cadastrar(string sNome, string sCNPJ, string sIE, string sTelefone, string sEndereco)
        {
            try
            {
                //Verificar se o DataTable de cadastro está vazio


               if (dtFornecedor.Rows.Count == 0)
                {
                    //Caso o datatable de cadastro estiver vazio
                    //Chamar o método para criar o datatable
                    //Antes de popular as colunas
                    CriarDataTable();

                    //Depois de criar o datatable de cadastro
                    //Criar uma variavel do tipo DataRow
                    DataRow drLinha = dtFornecedor.NewRow();

                    //Popular as colunas do DataTable com as variáveis
                    //Primeiro é o nome da coluna
                    //depois o valor do parametro
                    drLinha["Nome"] = sNome;
                    drLinha["CNPJ"] = sCNPJ;
                    drLinha["Telefone"] = sTelefone;
                    drLinha["IE"] = sIE;
                    drLinha["Endereco"] = sEndereco;


                    //Adicionar uma nova linha 
                    //no DataTable de cadastro de cliente
                    dtFornecedor.Rows.Add(drLinha);
                }
                else
                {
                    //Depois de criar o datatable de cadastro
                    //Criar uma variavel do tipo DataRow
                    DataRow drLinha = dtFornecedor.NewRow();

                    //Popular as colunas do DataTable com as variáveis
                    //Primeiro é o nome da coluna
                    //depois o valor do parametro
                    drLinha["Nome"] = sNome;
                    drLinha["CNPJ"] = sCNPJ;
                    drLinha["Telefone"] = sTelefone;
                    drLinha["IE"] = sIE;
                    drLinha["Endereco"] = sEndereco;

                    //Adicionar uma nova linha 
                    //no DataTable de cadastro de cliente
                    dtFornecedor.Rows.Add(drLinha);
                }
                return "Cadastro realizado com sucesso";

            }
            catch (Exception erro)
            {

                return erro.Message;
            }
        }
    }
}

