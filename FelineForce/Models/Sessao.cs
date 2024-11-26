using FelineForce.Models;

namespace FelineForce
{
    public static class Sessao
    {
        public static Usuario UsuarioLogado { get; private set; }

        public static void Logar(Usuario usuario)
        {
            UsuarioLogado = usuario;
        }

        public static void Logout()
        {
            UsuarioLogado = null;
        }
    }
}
