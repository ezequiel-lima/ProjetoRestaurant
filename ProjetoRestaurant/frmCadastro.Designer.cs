﻿
namespace ProjetoRestaurant
{
    partial class frmCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastro));
            this.label2 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalvarCadastro = new System.Windows.Forms.Button();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbLogin = new System.Windows.Forms.TextBox();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.txbConfirmarSenha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbCodigoConta = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Email:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(37, 230);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(70, 25);
            this.lblNome.TabIndex = 12;
            this.lblNome.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(37, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Login:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(37, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Senha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(37, 467);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Confirmar Senha:";
            // 
            // btnSalvarCadastro
            // 
            this.btnSalvarCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(66)))), ((int)(((byte)(71)))));
            this.btnSalvarCadastro.ForeColor = System.Drawing.Color.White;
            this.btnSalvarCadastro.Location = new System.Drawing.Point(46, 573);
            this.btnSalvarCadastro.Name = "btnSalvarCadastro";
            this.btnSalvarCadastro.Size = new System.Drawing.Size(538, 37);
            this.btnSalvarCadastro.TabIndex = 6;
            this.btnSalvarCadastro.Text = "Salvar Cadastro";
            this.btnSalvarCadastro.UseVisualStyleBackColor = false;
            this.btnSalvarCadastro.Click += new System.EventHandler(this.btnSalvarCadastro_Click);
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(119, 231);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(465, 26);
            this.txbNome.TabIndex = 0;
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(119, 293);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(465, 26);
            this.txbEmail.TabIndex = 1;
            // 
            // txbLogin
            // 
            this.txbLogin.Location = new System.Drawing.Point(119, 351);
            this.txbLogin.Name = "txbLogin";
            this.txbLogin.Size = new System.Drawing.Size(465, 26);
            this.txbLogin.TabIndex = 2;
            // 
            // txbSenha
            // 
            this.txbSenha.Location = new System.Drawing.Point(119, 410);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.Size = new System.Drawing.Size(465, 26);
            this.txbSenha.TabIndex = 3;
            // 
            // txbConfirmarSenha
            // 
            this.txbConfirmarSenha.Location = new System.Drawing.Point(209, 468);
            this.txbConfirmarSenha.Name = "txbConfirmarSenha";
            this.txbConfirmarSenha.Size = new System.Drawing.Size(375, 26);
            this.txbConfirmarSenha.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(37, 521);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Código Da Conta:";
            // 
            // txbCodigoConta
            // 
            this.txbCodigoConta.Location = new System.Drawing.Point(212, 522);
            this.txbCodigoConta.Name = "txbCodigoConta";
            this.txbCodigoConta.Size = new System.Drawing.Size(372, 26);
            this.txbCodigoConta.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(634, 233);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 644);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txbCodigoConta);
            this.Controls.Add(this.txbConfirmarSenha);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.txbLogin);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.btnSalvarCadastro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadastro";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSalvarCadastro;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbLogin;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.TextBox txbConfirmarSenha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbCodigoConta;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}