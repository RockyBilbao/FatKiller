using FatKiller.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace FatKiller.Data.Repository
{
    public class ProjectEntities : DbContext
    {
        public ProjectEntities(DbContextOptions<ProjectEntities> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Random rnd = new Random();

            //for (int i = 0; i < 10; i++)
            //{
            //    var macroId = Guid.NewGuid();
            //    modelBuilder.Entity<Macronutrients>().HasData(new Macronutrients
            //    {
            //        MacronutrientsId = macroId,
            //        Carbohydrates = rnd.Next(0, 99),
            //        Protein = rnd.Next(0, 99),
            //        Fat = rnd.Next(0, 99),
            //    });

            //    modelBuilder.Entity<Product>().HasData(new Product
            //    {
            //        ProductId = Guid.NewGuid(),
            //        ProductName = "Bułka",
            //        ProductCategory = ProductGenre.Dairy,
            //        ProductPrice = rnd.Next(0, 99),
            //        ProductWeight = rnd.Next(0, 150),
            //        MacronutrientsId = macroId
            //    });
            //}

        }

        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Macronutrients> Macronutrients { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserData> UserData { get; set; }
        public virtual DbSet<DailyFoodDiary> DailyFoodDiary { get; set; }
        public virtual DbSet<DailyFoodDiaryData> DailyFoodDiaryData { get; set; }
    }
}
