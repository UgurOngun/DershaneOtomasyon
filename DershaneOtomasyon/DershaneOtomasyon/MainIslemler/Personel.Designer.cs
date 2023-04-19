namespace DershaneOtomasyon
{
    partial class Personel
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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            OgrKayitButton = new Button();
            PersonelKayıtButton = new Button();
            HarcButton = new Button();
            OgretmenNotButton = new Button();
            OdevTakipButton = new Button();
            VeliBilgiButton = new Button();
            TakvimButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(HarcButton);
            groupBox1.Controls.Add(PersonelKayıtButton);
            groupBox1.Controls.Add(OgrKayitButton);
            groupBox1.Location = new Point(12, 64);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 183);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "KAYIT İŞLEMLERİ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(TakvimButton);
            groupBox2.Controls.Add(VeliBilgiButton);
            groupBox2.Controls.Add(OdevTakipButton);
            groupBox2.Controls.Add(OgretmenNotButton);
            groupBox2.Location = new Point(12, 268);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(776, 188);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "BİLGİ İŞLEMLERİ";
            // 
            // OgrKayitButton
            // 
            OgrKayitButton.Image = Properties.Resources.öğrenci;
            OgrKayitButton.Location = new Point(35, 17);
            OgrKayitButton.Name = "OgrKayitButton";
            OgrKayitButton.Size = new Size(150, 140);
            OgrKayitButton.TabIndex = 0;
            OgrKayitButton.UseVisualStyleBackColor = true;
            OgrKayitButton.Click += OgrKayitButton_Click;
            // 
            // PersonelKayıtButton
            // 
            PersonelKayıtButton.Image = Properties.Resources.Personel;
            PersonelKayıtButton.Location = new Point(312, 17);
            PersonelKayıtButton.Name = "PersonelKayıtButton";
            PersonelKayıtButton.Size = new Size(150, 140);
            PersonelKayıtButton.TabIndex = 1;
            PersonelKayıtButton.UseVisualStyleBackColor = true;
            PersonelKayıtButton.Click += PersonelKayıtButton_Click;
            // 
            // HarcButton
            // 
            HarcButton.Image = Properties.Resources.harç;
            HarcButton.Location = new Point(587, 17);
            HarcButton.Name = "HarcButton";
            HarcButton.Size = new Size(150, 140);
            HarcButton.TabIndex = 2;
            HarcButton.UseVisualStyleBackColor = true;
            HarcButton.Click += HarcButton_Click;
            // 
            // OgretmenNotButton
            // 
            OgretmenNotButton.Image = Properties.Resources.öğretmennotu;
            OgretmenNotButton.Location = new Point(6, 25);
            OgretmenNotButton.Name = "OgretmenNotButton";
            OgretmenNotButton.Size = new Size(150, 140);
            OgretmenNotButton.TabIndex = 3;
            OgretmenNotButton.UseVisualStyleBackColor = true;
            OgretmenNotButton.Click += OgretmenNotButton_Click;
            // 
            // OdevTakipButton
            // 
            OdevTakipButton.Image = Properties.Resources.ödev;
            OdevTakipButton.Location = new Point(203, 25);
            OdevTakipButton.Name = "OdevTakipButton";
            OdevTakipButton.Size = new Size(150, 140);
            OdevTakipButton.TabIndex = 4;
            OdevTakipButton.UseVisualStyleBackColor = true;
            OdevTakipButton.Click += OdevTakipButton_Click;
            // 
            // VeliBilgiButton
            // 
            VeliBilgiButton.Image = Properties.Resources.veli;
            VeliBilgiButton.Location = new Point(425, 25);
            VeliBilgiButton.Name = "VeliBilgiButton";
            VeliBilgiButton.Size = new Size(150, 140);
            VeliBilgiButton.TabIndex = 5;
            VeliBilgiButton.UseVisualStyleBackColor = true;
            VeliBilgiButton.Click += VeliBilgiButton_Click;
            // 
            // TakvimButton
            // 
            TakvimButton.Image = Properties.Resources.takvim;
            TakvimButton.Location = new Point(620, 25);
            TakvimButton.Name = "TakvimButton";
            TakvimButton.Size = new Size(150, 140);
            TakvimButton.TabIndex = 6;
            TakvimButton.UseVisualStyleBackColor = true;
            TakvimButton.Click += TakvimButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 160);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 3;
            label1.Text = "Öğrenci Kayıt";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(347, 160);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 4;
            label2.Text = "Personel Kayıt";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(629, 160);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 5;
            label3.Text = "Harç İşlemleri";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 168);
            label4.Name = "label4";
            label4.Size = new Size(91, 15);
            label4.TabIndex = 7;
            label4.Text = "Öğretmen Notu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(246, 168);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 8;
            label5.Text = "Ödev Takip";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(472, 168);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 9;
            label6.Text = "Veli Bilgileri";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(676, 168);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 10;
            label7.Text = "Takvim";
            // 
            // Personel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(812, 485);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Personel";
            Text = "Personel";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button HarcButton;
        private Button PersonelKayıtButton;
        private Button OgrKayitButton;
        private GroupBox groupBox2;
        private Button TakvimButton;
        private Button VeliBilgiButton;
        private Button OdevTakipButton;
        private Button OgretmenNotButton;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
    }
}