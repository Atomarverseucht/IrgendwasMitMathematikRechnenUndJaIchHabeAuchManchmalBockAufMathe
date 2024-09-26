namespace IrgendwasMitMathematikRechnenUndJaIchHabeAuchManchmalBockAufMathe
{
    partial class Ausgabe
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
            this.rtbAusgabe = new System.Windows.Forms.RichTextBox();
            this.btEingabe = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbAusgabe
            // 
            this.rtbAusgabe.Location = new System.Drawing.Point(37, 113);
            this.rtbAusgabe.Name = "rtbAusgabe";
            this.rtbAusgabe.Size = new System.Drawing.Size(1219, 858);
            this.rtbAusgabe.TabIndex = 0;
            this.rtbAusgabe.Text = "";
            // 
            // btEingabe
            // 
            this.btEingabe.Location = new System.Drawing.Point(37, 29);
            this.btEingabe.Name = "btEingabe";
            this.btEingabe.Size = new System.Drawing.Size(350, 55);
            this.btEingabe.TabIndex = 1;
            this.btEingabe.Text = "Zurück zur Eingabe";
            this.btEingabe.UseVisualStyleBackColor = true;
            this.btEingabe.Click += new System.EventHandler(this.btEingabe_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(885, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(371, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "Rechne";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ausgabe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1547, 1010);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btEingabe);
            this.Controls.Add(this.rtbAusgabe);
            this.Name = "Ausgabe";
            this.Text = "Ausgabe";
            this.Load += new System.EventHandler(this.Ausgabe_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbAusgabe;
        private System.Windows.Forms.Button btEingabe;
        private System.Windows.Forms.Button button1;
    }
}