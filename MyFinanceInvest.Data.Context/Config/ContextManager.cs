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
                optionsBuilder.UseSqlServer(@"Server=tcp:myfinanceju.database.windows.net,1433;Initial Catalog=MyFinance;Persist Security Info=False;User ID=udanjo;Password=udsp@2019;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
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
