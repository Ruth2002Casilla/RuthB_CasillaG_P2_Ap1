using Microsoft.EntityFrameworkCore;

namespace SegundoParcial.Server.DAL
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context>options) : base(options) { }
    }
}
