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
/// this class is to configure the Cube shape 
/// </summary>
namespace Lab2A
{
    /// <summary>
    /// Cube inherits from Box
    /// </summary>
    class Cube : Box
    {
        /// <summary>
        /// set the dimentsions of the cube
        /// </summary>
        public override void SetData()
        {
            Console.Write("Enter the side length: ");
            //parse the input as double, if success, value will be stored in the sideLength var
            //'out' is to indicate that length will receive the parsed value
            if (double.TryParse(Console.ReadLine(), out double sideLength))
            {
                //set all dimensions of the cube to the same value
                length = sideLength;
                width = sideLength;
                height = sideLength;
            }
            else
            {
                //if input for length is invalid
                Console.WriteLine("Invalid input for side length.");
                // Handle invalid input
            }
        }

        /// <summary>
        /// return a formatted string of the cube's info
        /// </summary>
        /// <returns>a string representing the cube's length</returns>
        public override string ToString()
        {
            string volumeString = CalculateVolume() > 0 ? $"Volume: {CalculateVolume():F2}" : string.Empty;
            return $"{length:F2} l";
        }
    }
}
