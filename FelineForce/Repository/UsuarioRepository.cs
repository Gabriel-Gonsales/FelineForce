using FelineForce.Models;
using FelineForce.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelineForce.Repository
{
    public class UsuarioRepository : GenericRepository<Usuario>, IUsuarioRepository
    {
        private readonly FelineForceContext _context;
        public UsuarioRepository(FelineForceContext context) : base(context)
        {
            _context = context;
        }

        public async Task BloquearUsuario(Guid usuarioId)
        {
            var user = await _context.Usuarios.FindAsync(usuarioId) ?? throw new NullReferenceException("Usuário não existe");
            user.Bloqueado = true;

            _context.Usuarios.Update(user);
            await _context.SaveChangesAsync();
        }
    }
}
