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
    public partial class loading : Form
    {
        public loading()
        {
            InitializeComponent();
        }
        private void loading_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            if (progressBar1.Value ==100)
            {
                timer1.Enabled = false;
                this.Hide();
                Selecao select = new Selecao();
                select.ShowDialog();
                this.Close();
                

                    
            }
            else ChargeText.Text = progressBar1.Value.ToString() + "%";
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void ChargeText_Click(object sender, EventArgs e)
        {

        }
    }
}
