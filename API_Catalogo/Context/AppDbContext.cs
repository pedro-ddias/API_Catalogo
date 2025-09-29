using API_Catalogo.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace API_Catalogo.Context;

internal class ApplicationDbContext:DbContext
{
    public DbSet<Categoria>? Categorias { get; set; }
    public DbSet<Produto>? Produtos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Lendo a string de conexão do arquivo appsettings.json
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();
        optionsBuilder.UseSqlServer(connectionString: configuration.GetConnectionString("DefaultConnection"));

    }
}
