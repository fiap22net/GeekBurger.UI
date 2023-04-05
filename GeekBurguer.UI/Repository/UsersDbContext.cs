using GeekBurguer.UI.Contract;
using GeekBurguer.UI.Model;
using Microsoft.EntityFrameworkCore;

namespace GeekBurguer.UI.Repository
{
    public class UsersDbContext:DbContext
    {
        public UsersDbContext(DbContextOptions<UsersDbContext> options)
         : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
    }
}
