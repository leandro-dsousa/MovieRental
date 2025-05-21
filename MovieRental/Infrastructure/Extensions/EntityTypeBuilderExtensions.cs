using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieRental.Domain.Entities.Common;

namespace MovieRental.Infrastructure.Extensions
{
    public static class EntityTypeBuilderExtensions
    {
        public static void AsAuditableEntity<T>(this EntityTypeBuilder<T> builder) where T : AuditableEntity
        {
            builder.AsPartialAuditableEntity();

            builder.Property(e => e.AlteracaoData)
                .HasDefaultValue(DateTime.UtcNow)
                .HasComment("Data de alteração do registo (auditoria).");

            builder.Property(e => e.AlteracaoUtilizadorId)
                .HasComment("Identificador do utilizador que alterou o registo (auditoria).");
        }

        public static void AsPartialAuditableEntity<T>(this EntityTypeBuilder<T> builder) where T : PartialAuditableEntity
        {
            builder.Property(e => e.CriacaoData)
                .HasDefaultValue(DateTime.UtcNow)
                .HasComment("Data de criação do registo (auditoria).");

            builder.Property(e => e.CriacaoUtilizadorId)
                .HasComment("Identificador do utilizador que criou o registo (auditoria).");
        }
    }
}
