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
    public partial class LivroReclamacaoForm : Form
    {
        public LivroReclamacaoForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Opcoes OP = new Opcoes();
            this.Hide();
            OP.ShowDialog();
        }
    }
}
