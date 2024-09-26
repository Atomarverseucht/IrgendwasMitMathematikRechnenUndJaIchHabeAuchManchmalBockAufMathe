namespace IrgendwasMitMathematikRechnenUndJaIchHabeAuchManchmalBockAufMathe
{
    partial class Eingabe
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btAusgabe = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cbEingabe = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btAusgabe
            // 
            this.btAusgabe.Location = new System.Drawing.Point(1130, 836);
            this.btAusgabe.Name = "btAusgabe";
            this.btAusgabe.Size = new System.Drawing.Size(317, 78);
            this.btAusgabe.TabIndex = 0;
            this.btAusgabe.Text = "Rechne aus";
            this.btAusgabe.UseVisualStyleBackColor = true;
            this.btAusgabe.Click += new System.EventHandler(this.btAusgabe_Click);
            // 
            // cbEingabe
            // 
            this.cbEingabe.FormattingEnabled = true;
            this.cbEingabe.Items.AddRange(new object[] {
            "Primzahlen berechnen"});
            this.cbEingabe.Location = new System.Drawing.Point(92, 73);
            this.cbEingabe.Name = "cbEingabe";
            this.cbEingabe.Size = new System.Drawing.Size(536, 33);
            this.cbEingabe.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Was willst du?";
            // 
            // Eingabe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1649, 990);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbEingabe);
            this.Controls.Add(this.btAusgabe);
            this.Name = "Eingabe";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAusgabe;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cbEingabe;
        private System.Windows.Forms.Label label1;
    }
}

