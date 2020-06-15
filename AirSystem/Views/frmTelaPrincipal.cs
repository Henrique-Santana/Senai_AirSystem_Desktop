using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirSystem.Views
{
    public partial class frmTelaPrincipal : Form
    {
        public frmTelaPrincipal()
        {
            InitializeComponent();
        }

        private void btnListarUsuario_Click(object sender, EventArgs e)
        {
            new frmListarUsuario().ShowDialog();
        }
    }
}
