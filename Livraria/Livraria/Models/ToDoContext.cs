using Microsoft.EntityFrameworkCore;

namespace Livraria.Models
{
    public class ToDoContext :DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext> option)
            : base(option)
        {
        }
        public DbSet<Produto> todoProducts { get; set; }
        // criando model para o banco de dados
    }
}
