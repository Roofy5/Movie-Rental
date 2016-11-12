namespace Wypozyczalnia
{
    partial class PrintOutMenu
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
            this.listPrintOutTypes = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioAll = new System.Windows.Forms.RadioButton();
            this.radioPrice = new System.Windows.Forms.RadioButton();
            this.radioPoints = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // listPrintOutTypes
            // 
            this.listPrintOutTypes.Font = new System.Drawing.Font("Courier New", 15.75F);
            this.listPrintOutTypes.FormattingEnabled = true;
            this.listPrintOutTypes.ItemHeight = 23;
            this.listPrintOutTypes.Location = new System.Drawing.Point(46, 105);
            this.listPrintOutTypes.Name = "listPrintOutTypes";
            this.listPrintOutTypes.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listPrintOutTypes.Size = new System.Drawing.Size(162, 280);
            this.listPrintOutTypes.TabIndex = 84;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(274, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 54);
            this.label1.TabIndex = 81;
            this.label1.Text = "WYDRUK";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(42, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 23);
            this.label9.TabIndex = 75;
            this.label9.Text = "Opcje druku:";
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrint.Location = new System.Drawing.Point(214, 178);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(250, 100);
            this.btnPrint.TabIndex = 85;
            this.btnPrint.Text = "Drukuj";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(470, 105);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(302, 277);
            this.richTextBox1.TabIndex = 86;
            this.richTextBox1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(466, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 23);
            this.label2.TabIndex = 75;
            this.label2.Text = "Wydruk:";
            // 
            // radioAll
            // 
            this.radioAll.AutoSize = true;
            this.radioAll.Checked = true;
            this.radioAll.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioAll.Location = new System.Drawing.Point(234, 106);
            this.radioAll.Name = "radioAll";
            this.radioAll.Size = new System.Drawing.Size(106, 22);
            this.radioAll.TabIndex = 87;
            this.radioAll.TabStop = true;
            this.radioAll.Text = "Wszystko";
            this.radioAll.UseVisualStyleBackColor = true;
            // 
            // radioPrice
            // 
            this.radioPrice.AutoSize = true;
            this.radioPrice.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioPrice.Location = new System.Drawing.Point(234, 129);
            this.radioPrice.Name = "radioPrice";
            this.radioPrice.Size = new System.Drawing.Size(126, 22);
            this.radioPrice.TabIndex = 87;
            this.radioPrice.Text = "Tylko cena";
            this.radioPrice.UseVisualStyleBackColor = true;
            // 
            // radioPoints
            // 
            this.radioPoints.AutoSize = true;
            this.radioPoints.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioPoints.Location = new System.Drawing.Point(234, 152);
            this.radioPoints.Name = "radioPoints";
            this.radioPoints.Size = new System.Drawing.Size(146, 22);
            this.radioPoints.TabIndex = 87;
            this.radioPoints.Text = "Tylko punkty";
            this.radioPoints.UseVisualStyleBackColor = true;
            // 
            // PrintOutMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.radioPoints);
            this.Controls.Add(this.radioPrice);
            this.Controls.Add(this.radioAll);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.listPrintOutTypes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Name = "PrintOutMenu";
            this.Text = "PrintOutMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listPrintOutTypes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioAll;
        private System.Windows.Forms.RadioButton radioPrice;
        private System.Windows.Forms.RadioButton radioPoints;
    }
}