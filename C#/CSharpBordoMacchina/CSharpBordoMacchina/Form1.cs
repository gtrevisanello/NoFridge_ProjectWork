using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpBordoMacchina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData()
        {
            Commessa myCommessa = new Commessa();
            this.dgvCommesse.DataSource = myCommessa.getDB();

            string[] items = new string[] { 
                "Abilito produzione da ufficio", 
                "Start programmato da ufficio",
                "Blocco incondizionato produzione"
            };
            box_controlWord.DataSource = items;
            box_controlWord.SelectedIndex = 0;

            items = new string[] {
                "Mancanza pezzi al prelievo",
                "Scarico pieno",
                "Pressa guasta",
                "Coclea guasta",
                "Mancanza aria impanto",
                "Elettro-valvola 1 rotta",
                "Elettro-valvola 2 rotta",
                "Elettro-valvola 3 rotta",
                "Elettro-valvola 4 rotta",
                "Sensore fine-corsa pistone 1 rotto",
                "Sensore fine-corsa pistone 2 rotto",
                "Sensore fine-corsa pistone 3 rotto",
                "Sensore fine-corsa pistone 4 rotto"
            };
            box_guasti.DataSource = items;
            box_guasti.SelectedIndex = 0;

            items = new string[] { "0", "1" };
            box_watchDog.DataSource = items;
            box_watchDog.SelectedIndex = 0;
        }

        private void dgvCommesse_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int currentRow = e.RowIndex;
            string Codice = dgvCommesse.Rows[currentRow].Cells["Codice_Prodotto"].Value.ToString();
            getCommessaDetails(Codice);
        }

        private void getCommessaDetails(string id)
        {
            Commessa myCommessa = new Commessa();
            myCommessa.getCommessa(id);

            txtArticolo.Text = myCommessa.Articolo;
            txtCodice.Text = myCommessa.Codice;
            txtPzLotto.Text = myCommessa.PzLotto.ToString();
        }

        private bool voidFields()
        {
            if (txtCodice.Text == "")
            {
                MessageBox.Show("Selezionare un articolo!", "COMMESSA INCOMPLETA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else
                return false;
        }

        private void btn_invia_Click(object sender, EventArgs e)
        {
            if (!voidFields())
            {
                string Codice = txtCodice.Text;
                string Articolo = txtArticolo.Text;
                int PzLotto = Convert.ToInt32(txtPzLotto.Text);
                int ControlWord = box_controlWord.SelectedIndex;
                string Avviso = message.Text;
                int Velocita = Convert.ToInt32(nudVelocita.Value);
                int Guasto = box_guasti.SelectedIndex;
                int WatchDog = box_watchDog.SelectedIndex;

                Commessa myCommessa = new Commessa(Codice, Articolo, PzLotto, ControlWord, Avviso, Velocita, Guasto, WatchDog);

                DialogResult = MessageBox.Show("Dopo questo messaggio la composizione non potrà essere bloccata.\nInviare i dati al PLC?", "INVIO DATI AL PLC", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.Yes)
                {
                    int result = myCommessa.PCtoPLC();
                    if (result == 200)
                        MessageBox.Show("Commessa inviata correttamente", "STATUS: 200", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
