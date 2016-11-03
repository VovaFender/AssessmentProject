using APro.Domain.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace APro.Domain.Data.Configuration
{
    internal static class ExaminationConfiguration
    {
        public static void Configure(ModelBuilder builder)
        {
            var examination = builder.Entity<Examination>();
            
            examination.ToTable("examination");
            examination.HasKey(e => e.ID);
            examination.Property(e => e.ID).HasColumnName("id");
            examination.Property(e => e.Description).HasColumnName("description");
            examination.Property(e => e.AssignedToID).HasColumnName("assigned_to_id");
            examination.Property(e => e.CreatedByID).HasColumnName("created_by_id");
            examination.Property(e => e.AssignmentDate).HasColumnName("assignment_date");
        }
    }
}