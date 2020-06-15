namespace AirSystem.Views
{
    partial class frmNovoUsuario
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
            this.labelNome = new System.Windows.Forms.Label();
            this.labelNascimento = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelConfSenha = new System.Windows.Forms.Label();
            this.labelSenha = new System.Windows.Forms.Label();
            this.labelEndereco = new System.Windows.Forms.Label();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.tbxSobrenome = new System.Windows.Forms.TextBox();
            this.tbxConfSenha = new System.Windows.Forms.TextBox();
            this.tbxEndereco = new System.Windows.Forms.TextBox();
            this.tbxNumero = new System.Windows.Forms.TextBox();
            this.dtNascimento = new System.Windows.Forms.DateTimePicker();
            this.tbxUsuario = new System.Windows.Forms.TextBox();
            this.tbxSenha = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.pbFotoUsuario = new System.Windows.Forms.PictureBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.CbxAdm = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(59, 35);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(39, 13);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome";
            // 
            // labelNascimento
            // 
            this.labelNascimento.AutoSize = true;
            this.labelNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNascimento.Location = new System.Drawing.Point(59, 117);
            this.labelNascimento.Name = "labelNascimento";
            this.labelNascimento.Size = new System.Drawing.Size(73, 13);
            this.labelNascimento.TabIndex = 1;
            this.labelNascimento.Text = "Nascimento";
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.Location = new System.Drawing.Point(59, 163);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(50, 13);
            this.labelUsuario.TabIndex = 2;
            this.labelUsuario.Text = "Usuário";
            // 
            // labelConfSenha
            // 
            this.labelConfSenha.AutoSize = true;
            this.labelConfSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfSenha.Location = new System.Drawing.Point(59, 249);
            this.labelConfSenha.Name = "labelConfSenha";
            this.labelConfSenha.Size = new System.Drawing.Size(100, 13);
            this.labelConfSenha.TabIndex = 3;
            this.labelConfSenha.Text = "Confirmar Senha";
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSenha.Location = new System.Drawing.Point(59, 207);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(43, 13);
            this.labelSenha.TabIndex = 4;
            this.labelSenha.Text = "Senha";
            // 
            // labelEndereco
            // 
            this.labelEndereco.AutoSize = true;
            this.labelEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEndereco.Location = new System.Drawing.Point(59, 74);
            this.labelEndereco.Name = "labelEndereco";
            this.labelEndereco.Size = new System.Drawing.Size(61, 13);
            this.labelEndereco.TabIndex = 5;
            this.labelEndereco.Text = "Endereço";
            // 
            // tbxNome
            // 
            this.tbxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNome.Location = new System.Drawing.Point(187, 32);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(100, 20);
            this.tbxNome.TabIndex = 6;
            this.tbxNome.Text = "Digite se Nome...";
            // 
            // tbxSobrenome
            // 
            this.tbxSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSobrenome.Location = new System.Drawing.Point(325, 32);
            this.tbxSobrenome.Name = "tbxSobrenome";
            this.tbxSobrenome.Size = new System.Drawing.Size(117, 20);
            this.tbxSobrenome.TabIndex = 7;
            this.tbxSobrenome.Text = "Digite se Sobrenome...";
            // 
            // tbxConfSenha
            // 
            this.tbxConfSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxConfSenha.Location = new System.Drawing.Point(187, 246);
            this.tbxConfSenha.Name = "tbxConfSenha";
            this.tbxConfSenha.Size = new System.Drawing.Size(124, 20);
            this.tbxConfSenha.TabIndex = 8;
            this.tbxConfSenha.UseSystemPasswordChar = true;
            this.tbxConfSenha.TextChanged += new System.EventHandler(this.tbxConfSenha_TextChanged);
            // 
            // tbxEndereco
            // 
            this.tbxEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEndereco.Location = new System.Drawing.Point(187, 71);
            this.tbxEndereco.Name = "tbxEndereco";
            this.tbxEndereco.Size = new System.Drawing.Size(181, 20);
            this.tbxEndereco.TabIndex = 9;
            this.tbxEndereco.Text = "Digite de Endereço...";
            // 
            // tbxNumero
            // 
            this.tbxNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNumero.Location = new System.Drawing.Point(396, 71);
            this.tbxNumero.Name = "tbxNumero";
            this.tbxNumero.Size = new System.Drawing.Size(46, 20);
            this.tbxNumero.TabIndex = 10;
            this.tbxNumero.Text = "Nº";
            // 
            // dtNascimento
            // 
            this.dtNascimento.Location = new System.Drawing.Point(187, 111);
            this.dtNascimento.Name = "dtNascimento";
            this.dtNascimento.Size = new System.Drawing.Size(254, 20);
            this.dtNascimento.TabIndex = 11;
            // 
            // tbxUsuario
            // 
            this.tbxUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUsuario.Location = new System.Drawing.Point(187, 160);
            this.tbxUsuario.Name = "tbxUsuario";
            this.tbxUsuario.Size = new System.Drawing.Size(106, 20);
            this.tbxUsuario.TabIndex = 12;
            this.tbxUsuario.Text = "Digite seu Usuário...";
            // 
            // tbxSenha
            // 
            this.tbxSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSenha.Location = new System.Drawing.Point(187, 204);
            this.tbxSenha.Name = "tbxSenha";
            this.tbxSenha.Size = new System.Drawing.Size(124, 20);
            this.tbxSenha.TabIndex = 13;
            this.tbxSenha.UseSystemPasswordChar = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(187, 299);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 14;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // pbFotoUsuario
            // 
            this.pbFotoUsuario.Location = new System.Drawing.Point(493, 32);
            this.pbFotoUsuario.Name = "pbFotoUsuario";
            this.pbFotoUsuario.Size = new System.Drawing.Size(128, 99);
            this.pbFotoUsuario.TabIndex = 15;
            this.pbFotoUsuario.TabStop = false;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(493, 137);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(55, 23);
            this.btnAlterar.TabIndex = 16;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(563, 137);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(58, 23);
            this.btnDeletar.TabIndex = 17;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            // 
            // CbxAdm
            // 
            this.CbxAdm.AutoSize = true;
            this.CbxAdm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxAdm.Location = new System.Drawing.Point(509, 191);
            this.CbxAdm.Name = "CbxAdm";
            this.CbxAdm.Size = new System.Drawing.Size(89, 17);
            this.CbxAdm.TabIndex = 18;
            this.CbxAdm.Text = "Administrador";
            this.CbxAdm.UseVisualStyleBackColor = true;
            // 
            // frmNovoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 343);
            this.Controls.Add(this.CbxAdm);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.pbFotoUsuario);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.tbxSenha);
            this.Controls.Add(this.tbxUsuario);
            this.Controls.Add(this.dtNascimento);
            this.Controls.Add(this.tbxNumero);
            this.Controls.Add(this.tbxEndereco);
            this.Controls.Add(this.tbxConfSenha);
            this.Controls.Add(this.tbxSobrenome);
            this.Controls.Add(this.tbxNome);
            this.Controls.Add(this.labelEndereco);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.labelConfSenha);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.labelNascimento);
            this.Controls.Add(this.labelNome);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmNovoUsuario";
            this.Text = "frmNovoUsuario";
            this.Load += new System.EventHandler(this.frmNovoUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelNascimento;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelConfSenha;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.Label labelEndereco;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.TextBox tbxSobrenome;
        private System.Windows.Forms.TextBox tbxConfSenha;
        private System.Windows.Forms.TextBox tbxEndereco;
        private System.Windows.Forms.TextBox tbxNumero;
        private System.Windows.Forms.DateTimePicker dtNascimento;
        private System.Windows.Forms.TextBox tbxUsuario;
        private System.Windows.Forms.TextBox tbxSenha;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.PictureBox pbFotoUsuario;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.CheckBox CbxAdm;
    }
}