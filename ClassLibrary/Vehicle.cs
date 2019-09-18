using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public abstract class Vehicle
    {
        public string LicensePlate
        {
            set
            {
                if (value.Length > 70) throw new Exception("Too many chars.");
                LicensePlate = value;
            }
            get { return LicensePlate; }
        }
        public DateTime Date;

        public bool BroBizz;

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
