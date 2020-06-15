using AirSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirSystem.Repositories
{
    class UsuarioRepository
    {

        private static List<Usuarios> usuarios;

        private static int contador = 1;

        public UsuarioRepository()
        {

            if (usuarios == null)
            {
                usuarios = new List<Usuarios>();

                usuarios.Add(new Usuarios
                {
                    Id = 1,
                    Nome = "Admin",
                    Sobrenome = "Admin",
                    Usuario = "Administrador",
                    Endereco = "Airframe",
                    Numero = " ",
                    Senha = "1234",
                    Admin = true
                }
               );
                contador++;
                usuarios.Add(new Usuarios
                {
                    Id = 1,
                    Nome = "Henrique",
                    Sobrenome = "Scarfece",
                    Usuario = "Scar",
                    Endereco = "Logo alí",
                    Numero = " ",
                    Senha = "12345",
                    Admin = false
                }
                );
                contador++;
            }
        }
        public List<Usuarios> BuscarTodos()
        {
            return usuarios;
        }

        public void Adicionar(Usuarios usuario)
        {
            usuario.Id = contador;

            usuarios.Add(usuario);
        }

        public void editar(Usuarios usuario)
        {
            Usuarios u = usuarios.Find(x => x.Id == usuario.Id);
            usuarios[usuarios.IndexOf(u)] = usuario;
        }

        public void deletar(int codigo)
        {
            Usuarios usuario = usuarios.Find(x => x.Id == codigo);

            // removo o usuário da lista;
            usuarios.Remove(usuario);
        }
    }
}
