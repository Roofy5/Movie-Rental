namespace Wypozyczalnia
{
    partial class ClientPanel
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.btnDeleteClient = new System.Windows.Forms.Button();
            this.btnModifyClient = new System.Windows.Forms.Button();
            this.btnClientInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(151, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "PANEL KLIENTA";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Control;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(335, 98);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(323, 394);
            this.listBox1.TabIndex = 1;
            // 
            // btnAddClient
            // 
            this.btnAddClient.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddClient.Location = new System.Drawing.Point(32, 90);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(213, 97);
            this.btnAddClient.TabIndex = 2;
            this.btnAddClient.Text = "Dodaj klienta";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDeleteClient.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnDeleteClient.Location = new System.Drawing.Point(32, 399);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(213, 97);
            this.btnDeleteClient.TabIndex = 2;
            this.btnDeleteClient.Text = "Usuń klienta";
            this.btnDeleteClient.UseVisualStyleBackColor = true;
            this.btnDeleteClient.Click += new System.EventHandler(this.btnUsunKlienta_Click);
            // 
            // btnModifyClient
            // 
            this.btnModifyClient.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnModifyClient.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnModifyClient.Location = new System.Drawing.Point(32, 296);
            this.btnModifyClient.Name = "btnModifyClient";
            this.btnModifyClient.Size = new System.Drawing.Size(213, 97);
            this.btnModifyClient.TabIndex = 2;
            this.btnModifyClient.Text = "Modyfikuj dane osobowe";
            this.btnModifyClient.UseVisualStyleBackColor = true;
            this.btnModifyClient.Click += new System.EventHandler(this.btnModifyClient_Click);
            // 
            // btnClientInfo
            // 
            this.btnClientInfo.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClientInfo.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnClientInfo.Location = new System.Drawing.Point(32, 193);
            this.btnClientInfo.Name = "btnClientInfo";
            this.btnClientInfo.Size = new System.Drawing.Size(213, 97);
            this.btnClientInfo.TabIndex = 2;
            this.btnClientInfo.Text = "Informacje o kliencie";
            this.btnClientInfo.UseVisualStyleBackColor = true;
            this.btnClientInfo.Click += new System.EventHandler(this.btnClientInfo_Click);
            // 
            // ClientPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.btnClientInfo);
            this.Controls.Add(this.btnModifyClient);
            this.Controls.Add(this.btnDeleteClient);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Name = "ClientPanel";
            this.Text = "ClientPanel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnDeleteClient;
        private System.Windows.Forms.Button btnModifyClient;
        private System.Windows.Forms.Button btnClientInfo;
    }
}