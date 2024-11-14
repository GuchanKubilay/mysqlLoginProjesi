namespace mysqlLoginProjesi
{
    partial class Form2
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
            btnKaydol = new Button();
            btnGeriDon = new Button();
            txtYeniKullanici = new TextBox();
            txtSifre = new TextBox();
            txtSifreTekrar = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 38);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 64);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 0;
            label2.Text = "Şifre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 93);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 0;
            label3.Text = "Şifre tekrar";
            // 
            // btnKaydol
            // 
            btnKaydol.Location = new Point(169, 146);
            btnKaydol.Name = "btnKaydol";
            btnKaydol.Size = new Size(75, 23);
            btnKaydol.TabIndex = 1;
            btnKaydol.Text = "Kayıt Ol";
            btnKaydol.UseVisualStyleBackColor = true;
            btnKaydol.Click += btnKaydol_Click;
            // 
            // btnGeriDon
            // 
            btnGeriDon.Location = new Point(12, 146);
            btnGeriDon.Name = "btnGeriDon";
            btnGeriDon.Size = new Size(151, 23);
            btnGeriDon.TabIndex = 1;
            btnGeriDon.Text = "Giriş ekranına dönün";
            btnGeriDon.UseVisualStyleBackColor = true;
            btnGeriDon.Click += btnGeriDon_Click;
            // 
            // txtYeniKullanici
            // 
            txtYeniKullanici.Location = new Point(144, 32);
            txtYeniKullanici.Name = "txtYeniKullanici";
            txtYeniKullanici.Size = new Size(100, 23);
            txtYeniKullanici.TabIndex = 2;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(144, 61);
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.Size = new Size(100, 23);
            txtSifre.TabIndex = 2;
            // 
            // txtSifreTekrar
            // 
            txtSifreTekrar.Location = new Point(144, 90);
            txtSifreTekrar.Name = "txtSifreTekrar";
            txtSifreTekrar.PasswordChar = '*';
            txtSifreTekrar.Size = new Size(100, 23);
            txtSifreTekrar.TabIndex = 2;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(301, 204);
            Controls.Add(txtSifreTekrar);
            Controls.Add(txtSifre);
            Controls.Add(txtYeniKullanici);
            Controls.Add(btnGeriDon);
            Controls.Add(btnKaydol);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Kayıt ekranı";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnKaydol;
        private Button btnGeriDon;
        private TextBox txtYeniKullanici;
        private TextBox txtSifre;
        private TextBox txtSifreTekrar;
    }
}