using API_CRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace API_CRUD.Data
{
    public class UsuarioContext : DbContext
    {
        public UsuarioContext(DbContextOptions<UsuarioContext> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios{get;set;}
    }
}