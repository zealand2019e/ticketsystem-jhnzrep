using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public abstract class Vehicle
    {
        public string LicensePlate;
        public DateTime Date;

        /// <summary>
        /// Function to get Price
        /// </summary>
        /// <returns>Price in decimal form</returns>
        public abstract decimal Price();

        /// <summary>
        /// Fucntion to get vechile type
        /// </summary>
        /// <returns>Vechicle type in string form.</returns>
        public abstract string VechicleType();
    }
}
