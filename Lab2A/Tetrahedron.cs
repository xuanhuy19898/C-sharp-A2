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
/// this class is to configure the Tetraahedron shape 
/// </summary>
namespace Lab2A
{
    /// <summary>
    /// Tetrahedron inherits from Shape
    /// </summary>
    class Tetrahedron : Shape
    {
        private double edgeLength;

        /// <summary>
        /// set the data of Tetrahedron by obtaining its edge length
        /// </summary>
        public override void SetData()
        {
            Console.Write("Enter the edge length: ");
            if (double.TryParse(Console.ReadLine(), out edgeLength))
            {
                //input successfully parsed
            }
            else
            {
                //invalid input for the edge length
                Console.WriteLine("Invalid input for edge length.");
            }
        }

        /// <summary>
        /// calculate and return area of the tetrahedron
        /// </summary>
        /// <returns>the area of the tetrahedron</returns>
        public override double CalculateArea()
        {
            double area = Math.Sqrt(3) * edgeLength * edgeLength;
            return area;
        }

        /// <summary>
        /// calculate and return its volume
        /// </summary>
        /// <returns>the volume of the tetrahedron</returns>
        public override double CalculateVolume()
        {
            double volume = (1.0 / 12.0) * Math.Sqrt(2) * edgeLength * edgeLength * edgeLength;
            return volume;
        }

        /// <summary>
        /// return a formatted string representation of the tetrahedron
        /// </summary>
        /// <returns>a string representation of the tetrahedron</returns>
        public override string ToString()
        {
            string volumeString = CalculateVolume() > 0 ? $"\nVolume: {CalculateVolume():F2}" : string.Empty;
            return $"{edgeLength:F2} l";
        }
    }
}
