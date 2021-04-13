namespace IKotomasyon
{
    partial class izinLimitGuncelle
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtYeniLimit = new System.Windows.Forms.TextBox();
            this.txtLimit = new System.Windows.Forms.TextBox();
            this.cbIzinTipi = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(6, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 42;
            this.label2.Text = "YENİ LİMİT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(156, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "İZİN LİMİTİ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(6, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 20);
            this.label9.TabIndex = 40;
            this.label9.Text = "İZİN TİPİ";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(160, 192);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(100, 51);
            this.btnGuncelle.TabIndex = 39;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // txtYeniLimit
            // 
            this.txtYeniLimit.Location = new System.Drawing.Point(10, 223);
            this.txtYeniLimit.Name = "txtYeniLimit";
            this.txtYeniLimit.Size = new System.Drawing.Size(100, 20);
            this.txtYeniLimit.TabIndex = 38;
            // 
            // txtLimit
            // 
            this.txtLimit.Location = new System.Drawing.Point(160, 130);
            this.txtLimit.Name = "txtLimit";
            this.txtLimit.ReadOnly = true;
            this.txtLimit.Size = new System.Drawing.Size(100, 20);
            this.txtLimit.TabIndex = 37;
            // 
            // cbIzinTipi
            // 
            this.cbIzinTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIzinTipi.FormattingEnabled = true;
            this.cbIzinTipi.Items.AddRange(new object[] {
            "Raporlu",
            "Ücretli",
            "Ücretsiz"});
            this.cbIzinTipi.Location = new System.Drawing.Point(10, 126);
            this.cbIzinTipi.Name = "cbIzinTipi";
            this.cbIzinTipi.Size = new System.Drawing.Size(121, 21);
            this.cbIzinTipi.TabIndex = 36;
            // 
            // izinLimitGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 334);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.txtYeniLimit);
            this.Controls.Add(this.txtLimit);
            this.Controls.Add(this.cbIzinTipi);
            this.Name = "izinLimitGuncelle";
            this.Text = "izinLimitGuncelle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtYeniLimit;
        private System.Windows.Forms.TextBox txtLimit;
        private System.Windows.Forms.ComboBox cbIzinTipi;
    }
}