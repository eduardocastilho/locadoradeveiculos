using Microsoft.EntityFrameworkCore;

namespace locadoradeveiculos.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        public DbSet<Aluguel> alugueis { get; set; }
        public DbSet<Cliente> clientes { get; set; }
        public DbSet<Funcionario> funcionarios { get; set; }
        public DbSet<Veiculo> veiculos { get; set; }

    }
}
