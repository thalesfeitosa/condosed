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
            TelEmergenciaMTextbox.Enabled = true;
            TelEmergenciaMTextbox2.Enabled= true;
            TelCondominoMTextBox.Enabled = true;
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
            ProprietarioBoxNao.Enabled = true;
            ProprietarioBoxSim.Enabled = true;
            VeiculoMarcaTextBox.Enabled = true;
            VeiculoMarcaTextBox2.Enabled= true;
            VeiculoMarcaTextBox3.Enabled= true;
            VeiculoPlacaTextBox.Enabled = true;
            VeiculoPlacaTextBox2.Enabled= true;
            VeiculoPlacaTextBox3.Enabled= true;

            

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
            TelEmergenciaMTextbox.Enabled = false;
            TelEmergenciaMTextbox2.Enabled = false;
            TelCondominoMTextBox.Enabled = false;   
            ProprietarioBoxSim.Enabled = false;
            ProprietarioBoxNao.Enabled = false;
            VeiculoPlacaTextBox3.Enabled = false;
            VeiculoPlacaTextBox.Enabled= false; 
            VeiculoPlacaTextBox2.Enabled = false;
            VeiculoMarcaTextBox.Enabled= false;
            VeiculoMarcaTextBox2.Enabled= false;    
            VeiculoMarcaTextBox3.Enabled = false;
            
            

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
                TipoVeiculoLabel2.Visible = false;
                TipoVeiculoLabel3.Visible= false;
                VeiculoMarcaTextBox2.Visible = false;
                VeiculoMarcaTextBox3.Visible = false;
                VeiculoLabelModelo2.Visible = false;
                VeiculoLabelModelo3.Visible= false;
                VeiculoModeloTxtBox2.Visible = false;
                VeiculoModeloTxtBox3.Visible = false;
                TipoVeiculoLabel2.Visible= false;
                TipoVeiculoLabel3.Visible = false;
                VeiculoLabelPlaca.Visible= false;
                VeiculoLabelPlaca2.Visible= false;
                VeiculoLabelPlaca3.Visible= false;
                VeiculoMarcaLabel2.Visible= false;
                VeiculoMarcaLabel3.Visible= false;
                VeiculoLabelPlaca2.Visible = false;
                VeiculoLabelPlaca3.Visible= false;
                AddVeiculoButtonAddVeiculoButton.Visible= false;
                TipoVeiculoTxtBox2.Visible= false;
                TipoVeiculoTxtBox3.Visible= false;  
               
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

        /*private void pictureBox5_Click(object sender, EventArgs e)
        {

            CadPessoasClass CPC = new CadPessoasClass(NomeEmergenciaTxtBox.Text, NomeEmergenciaTxtBox2.Text, TelEmergenciaMTextbox.Text, TelEmergenciaMTextbox2.Text, emergencianome2.Text, telefoneemergencia.Text, ProprietarioBoxNao.Checked, ProprietarioBoxSim.Checked, NomeTextBox.Text, BlocoTextBox.Text, UnidadeTextBox.Text, MoradoresTxtBox.Text, MoradoresTxtBox2.Text, MoradoresTxtBox3.Text, MoradoresTxtBox4.Text, ParentescoTxtBox.Text, ParentescoTxtBox2.Text, ParentescoTxtBox3.Text, ParentescoTxtBox4.Text, MoradoresDtNascimentoTxtBox2.Text, MoradoresDtNascimentoTxtBox3.Text, MoradoresDtNascimentoTxtBox4.Text, MoradoresDtNascimentoTxtBox.Text, TelCondominoMTextBox.Text, VagaBoxSim.Checked, VagaBoxNao.Checked, VeiculoPlacaTextBox.Text, VeiculoPlacaTextBox2.Text, VeiculoPlacaTextBox3.Text, VeiculoModeloTextBox.Text, VeiculoModeloTxtBox2.Text, VeiculoModeloTxtBox3.Text, VeiculoMarcaTextBox.Text, VeiculoMarcaTextBox2.Text, VeiculoMarcaTextBox3.Text, AnimaisCheckBoxNao.Checked, AnimaisCheckBoxSim.Checked, QuantosAnimaisTxtBox.Text, ParentescoEmergenciaTxtBox.Text, ParentescoEmergenciaTxtBox2.Text);
            MessageBox.Show(CPC.mensagem);
            NomeEmergenciaTxtBox.Text = string.Empty;
            NomeEmergenciaTxtBox2.Text = string.Empty;
            TelEmergenciaMTextbox.Text = string.Empty;
            TelEmergenciaMTextbox2.Text = string.Empty;
            ProprietarioBoxNao.Checked = false;
            ProprietarioBoxSim.Checked = false;
            NomeTextBox.Text = string.Empty;
            BlocoTextBox.Text = string.Empty;
            UnidadeTextBox.Text = string.Empty;
            MoradoresTxtBox.Text = string.Empty;
            MoradoresTxtBox2.Text = string.Empty;
            MoradoresTxtBox3.Text = string.Empty;
            MoradoresTxtBox4.Text = string.Empty;
            ParentescoTxtBox.Text = string.Empty;
            ParentescoTxtBox2.Text = string.Empty;
            ParentescoTxtBox3.Text = string.Empty;
            ParentescoTxtBox4.Text = string.Empty;
            MoradoresDtNascimentoTxtBox2.Text = string.Empty;
            MoradoresDtNascimentoTxtBox3.Text = string.Empty;
            MoradoresDtNascimentoTxtBox4.Text = string.Empty;
            MoradoresDtNascimentoTxtBox.Text = string.Empty;
            TelCondominoMTextBox.Text = string.Empty;
            VagaBoxSim.Checked = false;
            VagaBoxNao.Checked = false;
            VeiculoPlacaTextBox.Text = string.Empty;
            VeiculoPlacaTextBox2.Text = string.Empty;
            VeiculoPlacaTextBox3.Text = string.Empty;
            VeiculoModeloTextBox.Text = string.Empty;
            VeiculoModeloTxtBox2.Text = string.Empty;
            VeiculoModeloTxtBox3.Text = string.Empty;
            VeiculoMarcaTextBox.Text = string.Empty;
            VeiculoMarcaTextBox2.Text = string.Empty;
            VeiculoMarcaTextBox3.Text = string.Empty;
            AnimaisCheckBoxNao.Checked = false;
            AnimaisCheckBoxSim.Checked = false;
            QuantosAnimaisTxtBox.Text = string.Empty;
            ParentescoEmergenciaTxtBox.Text = string.Empty;
            ParentescoEmergenciaTxtBox2.Text = string.Empty;

            */

        // para voltar a funcionar, não esquecer de voltar com o comentário na linha 1008 do CadPessoas.Desigers.cs

        }
    }
