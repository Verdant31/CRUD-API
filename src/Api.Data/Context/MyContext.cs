using Microsoft.EntityFrameworkCore;
using Api.Data.Mapping;
using Api.Domain.Entities;

//Vai receber as entidades que estão na pasta Dominio
namespace Api.Data.Context
{
  public class MyContext : DbContext
  {
    public DbSet<UserEntity> Users { get; set; }

    public MyContext(DbContextOptions<MyContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);
      modelBuilder.Entity<UserEntity>(new UserMap().Configure);
    }
  }
}
