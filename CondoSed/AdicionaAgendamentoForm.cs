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
    public partial class AdicionaAgendamentoForm : Form
    {
        public AdicionaAgendamentoForm()
        {
            InitializeComponent();
        }

        private void AdicionaAgendamentoForm_Load(object sender, EventArgs e)
        {
            TotalConvidadosSalaolbl.Visible = false;
            TotalConvidadosTxtBox.Visible = false;
            QtdFilhosTxtbox1.Visible = false;
            QtdFilhosTxtbox2.Visible = false;
            QtdFilhosTxtbox3.Visible = false;
            QtdFilhosTxtbox4.Visible = false;
            QtdFilhosTxtbox5.Visible = false;
            QtdFilhosTxtbox6.Visible = false;
            QtdFilhosTxtbox7.Visible = false;
            QtdFilhosTxtbox8.Visible = false;
            QtdLabel1.Visible = false;
            QtdLabel2.Visible = false;
            QtdLabel3.Visible = false;
            QtdLabel4.Visible = false;
            QtdLabel5.Visible = false;
            QtdLabel6.Visible = false;
            QtdLabel7.Visible = false;
            QtdLabel8.Visible = false;


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void AgendaSalaoSimCb_CheckedChanged(object sender, EventArgs e)
        {
            if(AgendaSalaoSimCb.Checked)
            {
                TotalConvidadosTxtBox.Visible = true;
                TotalConvidadosSalaolbl.Visible = true;
            }
            
            else
            {
                TotalConvidadosTxtBox.Visible = false;
                TotalConvidadosSalaolbl.Visible=false;
            }
        }

        private void FilhosConvidadosCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (FilhosConvidadosCheckBox1.Checked)
            {
                QtdLabel1.Visible = true;
                QtdFilhosTxtbox1.Visible = true;
            }
            else
            {
                QtdLabel1.Visible = false;
                QtdFilhosTxtbox1.Visible = false;
            }
        }

        private void FilhosConvidadosCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (FilhosConvidadosCheckBox2.Checked)
            {
                QtdFilhosTxtbox2.Visible = true;
                QtdLabel2.Visible = true;
            }
            else
            {
                QtdFilhosTxtbox2.Visible = false;
                QtdLabel2.Visible = false;
            }
        }

        private void FilhosConvidadosCheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (FilhosConvidadosCheckBox3.Checked)
            {
                QtdFilhosTxtbox3.Visible = true;
                QtdLabel3.Visible = true;
            }
            else
            {
                QtdFilhosTxtbox3.Visible = false;
                QtdLabel3.Visible = false;
            }
        }

        private void FilhosConvidadosCheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (FilhosConvidadosCheckBox4.Checked)
            {
                QtdFilhosTxtbox4.Visible = true;
                QtdLabel4.Visible = true;
            }
            else
            {
                QtdFilhosTxtbox4.Visible = false;
                QtdLabel4.Visible = false;
            }
        }

        private void FilhosConvidadosCheckBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (FilhosConvidadosCheckBox5.Checked)
            {
                QtdFilhosTxtbox5.Visible = true;
                QtdLabel5.Visible = true;
            }
            else
            {
                QtdFilhosTxtbox5.Visible = false;
                QtdLabel5.Visible = false;
            }
        }

        private void FilhosConvidadosCheckBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (FilhosConvidadosCheckBox6.Checked)
            {
                QtdFilhosTxtbox6.Visible = true;
                QtdLabel6.Visible = true;
            }
            else
            {
                QtdFilhosTxtbox6.Visible = false;
                QtdLabel6.Visible = false;
            }
        }

        private void FilhosConvidadosCheckBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (FilhosConvidadosCheckBox7.Checked)
            {
                QtdFilhosTxtbox7.Visible = true;
                QtdLabel7.Visible = true;
            }
            else
            {
                QtdFilhosTxtbox7.Visible = false;
                QtdLabel7.Visible = false;
            }
        }

        private void FilhosConvidadosCheckBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (FilhosConvidadosCheckBox8.Checked)
            {
                QtdFilhosTxtbox8.Visible = true;
                QtdLabel8.Visible = true;
            }
            else
            {
                QtdFilhosTxtbox8.Visible = false;
                QtdLabel8.Visible = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AgendamentoForm agendamentoForm = new AgendamentoForm();
            this.Hide();
            agendamentoForm.ShowDialog();

        }
    }
}
