using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystemClassLibrary {
    public class MC : Vehicle {
        private string _licenseplate;
        private DateTime _date;
        //public string _car;

        public string Licenseplate { get; set; }
        public DateTime Date { get; set; }
        //public string ar { get; set; }

        public MC(string licenseplate, DateTime date, string car) {
            Licenseplate = licenseplate;
            Date = date;
            //Car = car;
        }

        public static double Price() {
            return 125;
        }

        public string VehicleType() {
            return "MC";
        }

    }
}
