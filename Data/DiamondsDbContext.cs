using Data.EntityModels;
using Microsoft.EntityFrameworkCore;


namespace Data
{
    public class DiamondsDbContext : DbContext
    {
        public DiamondsDbContext(DbContextOptions<DiamondsDbContext> options)
    : base(options)
        { }

        public DbSet<Hero> Heroes { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Quest> Quests { get; set; }
        public DbSet<Stage> Stages { get; set; }
    }
}
