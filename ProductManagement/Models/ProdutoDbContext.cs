using System.Data.Entity;

namespace ProductManagement.Models
{
    public class ProdutoDbContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
    }
}