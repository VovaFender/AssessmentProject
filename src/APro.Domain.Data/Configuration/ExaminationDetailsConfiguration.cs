using APro.Domain.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace APro.Domain.Data.Configuration
{
    public static class ExaminationDetailsDetailsConfiguration
    {
        public static void Configure(ModelBuilder builder)
        {
            var examinationDetails = builder.Entity<ExaminationDetails>();
            
            examinationDetails.ToTable("examination_details");
            examinationDetails.HasKey(e => e.ID);
            examinationDetails.Property(e => e.ID).HasColumnName("id");
            examinationDetails.Property(e => e.Status).HasColumnName("status");
            examinationDetails.Property(e => e.ExaminationID).HasColumnName("examination_id");

            examinationDetails
                .HasOne(ed => ed.Examination)
                .WithOne(e => e.ExaminationDetails)
                .HasForeignKey(typeof(ExaminationDetails), "ExaminationID");

            examinationDetails
                .HasMany(ed => ed.UserAnswers)
                .WithOne(ua => ua.ExaminationDetails)
                .HasForeignKey(ua => ua.ExaminationDetailsID);
        }
    }
}