using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieRental.Domain.Entities.Customers;
using MovieRental.Infrastructure.Extensions;

namespace MovieRental.Infrastructure.EntityConfigurations.Customers
{
    public class MovieEntityConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable(nameof(Customer));

            builder.HasKey(e => e.CustomerId);

            builder.Property(e => e.CustomerName);

            builder.AsAuditableEntity();

        }
    }
}
