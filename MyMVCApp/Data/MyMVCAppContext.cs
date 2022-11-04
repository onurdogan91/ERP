using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MyMVCApp.Data
{
    public class MyMVCAppContext : DbContext
    {
        public MyMVCAppContext (DbContextOptions<MyMVCAppContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie.Models.Movie> Movie { get; set; } = default!;
    }
}
