using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyFinanceInvest.Domain.Entities;

namespace MyFinanceInvest.Data.Context.MappingData
{
    public class BankMap : IEntityTypeConfiguration<BankInfo>
    {
        public void Configure(EntityTypeBuilder<BankInfo> builder)
        {

            builder.ToTable("MI_BANCO");

            builder.HasKey(o => o.Id);

            builder.Property(t => t.Id)
                .HasMaxLength(15)
                .HasColumnName("Id")
                .UseSqlServerIdentityColumn();


            builder.Property(t => t.Code)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("Codigo")
                    .HasColumnType("varchar(15)");

            builder.Property(t => t.Description)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("Descricao")
                    .HasColumnType("varchar(250)");

        }
    }
}
