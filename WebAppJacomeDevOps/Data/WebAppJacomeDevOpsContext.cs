using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppJacomeDevOps.Models;

namespace WebAppJacomeDevOps.Data
{
    public class WebAppJacomeDevOpsContext : DbContext
    {
        public WebAppJacomeDevOpsContext (DbContextOptions<WebAppJacomeDevOpsContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppJacomeDevOps.Models.Movie> Movie { get; set; } = default!;
    }
}
