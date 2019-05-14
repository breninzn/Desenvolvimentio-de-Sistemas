using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace prjCadastro
{
    public class clsProduto
    {
        DataTable dtCadastroProduto = new DataTable();

        private void CriarDataTable()
        {
            //Criar as colunas do datatable
            dtCadastroProduto.Columns.Add("NomeProduto");
            dtCadastroProduto.Columns.Add("EstoqueProduto");
            dtCadastroProduto.Columns.Add("ValorCompra");
            dtCadastroProduto.Columns.Add("ValorVenda");
            dtCadastroProduto.Columns.Add("ValorLucro");
            dtCadastroProduto.Columns.Add("UnidadeProduto");
        }

        public DataTable Consultar()
        {
            return dtCadastroProduto;
        }

        public string Cadastrar(string sProduto,decimal dEstoque, decimal dCompra, decimal dVenda,
        decimal dLucro, string sUnidade)
        {
            try
            {
                if (dtCadastroProduto.Rows.Count == 0)
                {
                    //Caso o datatable de cadastro estiver vazio
                    //Chamar o método para criar o datatable
                    //Antes de popular as colunas
                    CriarDataTable();

                    //Depois de criar o datatable de cadastro
                    //Criar uma variavel do tipo DataRow
                    DataRow drLinha = dtCadastroProduto.NewRow();

                    //Popular as colunas do DataTable com as variáveis
                    //Primeiro é o nome da coluna
                    //depois o valor do parametro
                    drLinha["NomeProduto"]   =  sProduto;
                    drLinha["EstoqueProduto"]=  dEstoque;
                    drLinha["ValorCompra"]   =  dCompra ;
                    drLinha["ValorVenda"]    =  dVenda ;
                    drLinha["ValorLucro"]    =  dLucro ;
                    drLinha["UnidadeProduto"] = sUnidade;

                    //Adicionar uma nova linha 
                    //no DataTable de cadastro de cliente
                    dtCadastroProduto.Rows.Add(drLinha);
                }
                else
                {
                    //Depois de criar o datatable de cadastro
                    //Criar uma variavel do tipo DataRow
                    DataRow drLinha = dtCadastroProduto.NewRow();

                    //Popular as colunas do DataTable com as variáveis
                    //Primeiro é o nome da coluna
                    //depois o valor do parametro
                    drLinha["NomeProduto"] = sProduto;
                    drLinha["EstoqueProduto"] = dEstoque;
                    drLinha["ValorCompra"] = dCompra;
                    drLinha["ValorVenda"] = dVenda;
                    drLinha["ValorLucro"] = dLucro;
                    drLinha["UnidadeProduto"] = sUnidade;


                    //Adicionar uma nova linha 
                    //no DataTable de cadastro de cliente
                    dtCadastroProduto.Rows.Add(drLinha);
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
