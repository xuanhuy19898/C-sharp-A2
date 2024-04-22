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
/// this class is to configure the Triangle shape 
/// </summary>
namespace Lab2A
{
    /// <summary>
    /// Triangle inherits from Shape
    /// </summary>
    class Triangle : Shape
    {
        private double baseLength;
        private double height;

        /// <summary>
        /// set the data of the triangle by obtaining its base length and its height
        /// </summary>
        public override void SetData()
        {
            Console.Write("Enter the base length: ");
            if (double.TryParse(Console.ReadLine(), out baseLength))
            {
                Console.Write("Enter the height: ");
                if (double.TryParse(Console.ReadLine(), out height))
                {
                    //input successfully parsed
                }
                else
                {
                    //invalid input for height
                    Console.WriteLine("Invalid input for height.");
                }
            }
            else
            {
                //invalid input for the base length
                Console.WriteLine("Invalid input for base length.");
            }
        }

        /// <summary>
        /// calculate and return the area of the triangle
        /// </summary>
        /// <returns>the triangle's area</returns>
        public override double CalculateArea()
        {
            double area = 0.5 * baseLength * height;
            return area;
        }

        /// <summary>
        /// a triangle doesn't have a volume so it returns 0
        /// </summary>
        /// <returns>0</returns>
        public override double CalculateVolume()
        {
            return 0;
        }

        /// <summary>
        /// return a formatted string representation of the triangle
        /// </summary>
        /// <returns>a string representation of the sphere</returns>
        public override string ToString()
        {
            string volumeString = CalculateVolume() > 0 ? $"Volume: {CalculateVolume():F2}" : string.Empty;
            return $"{baseLength:F2} b x {height:F2} h";
        }
    }
}
