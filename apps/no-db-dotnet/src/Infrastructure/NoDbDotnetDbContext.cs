using Microsoft.EntityFrameworkCore;

namespace NoDbDotnet.Infrastructure;

public class NoDbDotnetDbContext : DbContext
{
    public NoDbDotnetDbContext(DbContextOptions<NoDbDotnetDbContext> options)
        : base(options) { }
}
