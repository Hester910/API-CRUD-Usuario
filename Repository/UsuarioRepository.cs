using API_CRUD.Data;
using API_CRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace API_CRUD.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly UsuarioContext _context;

        public UsuarioRepository(UsuarioContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Usuario>> BuscaUsuarios()
        {
            return await _context.Usuarios.ToListAsync();
        }

        public async Task<Usuario> BuscaUsuario(int id)
        {
            return await _context.Usuarios.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public void AdicionaUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public void AtualizaUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public void DeletaUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}