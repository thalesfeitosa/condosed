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
            ContaoEmergenciaTxtBox.Enabled = true;
            ContaoEmergenciaTxtBox2.Enabled = true;
            MoradoresDtNascimentoTxtBox.Enabled = true;
            MoradoresDtNascimentoTxtBox2.Enabled = true;
            MoradoresDtNascimentoTxtBox3.Enabled = true;
            MoradoresDtNascimentoTxtBox4.Enabled = true;
            MoradoresTxtBox.Enabled = true;
            MoradoresTxtBox2.Enabled = true;
            MoradoresTxtBox3.Enabled = true;
            MoradoresTxtBox4.Enabled = true;
            NomeEmergenciaTxtBox.Enabled = true;
            NomeEmergenciaTxtBox2.Enabled = true;
            ParentescoEmergenciaTxtBox.Enabled = true;
            ParentescoEmergenciaTxtBox2.Enabled = true;
            ParentescoTxtBox.Enabled = true;
            ParentescoTxtBox2.Enabled = true;
            ParentescoTxtBox3.Enabled = true;
            ParentescoTxtBox4.Enabled = true;
            TipoVeiculoTxtBox.Enabled = true;
            TipoVeiculoTxtBox2.Enabled = true;
            TipoVeiculoTxtBox3.Enabled = true;
            NomeTextBox.Enabled = true;
            BlocoTextBox.Enabled = true;
            UnidadeTextBox.Enabled = true;
            TelefoneCondominoLabel.Enabled = true;
            TelefoneCondominoTxtBox.Enabled = true;
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
            ParentescoTxtBox.Enabled = false;
            ParentescoTxtBox2.Enabled = false;
            ParentescoTxtBox3.Enabled = false;
            ParentescoTxtBox4.Enabled = false;
            TipoVeiculoTxtBox.Enabled = false;
            TipoVeiculoTxtBox2.Enabled=false;
            TipoVeiculoTxtBox3.Enabled=false;
            NomeTextBox.Enabled = false;
            BlocoTextBox.Enabled = false;
            UnidadeTextBox.Enabled = false;
            TelefoneCondominoLabel.Enabled = false;
            TelefoneCondominoTxtBox.Enabled = false;
            
            

        }

        private void VagaBoxSim_CheckedChanged(object sender, EventArgs e)
        {
            if (VagaBoxSim.Checked)
            {
                TipoVeiculoLabel.Visible = true;
                TipoVeiculoTxtBox.Visible= true;
                VeiculoLabel.Visible = true;
                VeiculoMarcaLabel.Visible = true;
                VeiculoLabelModelo.Visible = true;
                VeiculoLabelPlaca.Visible = true;
                VeiculoMarcaTextBox.Visible = true;
                VeiculoModeloTextBox.Visible = true;
                VeiculoPlacaTextBox.Visible = true;
                AddVeiculoButtonAddVeiculoButton.Visible = true;
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
                AddVeiculoButtonAddVeiculoButton.Visible = false;
                TipoVeiculoLabel.Visible = false;
                TipoVeiculoTxtBox.Visible = false;
               
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

        private void AddVeiculoButtonAddVeiculoButton_Click(object sender, EventArgs e)
        {
            TipoVeiculoTxtBox2.Visible = true;
            TipoVeiculoLabel2.Visible = true;
            VeiculoMarcaLabel2.Visible = true;
            VeiculoMarcaTextBox2.Visible = true;
            VeiculoLabelModelo2.Visible = true;
            VeiculoModeloTxtBox2.Visible = true;
            VeiculoPlacaTextBox2.Visible = true;
            VeiculoLabelPlaca2.Visible = true;
            AddVeiculoButton2.Visible = true;
        }

        private void AddVeiculoButton2_Click(object sender, EventArgs e)
        {
            TipoVeiculoTxtBox3.Visible = true;
            TipoVeiculoLabel3.Visible = true;
            VeiculoMarcaLabel3.Visible = true;
            VeiculoMarcaTextBox3.Visible = true;
            VeiculoLabelModelo3.Visible = true;
            VeiculoModeloTxtBox3.Visible = true;
            VeiculoPlacaTextBox3.Visible = true;
            VeiculoLabelPlaca3.Visible = true;
            AddVeiculoButton2.Visible = true;
        }

        private void AnimaisCheckBoxSim_CheckedChanged(object sender, EventArgs e)
        {
            EspecieLabel.Visible = true;
            GatoCheckBox.Visible = true;
            CachorroCheckBox.Visible = true;
            OutroscheckBox.Visible = true;
            QuantosAnimaisLabel.Visible = true;
            QuantosAnimaisTxtBox.Visible = true;
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
             Opcoes opt = new Opcoes();
              opt.ShowDialog();
                this.Close();
        }
    }
}
