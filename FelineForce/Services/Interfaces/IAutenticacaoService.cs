using FelineForce.Models;
using Microsoft.EntityFrameworkCore;

namespace FelineForce.Services
{
    public interface IAutenticacaoService
    {
        public Task<Usuario> LoginAsync(string nome, string senha);
    }
}