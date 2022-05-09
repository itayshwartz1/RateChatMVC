using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NewProject1.Models;

namespace NewProject1.Data
{
    public class NewProject1Context : DbContext
    {
        public NewProject1Context (DbContextOptions<NewProject1Context> options)
            : base(options)
        {
        }

        public DbSet<NewProject1.Models.Rate> Rate { get; set; }
    }
}
