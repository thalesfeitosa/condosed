using Npgsql.Internal.TypeHandlers.LTreeHandlers;
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
    public partial class CadUsuario : Form
    {
        public CadUsuario()
        {
            InitializeComponent();
        }

        private void CadButtonSave_Click(object sender, EventArgs e)
        {
            CadastrarUserClass cad = new CadastrarUserClass(UserNomeText.Text, SenhaUsuarioText.Text, FuncaoNameText.Text );
            MessageBox.Show(cad.mensagem);
            UserNomeText.Text = String.Empty;
            SenhaUsuarioText.Text = String.Empty;
            FuncaoNameText.Text = String.Empty;
            UserNomeText.Enabled = false;
            SenhaUsuarioText.Enabled = false;
            FuncaoNameText.Enabled = false;


        }

        private void CadUsuario_Load(object sender, EventArgs e)
        {
            UserNomeText.Enabled = false;
            FuncaoNameText.Enabled = false;
            SenhaUsuarioText.Enabled = false;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            UserNomeText.Enabled = true;
            FuncaoNameText.Enabled = true;
            SenhaUsuarioText.Enabled = true;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            BuscarUsuarioCadastradoForm BUF = new BuscarUsuarioCadastradoForm();
            BUF.ShowDialog();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login Log = new Login();
            Log.ShowDialog();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
