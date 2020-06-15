using System;

namespace AirSystem.Views
{
    partial class frmLogin
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
            this.components = new System.ComponentModel.Container();
            this.lblTime = new System.Windows.Forms.Label();
            this.LabelSenha = new System.Windows.Forms.Label();
            this.tbxSenha = new System.Windows.Forms.TextBox();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.tbxUsuario = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnNovoUsuario = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LblTimer = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(334, 244);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(51, 15);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "Idioma";
            this.lblTime.Click += new System.EventHandler(this.label1_Click);
            // 
            // LabelSenha
            // 
            this.LabelSenha.AutoSize = true;
            this.LabelSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSenha.Location = new System.Drawing.Point(331, 193);
            this.LabelSenha.Name = "LabelSenha";
            this.LabelSenha.Size = new System.Drawing.Size(48, 15);
            this.LabelSenha.TabIndex = 2;
            this.LabelSenha.Text = "Senha";
            // 
            // tbxSenha
            // 
            this.tbxSenha.Location = new System.Drawing.Point(334, 212);
            this.tbxSenha.Name = "tbxSenha";
            this.tbxSenha.Size = new System.Drawing.Size(148, 20);
            this.tbxSenha.TabIndex = 3;
            this.tbxSenha.UseSystemPasswordChar = true;
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.Location = new System.Drawing.Point(334, 143);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(57, 15);
            this.labelUsuario.TabIndex = 4;
            this.labelUsuario.Text = "Usuario";
            // 
            // tbxUsuario
            // 
            this.tbxUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.tbxUsuario.Location = new System.Drawing.Point(334, 162);
            this.tbxUsuario.Name = "tbxUsuario";
            this.tbxUsuario.Size = new System.Drawing.Size(148, 20);
            this.tbxUsuario.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(334, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 103);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnEntrar
            // 
            this.btnEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.Location = new System.Drawing.Point(16, 244);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(75, 23);
            this.btnEntrar.TabIndex = 7;
            this.btnEntrar.Text = "Entrar ";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Inglês",
            "Português"});
            this.comboBox1.Location = new System.Drawing.Point(334, 263);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(148, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.Text = "Selecione";
            // 
            // btnNovoUsuario
            // 
            this.btnNovoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoUsuario.Location = new System.Drawing.Point(113, 244);
            this.btnNovoUsuario.Name = "btnNovoUsuario";
            this.btnNovoUsuario.Size = new System.Drawing.Size(97, 23);
            this.btnNovoUsuario.TabIndex = 9;
            this.btnNovoUsuario.Text = "NovoUsuário";
            this.btnNovoUsuario.UseVisualStyleBackColor = true;
            this.btnNovoUsuario.Click += new System.EventHandler(this.btnNovoUsuario_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(237, 244);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(12, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(226, 173);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // LblTimer
            // 
            this.LblTimer.AutoSize = true;
            this.LblTimer.Location = new System.Drawing.Point(433, 8);
            this.LblTimer.Name = "LblTimer";
            this.LblTimer.Size = new System.Drawing.Size(49, 13);
            this.LblTimer.TabIndex = 12;
            this.LblTimer.Text = "20:38:22";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(500, 309);
            this.Controls.Add(this.LblTimer);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnNovoUsuario);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.tbxUsuario);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.tbxSenha);
            this.Controls.Add(this.LabelSenha);
            this.Controls.Add(this.lblTime);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label LabelSenha;
        private System.Windows.Forms.TextBox tbxSenha;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.TextBox tbxUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnNovoUsuario;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label LblTimer;
        private System.Windows.Forms.Timer timer;
    }
}