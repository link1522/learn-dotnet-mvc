using Microsoft.EntityFrameworkCore;

namespace HelloMVC.Models;

public class DotnetMvcContext : DbContext
{
  public DotnetMvcContext() { }

  public DotnetMvcContext(DbContextOptions<DotnetMvcContext> options) { }

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    var connectionString = "server=127.0.0.1;database=dotnet_mvc;user=root;password=root;";
    optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
  }

  public DbSet<Book> book { get; set; }
}
