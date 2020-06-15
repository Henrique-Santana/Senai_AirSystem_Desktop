using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
using System.Media;

namespace AirSystem.Views
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        private void timer_Tick(object sender, EventArgs e)
        {
            LblTimer.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (tbxUsuario.Text.Trim().Length != 0 && tbxSenha.Text.Trim().Length != 0)
            {
                MessageBox.Show("Bem Vindo", "Entrada");
                new frmTelaPrincipal().ShowDialog();
            }
            else
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Digite o usuário.", "Erro");
            }

        }

        private void btnNovoUsuario_Click(object sender, EventArgs e)
        {
            new frmNovoUsuario().ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void teste_Click(object sender, EventArgs e)
        {
            new frmListarUsuario().ShowDialog();
        }
    }
}
