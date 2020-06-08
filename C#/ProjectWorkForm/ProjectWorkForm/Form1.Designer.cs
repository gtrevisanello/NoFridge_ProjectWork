namespace ProjectWorkForm
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelSelezioneProdotto = new System.Windows.Forms.Label();
            this.labelControllo = new System.Windows.Forms.Label();
            this.button0 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelProdottoSelezionato = new System.Windows.Forms.Label();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelInfo = new System.Windows.Forms.Label();
            this.labelStatoMacchina = new System.Windows.Forms.Label();
            this.labelVelocità = new System.Windows.Forms.Label();
            this.labelIP = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnInvia = new System.Windows.Forms.Button();
            this.btnStatoMacchina = new System.Windows.Forms.Button();
            this.btnVelocità = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBoxSceltaProdotto = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSelezioneProdotto
            // 
            this.labelSelezioneProdotto.AutoSize = true;
            this.labelSelezioneProdotto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelezioneProdotto.Location = new System.Drawing.Point(52, 78);
            this.labelSelezioneProdotto.Name = "labelSelezioneProdotto";
            this.labelSelezioneProdotto.Size = new System.Drawing.Size(338, 20);
            this.labelSelezioneProdotto.TabIndex = 1;
            this.labelSelezioneProdotto.Text = "Selezione prodotto (Nome dell\'articolo)";
            this.labelSelezioneProdotto.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelControllo
            // 
            this.labelControllo.AutoSize = true;
            this.labelControllo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControllo.Location = new System.Drawing.Point(990, 51);
            this.labelControllo.Name = "labelControllo";
            this.labelControllo.Size = new System.Drawing.Size(127, 20);
            this.labelControllo.TabIndex = 2;
            this.labelControllo.Text = "Controllo PLC";
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(852, 93);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(111, 51);
            this.button0.TabIndex = 3;
            this.button0.Text = "Abilita produzione";
            this.button0.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(998, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 51);
            this.button1.TabIndex = 4;
            this.button1.Text = "Abilita avvio programmato";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1143, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 51);
            this.button2.TabIndex = 5;
            this.button2.Text = "Blocco immediato produzione";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // labelProdottoSelezionato
            // 
            this.labelProdottoSelezionato.AutoSize = true;
            this.labelProdottoSelezionato.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProdottoSelezionato.Location = new System.Drawing.Point(52, 162);
            this.labelProdottoSelezionato.Name = "labelProdottoSelezionato";
            this.labelProdottoSelezionato.Size = new System.Drawing.Size(172, 20);
            this.labelProdottoSelezionato.TabIndex = 6;
            this.labelProdottoSelezionato.Text = "Prodotti selezionati";
            // 
            // DataGridView1
            // 
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(32, 212);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowHeadersWidth = 51;
            this.DataGridView1.RowTemplate.Height = 24;
            this.DataGridView1.Size = new System.Drawing.Size(755, 242);
            this.DataGridView1.TabIndex = 7;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.Location = new System.Drawing.Point(972, 212);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(154, 20);
            this.labelInfo.TabIndex = 8;
            this.labelInfo.Text = "Informazioni PLC";
            // 
            // labelStatoMacchina
            // 
            this.labelStatoMacchina.AutoSize = true;
            this.labelStatoMacchina.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatoMacchina.Location = new System.Drawing.Point(849, 265);
            this.labelStatoMacchina.Name = "labelStatoMacchina";
            this.labelStatoMacchina.Size = new System.Drawing.Size(119, 17);
            this.labelStatoMacchina.TabIndex = 9;
            this.labelStatoMacchina.Text = "Stato Macchina";
            // 
            // labelVelocità
            // 
            this.labelVelocità.AutoSize = true;
            this.labelVelocità.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVelocità.Location = new System.Drawing.Point(1065, 265);
            this.labelVelocità.Name = "labelVelocità";
            this.labelVelocità.Size = new System.Drawing.Size(152, 17);
            this.labelVelocità.TabIndex = 10;
            this.labelVelocità.Text = "Velocità produzione";
            // 
            // labelIP
            // 
            this.labelIP.AutoSize = true;
            this.labelIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIP.Location = new System.Drawing.Point(53, 34);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(88, 17);
            this.labelIP.TabIndex = 11;
            this.labelIP.Text = "Indirizzo IP";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(148, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 22);
            this.textBox1.TabIndex = 12;
            // 
            // btnInvia
            // 
            this.btnInvia.Location = new System.Drawing.Point(334, 110);
            this.btnInvia.Name = "btnInvia";
            this.btnInvia.Size = new System.Drawing.Size(114, 44);
            this.btnInvia.TabIndex = 13;
            this.btnInvia.Text = "Invio";
            this.btnInvia.UseVisualStyleBackColor = true;
            // 
            // btnStatoMacchina
            // 
            this.btnStatoMacchina.Location = new System.Drawing.Point(852, 306);
            this.btnStatoMacchina.Name = "btnStatoMacchina";
            this.btnStatoMacchina.Size = new System.Drawing.Size(111, 68);
            this.btnStatoMacchina.TabIndex = 14;
            this.btnStatoMacchina.Text = "Visualizza lo stato della macchina";
            this.btnStatoMacchina.UseVisualStyleBackColor = true;
            this.btnStatoMacchina.Click += new System.EventHandler(this.btnStatoMacchina_Click);
            // 
            // btnVelocità
            // 
            this.btnVelocità.Location = new System.Drawing.Point(1081, 306);
            this.btnVelocità.Name = "btnVelocità";
            this.btnVelocità.Size = new System.Drawing.Size(111, 68);
            this.btnVelocità.TabIndex = 15;
            this.btnVelocità.Text = "Visualizza la velocità di produzione";
            this.btnVelocità.UseVisualStyleBackColor = true;
            this.btnVelocità.Click += new System.EventHandler(this.btnVelocità_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(334, 27);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 39);
            this.button3.TabIndex = 16;
            this.button3.Text = "Invio";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // comboBoxSceltaProdotto
            // 
            this.comboBoxSceltaProdotto.FormattingEnabled = true;
            this.comboBoxSceltaProdotto.Location = new System.Drawing.Point(56, 120);
            this.comboBoxSceltaProdotto.Name = "comboBoxSceltaProdotto";
            this.comboBoxSceltaProdotto.Size = new System.Drawing.Size(245, 24);
            this.comboBoxSceltaProdotto.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 531);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnVelocità);
            this.Controls.Add(this.btnStatoMacchina);
            this.Controls.Add(this.btnInvia);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelIP);
            this.Controls.Add(this.labelVelocità);
            this.Controls.Add(this.labelStatoMacchina);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.labelProdottoSelezionato);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.labelControllo);
            this.Controls.Add(this.labelSelezioneProdotto);
            this.Controls.Add(this.comboBoxSceltaProdotto);
            this.Name = "Form1";
            this.Text = "Menu principale";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelSelezioneProdotto;
        private System.Windows.Forms.Label labelControllo;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelProdottoSelezionato;
        private System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label labelStatoMacchina;
        private System.Windows.Forms.Label labelVelocità;
        private System.Windows.Forms.Label labelIP;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnInvia;
        private System.Windows.Forms.Button btnStatoMacchina;
        private System.Windows.Forms.Button btnVelocità;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBoxSceltaProdotto;
    }
}

