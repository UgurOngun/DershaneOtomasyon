namespace DershaneOtomasyon
{
    partial class OgrenciGiris
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
            label4 = new Label();
            GirisButton = new Button();
            OkulNoTextBox = new TextBox();
            TCKimlikTextBox = new TextBox();
            GirisKoduTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(236, 49);
            label4.Name = "label4";
            label4.Size = new Size(118, 15);
            label4.TabIndex = 15;
            label4.Text = "GİRİS KODU GELECEK";
            // 
            // GirisButton
            // 
            GirisButton.Location = new Point(237, 187);
            GirisButton.MaximumSize = new Size(115, 42);
            GirisButton.Name = "GirisButton";
            GirisButton.Size = new Size(115, 42);
            GirisButton.TabIndex = 14;
            GirisButton.Text = "GİRİŞ";
            GirisButton.UseVisualStyleBackColor = true;
            GirisButton.Click += GirisButton_Click;
            // 
            // OkulNoTextBox
            // 
            OkulNoTextBox.Location = new Point(111, 166);
            OkulNoTextBox.Name = "OkulNoTextBox";
            OkulNoTextBox.Size = new Size(100, 23);
            OkulNoTextBox.TabIndex = 13;
            // 
            // TCKimlikTextBox
            // 
            TCKimlikTextBox.Location = new Point(111, 106);
            TCKimlikTextBox.Name = "TCKimlikTextBox";
            TCKimlikTextBox.Size = new Size(100, 23);
            TCKimlikTextBox.TabIndex = 12;
            // 
            // GirisKoduTextBox
            // 
            GirisKoduTextBox.Location = new Point(111, 46);
            GirisKoduTextBox.Name = "GirisKoduTextBox";
            GirisKoduTextBox.Size = new Size(100, 23);
            GirisKoduTextBox.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 169);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 10;
            label3.Text = "Okul No";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 109);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 9;
            label2.Text = "TC Kimlik";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 49);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 8;
            label1.Text = "Giriş Kodu";
            // 
            // OgrenciGiris
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(364, 241);
            Controls.Add(label4);
            Controls.Add(GirisButton);
            Controls.Add(OkulNoTextBox);
            Controls.Add(TCKimlikTextBox);
            Controls.Add(GirisKoduTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximumSize = new Size(380, 280);
            MinimumSize = new Size(380, 280);
            Name = "OgrenciGiris";
            Text = "OgrenciGiris";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Button GirisButton;
        private TextBox OkulNoTextBox;
        private TextBox TCKimlikTextBox;
        private TextBox GirisKoduTextBox;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}