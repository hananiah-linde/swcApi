using Api.Database.Postgre.Constants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Api.Database.Entity.Threats;

namespace Api.Database.Postgre.Configuration;
internal class TypeConfiguration : IEntityTypeConfiguration<Entity.Threats.Type>
{
    public void Configure(EntityTypeBuilder<Entity.Threats.Type> builder)
    {
        builder.ToTable(TableName.Type);

        builder.HasKey(t => t.Id);
        builder.Property(x => x.Id)
            .IsRequired()
            .UseIdentityColumn()
            .HasColumnType(ColumnTypeName.INT);


        builder.Property(t => t.Name)
            .HasColumnName("name")
            .HasColumnType(ColumnTypeName.VARCHAR)
            .HasMaxLength(45);


        builder.Property(s => s.Description)
            .HasColumnName("description")
            .HasColumnType(ColumnTypeName.VARCHAR)
            .HasMaxLength(255);

        builder.HasData(
            new Entity.Threats.Type { Id = 1, Name = "Referrer Spam", Description = "a Referrer spammer" },
            new Entity.Threats.Type { Id = 2, Name = "Web Crawler", Description = "potential search engine or index spider" }

        );
    }
}
