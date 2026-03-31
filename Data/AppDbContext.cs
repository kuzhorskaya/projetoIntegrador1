using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.Net.Http.Headers;
using projetoIntegrador1.Models;

namespace projetoIntegrador1.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) 
        : base(options)
        {
        } 

        public DbSet<User> Users => Set<User>();
        public DbSet<Project> Projects => Set<Project>();
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
            .HasMany(u => u.ProjectList)
            .WithMany(p => p.UserList);
        }



        // TODO: esta classe é o ponto central para EF Core salvar/ler dados.
        // Você deve configurar o banco em Program.cs com options.UseSqlite("Data Source=app.db").

        // TODO: adicionar os DbSet para as tabelas que você vai usar:
        // public DbSet<User> Users { get; set; }
        // public DbSet<Project> Projects { get; set; }

        // Depois de criar os modelos, rode as migrations:
        // dotnet ef migrations add Initial
        // dotnet ef database update
    }
}