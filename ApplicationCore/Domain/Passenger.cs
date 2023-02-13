using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Domain
{
    public class Passenger
    {
        public int PasseportNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public ICollection<Flight> Flights { get; set; }

        //public bool CheckProfile(string fn,string ln)
        //{
        //    if (FirstName==fn && LastName==ln)
        //    {
        //        return true;
        //    }
        //    return false;
        //}
        //public bool CheckProfile(string fn, string ln,string email)
        //{
        //    if (FirstName == fn && LastName == ln && EmailAddress==email)
        //    {
        //        return true;
        //    }
        //    return false;
        //}
        public bool CheckProfile(string fn, string ln, string email=null)
        {
            if (email!=null)
            {
                if (FirstName == fn && LastName == ln && EmailAddress == email)
                {
                    return true;
                }
                return false;
            }
           else { return false; }
        }
        public virtual void PassengerType()
        {
            Console.WriteLine("I'm a passenger");
        }
    }
}
