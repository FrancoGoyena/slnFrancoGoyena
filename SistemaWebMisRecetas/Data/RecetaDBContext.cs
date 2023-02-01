using Microsoft.EntityFrameworkCore;
using SistemaWebMisRecetas.Models;

namespace SistemaWebMisRecetas.Data
{
    public class RecetaDBContext:DbContext
    {
        public RecetaDBContext(DbContextOptions<RecetaDBContext> options) : base(options) { }

        public DbSet<Receta> Recetas { get; set; }
    }
}
