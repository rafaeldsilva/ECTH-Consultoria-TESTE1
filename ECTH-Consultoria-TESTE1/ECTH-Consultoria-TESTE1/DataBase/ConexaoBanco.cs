using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;

namespace ECTH_Consultoria_TESTE1.DataBase
{
    // Classe de conexão com o banco de dados
    public class ConexaoBanco
    {
        private SQLiteConnection _conexao;

        public SQLiteConnection ConexaoReturn { get => _conexao; set => _conexao = value; }

        // Método construtor de conexão com o banco de dados
        public ConexaoBanco()
        {
            // Classe contento os atributos de acesso ao banco de dados
            DataSourcedBanco ds = new DataSourcedBanco();

            // Instancia a clase de conexão do Sqlite, passando parametro o DataSource do banco de dados
            SQLiteConnection Conexao = new SQLiteConnection(ds.DataSource);

            // Abre a conexão
            Conexao.Open();

            // classe de retorno de conexão com o bando de dados
            ConexaoReturn = Conexao;
        }
    }
}
