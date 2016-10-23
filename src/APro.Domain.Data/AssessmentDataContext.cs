using APro.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace APro.Domain.Data
{
    public class AssessmentDataContext : DbContext
    {
        public AssessmentDataContext(DbContextOptions<AssessmentDataContext> options)
            : base(options)
        {
        }

        public DbSet<Question> Questions { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Question>().ToTable("question");
            builder.Entity<Question>().Property(q => q.ID).HasColumnName("id");
            builder.Entity<Question>().Property(q => q.Description).HasColumnName("description");
            builder.Entity<Question>().HasKey(q => q.ID);

            base.OnModelCreating(builder);
        }
    }    
}