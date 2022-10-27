using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystemClassLibrary {
    public abstract class Vehicle
    {
        public int _licensePlate { get; set; }
        public DateTime Date { get; set; }

        private int licensePlateRestriction { get; set; }

        /// <summary>
        /// Denne metode har den funktion at fortælle brugeren, at nummerpladsen højst må indeholde 7 tegn.
        /// </summary>
        /// <returns>Denne metode returner enten nummerpladen eller ArgumentException'en, at "nummerpladen må højst indeholde 7 tegn.</returns>
        /// <exception cref="ArgumentException"></exception>
        public virtual int LicensePlateRestriction()
        {
            if (_licensePlate < 8)
            {
                return _licensePlate;
            }
            else
            {
                throw new ArgumentException("Licenseplate must contain 7 characters at most.");
            }
        }
    }
}
