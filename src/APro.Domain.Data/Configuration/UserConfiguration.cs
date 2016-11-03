using APro.Domain.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace APro.Domain.Data.Configuration
{
    internal static class UserConfiguration
    {
        public static void Configure(ModelBuilder builder)
        {
            var user = builder.Entity<User>();

            user.HasKey(u => u.ID);
            user.ToTable("user_account");
            user.Property(u => u.ID).HasColumnName("id");
            user.Property(u => u.FirstName).HasColumnName("first_name");
            user.Property(u => u.LastName).HasColumnName("last_name");
            user.Property(u => u.RoleID).HasColumnName("role_id");
        }
    }
}