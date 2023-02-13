using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Domain
{
    public enum PlaneType { Boing, Airbus }
    public class Plane
    {
        public int Capacity { get; set; }
        public DateTime ManufactureDate { get; set; }
        public int PlaneID { get; set; }
        public PlaneType PlaneType { get; set; }
        public ICollection<Flight> Flights { get; set; }
        public override string ToString()
        {
            return this.PlaneID + " " + this.PlaneType + " " + this.ManufactureDate + " " +this.Capacity;
        }
        //public Plane(PlaneType pt, int capacity, DateTime date)
        //{
        //    this.PlaneType= pt;
        //    this.Capacity= capacity;
        //    this.ManufactureDate= date;
        //}

        //public Plane()
        //{
        //}
    }
}
