using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWorkForm
{
    public partial class Form1 : Form
    {
        public string Ricerca;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        void txtSelezione_TextChanged(object sender, EventArgs e)
        {
            Ricerca = txtSelezione.Text;

            /*void funcRicerca()
            {
                Commessa myCommessa = new Commessa();
                this.DataGridView1.DataSource = myCommessa.GetCommesse(Ricerca);
            }*/
        }

        void btnInvia_Click(object sender, EventArgs e)
        {
            Commessa myCommessa = new Commessa();
            this.DataGridView1.DataSource = myCommessa.GetCommesse(Ricerca);
        }


        //-----------------------------------------------------------------------------------------------------------------

        private void btnStatoMacchina_Click(object sender, EventArgs e)
        {
            FormStatoMacchina form2 = new FormStatoMacchina();
            form2.Show();
        }

        private void btnVelocità_Click(object sender, EventArgs e)
        {
            FormVelocità form3 = new FormVelocità();
            form3.Show();
        }
    }
}
