using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieRental.Domain.Entities.Rentals;
using MovieRental.Infrastructure.Extensions;

namespace MovieRental.Infrastructure.EntityConfigurations.Rentals
{
    public class RentalEntityConfiguration : IEntityTypeConfiguration<Rental>
    {
        public void Configure(EntityTypeBuilder<Rental> builder)
        {
            builder.ToTable(nameof(Rental));

            builder.HasKey(e => e.Id);

            builder.Property(e => e.DaysRented)
                .HasComment("<int> Dias alugados");

            builder.Property(e => e.CustomerId)
                .HasComment("<int> FK Customer");
            
            builder.Property(e => e.MovieId)
                .HasComment("<int> FK Movie");

            builder.Property(e => e.PaymentMethod)
                .HasComment("<string> Método de pagamento");


            builder.HasOne(d => d.Customer)
              .WithMany(p => p.Rentals)
              .HasForeignKey(d => d.CustomerId);
            
            builder.HasOne(d => d.Movie)
              .WithMany(p => p.Rentals)
              .HasForeignKey(d => d.MovieId);

            builder.AsAuditableEntity();

        }
    }
}
