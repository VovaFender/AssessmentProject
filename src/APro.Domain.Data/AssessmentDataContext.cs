using Microsoft.EntityFrameworkCore;

public class AssessmentDataContext : DbContext
{
    public AssessmentDataContext(DbContextOptions<AssessmentDataContext> options)
        : base(options)
    {
        
    }

    public DbSet<Question> Questions { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Question>().HasKey(q => q.QuestionID);
        
        base.OnModelCreating(builder);
    }

}