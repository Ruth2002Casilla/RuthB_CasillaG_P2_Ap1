
using Biblioteca.Models;
using Microsoft.EntityFrameworkCore;

namespace SegundoParcial.Server.DAL
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context>options) : base(options) { }

        public DbSet<Vehiculo> Vehiculos { get; set; }
        public DbSet<Accesorios> Accesorios { get; set;}
        public DbSet<VehiculoDetalle> VehiculosDetalle { get; set; }
    }
}
