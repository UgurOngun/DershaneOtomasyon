namespace DershaneOtomasyon
{
    partial class PersonelGiris
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            GirisKoduTextBox = new TextBox();
            TCKimlikTextBox = new TextBox();
            SifreTextBox = new TextBox();
            GirisButton = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 49);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 0;
            label1.Text = "Giriş Kodu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 109);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 1;
            label2.Text = "TC Kimlik";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 169);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 2;
            label3.Text = "Şifre";
            // 
            // GirisKoduTextBox
            // 
            GirisKoduTextBox.Location = new Point(112, 46);
            GirisKoduTextBox.Name = "GirisKoduTextBox";
            GirisKoduTextBox.Size = new Size(100, 23);
            GirisKoduTextBox.TabIndex = 3;
            // 
            // TCKimlikTextBox
            // 
            TCKimlikTextBox.Location = new Point(112, 106);
            TCKimlikTextBox.Name = "TCKimlikTextBox";
            TCKimlikTextBox.Size = new Size(100, 23);
            TCKimlikTextBox.TabIndex = 4;
            // 
            // SifreTextBox
            // 
            SifreTextBox.Location = new Point(112, 166);
            SifreTextBox.Name = "SifreTextBox";
            SifreTextBox.Size = new Size(100, 23);
            SifreTextBox.TabIndex = 5;
            // 
            // GirisButton
            // 
            GirisButton.Location = new Point(237, 187);
            GirisButton.MaximumSize = new Size(115, 42);
            GirisButton.Name = "GirisButton";
            GirisButton.Size = new Size(115, 42);
            GirisButton.TabIndex = 6;
            GirisButton.Text = "GİRİŞ";
            GirisButton.UseVisualStyleBackColor = true;
            GirisButton.Click += GirisButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(237, 49);
            label4.Name = "label4";
            label4.Size = new Size(118, 15);
            label4.TabIndex = 7;
            label4.Text = "GİRİS KODU GELECEK";
            // 
            // PersonelGiris
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(364, 241);
            Controls.Add(label4);
            Controls.Add(GirisButton);
            Controls.Add(SifreTextBox);
            Controls.Add(TCKimlikTextBox);
            Controls.Add(GirisKoduTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximumSize = new Size(380, 280);
            MinimumSize = new Size(380, 280);
            Name = "PersonelGiris";
            Text = "PersonelGiris";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox GirisKoduTextBox;
        private TextBox TCKimlikTextBox;
        private TextBox SifreTextBox;
        private Button GirisButton;
        private Label label4;
    }
}