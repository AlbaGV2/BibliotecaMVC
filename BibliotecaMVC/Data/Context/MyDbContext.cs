using BibliotecaMVC.Core.Entities;
using Microsoft.EntityFrameworkCore;


namespace BibliotecaMVC.Data.Context {
    public class MyDbContext : DbContext

    {
        public MyDbContext(DbContextOptions options) : base(options)
        {
        }

        protected MyDbContext()
        {
        }

        public DbSet<Libro> Libros { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Rol> Roles { get; set; }


      
    }
    }
