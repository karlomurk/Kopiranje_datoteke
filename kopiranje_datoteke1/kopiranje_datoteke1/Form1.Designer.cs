namespace kopiranje_datoteke1
{
    partial class Form1
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
            this.pokreniTipka = new System.Windows.Forms.Button();
            this.zaustaviTipka = new System.Windows.Forms.Button();
            this.napredakTraka = new System.Windows.Forms.ProgressBar();
            this.napredakTekst = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tekst = new System.Windows.Forms.TextBox();
            this.tekst1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pokreniTipka
            // 
            this.pokreniTipka.Location = new System.Drawing.Point(214, 231);
            this.pokreniTipka.Name = "pokreniTipka";
            this.pokreniTipka.Size = new System.Drawing.Size(75, 23);
            this.pokreniTipka.TabIndex = 0;
            this.pokreniTipka.Text = "b";
            this.pokreniTipka.UseVisualStyleBackColor = true;
            this.pokreniTipka.Click += new System.EventHandler(this.pokreniTipka_Click);
            // 
            // zaustaviTipka
            // 
            this.zaustaviTipka.Location = new System.Drawing.Point(382, 231);
            this.zaustaviTipka.Name = "zaustaviTipka";
            this.zaustaviTipka.Size = new System.Drawing.Size(75, 23);
            this.zaustaviTipka.TabIndex = 1;
            this.zaustaviTipka.Text = "button2";
            this.zaustaviTipka.UseVisualStyleBackColor = true;
            this.zaustaviTipka.Click += new System.EventHandler(this.zaustaviTipka_Click);
            // 
            // napredakTraka
            // 
            this.napredakTraka.Location = new System.Drawing.Point(214, 166);
            this.napredakTraka.Name = "napredakTraka";
            this.napredakTraka.Size = new System.Drawing.Size(490, 30);
            this.napredakTraka.TabIndex = 2;
            // 
            // napredakTekst
            // 
            this.napredakTekst.Location = new System.Drawing.Point(214, 203);
            this.napredakTekst.Name = "napredakTekst";
            this.napredakTekst.Size = new System.Drawing.Size(100, 22);
            this.napredakTekst.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(108, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(108, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tekst
            // 
            this.tekst.Location = new System.Drawing.Point(214, 23);
            this.tekst.Name = "tekst";
            this.tekst.Size = new System.Drawing.Size(490, 22);
            this.tekst.TabIndex = 6;
            // 
            // tekst1
            // 
            this.tekst1.Location = new System.Drawing.Point(214, 72);
            this.tekst1.Name = "tekst1";
            this.tekst1.Size = new System.Drawing.Size(490, 22);
            this.tekst1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tekst1);
            this.Controls.Add(this.tekst);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.napredakTekst);
            this.Controls.Add(this.napredakTraka);
            this.Controls.Add(this.zaustaviTipka);
            this.Controls.Add(this.pokreniTipka);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pokreniTipka;
        private System.Windows.Forms.Button zaustaviTipka;
        private System.Windows.Forms.ProgressBar napredakTraka;
        private System.Windows.Forms.TextBox napredakTekst;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tekst;
        private System.Windows.Forms.TextBox tekst1;
    }
}

