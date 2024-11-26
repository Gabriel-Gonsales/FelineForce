using FelineForce.Models;
using FelineForce.Repository.Interfaces;

namespace FelineForce.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public async Task CriarUsuario(string nome, decimal salario, int horas, string senha, Usuario.TipoUsuario tipo)
        {
            var usuario = new Usuario
            {
                Nome = nome,
                Senha = senha,
                Tipo = tipo,
                HorasTrabalhadas = horas,
                Salario = salario,
                Bloqueado = false,
                Excluido = false
            };

            await _usuarioRepository.AddAsync(usuario);
        }

        public async Task AtualizarUsuario(Usuario usuario)
        {
            await _usuarioRepository.UpdateAsync(usuario);
        }
        public async Task BloqueiaUsuario(Guid usuarioId)
        {
            await _usuarioRepository.BloquearUsuario(usuarioId);
        }
        public async Task ExcluirUsuario(Guid id)
        {
            await _usuarioRepository.DeleteAsync(id);
        }

        public async Task<Usuario> ObterUsuarioPorId(Guid id)
        {
            return await _usuarioRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Usuario>> ObterTodosUsuarios()
        {
            return await _usuarioRepository.GetAllAsync();
        }
    }
}