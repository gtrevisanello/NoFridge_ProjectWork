namespace ProjectWorkForm
{
    partial class FormVelocità
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtboxStatoMacchina = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtboxStatoMacchina
            // 
            this.txtboxStatoMacchina.Location = new System.Drawing.Point(85, 79);
            this.txtboxStatoMacchina.Name = "txtboxStatoMacchina";
            this.txtboxStatoMacchina.ReadOnly = true;
            this.txtboxStatoMacchina.Size = new System.Drawing.Size(259, 83);
            this.txtboxStatoMacchina.TabIndex = 1;
            this.txtboxStatoMacchina.Text = "";
            // 
            // FormVelocità
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 240);
            this.Controls.Add(this.txtboxStatoMacchina);
            this.Name = "FormVelocità";
            this.Text = "Velocità di produzione";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtboxStatoMacchina;
    }
}