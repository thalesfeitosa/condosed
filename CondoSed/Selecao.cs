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
    public partial class Selecao : Form
    {
        public Selecao()
        {
            InitializeComponent();
        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CadUsuario CadUser = new CadUsuario();
            CadUser.ShowDialog();
            this.Close();
        }

     

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Opcoes opt = new Opcoes();
            opt.ShowDialog();
            this.Dispose();
        }
    }
}
