using Microsoft.EntityFrameworkCore;
using TesteCoordly.Model;

namespace TesteCoordly.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Produto> Produtos { get; set; }
}
