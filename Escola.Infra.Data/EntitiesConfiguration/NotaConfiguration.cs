using Escola.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Escola.Infra.Data.EntitiesConfiguration
{
    public class NotaConfiguration : IEntityTypeConfiguration<Nota>
    {
        public void Configure(EntityTypeBuilder<Nota> builder)
        {
            builder.HasKey(n => n.Id);
            builder.Property(n => n.MatriculaId)
                .IsRequired();
            builder.Property(n => n.ValorNota)
                .HasPrecision(10,2)
                .IsRequired();

            builder.HasOne(x => x.Matricula)
                .WithMany(x => x.Notas)
                .HasForeignKey(x => x.MatriculaId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
