namespace mysqlLoginProjesi
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            txtKullaniciAdi = new TextBox();
            txtSifre = new TextBox();
            button1 = new Button();
            lblKaydol = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 49);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 83);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 1;
            label2.Text = "Şifre              :";
            label2.Click += label2_Click;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(162, 46);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(100, 23);
            txtKullaniciAdi.TabIndex = 2;
            txtKullaniciAdi.TextChanged += textBox1_TextChanged;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(162, 80);
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.Size = new Size(100, 23);
            txtSifre.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(78, 132);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Giriş";
            button1.UseVisualStyleBackColor = true;
            // 
            // lblKaydol
            // 
            lblKaydol.Location = new Point(187, 132);
            lblKaydol.Name = "lblKaydol";
            lblKaydol.Size = new Size(75, 23);
            lblKaydol.TabIndex = 4;
            lblKaydol.Text = "Kayıt ol";
            lblKaydol.UseVisualStyleBackColor = true;
            lblKaydol.Click += lblKaydol_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 211);
            Controls.Add(lblKaydol);
            Controls.Add(button1);
            Controls.Add(txtSifre);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Kullanıcı girişi";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtKullaniciAdi;
        private TextBox txtSifre;
        private Button button1;
        private Button lblKaydol;
    }
}
