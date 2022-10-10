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

        public MC(string licenseplate, DateTime date) {
            Licenseplate = licenseplate;
            Date = date;
            //Car = car;
        }
        /// <summary>
        /// Denne metode har den funktion at give en pris på MC-køretøjet.
        /// </summary>
        /// <returns>Denne metode returner, at prisen på MC-køretøjet er 125.</returns>
        public double Price() {
            return 125;
        }
        /// <summary>
        /// Denne metode har den funktion at fortælle, hvad for et køretøjtype, som MC er.
        /// </summary>
        /// <returns>Denne metode returner, at køretøjtypen er MC.</returns>
        public string VehicleType() {
            return "MC";
        }

    }
}
