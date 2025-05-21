using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieRental.Domain.Entities.Movies;
using MovieRental.Infrastructure.Extensions;

namespace MovieRental.Infrastructure.EntityConfigurations.Movies
{
    public class MovieEntityConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.ToTable(nameof(Movie));

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Title)
                .HasComment("<string> Title");

            builder.AsAuditableEntity();

        }
    }
}
