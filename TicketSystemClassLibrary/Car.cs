using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystemClassLibrary {
    public class Car : Vehicle {

        private string _licenseplate;
        private DateTime _date;

        //public string Licenseplate { get; set; }
        //public DateTime Date { get; set; }
        public string LicensePlate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime Date { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        //public string ar { get; set; }


        public Car(string licenseplate, DateTime date)
        {
            LicensePlate = licenseplate;
            Date = date;
            //Car = car;
        }
        /// <summary>
        /// Denne metode "Price" udfører funktionen af at returnere en pris, som i dette tilfælde skal returneres med 240 kr.
        /// </summary>
        /// <returns>Den returner 240 som prisen.</returns>
        public /*static*/ double Price()
        {
            //Date.DayOfWeek == DayOfWeek.Sunday;
            return 240;
        }
        /// <summary>
        /// Denne metode "VehicleType" udfører funktionen af at fortælle hvilken string, som Car har.
        /// </summary>
        /// <returns>Den returner stringen "Car".</returns>
        public string VehicleType()
        {
            return "Car";
        }

    }
}
