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
    public partial class CadPessoas : Form
    {
        public CadPessoas()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void VeiculoLabel_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void BicicletaLabelMarca2_Click(object sender, EventArgs e)
        {

        }

        private void BicicletaTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BicicletaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CadPessoas_Load(object sender, EventArgs e)
        {
            ContaoEmergenciaTxtBox.Enabled = false;
            ContaoEmergenciaTxtBox2.Enabled = false;
            MoradoresDtNascimentoTxtBox.Enabled = false;
            MoradoresDtNascimentoTxtBox2.Enabled = false;
            MoradoresDtNascimentoTxtBox3.Enabled = false;
            MoradoresDtNascimentoTxtBox4.Enabled = false;
            MoradoresTxtBox.Enabled = false;
            MoradoresTxtBox2.Enabled = false;
            MoradoresTxtBox3.Enabled = false;
            MoradoresTxtBox4.Enabled = false;
            NomeEmergenciaTxtBox.Enabled = false;
            NomeEmergenciaTxtBox2.Enabled = false;
            ParentescoEmergenciaTxtBox.Enabled = false;
            ParentescoEmergenciaTxtBox2.Enabled = false;
            ParentescoTxtBox3.Enabled = false;
        }

        private void VagaBoxSim_CheckedChanged(object sender, EventArgs e)
        {
            if (VagaBoxSim.Checked)
            {
                VeiculoLabel.Visible = true;
                VeiculoMarcaLabel.Visible = true;
                VeiculoLabelModelo.Visible = true;
                VeiculoLabelPlaca.Visible = true;
                VeiculoMarcaTextBox.Visible = true;
                VeiculoModeloTextBox.Visible = true;
                VeiculoPlacaTextBox.Visible = true;
            }
            else
            {
                VeiculoLabel.Visible = false;
                VeiculoMarcaLabel.Visible = false;
                VeiculoLabelModelo.Visible = false;
                VeiculoLabelPlaca.Visible = false;
                VeiculoMarcaTextBox.Visible = false;
                VeiculoModeloTextBox.Visible = false;
                VeiculoPlacaTextBox.Visible = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void ProprietarioBoxNao_CheckedChanged(object sender, EventArgs e)
        {
            if (ProprietarioBoxNao.Checked)
            {
                NomeProprietarioLabel.Visible = true;
                ProprietarioTxtBox.Visible = true;
            }
            else
            {
                NomeProprietarioLabel.Visible = false;
                ProprietarioTxtBox.Visible= false;
            }
        }
    }
}
