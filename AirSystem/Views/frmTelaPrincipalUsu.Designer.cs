namespace AirSystem.Views
{
    partial class frmTelaPrincipalUsu
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
            this.btnGereRelatorio = new System.Windows.Forms.Button();
            this.btnGereCompanhia = new System.Windows.Forms.Button();
            this.btnGereAvioes = new System.Windows.Forms.Button();
            this.btnListarAvioes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGereRelatorio
            // 
            this.btnGereRelatorio.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnGereRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGereRelatorio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGereRelatorio.Location = new System.Drawing.Point(299, 193);
            this.btnGereRelatorio.Name = "btnGereRelatorio";
            this.btnGereRelatorio.Size = new System.Drawing.Size(109, 81);
            this.btnGereRelatorio.TabIndex = 8;
            this.btnGereRelatorio.Text = "Gerenciar Relatório";
            this.btnGereRelatorio.UseVisualStyleBackColor = false;
            // 
            // btnGereCompanhia
            // 
            this.btnGereCompanhia.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnGereCompanhia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGereCompanhia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGereCompanhia.Location = new System.Drawing.Point(110, 193);
            this.btnGereCompanhia.Name = "btnGereCompanhia";
            this.btnGereCompanhia.Size = new System.Drawing.Size(109, 81);
            this.btnGereCompanhia.TabIndex = 7;
            this.btnGereCompanhia.Text = "Gerenciar Companhia";
            this.btnGereCompanhia.UseVisualStyleBackColor = false;
            // 
            // btnGereAvioes
            // 
            this.btnGereAvioes.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnGereAvioes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGereAvioes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGereAvioes.Location = new System.Drawing.Point(299, 71);
            this.btnGereAvioes.Name = "btnGereAvioes";
            this.btnGereAvioes.Size = new System.Drawing.Size(109, 81);
            this.btnGereAvioes.TabIndex = 6;
            this.btnGereAvioes.Text = "Gerenciar Aviões";
            this.btnGereAvioes.UseVisualStyleBackColor = false;
            // 
            // btnListarAvioes
            // 
            this.btnListarAvioes.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnListarAvioes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarAvioes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnListarAvioes.Location = new System.Drawing.Point(110, 70);
            this.btnListarAvioes.Name = "btnListarAvioes";
            this.btnListarAvioes.Size = new System.Drawing.Size(109, 81);
            this.btnListarAvioes.TabIndex = 5;
            this.btnListarAvioes.Text = "Listar Aviões";
            this.btnListarAvioes.UseVisualStyleBackColor = false;
            // 
            // frmTelaPrincipalUsu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 366);
            this.Controls.Add(this.btnGereRelatorio);
            this.Controls.Add(this.btnGereCompanhia);
            this.Controls.Add(this.btnGereAvioes);
            this.Controls.Add(this.btnListarAvioes);
            this.Name = "frmTelaPrincipalUsu";
            this.Text = "frmTelaPrincipalUsu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGereRelatorio;
        private System.Windows.Forms.Button btnGereCompanhia;
        private System.Windows.Forms.Button btnGereAvioes;
        private System.Windows.Forms.Button btnListarAvioes;
    }
}