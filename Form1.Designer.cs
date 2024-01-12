namespace Approsimazione_zeri
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
            this.btnDisegna = new System.Windows.Forms.Button();
            this.btnBisezione = new System.Windows.Forms.Button();
            this.btnSecanti = new System.Windows.Forms.Button();
            this.btnTangenti = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDisegna
            // 
            this.btnDisegna.Location = new System.Drawing.Point(21, 25);
            this.btnDisegna.Name = "btnDisegna";
            this.btnDisegna.Size = new System.Drawing.Size(75, 23);
            this.btnDisegna.TabIndex = 0;
            this.btnDisegna.Text = "disegna";
            this.btnDisegna.UseVisualStyleBackColor = true;
            this.btnDisegna.Click += new System.EventHandler(this.btnDisegna_Click);
            // 
            // btnBisezione
            // 
            this.btnBisezione.Location = new System.Drawing.Point(21, 129);
            this.btnBisezione.Name = "btnBisezione";
            this.btnBisezione.Size = new System.Drawing.Size(75, 23);
            this.btnBisezione.TabIndex = 1;
            this.btnBisezione.Text = "Bisezione";
            this.btnBisezione.UseVisualStyleBackColor = true;
            this.btnBisezione.Click += new System.EventHandler(this.btnBisezione_Click);
            // 
            // btnSecanti
            // 
            this.btnSecanti.Location = new System.Drawing.Point(21, 169);
            this.btnSecanti.Name = "btnSecanti";
            this.btnSecanti.Size = new System.Drawing.Size(75, 23);
            this.btnSecanti.TabIndex = 2;
            this.btnSecanti.Text = "Secanti";
            this.btnSecanti.UseVisualStyleBackColor = true;
            this.btnSecanti.Click += new System.EventHandler(this.btnSecanti_Click);
            // 
            // btnTangenti
            // 
            this.btnTangenti.Location = new System.Drawing.Point(21, 209);
            this.btnTangenti.Name = "btnTangenti";
            this.btnTangenti.Size = new System.Drawing.Size(75, 23);
            this.btnTangenti.TabIndex = 3;
            this.btnTangenti.Text = "Tangenti";
            this.btnTangenti.UseVisualStyleBackColor = true;
            this.btnTangenti.Click += new System.EventHandler(this.btnTangenti_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(141, 85);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnTangenti);
            this.Controls.Add(this.btnSecanti);
            this.Controls.Add(this.btnBisezione);
            this.Controls.Add(this.btnDisegna);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDisegna;
        private System.Windows.Forms.Button btnBisezione;
        private System.Windows.Forms.Button btnSecanti;
        private System.Windows.Forms.Button btnTangenti;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

