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
    public partial class CorreiosForm : Form
    {
        public CorreiosForm()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            CadastroCorreiosForm cadcorreios = new CadastroCorreiosForm();
            cadcorreios.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Opcoes OP = new Opcoes();
            this.Hide();
            OP.ShowDialog();
            
        }
    }
}
