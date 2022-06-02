using API_A2W.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API_A2W.Data.Mapping
{
    public class CarroMap : IEntityTypeConfiguration<CarroEntity>
    {
        public void Configure(EntityTypeBuilder<CarroEntity> builder)
        {
            builder.ToTable("Carro");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.NomeCarro).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Marca).IsRequired().HasMaxLength(60);
            builder.Property(x => x.Placa).IsRequired().HasMaxLength(15);
        }
    }
}
