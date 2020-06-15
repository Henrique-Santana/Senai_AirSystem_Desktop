namespace AirSystem.Views
{
    partial class frmListarUsuario
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
            this.dgvListaAluno = new System.Windows.Forms.DataGridView();
            this.labelEndereco = new System.Windows.Forms.Label();
            this.labelSenha = new System.Windows.Forms.Label();
            this.labelConfSenha = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelNascimento = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaAluno)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaAluno
            // 
            this.dgvListaAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaAluno.Location = new System.Drawing.Point(12, 12);
            this.dgvListaAluno.Name = "dgvListaAluno";
            this.dgvListaAluno.Size = new System.Drawing.Size(296, 385);
            this.dgvListaAluno.TabIndex = 1;
            this.dgvListaAluno.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaAluno_CellClick);
            this.dgvListaAluno.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaAluno_CellContentClick);
            // 
            // labelEndereco
            // 
            this.labelEndereco.AutoSize = true;
            this.labelEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEndereco.Location = new System.Drawing.Point(350, 102);
            this.labelEndereco.Name = "labelEndereco";
            this.labelEndereco.Size = new System.Drawing.Size(61, 13);
            this.labelEndereco.TabIndex = 11;
            this.labelEndereco.Text = "Endereço";
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSenha.Location = new System.Drawing.Point(350, 275);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(43, 13);
            this.labelSenha.TabIndex = 10;
            this.labelSenha.Text = "Senha";
            // 
            // labelConfSenha
            // 
            this.labelConfSenha.AutoSize = true;
            this.labelConfSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfSenha.Location = new System.Drawing.Point(350, 317);
            this.labelConfSenha.Name = "labelConfSenha";
            this.labelConfSenha.Size = new System.Drawing.Size(100, 13);
            this.labelConfSenha.TabIndex = 9;
            this.labelConfSenha.Text = "Confirmar Senha";
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.Location = new System.Drawing.Point(350, 231);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(50, 13);
            this.labelUsuario.TabIndex = 8;
            this.labelUsuario.Text = "Usuário";
            // 
            // labelNascimento
            // 
            this.labelNascimento.AutoSize = true;
            this.labelNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNascimento.Location = new System.Drawing.Point(350, 185);
            this.labelNascimento.Name = "labelNascimento";
            this.labelNascimento.Size = new System.Drawing.Size(73, 13);
            this.labelNascimento.TabIndex = 7;
            this.labelNascimento.Text = "Nascimento";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(350, 24);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(39, 13);
            this.labelNome.TabIndex = 6;
            this.labelNome.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(350, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Numero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(350, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Sobrenome";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(500, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 20);
            this.textBox1.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(500, 59);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(126, 20);
            this.textBox2.TabIndex = 15;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(500, 99);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(126, 20);
            this.textBox3.TabIndex = 16;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(500, 139);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(126, 20);
            this.textBox4.TabIndex = 17;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(500, 182);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(126, 20);
            this.textBox5.TabIndex = 18;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(500, 228);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(126, 20);
            this.textBox6.TabIndex = 19;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(500, 272);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(126, 20);
            this.textBox7.TabIndex = 20;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(500, 314);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(126, 20);
            this.textBox8.TabIndex = 21;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(325, 374);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 22;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(427, 374);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 23;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.Location = new System.Drawing.Point(533, 374);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 23);
            this.btnDeletar.TabIndex = 24;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(12, 406);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 25;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(133, 407);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 26;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // frmListarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 441);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelEndereco);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.labelConfSenha);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.labelNascimento);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.dgvListaAluno);
            this.Name = "frmListarUsuario";
            this.Text = "frmListarUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaAluno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvListaAluno;
        private System.Windows.Forms.Label labelEndereco;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.Label labelConfSenha;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelNascimento;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnListar;
    }
}