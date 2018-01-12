using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;

namespace ECTH_Consultoria_TESTE1.DataBase
{
    // Classe de criação das tabelas do banco de dados
    public class Tabelas
    {
        public void CriarTabela(SQLiteConnection Conexao)
        {
            //Cria-se a tabela de usuarios
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("create table if not exists tb_drenagem_superficial_fernao_dias ([pkey] integer primary key autoincrement,");
            sql.AppendLine("[data_inspecao] varchar(50),");
            sql.AppendLine("[nome_da_concessionaria] varchar(50),");

            sql.AppendLine("[codigo_do_elemento] varchar(50),");

            sql.AppendLine("[rodovia] varchar(10),");

            sql.AppendLine("[Municipio] varchar(50),");

            sql.AppendLine("[km_inicial] varchar(20),");

            sql.AppendLine("[metro_inicial] varchar(20),");

            sql.AppendLine("[km_final] varchar(20),");

            sql.AppendLine("[metro_final] varchar(20),");

            sql.AppendLine("[unidade_federativa] varchar(20),");

            sql.AppendLine("[sentido] varchar(50),");

            sql.AppendLine("[sentido_geografico] varchar(50),");

            sql.AppendLine("[lado_rodovia] varchar(50),");

            sql.AppendLine("[latitude_inicio] varchar(20),");

            sql.AppendLine("[longitude_inicio] varchar(20),");

            sql.AppendLine("[latitude_fim] varchar(20),");

            sql.AppendLine("[longitude_fim] varchar(20),");

            sql.AppendLine("[extensao_metros] varchar(20),");

            sql.AppendLine("[largura_metros] varchar(20),");

            sql.AppendLine("[altura_metros] varchar(20),");

            sql.AppendLine("[ambiente] varchar(20),");

            sql.AppendLine("[estado_conservacao] varchar(20),");

            sql.AppendLine("[material] varchar(20),");

            sql.AppendLine("[tipo_elemento] varchar(20),");

            sql.AppendLine("[tipo] varchar(20),");

            sql.AppendLine("[ok] varchar(20),");

            sql.AppendLine("[reparar] varchar(20),");

            sql.AppendLine("[extensao_reparar] varchar(20),");

            sql.AppendLine("[limpeza] varchar(20),");

            sql.AppendLine("[extensao_limpeza] varchar(20),");

            sql.AppendLine("[implantar] varchar(20),");

            sql.AppendLine("[extensao_implantar] varchar(20),");

            sql.AppendLine("[Observacao] varchar(220),");

            sql.AppendLine("[foto_panoramica1] varchar(220),");

            sql.AppendLine("[foto_panoramica2] varchar(220),");

            sql.AppendLine("[foto_panoramica3] varchar(220),");

            sql.AppendLine("[foto_panoramica4] varchar(220),");

            sql.AppendLine("[foto_panoramica5] varchar(220),");

            sql.AppendLine("[foto_detalhe1] varchar(220),");

            sql.AppendLine("[foto_detalhe2] varchar(220),");

            sql.AppendLine("[foto_detalhe3] varchar(220),");

            sql.AppendLine("[foto_detalhe4] varchar(220),");

            sql.AppendLine("[foto_detalhe5] varchar(220))");

            // Classe SQLiteCommand para executar os comandos (Query)
            SQLiteCommand Comando = new SQLiteCommand(sql.ToString(), Conexao);

            // Bloco de tratamento de exceção de erro, para criação da tabela usuarios

            try
            {
                Comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show("Erro ao criar tabela do banco!" + ex.Message);
            }
        }

        public void InseriDadosTabela(SQLiteConnection Conexao)
        {
            //Classe Instanciada, para converter o arquivos csv para DataTable
            CSVConverteParaDataTable obj = new CSVConverteParaDataTable();
            string CSV = @"drenagem_superficial_FernaoDias.csv";

            var Dt = obj.ConvertCSVtoDataTable(CSV);

            if (Dt.Rows.Count > 0)
            {
               // Dt.Rows.RemoveAt(0);

                for (int i = 0; i < Dt.Rows.Count; i++)
                {
                    DataRow Dr = Dt.Rows[i];

                    //Popula a tabela SQL
                    StringBuilder sql = new StringBuilder();
                    sql.AppendLine("insert into tb_drenagem_superficial_fernao_dias " +
                                 "(data_inspecao, " +
                                 "nome_da_concessionaria, " +
                                 "codigo_do_elemento, " +
                                 "rodovia, " +
                                 "municipio, " +
                                 "km_inicial, " +
                                 "metro_inicial, " +
                                 "km_final, " +
                                 "metro_final, " +
                                 "unidade_federativa, " +
                                 "sentido, " +
                                 "sentido_geografico, " +
                                 "lado_rodovia, " +
                                 "latitude_inicio, " +
                                 "longitude_inicio, " +
                                 "latitude_fim, " +
                                 "longitude_fim, " +
                                 "extensao_metros, " +
                                 "largura_metros, " +
                                 "altura_metros, " +
                                 "ambiente, " +
                                 "estado_conservacao, " +
                                 "material, " +
                                 "tipo_elemento, " +
                                 "tipo, " +
                                 "ok, " +
                                 "reparar, " +
                                 "extensao_reparar, " +
                                 "limpeza, " +
                                 "extensao_limpeza, " +
                                 "implantar, " +
                                 "extensao_implantar, " +
                                 "Observacao, " +
                                 "foto_panoramica1, " +
                                 "foto_panoramica2, " +
                                 "foto_panoramica3, " +
                                 "foto_panoramica4, " +
                                 "foto_panoramica5, " +
                                 "foto_detalhe1, " +
                                 "foto_detalhe2, " +
                                 "foto_detalhe3, " +
                                 "foto_detalhe4, " +
                                 "foto_detalhe5)");

                    sql.AppendLine(" values ");

                    sql.AppendLine("('"+ Dr["data_inspecao"].ToString()+"'" +
                        ", '"+ Dr["nome_da_concessionaria"].ToString()+"'" +
                        ", '"+ Dr["codigo_do_elemento"].ToString()+"'" +
                        ", '"+ Dr["rodovia"].ToString()+"'" +
                        ", '"+ Dr["Municipio"].ToString()+"'" +
                        ", '"+ Dr["km_inicial"].ToString()+"'" +
                        ", '"+ Dr["metro_inicial"].ToString()+"'" +
                        ", '"+ Dr["km_final"].ToString()+"'" +
                        ", '"+ Dr["metro_final"].ToString()+"'" +
                        ", '"+ Dr["unidade_federativa"].ToString()+"'" +
                        ", '"+ Dr["sentido"].ToString()+"'" +
                        ", '"+ Dr["sentido_geografico"].ToString()+"'" +
                        ", '"+ Dr["lado_rodovia"].ToString()+"'" +
                        ", '"+ Dr["latitude_inicio"].ToString()+"'" +
                        ", '"+ Dr["longitude_inicio"].ToString()+"'" +
                        ", '"+ Dr["latitude_fim"].ToString()+"'" +
                        ", '"+ Dr["longitude_fim"].ToString()+"'" +
                        ", '"+ Dr["extensao_metros"].ToString()+"'" +
                        ", '"+ Dr["largura_metros"].ToString()+"'" +
                        ", '"+ Dr["altura_metros"].ToString()+"'" +
                        ", '"+ Dr["ambiente"].ToString()+"'" +
                        ", '"+ Dr["estado_conservacao"].ToString()+"'" +
                        ", '"+ Dr["material"].ToString()+"'" +
                        ", '"+ Dr["tipo_elemento"].ToString()+"'" +
                        ", '"+ Dr["tipo"].ToString()+"'" +
                        ", '"+ Dr["ok"].ToString()+"'" +
                        ", '"+ Dr["reparar"].ToString()+"'" +
                        ", '"+ Dr["extensao_reparar"].ToString()+"'" +
                        ", '"+ Dr["limpeza"].ToString()+"'" +
                        ", '"+ Dr["extensao_limpeza"].ToString()+"'" +
                        ", '"+ Dr["implantar"].ToString()+"'" +
                        ", '"+ Dr["extensao_implantar"].ToString()+"'" +
                        ", '"+ Dr["Observacao"].ToString()+"'" +
                        ", '"+ Dr["foto_panoramica1"].ToString()+"'" +
                        ", '"+ Dr["foto_panoramica2"].ToString()+"'" +
                        ", '"+ Dr["foto_panoramica3"].ToString()+"'" +
                        ", '"+ Dr["foto_panoramica4"].ToString()+"'" +
                        ", '"+ Dr["foto_panoramica5"].ToString()+"'" +
                        ", '"+ Dr["foto_detalhe1"].ToString()+"'" +
                        ", '"+ Dr["foto_detalhe2"].ToString()+"'" +
                        ", '"+ Dr["foto_detalhe3"].ToString()+"'" +
                        ", '"+ Dr["foto_detalhe4"].ToString()+"'" +
                        ", '"+ Dr["foto_detalhe5"].ToString()+"')");

                    // Classe SQLiteCommand para executar os comandos (Query)
                    SQLiteCommand Comando = new SQLiteCommand(sql.ToString(), Conexao);

                    // Bloco de tratamento de exceção de erro, para criação de usuario administrador
                    try
                    {
                        
                        Comando.ExecuteNonQuery();
                        
                    }
                    catch (Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show("Erro ao inserir registro!" + ex.Message);
                    }

                }
            }
            Conexao.Close();
        }

       public DataTable Listar(SQLiteConnection Conexao)
        {
            DataTable dtListar = new DataTable();
            dtListar.Clear();

            //Cria usuario administrador
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("select * from tb_drenagem_superficial_fernao_dias");

            // Classe SQLiteCommand para executar os comandos (Query)
            SQLiteCommand Comando = new SQLiteCommand(sql.ToString(), Conexao);

            

            // Bloco de tratamento de exceção de erro, para criação de usuario administrador
            try
            {
                Comando.ExecuteNonQuery();

                SQLiteDataAdapter adpResult = new SQLiteDataAdapter(Comando);
                adpResult.Fill(dtListar);

            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show("Erro ao criar Somente Visualização!" + ex.Message);
            }

            return dtListar;
        }
    }
}
