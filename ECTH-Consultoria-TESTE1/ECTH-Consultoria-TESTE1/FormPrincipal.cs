using ECTH_Consultoria_TESTE1.DataBase;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ECTH_Consultoria_TESTE1
{
    public partial class FormPrincipal : MetroForm
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

            


        }

        public void Listar()
        {

            this.Cursor = Cursors.WaitCursor;
            ConfiguraBanco configBD = new ConfiguraBanco();
            // Classe de conexão com o banco de dados
            ConexaoBanco conexao = new ConexaoBanco();

            Tabelas tabelas = new Tabelas();
            this.Cursor = Cursors.Default;
            var dtLista = tabelas.Listar(conexao.ConexaoReturn);

            dgListar.DataSource = dtLista;


        }

        private void btListar_Click(object sender, EventArgs e)
        {
            Listar();
        }
    }
}
