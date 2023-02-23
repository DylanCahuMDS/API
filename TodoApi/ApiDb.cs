using Microsoft.EntityFrameworkCore;

class ApiDb : DbContext
{
    public ApiDb(DbContextOptions<ApiDb> options)
        : base(options) { }

    public DbSet<Api> Users => Set<Api>();
}

