using Microsoft.EntityFrameworkCore;

public class AssessmentDataContext : DbContext
{
    public AssessmentDataContext(DbContextOptions<AssessmentDataContext> options)
        : base(options)
    {
        
    }

    public DbSet<Question> Questions { get; set; }
}