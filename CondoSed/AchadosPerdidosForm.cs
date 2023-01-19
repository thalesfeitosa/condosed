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
    public partial class AchadosPerdidosForm : Form
    {
        public AchadosPerdidosForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AdicionaAchados_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void AchadosPerdidosForm_Load(object sender, EventArgs e)
        {
            ItemAchadoBox.Enabled = false;
            LocalAchadoBox.Enabled = false;
            EntregueCheckBox.Enabled = false;
        }

        private void AdicionaAchados_Click(object sender, EventArgs e)
        {
            ItemAchadoBox.Enabled = true;
            LocalAchadoBox.Enabled = true;
            EntregueCheckBox.Enabled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Opcoes opc = new Opcoes();
            opc.ShowDialog();
        }
    }
}
