using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    // becomes and EF DbContext class once you inherit from DbContext
    public class MovieShopDbContext: DbContext
    {
        // assign the connection string to this DbContext
        public MovieShopDbContext(DbContextOptions<MovieShopDbContext> options) : base(options)
        {

        }
    }
}
