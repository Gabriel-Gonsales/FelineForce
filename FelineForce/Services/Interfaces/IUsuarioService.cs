using FelineForce.Models;
using FelineForce.Repository.Interfaces;

namespace FelineForce.Services
{
    public interface IUsuarioService
    {

        public Task CriarUsuario(string nome, decimal salario, int horas, string senha, Usuario.TipoUsuario tipo);

        public Task AtualizarUsuario(Usuario usuario);
        public Task BloqueiaUsuario(Guid usuarioId);
        public Task ExcluirUsuario(Guid id);

        public Task<Usuario> ObterUsuarioPorId(Guid id);

        public Task<IEnumerable<Usuario>> ObterTodosUsuarios();
    }
}