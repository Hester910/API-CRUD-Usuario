using API_CRUD.Models;

namespace API_CRUD.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public void AdicionaUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public void AtualizaUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public Task<Usuario> BuscaUsuario(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Usuario>> BuscaUsuarios()
        {
            throw new NotImplementedException();
        }

        public void DeletaUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}