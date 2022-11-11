using GamzeNurKural_Week3_Homework.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GamzeNurKural_Week3_Homework.Data.Configurations
{
    public class WorkerConfiguration : IEntityTypeConfiguration<Worker>
    {
        public void Configure(EntityTypeBuilder<Worker> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.FirstName).IsRequired();
            builder.Property(x => x.LastName).IsRequired();
            builder.Property(x => x.BirthDate).IsRequired();
            builder.Property(x => x.Mail).IsRequired();
            builder.Property(x => x.Phone).IsRequired();
            builder.ToTable("Workers");
        }
    }
}
