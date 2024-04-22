//I, Xuan Huy Pham, 000899551 certify that this material is my original work.  No other person's work has been used without due acknowledgement.
using System;
using Lab2;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Xuan Huy Pham, 000899551
/// Assignment 2A
/// this class is to configure the Sphere shape 
/// </summary>
namespace Lab2A
{
    /// <summary>
    /// Sphere inherits from Shape
    /// </summary>
    class Sphere : Shape
    {
        private double radius;
        //set the data for sphere by obtaining its radius
        public override void SetData()
        {
            Console.Write("Enter the radius: ");
            if (double.TryParse(Console.ReadLine(), out radius))
            {
            }
            else
            {
                //invalid input for raidus
                Console.WriteLine("Invalid input for radius.");
            }
        }

        /// <summary>
        /// calculate and return the surface area of the sphere
        /// </summary>
        /// <returns>the surface area of the sphere</returns>
        public override double CalculateArea()
        {
            double surfaceArea = 4 * Math.PI * radius * radius;
            return surfaceArea;
        }

        /// <summary>
        /// calculate and return the volume of the sphere
        /// </summary>
        /// <returns>the volume of the sphere</returns>
        public override double CalculateVolume()
        {
            double volume = (4.0 / 3.0) * Math.PI * radius * radius * radius;
            return volume;
        }

        /// <summary>
        /// return a formatted string representation of the sphere's info
        /// </summary>
        /// <returns>a string representation of the sohere</returns>
        public override string ToString()
        {
            string volumeString = CalculateVolume() > 0 ? $"Volume: {CalculateVolume():F2}" : string.Empty;
            return $"{radius:F2} r";
        }
    }
}
