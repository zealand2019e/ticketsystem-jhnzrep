using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class MC : Vehicle
    {
        public MC()
        { }

        public override decimal Price()
        {
            return 125;
        }

        /// <summary>
        /// Fucntion to get vechile type
        /// </summary>
        /// <returns>Vechicle type in string form.</returns>
        public override string VechicleType()
        {
            return "MC";
        }
    }
}
