using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;

namespace ECTH_Consultoria_TESTE1.DataBase
{
    public class ConfiguraBanco
    {
        // Método construtor da classe ConfiguraBanco
        public ConfiguraBanco()
        {
            // Classe do caminho de origem do banco de dados
            DataSourcedBanco ds = new DataSourcedBanco();

            // Bloco de tratamento de exceção de erro, para criação da tabela usuarios


            try
            {
                // Condição que verifica se o banco de dados existe, para criação do mesmo
                if (!File.Exists(ds.Banco))
                {
                    // Cria-se o arquivo do banco de dados
                    SQLiteConnection.CreateFile(ds.Banco);

                    // Classe de conexão com o banco de dados
                    ConexaoBanco conexao = new ConexaoBanco();

                    // Cria-se a tabela do banco de dados, passando o parametro da classe de conexão
                    Tabelas tabelas = new Tabelas();
                    tabelas.CriarTabela(conexao.ConexaoReturn);

                    tabelas.InseriDadosTabela(conexao.ConexaoReturn);



                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Erro ao criar banco de dados!" + ex.Message);
            }

        }


    }
}
