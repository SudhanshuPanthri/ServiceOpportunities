using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceOpportunities.Infrastructure.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions options):base(options)
        {
            
        }
    }
}
