using AirSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AirSystem.Repositories;


namespace AirSystem.Views
{
    public partial class frmNovoUsuario : Form
    {
        private Usuarios usuario = null;

        public frmNovoUsuario()
        {
            InitializeComponent();
        }
        public frmNovoUsuario(Usuarios usuario)
        {
            InitializeComponent();

            this.usuario = usuario;
        }

        private void frmNovoUsuario_Load(object sender, EventArgs e)
        {
            if (usuario != null)
            {
                tbxNome.Text = usuario.Nome;
                tbxSobrenome.Text = usuario.Sobrenome;
                tbxEndereco.Text = usuario.Endereco;
                tbxNumero.Text = usuario.Numero;
                tbxUsuario.Text = usuario.Usuario;
                tbxSenha.Text = usuario.Senha;
            }
        }

        private void tbxConfSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
                if (!Utils.temCamposVazio(this))
                //8. Armazena os dados do novo usuário nas propriedades da classe e carrega na lista (para alimentar o datagrid)
                //instanciar a classe UsuarioRepository onde estão criados os métodos de acesso aos dados

                {
                    UsuarioRepository repository = new UsuarioRepository();
                    if (this.usuario == null)
                    {
                        //Atribui nas propriedades da classe usuários os valores dos campos do formulário
                        Usuarios usuario = new Usuarios
                        {
                            Nome = tbxNome.Text,
                            Sobrenome = tbxSobrenome.Text,
                            Usuario = tbxUsuario.Text,
                            Endereco = tbxEndereco.Text,
                            Numero = tbxNumero.Text,
                            Senha = tbxSenha.Text,
                            Admin = CbxAdm.Checked
                        };
                        //chama o método adicionar - passando a classe usuario
                        repository.Adicionar(usuario);

                        //Todos os campos foram preenchidos - Salva os campos no BD
                        MessageBox.Show("Dados Salvos.",
                                        "Aviso", MessageBoxButtons.OK,
                                         MessageBoxIcon.Information);

                    }
                    else
                    {
                    //alimenta as propriedades da classe com o conteúdo dos campos do formulário

                        this.usuario.Nome = tbxNome.Text;
                        this.usuario.Sobrenome = tbxSobrenome.Text;
                        this.usuario.Usuario = tbxUsuario.Text;
                        this.usuario.Endereco = tbxEndereco.Text;
                        this.usuario.Numero = tbxNumero.Text;
                        this.usuario.Senha = tbxSenha.Text;
                        this.usuario.Admin = CbxAdm.Checked;
                        //Chama o método para editar 
                        //Atalho para criar o método -> Alt Enter para criar o método editar

                    repository.editar(usuario);
                    }
                    this.Close();

                }
                else
                {   //Texto , Título, Botões, Ícone
                    MessageBox.Show("Todos os campos são obrigatórios.",
                                    "Aviso", MessageBoxButtons.OK,
                                     MessageBoxIcon.Information);
                }
            
        }
    }
}
