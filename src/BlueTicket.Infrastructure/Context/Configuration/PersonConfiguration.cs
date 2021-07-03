using BlueTicket.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlueTicket.Infrastructure.Context.Configuration
{
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {           
            builder.HasKey(p => p.PersonId);

            builder.Property(p => p.FirstName)
                   .HasColumnType("varchar")
                   .HasMaxLength(50)
                   .IsRequired();

            builder.Property(p => p.LastName)
                   .HasColumnType("varchar")
                   .HasMaxLength(50)
                   .IsRequired();

            builder.Property(p => p.Email)
                   .HasColumnType("varchar")
                   .HasMaxLength(50)
                   .IsRequired();

            builder.Property(p => p.Gender)
                   .HasColumnType("int");

            builder.HasQueryFilter(p => p.Active);
        }
    }
}
