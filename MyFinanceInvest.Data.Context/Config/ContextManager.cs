using Microsoft.EntityFrameworkCore;
using MyFinanceInvest.Data.Context.MappingData;
using MyFinanceInvest.Domain.Entities;

namespace MyFinanceInvest.Data.Context.Config
{
    public class ContextManager : DbContext
    {
        #region DataBase

        public DbSet<BankInfo> Bank { get; set; }


        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("DataBase");
            }
        }
        public ContextManager(DbContextOptions<ContextManager> options) :
           base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BankMap());

            base.OnModelCreating(modelBuilder);
        }

    }
}
