using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CondoSed
{
    public partial class CadastroCorreiosForm : Form
    {
        public CadastroCorreiosForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CorreiosForm form = new CorreiosForm();
            form.ShowDialog();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            CadastrarCorreioClass CadCorreios = new CadastrarCorreioClass(DestNameText.Text, DestBlocoText.Text, DestAptText.Text, DestRecebedorText.Text, CodRastreamentoText.Text, LocalizacaoEstoqueText.Text, RecebedorCondoText.Text,
                StatusCheckBox.Checked);
            MessageBox.Show(CadCorreios.mensagem);
            DestNameText.Text = String.Empty;
            DestBlocoText.Text= String.Empty;
            DestAptText.Text  = String.Empty;
            DestRecebedorText.Text= String.Empty;
            CodRastreamentoText.Text= String.Empty;
            LocalizacaoEstoqueText.Text= String.Empty;
            RecebedorCondoText.Text= String.Empty;
            StatusCheckBox.Checked = false;

            











        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            CorreiosForm CorreiosForm = new CorreiosForm();

            this.Hide();
            CorreiosForm.ShowDialog();
        }
    }
}
