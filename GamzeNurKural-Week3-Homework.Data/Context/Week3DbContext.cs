using GamzeNurKural_Week3_Homework.Data.Configurations;
using GamzeNurKural_Week3_Homework.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GamzeNurKural_Week3_Homework.Data.Context
{
    public class Week3DbContext : DbContext
    {
        public Week3DbContext(DbContextOptions<Week3DbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new WorkerConfiguration());
        }

        DbSet<Worker> Workers { get; set; }

    }
}
