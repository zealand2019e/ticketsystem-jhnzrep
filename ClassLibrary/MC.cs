using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class MC
    {
        public string LicensePlate { get; set; }
        public DateTime Date { get; set; }

        /// <summary>
        /// Function to get Price
        /// </summary>
        /// <returns>Price in decimal form</returns>
        public decimal Price()
        {
            return 125;
        }

        /// <summary>
        /// Fucntion to get vechile type
        /// </summary>
        /// <returns>Vechicle type in string form.</returns>
        public string VechicleType()
        {
            return "MC";
        }
    }
}
