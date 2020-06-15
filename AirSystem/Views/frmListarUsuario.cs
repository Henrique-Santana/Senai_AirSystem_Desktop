using AirSystem.Models;
using AirSystem.Repositories;
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
    public partial class frmListarUsuario : Form
    {
        public frmListarUsuario()
        {
            InitializeComponent();
        }

        private void frmListaUsuario_Load(object sender, EventArgs e)
        {
        }

        private void carregaLista()
        {
            UsuarioRepository repository = new UsuarioRepository();
            dgvListaAluno.DataSource = null;
            dgvListaAluno.DataSource = repository.BuscarTodos();
            //AlterarContador();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            carregaLista();
        }

        private void dgvListaAluno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvListaAluno_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //captura a linha que foi selecionada
            DataGridViewRow linha = dgvListaAluno.Rows[e.RowIndex];
            //guarda nas variáveis os conteúdos das células
            string Nome = linha.Cells[1].Value.ToString();
            string Sobrenome = linha.Cells[2].Value.ToString();
            string Usuario = linha.Cells[3].Value.ToString();
            string Endereco = linha.Cells[5].Value.ToString();
            string Numero = linha.Cells[6].Value.ToString();
            string senha = linha.Cells[7].Value.ToString();

            //esse campo precisa ser convertido pois é numérico
            int codigo = Convert.ToInt32(linha.Cells[0].Value.ToString());
            //Joga nas propriedades do objeto usuario
            Usuarios usuario = new Usuarios
            {
                Nome = Nome,
                Sobrenome = Sobrenome,
                Usuario = Usuario,
                Endereco = Endereco,
                Numero = Numero,
                Senha = senha
            };
            //Chama o formulário de cadastro passando a classe usuario

            new frmNovoUsuario(usuario).ShowDialog();
            //chama o método para carregar o datagrid
            carregaLista();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            new frmNovoUsuario().ShowDialog();
        }
    }
}
