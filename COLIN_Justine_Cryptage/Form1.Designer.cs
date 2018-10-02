namespace COLIN_Justine_Cryptage
{
    partial class Form1
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
            System.Windows.Forms.Label Texte;
            System.Windows.Forms.Label Cle;
            System.Windows.Forms.Label Crypte;
            System.Windows.Forms.Label Decrypte;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Btn_Encryp_Perso = new System.Windows.Forms.Button();
            this.Btn_Encrypt_Net = new System.Windows.Forms.Button();
            this.Btn_Des_Perso = new System.Windows.Forms.Button();
            this.Btn_Des_Net = new System.Windows.Forms.Button();
            this.TexteBase = new System.Windows.Forms.TextBox();
            this.TexteDecrypte = new System.Windows.Forms.TextBox();
            this.TexteCrypte = new System.Windows.Forms.TextBox();
            this.CleCryptage = new System.Windows.Forms.TextBox();
            this.Exit = new System.Windows.Forms.Button();
            Texte = new System.Windows.Forms.Label();
            Cle = new System.Windows.Forms.Label();
            Crypte = new System.Windows.Forms.Label();
            Decrypte = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Texte
            // 
            Texte.AutoSize = true;
            Texte.BackColor = System.Drawing.Color.Transparent;
            Texte.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Texte.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            Texte.Location = new System.Drawing.Point(52, 43);
            Texte.Name = "Texte";
            Texte.Size = new System.Drawing.Size(51, 22);
            Texte.TabIndex = 8;
            Texte.Text = "Text :";
            // 
            // Cle
            // 
            Cle.AutoSize = true;
            Cle.BackColor = System.Drawing.Color.Transparent;
            Cle.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Cle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            Cle.Location = new System.Drawing.Point(52, 115);
            Cle.Name = "Cle";
            Cle.Size = new System.Drawing.Size(47, 22);
            Cle.TabIndex = 9;
            Cle.Text = "Key :";
            // 
            // Crypte
            // 
            Crypte.AutoSize = true;
            Crypte.BackColor = System.Drawing.Color.Transparent;
            Crypte.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Crypte.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            Crypte.Location = new System.Drawing.Point(55, 244);
            Crypte.Name = "Crypte";
            Crypte.Size = new System.Drawing.Size(135, 22);
            Crypte.TabIndex = 10;
            Crypte.Text = "Encrypted Text :";
            // 
            // Decrypte
            // 
            Decrypte.AutoSize = true;
            Decrypte.BackColor = System.Drawing.Color.Transparent;
            Decrypte.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Decrypte.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            Decrypte.Location = new System.Drawing.Point(52, 364);
            Decrypte.Name = "Decrypte";
            Decrypte.Size = new System.Drawing.Size(132, 22);
            Decrypte.TabIndex = 11;
            Decrypte.Text = "Decrypted Text :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label1.Location = new System.Drawing.Point(51, 68);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(104, 22);
            label1.TabIndex = 13;
            label1.Text = "(MAJ ONLY)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label2.Location = new System.Drawing.Point(52, 138);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(104, 22);
            label2.TabIndex = 14;
            label2.Text = "(MAJ ONLY)";
            // 
            // Btn_Encryp_Perso
            // 
            this.Btn_Encryp_Perso.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.Btn_Encryp_Perso.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Encryp_Perso.Location = new System.Drawing.Point(55, 177);
            this.Btn_Encryp_Perso.Name = "Btn_Encryp_Perso";
            this.Btn_Encryp_Perso.Size = new System.Drawing.Size(250, 35);
            this.Btn_Encryp_Perso.TabIndex = 0;
            this.Btn_Encryp_Perso.Text = "Personal Encryption";
            this.Btn_Encryp_Perso.UseVisualStyleBackColor = false;
            this.Btn_Encryp_Perso.Click += new System.EventHandler(this.Btn_Encryp_Perso_Click);
            // 
            // Btn_Encrypt_Net
            // 
            this.Btn_Encrypt_Net.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.Btn_Encrypt_Net.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Encrypt_Net.Location = new System.Drawing.Point(343, 177);
            this.Btn_Encrypt_Net.Name = "Btn_Encrypt_Net";
            this.Btn_Encrypt_Net.Size = new System.Drawing.Size(250, 35);
            this.Btn_Encrypt_Net.TabIndex = 1;
            this.Btn_Encrypt_Net.Text = ".NET Encryption";
            this.Btn_Encrypt_Net.UseVisualStyleBackColor = false;
            this.Btn_Encrypt_Net.Click += new System.EventHandler(this.Btn_Encrypt_Net_Click);
            // 
            // Btn_Des_Perso
            // 
            this.Btn_Des_Perso.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.Btn_Des_Perso.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Des_Perso.Location = new System.Drawing.Point(55, 298);
            this.Btn_Des_Perso.Name = "Btn_Des_Perso";
            this.Btn_Des_Perso.Size = new System.Drawing.Size(250, 35);
            this.Btn_Des_Perso.TabIndex = 2;
            this.Btn_Des_Perso.Text = "Personal Decryption";
            this.Btn_Des_Perso.UseVisualStyleBackColor = false;
            this.Btn_Des_Perso.Click += new System.EventHandler(this.Btn_Des_Perso_Click);
            // 
            // Btn_Des_Net
            // 
            this.Btn_Des_Net.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.Btn_Des_Net.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Des_Net.Location = new System.Drawing.Point(343, 298);
            this.Btn_Des_Net.Name = "Btn_Des_Net";
            this.Btn_Des_Net.Size = new System.Drawing.Size(250, 35);
            this.Btn_Des_Net.TabIndex = 3;
            this.Btn_Des_Net.Text = ".NET Decryption";
            this.Btn_Des_Net.UseVisualStyleBackColor = false;
            this.Btn_Des_Net.Click += new System.EventHandler(this.Btn_Des_Net_Click);
            // 
            // TexteBase
            // 
            this.TexteBase.Location = new System.Drawing.Point(189, 43);
            this.TexteBase.Name = "TexteBase";
            this.TexteBase.Size = new System.Drawing.Size(400, 22);
            this.TexteBase.TabIndex = 4;
            // 
            // TexteDecrypte
            // 
            this.TexteDecrypte.Location = new System.Drawing.Point(193, 364);
            this.TexteDecrypte.Name = "TexteDecrypte";
            this.TexteDecrypte.Size = new System.Drawing.Size(400, 22);
            this.TexteDecrypte.TabIndex = 5;
            // 
            // TexteCrypte
            // 
            this.TexteCrypte.Location = new System.Drawing.Point(189, 244);
            this.TexteCrypte.Name = "TexteCrypte";
            this.TexteCrypte.Size = new System.Drawing.Size(400, 22);
            this.TexteCrypte.TabIndex = 6;
            // 
            // CleCryptage
            // 
            this.CleCryptage.Location = new System.Drawing.Point(189, 113);
            this.CleCryptage.Name = "CleCryptage";
            this.CleCryptage.Size = new System.Drawing.Size(400, 22);
            this.CleCryptage.TabIndex = 7;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.Exit.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(343, 415);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(250, 35);
            this.Exit.TabIndex = 12;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(650, 486);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(Decrypte);
            this.Controls.Add(Crypte);
            this.Controls.Add(Cle);
            this.Controls.Add(Texte);
            this.Controls.Add(this.CleCryptage);
            this.Controls.Add(this.TexteCrypte);
            this.Controls.Add(this.TexteDecrypte);
            this.Controls.Add(this.TexteBase);
            this.Controls.Add(this.Btn_Des_Net);
            this.Controls.Add(this.Btn_Des_Perso);
            this.Controls.Add(this.Btn_Encrypt_Net);
            this.Controls.Add(this.Btn_Encryp_Perso);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Cryptage - Colin Justine";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Encryp_Perso;
        private System.Windows.Forms.Button Btn_Encrypt_Net;
        private System.Windows.Forms.Button Btn_Des_Perso;
        private System.Windows.Forms.Button Btn_Des_Net;
        private System.Windows.Forms.TextBox TexteBase;
        private System.Windows.Forms.TextBox TexteDecrypte;
        private System.Windows.Forms.TextBox TexteCrypte;
        private System.Windows.Forms.TextBox CleCryptage;
        private System.Windows.Forms.Button Exit;
    }
}