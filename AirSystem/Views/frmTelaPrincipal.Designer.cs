namespace AirSystem.Views
{
    partial class frmTelaPrincipal
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
            this.btnListarUsuario = new System.Windows.Forms.Button();
            this.btnListarAvioes = new System.Windows.Forms.Button();
            this.btnGereAvioes = new System.Windows.Forms.Button();
            this.btnGereCompanhia = new System.Windows.Forms.Button();
            this.btnGereRelatorio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListarUsuario
            // 
            this.btnListarUsuario.BackColor = System.Drawing.Color.Black;
            this.btnListarUsuario.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnListarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnListarUsuario.Location = new System.Drawing.Point(97, 63);
            this.btnListarUsuario.Name = "btnListarUsuario";
            this.btnListarUsuario.Size = new System.Drawing.Size(111, 82);
            this.btnListarUsuario.TabIndex = 0;
            this.btnListarUsuario.Text = "Listar Usuário";
            this.btnListarUsuario.UseVisualStyleBackColor = false;
            this.btnListarUsuario.Click += new System.EventHandler(this.btnListarUsuario_Click);
            // 
            // btnListarAvioes
            // 
            this.btnListarAvioes.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnListarAvioes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarAvioes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnListarAvioes.Location = new System.Drawing.Point(296, 63);
            this.btnListarAvioes.Name = "btnListarAvioes";
            this.btnListarAvioes.Size = new System.Drawing.Size(109, 81);
            this.btnListarAvioes.TabIndex = 1;
            this.btnListarAvioes.Text = "Listar Aviões";
            this.btnListarAvioes.UseVisualStyleBackColor = false;
            // 
            // btnGereAvioes
            // 
            this.btnGereAvioes.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnGereAvioes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGereAvioes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGereAvioes.Location = new System.Drawing.Point(485, 64);
            this.btnGereAvioes.Name = "btnGereAvioes";
            this.btnGereAvioes.Size = new System.Drawing.Size(109, 81);
            this.btnGereAvioes.TabIndex = 2;
            this.btnGereAvioes.Text = "Gerenciar Aviões";
            this.btnGereAvioes.UseVisualStyleBackColor = false;
            // 
            // btnGereCompanhia
            // 
            this.btnGereCompanhia.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnGereCompanhia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGereCompanhia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGereCompanhia.Location = new System.Drawing.Point(99, 183);
            this.btnGereCompanhia.Name = "btnGereCompanhia";
            this.btnGereCompanhia.Size = new System.Drawing.Size(109, 81);
            this.btnGereCompanhia.TabIndex = 3;
            this.btnGereCompanhia.Text = "Gerenciar Companhia";
            this.btnGereCompanhia.UseVisualStyleBackColor = false;
            // 
            // btnGereRelatorio
            // 
            this.btnGereRelatorio.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnGereRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGereRelatorio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGereRelatorio.Location = new System.Drawing.Point(296, 183);
            this.btnGereRelatorio.Name = "btnGereRelatorio";
            this.btnGereRelatorio.Size = new System.Drawing.Size(109, 81);
            this.btnGereRelatorio.TabIndex = 4;
            this.btnGereRelatorio.Text = "Gerenciar Relatório";
            this.btnGereRelatorio.UseVisualStyleBackColor = false;
            // 
            // frmTelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 375);
            this.Controls.Add(this.btnGereRelatorio);
            this.Controls.Add(this.btnGereCompanhia);
            this.Controls.Add(this.btnGereAvioes);
            this.Controls.Add(this.btnListarAvioes);
            this.Controls.Add(this.btnListarUsuario);
            this.Name = "frmTelaPrincipal";
            this.Text = "frmTelaPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListarUsuario;
        private System.Windows.Forms.Button btnListarAvioes;
        private System.Windows.Forms.Button btnGereAvioes;
        private System.Windows.Forms.Button btnGereCompanhia;
        private System.Windows.Forms.Button btnGereRelatorio;
    }
}