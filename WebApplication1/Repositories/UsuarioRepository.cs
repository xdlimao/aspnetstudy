using WebApplication1.Interfaces;
using WebApplication1.Model;

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
            
        }
    }
}
