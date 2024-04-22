//I, Xuan Huy Pham, 000899551 certify that this material is my original work.  No other person's work has been used without due acknowledgement.
using System;

/// <summary>
/// Xuan Huy Pham, 000899551
/// Assignment 2A
/// this class is to configure the Square shape 
/// </summary>
namespace Lab2A
{
    /// <summary>
    /// Square inherits from Rectangle
    /// </summary>
    class Square : Rectangle
    {
        /// <summary>
        /// set the data for square by obtaining its length
        /// </summary>
        public override void SetData()
        {
            Console.Write("Enter the side length: ");
            if (double.TryParse(Console.ReadLine(), out double sideLength))
            {
                //set the properties of the base class directly
                length = sideLength;
                width = sideLength;
            }
            else
            {
                //invalid input for length
                Console.WriteLine("Invalid input for side length.");
            }
        }

        /// <summary>
        /// return a formatted string representation of the square info
        /// </summary>
        /// <returns>a string presentation of the square</returns>
        public override string ToString()
        {
            string volumeString = CalculateVolume() > 0 ? $"Volume: {CalculateVolume():F2}" : string.Empty;
            return $"{length:F2} l";
        }

    }
}
