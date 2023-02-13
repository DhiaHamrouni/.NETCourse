using ApplicationCore.Domain;
using ApplicationCore.Interface;
using ConsoleApp4.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Service
{
    public class ServiceFlight : IServiceFlight
    {
        public List<Flight> Flights { get; set; } = new List<Flight>();

        //public List<DateTime> GetFlightDates(string destination)
        //{
        //    //List<DateTime> result = new List<DateTime>();
        //    //for (int i = 0;i<Flights.Count();i++)
        //    //{
        //    //    if (Flights[i].Destination == destination)
        //    //    {
        //    //        result.Add(Flights[i].FlightDate);
        //    //    }
        //    //}
        //    //return result;
        //}
        public void GetFlightDates(string destination)
        {
            foreach (var item in Flights)
            {
                if (item.Destination == destination)
                {
                    Console.WriteLine(item.FlightDate);
                }
            }
        }

        public void GetFlights(string filterType, string filterValue)
        {
            switch (filterType)
            {
                case "destination":
                    foreach (var item in Flights)
                    {
                        if (item.Destination == filterValue)
                        {
                            Console.WriteLine(item);
                        }
                    }
                    break;
                case "FlightDate":
                    foreach (var item in Flights)
                    {
                        if (item.FlightDate == DateTime.Parse(filterValue))
                        {
                            Console.WriteLine(item);
                        }
                    }
                    break;
                case "departure":
                    foreach (var item in Flights)
                    {
                        if (item.Departure == filterValue)
                        {
                            Console.WriteLine(item);
                        }
                    }
                    break;
                case "Flightid":
                    foreach (var item in Flights)
                    {
                        if (item.FlightId == int.Parse(filterValue))
                        {
                            Console.WriteLine(item);
                        }
                    }
                    break;
                case "PlaneId":
                    foreach (var item in Flights)
                    {
                        if (item.Plane.PlaneID == int.Parse(filterValue))
                        {
                            Console.WriteLine(item);
                        }
                    }
                    break;

            }
        }

        public IEnumerable<DateTime> GetFlightdates(string destination)
        {
            var query = from flight in Flights
                        where flight.Destination == destination
                        select flight.FlightDate;
            return query;
        }

        public int ProgrammedFlightNumber(DateTime startDate)
        {
            var query = from flight in Flights
                        where flight.FlightDate>startDate && flight.FlightDate<startDate.AddDays(7)
                        select flight;
            return query.Count();
        }

        public void ShowFlightDetails(Plane plane)
        {
            var query= from flight in Flights
                       where flight.Plane==plane
                       select flight;
             foreach(var item in query)
            {
                Console.WriteLine(item.FlightDate);
                Console.WriteLine(item.Destination);
            }
        }

       
    }
}
