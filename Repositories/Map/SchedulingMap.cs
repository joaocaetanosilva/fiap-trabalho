using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Recycle.Entities;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Recycle.Repository.Map
{
    public class SchedulingMap : IEntityTypeConfiguration<Scheduling>
    {
        public void Configure(EntityTypeBuilder<Scheduling> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.Id)
                .ValueGeneratedOnAdd();

            builder.Property(b => b.Horario)
               .IsRequired();

             builder.Property(b => b.Bairro)
                .HasMaxLength(60)
                .IsRequired();
        }
    }
}
