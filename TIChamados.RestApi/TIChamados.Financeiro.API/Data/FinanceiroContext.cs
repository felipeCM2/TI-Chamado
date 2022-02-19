using Microsoft.EntityFrameworkCore;
using TIChamados.Financeiro.API.Models;

namespace TIChamados.Financeiro.API.Data
{
    public class FinanceiroContext : DbContext
    {
        public FinanceiroContext(DbContextOptions<FinanceiroContext> options): base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            ChangeTracker.AutoDetectChangesEnabled = false;
        }

        public DbSet<Models.Financeiro> Financeiro { get; set; }
    }
}
