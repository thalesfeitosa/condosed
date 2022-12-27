using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using NpgsqlTypes;

namespace CondoSed
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            UserTextLogin.Select();
        }

        //boto login
        private void pictureBox1_Click(object sender, EventArgs e)


        {
            //abre a conexão com o banco instanciando a classe conexão
            NpgsqlConnection Conexao = new NpgsqlConnection();
            
            Conexao.ConnectionString = "Server = localhost; Port = 5432; Database = condosed;User id= postgres; Password = #abc123#";


            Conexao.Open();
            string query = "Select * From system.usuarios where nmusuario ='" + UserTextLogin.Text + "' and senha = '" + MaskTextBoxSenha.Text + "'";
           
            NpgsqlDataAdapter DataAdapter = new NpgsqlDataAdapter(query, Conexao);
            DataTable dt = new DataTable();
            DataAdapter.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                
                Opcoes op = new Opcoes();
                op.ShowDialog();
                Conexao.Close();

                UserTextLogin.Text = String.Empty;
                MaskTextBoxSenha.Text = String.Empty;

                

            }

            else
            {
                MessageBox.Show("Usuário ou Senha incorreta! Verifique!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UserTextLogin.Text = ""; //limpa as text box
                MaskTextBoxSenha.Text = "";
                UserTextLogin.Select();// cursor irá iniciar na primeira textbox
            }
            



        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Selecao sel = new Selecao();
            sel.ShowDialog();
            
        }
    }
}
