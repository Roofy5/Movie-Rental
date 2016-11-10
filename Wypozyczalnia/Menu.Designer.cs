namespace Wypozyczalnia
{
    partial class Menu
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnKlienci = new System.Windows.Forms.Button();
            this.btnFilmy = new System.Windows.Forms.Button();
            this.btnKategorie = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(176, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "WYPOŻYCZALNIA";
            // 
            // btnKlienci
            // 
            this.btnKlienci.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKlienci.Location = new System.Drawing.Point(99, 152);
            this.btnKlienci.Name = "btnKlienci";
            this.btnKlienci.Size = new System.Drawing.Size(250, 100);
            this.btnKlienci.TabIndex = 1;
            this.btnKlienci.Text = "Klienci";
            this.btnKlienci.UseVisualStyleBackColor = true;
            this.btnKlienci.Click += new System.EventHandler(this.btnKlienci_Click);
            // 
            // btnFilmy
            // 
            this.btnFilmy.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFilmy.Location = new System.Drawing.Point(397, 152);
            this.btnFilmy.Name = "btnFilmy";
            this.btnFilmy.Size = new System.Drawing.Size(250, 100);
            this.btnFilmy.TabIndex = 1;
            this.btnFilmy.Text = "Filmy";
            this.btnFilmy.UseVisualStyleBackColor = true;
            this.btnFilmy.Click += new System.EventHandler(this.btnFilmy_Click);
            // 
            // btnKategorie
            // 
            this.btnKategorie.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKategorie.Location = new System.Drawing.Point(99, 297);
            this.btnKategorie.Name = "btnKategorie";
            this.btnKategorie.Size = new System.Drawing.Size(250, 100);
            this.btnKategorie.TabIndex = 1;
            this.btnKategorie.Text = "Kategorie";
            this.btnKategorie.UseVisualStyleBackColor = true;
            this.btnKategorie.Click += new System.EventHandler(this.btnKategorie_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(99, 452);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Zapisz";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnKategorie);
            this.Controls.Add(this.btnFilmy);
            this.Controls.Add(this.btnKlienci);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKlienci;
        private System.Windows.Forms.Button btnFilmy;
        private System.Windows.Forms.Button btnKategorie;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

