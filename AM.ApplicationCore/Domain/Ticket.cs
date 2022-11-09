using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Ticket
    {
        public double price { get; set; }
        public int seat { get; set; }
        public bool VIP { get; set; }

        public virtual Flight flight { get; set; }
        public virtual Passenger passenger { get; set; }
        public int flightKey { get; set; }
        public string passengerKey { get; set; }



        public override string ToString()
        {
            return $"Price: {price}, Seat:{seat}, VIP:{VIP}, Flight: {flight}, Passenger:{passenger}";
        }
    }
}
