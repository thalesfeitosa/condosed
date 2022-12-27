using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using NpgsqlTypes;

namespace CondoSed
{
    public partial class Selecao : Form
    {
        public Selecao()
        {
            InitializeComponent();
        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CadUsuario CadUser = new CadUsuario();
            CadUser.ShowDialog();
            this.Close();
        }

     

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login Log = new Login();
            Log.ShowDialog();
            this.Dispose();
        }

        private void TestaConexaoBd_MouseEnter(object sender, EventArgs e)
        {
          
        }

        private void TestaConexaoBd_Click(object sender, EventArgs e)
        {
            Conexao coonn = new Conexao();
            coonn.Connectar();

        }

        private void TestaConexaoBd_MouseEnter_1(object sender, EventArgs e)
        {
            TesteConexaoBdTip.AutoPopDelay = 4000;
            TesteConexaoBdTip.InitialDelay = 100;
            TesteConexaoBdTip.ReshowDelay = 200;

            TesteConexaoBdTip.SetToolTip(TestaConexaoBd, "Teste de Conexão com o Banco de Dados");

        }

        private void Selecao_Load(object sender, EventArgs e)
        {

        }
    }
}
