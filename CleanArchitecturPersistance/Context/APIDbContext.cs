using CleanArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Persistance.Context;

public class APIDbContext: DbContext 
{

    public APIDbContext (DbContextOptions options) : base(options)
    {        }
    public DbSet<Product> Products { get; set; }
}
