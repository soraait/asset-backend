using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class GoodsDetailContext:DbContext
    {
        
        public GoodsDetailContext(DbContextOptions<GoodsDetailContext> options):base (options)
        {

        }
        public DbSet<GoodsDetail> GoodsDetail { get; set; }
       
    }
}
