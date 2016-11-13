using APro.Domain.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace APro.Domain.Data
{
    public static class PossibleAnswerSelectedConfiguration
    {
        public static void Configure(ModelBuilder builder)
        {
            var entity = builder.Entity<PossibleAnswerSelected>();
            
            entity.ToTable("possible_answer_selected");
            entity.HasKey(e => e.ID);
            entity.Property(e => e.ID).HasColumnName("id");
            entity.Property(e => e.QuestionUserAnswerID).HasColumnName("question_user_answer_id");
            entity.Property(e => e.SelectedAnswerID).HasColumnName("selected_answer_id");

            entity
                .HasOne(e => e.QuestionUserAnswer)
                .WithMany(qua =>qua.SelectedAnswers)
                .HasForeignKey(e => e.QuestionUserAnswerID);

            entity
                .HasOne(e => e.SelectedAnswer)
                .WithMany(psa => psa.UsersChoices)
                .HasForeignKey(e => e.SelectedAnswerID);
        }
    }
}