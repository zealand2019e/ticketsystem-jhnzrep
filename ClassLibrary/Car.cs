﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Car : Vehicle
    {

        public Car()
        {
        }
        /// <summary>
        /// Function to get Price
        /// </summary>
        /// <returns>Price in decimal form</returns>
        public override decimal Price()
        {
            return 240;
        }

        /// <summary>
        /// Fucntion to get vechile type
        /// </summary>
        /// <returns>Vechicle type in string form.</returns>
        public override string VechicleType()
        {
            return "Car";
        }
    }
}
