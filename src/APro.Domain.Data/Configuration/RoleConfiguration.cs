using APro.Domain.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace APro.Domain.Data.Configuration
{
    public static class RoleConfiguration
    {
        public static void Configure(ModelBuilder builder)
        {
            var role = builder.Entity<Role>();

            role.ToTable("role");
            role.HasKey(r => r.ID);
            role.Property(r => r.ID).HasColumnName("id");
            role.Property(r => r.Title).HasColumnName("title");
            
            role
                .HasMany(r => r.Users)
                .WithOne(u => u.Role)
                .HasForeignKey(u => u.RoleID);
        }
    }   
}