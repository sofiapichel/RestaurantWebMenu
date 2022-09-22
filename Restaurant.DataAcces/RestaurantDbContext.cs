using Microsoft.EntityFrameworkCore;
using System;
using Restaurant.Models;

namespace Restaurant.DataAcces
{
    public class RestaurantDbContext : DbContext
    {
        public RestaurantDbContext(DbContextOptions<RestaurantDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    //    //optionsBuilder.UseSqlServer(@"Data Source = localhost; Initial Catalog = SMSAsignaciones; Integrated Security = true");
        //    optionsBuilder.UseSqlServer(@"Server=.\sqlexpress;Database=ConsultasRestaurant_Db ; Trusted_Connection=true;");
        //    //    //comentar OnConfiguring  cuando  se configure en BASE del constructor
        //}

        public DbSet<Restaurante> Restaurants { get; set; }

    }
}
