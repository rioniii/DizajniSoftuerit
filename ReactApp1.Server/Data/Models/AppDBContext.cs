﻿﻿using Microsoft.EntityFrameworkCore;

namespace ReactApp1.Server.Data.Models
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }
      
        public DbSet<User> Users { get; set; }

    }
}
