using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        
        public DateTime BirthDate { get; set; }
        public virtual IList<Ticket> ticket { get; set; }

        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        [Required]
        public FullName FullName { get; set; }

        [Key]
        public string PassportNumber { get; set; }

        [RegularExpression("^[0-9]{8}$")]
        public string TelNumber { get; set; }
       // public IList<Flight> Flights { get; set; }
        public virtual string PassengerType { get { return "Unknown passenger type"; } }
        public override string ToString()
        {
            return $"PassportNumber : {PassportNumber}";
        }
    }
}
