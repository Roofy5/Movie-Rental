namespace Wypozyczalnia
{
    partial class MoviesMenu
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
            this.btnMovieInfo = new System.Windows.Forms.Button();
            this.btnModifyMovie = new System.Windows.Forms.Button();
            this.btnDeleteMovie = new System.Windows.Forms.Button();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMovieInfo
            // 
            this.btnMovieInfo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnMovieInfo.Location = new System.Drawing.Point(22, 191);
            this.btnMovieInfo.Name = "btnMovieInfo";
            this.btnMovieInfo.Size = new System.Drawing.Size(184, 97);
            this.btnMovieInfo.TabIndex = 5;
            this.btnMovieInfo.Text = "Informacje o filmie";
            this.btnMovieInfo.UseVisualStyleBackColor = true;
            // 
            // btnModifyMovie
            // 
            this.btnModifyMovie.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnModifyMovie.Location = new System.Drawing.Point(22, 294);
            this.btnModifyMovie.Name = "btnModifyMovie";
            this.btnModifyMovie.Size = new System.Drawing.Size(184, 97);
            this.btnModifyMovie.TabIndex = 6;
            this.btnModifyMovie.Text = "Modyfikuj film";
            this.btnModifyMovie.UseVisualStyleBackColor = true;
            // 
            // btnDeleteMovie
            // 
            this.btnDeleteMovie.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDeleteMovie.Location = new System.Drawing.Point(22, 397);
            this.btnDeleteMovie.Name = "btnDeleteMovie";
            this.btnDeleteMovie.Size = new System.Drawing.Size(184, 97);
            this.btnDeleteMovie.TabIndex = 7;
            this.btnDeleteMovie.Text = "Usuń film";
            this.btnDeleteMovie.UseVisualStyleBackColor = true;
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.Location = new System.Drawing.Point(22, 88);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(184, 97);
            this.btnAddMovie.TabIndex = 8;
            this.btnAddMovie.Text = "Dodaj film";
            this.btnAddMovie.UseVisualStyleBackColor = true;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(273, 88);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(366, 407);
            this.listBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Panel Filmu";
            // 
            // MoviesMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.btnMovieInfo);
            this.Controls.Add(this.btnModifyMovie);
            this.Controls.Add(this.btnDeleteMovie);
            this.Controls.Add(this.btnAddMovie);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Name = "MoviesMenu";
            this.Text = "MoviesMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMovieInfo;
        private System.Windows.Forms.Button btnModifyMovie;
        private System.Windows.Forms.Button btnDeleteMovie;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
    }
}