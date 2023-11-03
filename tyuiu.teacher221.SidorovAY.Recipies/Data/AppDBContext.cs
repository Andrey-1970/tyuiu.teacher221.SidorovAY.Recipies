using Microsoft.EntityFrameworkCore;

namespace tyuiu.teacher221.SidorovAY.Recipies.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> option) : base(option) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Ingridient> Ingridients { get; set; }
        public DbSet<MesureType> MesureTypes { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
    }
}
