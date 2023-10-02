namespace CRUD
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
            this.nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.prezzo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.LISTAP = new System.Windows.Forms.ListBox();
            this.search = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.newname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.newwprice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.textBoxPercentuale = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(291, 85);
            this.nome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(161, 22);
            this.nome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(329, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Prodotto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // prezzo
            // 
            this.prezzo.Location = new System.Drawing.Point(291, 145);
            this.prezzo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.prezzo.Name = "prezzo";
            this.prezzo.Size = new System.Drawing.Size(161, 22);
            this.prezzo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(341, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prezzo";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button1.Location = new System.Drawing.Point(597, 42);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 80);
            this.button1.TabIndex = 5;
            this.button1.Text = "aggiungi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LISTAP
            // 
            this.LISTAP.FormattingEnabled = true;
            this.LISTAP.ItemHeight = 16;
            this.LISTAP.Location = new System.Drawing.Point(1020, 54);
            this.LISTAP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LISTAP.Name = "LISTAP";
            this.LISTAP.Size = new System.Drawing.Size(368, 388);
            this.LISTAP.TabIndex = 6;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(230, 233);
            this.search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(269, 22);
            this.search.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(226, 197);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Inserisci il prodotto da cercare";
            // 
            // newname
            // 
            this.newname.Location = new System.Drawing.Point(217, 313);
            this.newname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.newname.Name = "newname";
            this.newname.Size = new System.Drawing.Size(269, 22);
            this.newname.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(249, 275);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Inserisci il nuovo nome";
            // 
            // newwprice
            // 
            this.newwprice.Location = new System.Drawing.Point(217, 400);
            this.newwprice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.newwprice.Name = "newwprice";
            this.newwprice.Size = new System.Drawing.Size(269, 22);
            this.newwprice.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(241, 355);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Inserisci il nuovo prezzo";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button2.Location = new System.Drawing.Point(597, 130);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 94);
            this.button2.TabIndex = 14;
            this.button2.Text = "Modifica il nome";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button3.Location = new System.Drawing.Point(597, 240);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 95);
            this.button3.TabIndex = 15;
            this.button3.Text = "Modifica il prezzo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button4.Location = new System.Drawing.Point(597, 342);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(153, 94);
            this.button4.TabIndex = 16;
            this.button4.Text = "elimina";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button5.Location = new System.Drawing.Point(603, 456);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(146, 92);
            this.button5.TabIndex = 17;
            this.button5.Text = "ordinamento";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button6.Location = new System.Drawing.Point(768, 42);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(132, 79);
            this.button6.TabIndex = 18;
            this.button6.Text = "somma prezzi";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button7.Location = new System.Drawing.Point(766, 130);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(134, 110);
            this.button7.TabIndex = 19;
            this.button7.Text = "Aggiunta o sottrazione di una percentuale ";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button8.Location = new System.Drawing.Point(767, 246);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(132, 88);
            this.button8.TabIndex = 20;
            this.button8.Text = "salvataggio su file";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button9.Location = new System.Drawing.Point(766, 355);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(133, 80);
            this.button9.TabIndex = 21;
            this.button9.Text = "lettura da file";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button10.Location = new System.Drawing.Point(765, 462);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(134, 85);
            this.button10.TabIndex = 22;
            this.button10.Text = "trova prodotto min";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button11.Location = new System.Drawing.Point(691, 570);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(157, 66);
            this.button11.TabIndex = 23;
            this.button11.Text = "trova prodotto max";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // textBoxPercentuale
            // 
            this.textBoxPercentuale.Location = new System.Drawing.Point(217, 475);
            this.textBoxPercentuale.Name = "textBoxPercentuale";
            this.textBoxPercentuale.Size = new System.Drawing.Size(259, 22);
            this.textBoxPercentuale.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.Location = new System.Drawing.Point(226, 439);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(244, 24);
            this.label6.TabIndex = 25;
            this.label6.Text = "Aggiungi/sottrai percentuale";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1447, 668);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxPercentuale);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.newwprice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.newname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.search);
            this.Controls.Add(this.LISTAP);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.prezzo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nome);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox prezzo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox LISTAP;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox newname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox newwprice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.TextBox textBoxPercentuale;
        private System.Windows.Forms.Label label6;
    }
}

