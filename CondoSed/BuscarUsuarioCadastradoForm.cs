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
    public partial class BuscarUsuarioCadastradoForm : Form
    {
        public BuscarUsuarioCadastradoForm()
        {
            InitializeComponent();
        }

        private void BuscarUsuarioCadastradoForm_Load(object sender, EventArgs e)
        {
            Nome2textBox.Enabled = false;
            Codigo2TextBox.Enabled = false;
            FuncaoTextBox2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Nome2textBox.Enabled = true;
            Codigo2TextBox.Enabled = true;
            FuncaoTextBox2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            CadUsuario cadU = new CadUsuario();
            cadU.ShowDialog();
        }
    }
}
