using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using AM.ApplicationCore.Domain;
using AM.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;

namespace AM.Infrastructure
{
   public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(this.GetJsonConnectionString("appsettings.json"));
            optionsBuilder
                .UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);

        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<DateTime>().HaveColumnType("DateTime");
            base.ConfigureConventions(configurationBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Passenger>().Property(e => e.TelNumber).HasColumnName("NumTel");
            modelBuilder.ApplyConfiguration(new PlaneConfiguration());
            modelBuilder.ApplyConfiguration(new TicketConfiguration()); 
            modelBuilder.Entity<Passenger>().OwnsOne(e => e.FullName, c =>
            {
                c.Property(e => e.FirstName).HasColumnName("FullNameFirst");
            }
            );
            modelBuilder.Entity<Passenger>().OwnsOne(e => e.FullName, c =>
            {
                c.Property(e => e.LastName).HasColumnName("FullNameLast");
            }
            );
         /*  modelBuilder.Entity<Passenger>()
           .HasDiscriminator<string>("PassengerTypeValue").HasValue<Staff>("1").HasValue<Traveller>("2").HasValue<Passenger>("0");
         */
            modelBuilder.Entity<Traveller>().ToTable("Traveller");
            modelBuilder.Entity<Staff>().ToTable("Staff");
            base.OnModelCreating(modelBuilder);
        }
        



        public DbSet<Flight> flight { get; set; }
        public DbSet<Passenger> passenger { get; set; }
        public DbSet<Plane> plane { get; set; }
        public DbSet<Staff> staff { get; set; }
        public DbSet<Traveller> traveller { get; set; }
        public DbSet<Ticket> tickets { get; set; }

    }
}   
