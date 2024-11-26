using FelineForce.Models;
using Microsoft.EntityFrameworkCore;

namespace FelineForce.Services
{
    public class AutenticacaoService : IAutenticacaoService
    {
        private readonly FelineForceContext _context;

        public AutenticacaoService(FelineForceContext context)
        {
            _context = context;
        }

        public async Task<Usuario> LoginAsync(string nome, string senha)
        {
            // Busca o usuário pelo nome
            var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(u => u.Nome == nome);

            if (usuario == null)
                return null;

            if (usuario.Senha != senha)
                return null;

            if (usuario.Bloqueado)
                return null;

            return usuario; 
        }
    }
}
