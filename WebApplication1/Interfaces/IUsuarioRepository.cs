using WebApplication1.Models;

namespace WebApplication1.Interfaces
{
    public interface IUsuarioRepository
    {
        void Incluir(Usuario usuario);
        Task<IEnumerable<Usuario>> SelecionarTodos();
        Task<bool> SaveAllAsync();
    }
}
