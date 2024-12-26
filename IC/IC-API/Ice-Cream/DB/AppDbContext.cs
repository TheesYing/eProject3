﻿using Ice_Cream.Models;
using Microsoft.EntityFrameworkCore;

namespace Ice_Cream.DB
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<Order> Orders { get; set;}
        public DbSet<PaymentInfo> PaymentInfos { get; set; }

    }

}