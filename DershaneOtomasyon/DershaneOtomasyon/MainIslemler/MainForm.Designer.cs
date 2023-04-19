namespace DershaneOtomasyon
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PrsGisiButton = new Button();
            OgrGirisButton = new Button();
            SuspendLayout();
            // 
            // PrsGisiButton
            // 
            PrsGisiButton.BackColor = SystemColors.HighlightText;
            PrsGisiButton.Image = Properties.Resources.mudur1;
            PrsGisiButton.ImageAlign = ContentAlignment.MiddleLeft;
            PrsGisiButton.Location = new Point(70, 223);
            PrsGisiButton.Name = "PrsGisiButton";
            PrsGisiButton.Size = new Size(280, 100);
            PrsGisiButton.TabIndex = 0;
            PrsGisiButton.Text = "PERSONEL GİRİŞİ";
            PrsGisiButton.TextAlign = ContentAlignment.MiddleRight;
            PrsGisiButton.UseVisualStyleBackColor = false;
            PrsGisiButton.Click += PrsGirisButton_Click;
            // 
            // OgrGirisButton
            // 
            OgrGirisButton.BackColor = SystemColors.HighlightText;
            OgrGirisButton.Image = Properties.Resources.ogrenci3;
            OgrGirisButton.ImageAlign = ContentAlignment.MiddleLeft;
            OgrGirisButton.Location = new Point(530, 223);
            OgrGirisButton.Name = "OgrGirisButton";
            OgrGirisButton.Size = new Size(280, 102);
            OgrGirisButton.TabIndex = 1;
            OgrGirisButton.Text = "ÖĞRENCİ GİRİŞ";
            OgrGirisButton.TextAlign = ContentAlignment.MiddleRight;
            OgrGirisButton.UseVisualStyleBackColor = false;
            OgrGirisButton.Click += OgrGirisButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(884, 561);
            Controls.Add(OgrGirisButton);
            Controls.Add(PrsGisiButton);
            Name = "MainForm";
            Text = "Dershane Otomasyon";
            ResumeLayout(false);
        }

        #endregion

        private Button PrsGisiButton;
        private Button OgrGirisButton;
    }
}