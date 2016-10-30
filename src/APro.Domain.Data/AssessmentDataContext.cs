using APro.Domain.Data.Models;
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
        public DbSet<Test> Tests { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            BuildQuestion(builder);
            BuildTest(builder);
            
            base.OnModelCreating(builder);
        }

        //TODO: move to EntityConfiguration and mappings
        private void BuildTest(ModelBuilder builder)
        {
            var testQuestion = builder.Entity<TestQuestion>();
            testQuestion.ToTable("test_question");
            testQuestion.HasKey(tq => tq.ID);
            testQuestion.Property(tq => tq.ID).HasColumnName("id");
            testQuestion.Property(tq => tq.QuestionID).HasColumnName("question_id");
            testQuestion.Property(tq => tq.TestID).HasColumnName("test_id");

            testQuestion
                .HasOne(tq => tq.Question)
                .WithMany(q => q.TestQuestions)
                .HasForeignKey(tq => tq.QuestionID);

            testQuestion
                .HasOne(tq => tq.Test)
                .WithMany(t => t.TestQuestions)
                .HasForeignKey(tq => tq.TestID);

            builder.Entity<Question>().HasMany(q => q.TestQuestions)
                .WithOne(tq => tq.Question)
                .HasForeignKey(tq => tq.QuestionID);

            var test = builder.Entity<Test>();
            test.ToTable("test");
            test.HasKey(t => t.ID);
            test.Property(t => t.ID).HasColumnName("id");
            test.Property(t => t.Title).HasColumnName("title");
            test.Property(t => t.Description).HasColumnName("description");

            test
                .HasMany(t => t.TestQuestions)
                .WithOne(tq => tq.Test)
                .HasForeignKey(tq => tq.TestID);
        }

        //TODO: move to EntityConfiguration and mappings
        private void BuildQuestion(ModelBuilder builder)
        {
            var possibleAnswer = builder.Entity<PossibleAnswer>();
            possibleAnswer.ToTable("possible_answer");
            possibleAnswer.HasKey(pa => pa.ID);
            possibleAnswer.Property(pa => pa.ID).HasColumnName("id");
            possibleAnswer.Property(pa => pa.IsCorrect).HasColumnName("is_correct");
            possibleAnswer.Property(pa => pa.Description).HasColumnName("description");
            possibleAnswer.Property(pa => pa.QuestionID).HasColumnName("question_id");

            var questionTag = builder.Entity<QuestionTag>();
            questionTag.Property(qt => qt.ID).HasColumnName("id");
            questionTag.Property(qt => qt.QuestionID).HasColumnName("question_id");
            questionTag.Property(qt => qt.TagID).HasColumnName("tag_id");
            questionTag.ToTable("question_tag");
            questionTag.HasKey(qt => qt.ID);
            
            questionTag
                .HasOne(qt => qt.Tag)
                .WithMany(t => t.QuestionTags)
                .HasForeignKey(qt => qt.TagID);

            var question = builder.Entity<Question>();

            question.ToTable("question");
            question.Property(q => q.ID).HasColumnName("id");
            question.Property(q => q.Description).HasColumnName("description");
            question.Property(q => q.RateDatabase).HasColumnName("rate");
            question.Ignore(q => q.Rate);
            question.HasKey(q => q.ID);
            question
                .HasMany(q => q.QuestionTags)
                .WithOne(qt => qt.Question)
                .HasForeignKey(qt => qt.QuestionID);

            question.HasMany(q => q.PossibleAnswers)
                .WithOne(pa => pa.Question)
                .HasForeignKey(pa => pa.QuestionID);

            var tag = builder.Entity<Tag>();

            tag.ToTable("tag");
            tag.Property(t => t.ID).HasColumnName("id");
            tag.Property(t => t.Title).HasColumnName("title");
            tag.HasKey(t => t.ID);
            tag
                .HasMany(t => t.QuestionTags)
                .WithOne(qt => qt.Tag)
                .HasForeignKey(qt => qt.TagID);
        }
    }    
}