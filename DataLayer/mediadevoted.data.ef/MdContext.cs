using mediadevoted.domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace mediadevoted.data.ef
{
    public class MdContext : DbContext
    {
        private MdContext(DbContextOptions<MdContext> options) : base(options)
        {
        }

        public DbSet<Cart> Carts { get; set; }
    }
}
