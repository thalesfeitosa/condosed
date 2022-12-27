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
    public partial class Opcoes : Form
    {
        public Opcoes()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CadPessoas Cadp =  new CadPessoas();    
            Cadp.ShowDialog();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            CorreiosForm correios = new CorreiosForm();
            correios.ShowDialog();
            
        }

        private void AreaComumPic_Click(object sender, EventArgs e)
        {
            AgendamentoForm AGF = new AgendamentoForm();
            this.Hide();
            AGF.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            LivroReclamacaoForm LR = new LivroReclamacaoForm();
            this.Hide();
            LR.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            AchadosPerdidosForm AP = new AchadosPerdidosForm();
            this.Hide();
            AP.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("RECURSO EM FASE DE DESENVOLVIMENTO!!");
        }
    }
}
