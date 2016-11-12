namespace Wypozyczalnia
{
    partial class CategoriesMenu
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
            this.listCategories = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listMovies = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPoints = new System.Windows.Forms.TextBox();
            this.btnChangePoints = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listCategories
            // 
            this.listCategories.Font = new System.Drawing.Font("Courier New", 15.75F);
            this.listCategories.FormattingEnabled = true;
            this.listCategories.ItemHeight = 23;
            this.listCategories.Location = new System.Drawing.Point(12, 82);
            this.listCategories.Name = "listCategories";
            this.listCategories.Size = new System.Drawing.Size(175, 464);
            this.listCategories.TabIndex = 6;
            this.listCategories.SelectedIndexChanged += new System.EventHandler(this.listCategories_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(190, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 54);
            this.label1.TabIndex = 5;
            this.label1.Text = "KATEGORIE";
            // 
            // listMovies
            // 
            this.listMovies.Font = new System.Drawing.Font("Courier New", 15.75F);
            this.listMovies.FormattingEnabled = true;
            this.listMovies.ItemHeight = 23;
            this.listMovies.Location = new System.Drawing.Point(464, 82);
            this.listMovies.Name = "listMovies";
            this.listMovies.Size = new System.Drawing.Size(208, 464);
            this.listMovies.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(219, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 23);
            this.label5.TabIndex = 22;
            this.label5.Text = "Punkty na dzień:";
            // 
            // txtPoints
            // 
            this.txtPoints.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPoints.Location = new System.Drawing.Point(223, 124);
            this.txtPoints.Name = "txtPoints";
            this.txtPoints.Size = new System.Drawing.Size(97, 31);
            this.txtPoints.TabIndex = 21;
            // 
            // btnChangePoints
            // 
            this.btnChangePoints.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnChangePoints.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnChangePoints.Location = new System.Drawing.Point(329, 108);
            this.btnChangePoints.Name = "btnChangePoints";
            this.btnChangePoints.Size = new System.Drawing.Size(108, 61);
            this.btnChangePoints.TabIndex = 23;
            this.btnChangePoints.Text = "Ustaw punkty";
            this.btnChangePoints.UseVisualStyleBackColor = true;
            this.btnChangePoints.Click += new System.EventHandler(this.btnChangePoints_Click);
            // 
            // CategoriesMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.btnChangePoints);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPoints);
            this.Controls.Add(this.listMovies);
            this.Controls.Add(this.listCategories);
            this.Controls.Add(this.label1);
            this.Name = "CategoriesMenu";
            this.Text = "CategoriesMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listCategories;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listMovies;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPoints;
        private System.Windows.Forms.Button btnChangePoints;
    }
}