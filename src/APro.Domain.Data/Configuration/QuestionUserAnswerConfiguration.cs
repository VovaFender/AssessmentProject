using APro.Domain.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace APro.Domain.Data.Configuration
{
    public static class QuestionUserAnswerConfiguration
    {
        public static void Configure(ModelBuilder builder)
        {
            var questionUserAnswer = builder.Entity<QuestionUserAnswer>();
            
            questionUserAnswer.ToTable("question_user_answer");
            questionUserAnswer.HasKey(e => e.ID);
            questionUserAnswer.Property(e => e.ID).HasColumnName("id");            
            questionUserAnswer.Property(e => e.ExaminationDetailsID)
                .HasColumnName("examination_details_id");

            questionUserAnswer.Property(e => e.TestQuestionID).HasColumnName("test_question_id");

            questionUserAnswer
                .HasOne(qua => qua.TestQuestion)
                .WithMany(tq => tq.UserAnswers)
                .HasForeignKey(qua => qua.TestQuestionID);

            questionUserAnswer
                .HasOne(qua => qua.ExaminationDetails)
                .WithMany(ed => ed.UserAnswers)
                .HasForeignKey(qua => qua.ExaminationDetailsID);                
        }
    }
}