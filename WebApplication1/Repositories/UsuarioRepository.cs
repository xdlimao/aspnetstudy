using Microsoft.EntityFrameworkCore;
using WebApplication1.Interfaces;
using WebApplication1.Models;

namespace WebApplication1.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly db_ajintestContext _context; //Não precisa instanciar o contexto como no Spring

        public UsuarioRepository(db_ajintestContext context) //o context serve para o AddScoped
        {
            _context = context;
        }

        public void Incluir(Usuario usuario)
        {
            _context.Usuario.Add(usuario);
        }

        public async Task<bool> SaveAllAsync()
        {
            return await _context.SaveChangesAsync() > 0;    
        }

        public async Task<IEnumerable<Usuario>> SelecionarTodos()
        {
            return await _context.Usuario.ToListAsync();
        }
    }
}
