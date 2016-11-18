namespace Wypozyczalnia
{
    partial class NewRental
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
            this.txtImie = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNazwisko = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerRentDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerReturnDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPoints = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.listMovies = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMovies = new System.Windows.Forms.TextBox();
            this.btnAddRental = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.comboPoints = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtImie
            // 
            this.txtImie.Enabled = false;
            this.txtImie.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtImie.Location = new System.Drawing.Point(93, 82);
            this.txtImie.Name = "txtImie";
            this.txtImie.Size = new System.Drawing.Size(217, 31);
            this.txtImie.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 23);
            this.label2.TabIndex = 24;
            this.label2.Text = "Imie:";
            // 
            // txtNazwisko
            // 
            this.txtNazwisko.Enabled = false;
            this.txtNazwisko.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNazwisko.Location = new System.Drawing.Point(484, 82);
            this.txtNazwisko.Name = "txtNazwisko";
            this.txtNazwisko.Size = new System.Drawing.Size(217, 31);
            this.txtNazwisko.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(351, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 23);
            this.label3.TabIndex = 26;
            this.label3.Text = "Nazwisko:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(96, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(516, 54);
            this.label1.TabIndex = 27;
            this.label1.Text = "NOWE WYPOŻYCZENIE";
            // 
            // dateTimePickerRentDate
            // 
            this.dateTimePickerRentDate.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePickerRentDate.Location = new System.Drawing.Point(16, 151);
            this.dateTimePickerRentDate.Name = "dateTimePickerRentDate";
            this.dateTimePickerRentDate.Size = new System.Drawing.Size(305, 22);
            this.dateTimePickerRentDate.TabIndex = 28;
            this.dateTimePickerRentDate.CloseUp += new System.EventHandler(this.DateChange);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 23);
            this.label4.TabIndex = 24;
            this.label4.Text = "Data wypożyczenia:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(394, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 23);
            this.label5.TabIndex = 24;
            this.label5.Text = "Data zwrotu:";
            // 
            // dateTimePickerReturnDate
            // 
            this.dateTimePickerReturnDate.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePickerReturnDate.Location = new System.Drawing.Point(396, 151);
            this.dateTimePickerReturnDate.Name = "dateTimePickerReturnDate";
            this.dateTimePickerReturnDate.Size = new System.Drawing.Size(305, 22);
            this.dateTimePickerReturnDate.TabIndex = 28;
            this.dateTimePickerReturnDate.CloseUp += new System.EventHandler(this.DateChange);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(489, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 23);
            this.label6.TabIndex = 24;
            this.label6.Text = "Liczba Dni:";
            // 
            // txtDays
            // 
            this.txtDays.Enabled = false;
            this.txtDays.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtDays.Location = new System.Drawing.Point(648, 241);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(85, 31);
            this.txtDays.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(221, 353);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 23);
            this.label7.TabIndex = 24;
            this.label7.Text = "Punkty:";
            // 
            // txtPoints
            // 
            this.txtPoints.Enabled = false;
            this.txtPoints.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPoints.Location = new System.Drawing.Point(328, 350);
            this.txtPoints.Name = "txtPoints";
            this.txtPoints.Size = new System.Drawing.Size(85, 31);
            this.txtPoints.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(430, 353);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 23);
            this.label8.TabIndex = 24;
            this.label8.Text = "Cena:";
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPrice.Location = new System.Drawing.Point(511, 350);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(148, 31);
            this.txtPrice.TabIndex = 23;
            // 
            // listMovies
            // 
            this.listMovies.Font = new System.Drawing.Font("Courier New", 15.75F);
            this.listMovies.FormattingEnabled = true;
            this.listMovies.ItemHeight = 23;
            this.listMovies.Location = new System.Drawing.Point(16, 241);
            this.listMovies.Name = "listMovies";
            this.listMovies.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listMovies.Size = new System.Drawing.Size(305, 96);
            this.listMovies.TabIndex = 29;
            this.listMovies.SelectedIndexChanged += new System.EventHandler(this.listMovies_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(12, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 23);
            this.label9.TabIndex = 24;
            this.label9.Text = "Filmy:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(12, 353);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 23);
            this.label10.TabIndex = 24;
            this.label10.Text = "Filmy:";
            // 
            // txtMovies
            // 
            this.txtMovies.Enabled = false;
            this.txtMovies.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtMovies.Location = new System.Drawing.Point(119, 350);
            this.txtMovies.Name = "txtMovies";
            this.txtMovies.Size = new System.Drawing.Size(85, 31);
            this.txtMovies.TabIndex = 23;
            // 
            // btnAddRental
            // 
            this.btnAddRental.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddRental.Location = new System.Drawing.Point(483, 280);
            this.btnAddRental.Name = "btnAddRental";
            this.btnAddRental.Size = new System.Drawing.Size(250, 57);
            this.btnAddRental.TabIndex = 50;
            this.btnAddRental.Text = "Zatwierdź";
            this.btnAddRental.UseVisualStyleBackColor = true;
            this.btnAddRental.Click += new System.EventHandler(this.btnAddRental_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(415, 188);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(205, 23);
            this.label11.TabIndex = 51;
            this.label11.Text = "Naliczanie pkt:";
            // 
            // comboPoints
            // 
            this.comboPoints.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPoints.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboPoints.FormattingEnabled = true;
            this.comboPoints.Location = new System.Drawing.Point(626, 188);
            this.comboPoints.Name = "comboPoints";
            this.comboPoints.Size = new System.Drawing.Size(107, 26);
            this.comboPoints.TabIndex = 52;
            this.comboPoints.SelectedIndexChanged += new System.EventHandler(this.comboPoints_SelectedIndexChanged);
            // 
            // NewRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.comboPoints);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnAddRental);
            this.Controls.Add(this.listMovies);
            this.Controls.Add(this.dateTimePickerReturnDate);
            this.Controls.Add(this.dateTimePickerRentDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtMovies);
            this.Controls.Add(this.txtPoints);
            this.Controls.Add(this.txtDays);
            this.Controls.Add(this.txtImie);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNazwisko);
            this.Controls.Add(this.label3);
            this.Name = "NewRental";
            this.Text = "NewRental";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtImie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNazwisko;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerRentDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerReturnDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPoints;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ListBox listMovies;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMovies;
        private System.Windows.Forms.Button btnAddRental;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboPoints;
    }
}