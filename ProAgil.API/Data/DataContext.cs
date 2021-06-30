using Microsoft.EntityFrameworkCore;
using ProAgil.API.Model;

namespace ProAgil.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) {        }

        public DbSet<Evento> Eventos { get; set; } // IMPORTANTE: Toda vez que quiser criar uma tabela eu utilizo esse DBSET
                                                    // Uma boa pratica é sempre colocar o nome da tabela no plural
                     
    }
}
