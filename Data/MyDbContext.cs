﻿using Microsoft.EntityFrameworkCore;

namespace CongThongTin.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options) { 

        }
        
    }
}
