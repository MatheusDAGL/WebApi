using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebApi.Models;
using Microsoft.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WebApi.Infraestrutura
{
    public class ConnectionContext : DbContext
    {
        public DbSet<Funcionarios> Funcionarios { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(
            "Data Source=DESKTOP-7RJ7S3H\\SQLEXPRESS;Initial Catalog=BD_TESTE;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;"
            );

    }
}
