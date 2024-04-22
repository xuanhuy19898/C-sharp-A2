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
/// this class is to configure the Rectangle shape 
/// </summary>
namespace Lab2A
{
    /// <summary>
    /// Rectangle inherits from Shape
    /// </summary>
    class Rectangle : Shape
    {
        protected double length;
        protected double width;

        /// <summary>
        /// set the data for rectangle by obtaining its length and width
        /// </summary>
        public override void SetData()
        {
            Console.Write("Enter the length: ");
            if (double.TryParse(Console.ReadLine(), out length))
            {
                Console.Write("Enter the width: ");
                if (double.TryParse(Console.ReadLine(), out width))
                {
                    //input successfully parsed
                }
                else
                {
                    //invalid input for width
                    Console.WriteLine("Invalid input for width.");
                }
            }
            else
            {
                //invalid input for length
                Console.WriteLine("Invalid input for length.");
            }
        }

        /// <summary>
        /// calculate the area of the rectangle
        /// </summary>
        /// <returns>the area of the rectangle</returns>
        public override double CalculateArea()
        {
            return length * width;
        }

        /// <summary>
        /// rectangle doesn't have volume so this returns 0
        /// </summary>
        /// <returns>0 because rectangle doesn't have volume</returns>
        public override double CalculateVolume()
        {
            return 0;
        }

        /// <summary>
        /// return a formatted string representation of the rectangle info
        /// </summary>
        /// <returns>a string representation of the rectangle</returns>
        public override string ToString()
        {
            string volumeString = CalculateVolume() > 0 ? $"Volume: {CalculateVolume():F2}" : string.Empty;
            return $"{length:F2} l x {width:F2} w";
        }
    }
}
