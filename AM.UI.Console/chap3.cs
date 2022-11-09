using AM.ApplicationCore;
using AM.ApplicationCore.Domain;
using AM.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace AM.UI.Console
{
    public class chap3
    {
        static ShowLine showLine = System.Console.WriteLine;

       /* public static void Test1()
        {
            using (var dbcontext = new Context())
            {
                dbcontext.flight.AddRange(InMemorySource.Flights);
                dbcontext.plane.Add(InMemorySource.Boeing2);
                dbcontext.plane.Add(InMemorySource.Boeing1);
                dbcontext.plane.Add(InMemorySource.Airbus);
                dbcontext.staff.AddRange(InMemorySource.Staffs);
                dbcontext.traveller.AddRange(InMemorySource.Travellers);
                dbcontext.SaveChanges();




            }

        }*/
        
        public static void Test2()
        {
            using (var dbcontext = new Context())
            {
                var list = dbcontext.tickets.ToList();
                list.ShowList<Ticket>("Ticket", showLine); 

                    }
        }





    }
}

