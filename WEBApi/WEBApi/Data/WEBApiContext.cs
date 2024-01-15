using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WEBApi.Models;

namespace WEBApi.Data
{
    public class WEBApiContext : DbContext
    {
        public WEBApiContext (DbContextOptions<WEBApiContext> options)
            : base(options)
        {
        }

        public DbSet<WEBApi.Models.ShopList> ShopList { get; set; } = default!;
    }
}
