﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data.Common;

namespace net_il_mio_fotoalbum.Models
{
    public class PhotoContext : DbContext
    {
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=albumDB;Integrated Security=True;TrustServerCertificate=True;");
        }

    }
}