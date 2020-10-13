using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projeto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Infra.Data.Mappings
{
    public class MedicoMap : IEntityTypeConfiguration<Medico>
    {
        public void Configure(EntityTypeBuilder<Medico> builder)
        {
            builder.ToTable("Medico");

            builder.HasKey(m => m.IdMedico);

            builder.Property(m => m.IdMedico)
                .HasColumnName("IdMedico")
                .IsRequired();

            builder.Property(m => m.Nome)
                .HasColumnName("Nome")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(m => m.Crm)
                .HasColumnName("Crm")
                .HasMaxLength(10)
                .IsRequired();

            builder.Property(m => m.Especializacao)
                .HasColumnName("Especializacao")
                .HasMaxLength(200)
                .IsRequired();
        }
    }
}
