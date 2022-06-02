using API_A2W.Data.Mapping;
using API_A2W.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace API_A2W.Data.Context
{
    public class MyContext : DbContext
    {
        DbSet<CarroEntity> Carro { get; set; }

        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<CarroEntity>(new CarroMap().Configure);
        }
    }
}
