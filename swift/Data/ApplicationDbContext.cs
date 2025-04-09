using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace swift.Data // ⚠️ Убедись, что "swift" = имя твоего проекта
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Тут можно будет добавить DbSet, например:
        // public DbSet<UserProfile> UserProfiles { get; set; }
    }
}

