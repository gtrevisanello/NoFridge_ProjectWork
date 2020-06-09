namespace CSharpBordoMacchina
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
            this.label1 = new System.Windows.Forms.Label();
            this.box_controlWord = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.message = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.box_guasti = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.box_watchDog = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_invia = new System.Windows.Forms.Button();
            this.dgvCommesse = new System.Windows.Forms.DataGridView();
            this.txtCodice = new System.Windows.Forms.TextBox();
            this.txtPzLotto = new System.Windows.Forms.TextBox();
            this.txtArticolo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.nudVelocita = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommesse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVelocita)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "SELEZIONA COMMESSA:";
            // 
            // box_controlWord
            // 
            this.box_controlWord.FormattingEnabled = true;
            this.box_controlWord.Location = new System.Drawing.Point(794, 102);
            this.box_controlWord.Name = "box_controlWord";
            this.box_controlWord.Size = new System.Drawing.Size(270, 24);
            this.box_controlWord.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(660, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "CONTROL WORD:";
            // 
            // message
            // 
            this.message.Location = new System.Drawing.Point(884, 149);
            this.message.MaxLength = 100;
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(180, 96);
            this.message.TabIndex = 4;
            this.message.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(660, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "MESSAGGIO PER OPERATORE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(725, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "VELOCITA MACCHINA:";
            // 
            // box_guasti
            // 
            this.box_guasti.FormattingEnabled = true;
            this.box_guasti.Location = new System.Drawing.Point(794, 306);
            this.box_guasti.Name = "box_guasti";
            this.box_guasti.Size = new System.Drawing.Size(270, 24);
            this.box_guasti.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(659, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "GUASTI SIMULATI:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(780, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "WATCH DOG:";
            // 
            // box_watchDog
            // 
            this.box_watchDog.FormattingEnabled = true;
            this.box_watchDog.Location = new System.Drawing.Point(884, 347);
            this.box_watchDog.Name = "box_watchDog";
            this.box_watchDog.Size = new System.Drawing.Size(180, 24);
            this.box_watchDog.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(353, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(422, 46);
            this.label7.TabIndex = 12;
            this.label7.Text = "NUOVA COMMESSA";
            // 
            // btn_invia
            // 
            this.btn_invia.Location = new System.Drawing.Point(844, 394);
            this.btn_invia.Name = "btn_invia";
            this.btn_invia.Size = new System.Drawing.Size(132, 69);
            this.btn_invia.TabIndex = 13;
            this.btn_invia.Text = "INVIA DATI";
            this.btn_invia.UseVisualStyleBackColor = true;
            this.btn_invia.Click += new System.EventHandler(this.btn_invia_Click);
            // 
            // dgvCommesse
            // 
            this.dgvCommesse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCommesse.Location = new System.Drawing.Point(15, 202);
            this.dgvCommesse.Name = "dgvCommesse";
            this.dgvCommesse.RowHeadersWidth = 51;
            this.dgvCommesse.RowTemplate.Height = 24;
            this.dgvCommesse.Size = new System.Drawing.Size(604, 273);
            this.dgvCommesse.TabIndex = 14;
            this.dgvCommesse.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCommesse_RowHeaderMouseClick);
            // 
            // txtCodice
            // 
            this.txtCodice.Enabled = false;
            this.txtCodice.Location = new System.Drawing.Point(15, 162);
            this.txtCodice.Name = "txtCodice";
            this.txtCodice.Size = new System.Drawing.Size(147, 22);
            this.txtCodice.TabIndex = 15;
            // 
            // txtPzLotto
            // 
            this.txtPzLotto.Enabled = false;
            this.txtPzLotto.Location = new System.Drawing.Point(472, 162);
            this.txtPzLotto.Name = "txtPzLotto";
            this.txtPzLotto.Size = new System.Drawing.Size(147, 22);
            this.txtPzLotto.TabIndex = 16;
            // 
            // txtArticolo
            // 
            this.txtArticolo.Enabled = false;
            this.txtArticolo.Location = new System.Drawing.Point(249, 162);
            this.txtArticolo.Name = "txtArticolo";
            this.txtArticolo.Size = new System.Drawing.Size(147, 22);
            this.txtArticolo.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "CODICE:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(246, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "ARTICOLO:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(469, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "PEZZI PER LOTTO:";
            // 
            // nudVelocita
            // 
            this.nudVelocita.Location = new System.Drawing.Point(884, 266);
            this.nudVelocita.Name = "nudVelocita";
            this.nudVelocita.Size = new System.Drawing.Size(180, 22);
            this.nudVelocita.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 487);
            this.Controls.Add(this.nudVelocita);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtArticolo);
            this.Controls.Add(this.txtPzLotto);
            this.Controls.Add(this.txtCodice);
            this.Controls.Add(this.dgvCommesse);
            this.Controls.Add(this.btn_invia);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.box_watchDog);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.box_guasti);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.message);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.box_controlWord);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Compilazione Commesse";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommesse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVelocita)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox box_controlWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox message;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox box_guasti;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox box_watchDog;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_invia;
        private System.Windows.Forms.DataGridView dgvCommesse;
        private System.Windows.Forms.TextBox txtCodice;
        private System.Windows.Forms.TextBox txtPzLotto;
        private System.Windows.Forms.TextBox txtArticolo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nudVelocita;
    }
}

