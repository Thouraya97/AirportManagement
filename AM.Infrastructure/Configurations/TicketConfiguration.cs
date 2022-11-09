using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AM.Infrastructure.Configurations
{
    class TicketConfiguration : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            builder.HasKey(e => new { e.seat, e.flightKey, e.passengerKey });
            builder.HasOne(e => e.flight).WithMany(e => e.ticket).HasForeignKey(e => e.flightKey);
            builder.HasOne(e => e.passenger).WithMany(e => e.ticket).HasForeignKey(e => e.passengerKey);

        }
    }
}
