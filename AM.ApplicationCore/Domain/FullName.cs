using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
   
    public class FullName
    {
        
        [StringLength(250)]
        [MaxLength(300, ErrorMessage = "maximum characters allowed depassed")]
        public string FirstName { get; set; }

        
        [StringLength(250)]
        [MaxLength(300, ErrorMessage = "maximum characters allowed depassed")]
        public string LastName { get; set; }

        public override string ToString()
        {
            return $"FirstName : {FirstName}, LastName : {LastName}";
        }

    }
}
