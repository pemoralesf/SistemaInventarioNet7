using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SistemaInventario.Modelos;
using System.Reflection;

namespace SistemaInventario.AccesoDatos.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Bodega> TbBodegas { get; set; }
        public DbSet<Categoria> TbCategorias { get; set; }
        public DbSet<Marca> TbMarcas { get; set; }
        public DbSet<Producto> TbProductos { get; set; }
        public DbSet<UsuarioAplicacion> UsuarioAplicacion { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}