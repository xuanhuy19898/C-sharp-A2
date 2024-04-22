//I, Xuan Huy Pham, 000899551 certify that this material is my original work.  No other person's work has been used without due acknowledgement.
using System;

/// <summary>
/// Xuan Huy Pham, 000899551
/// Assignment 2A
/// this class is to configure the Circle shape 
/// </summary>
namespace Lab2A
{
    /// <summary>
    /// Circle inherits from Ellipse
    /// </summary>
    class Circle : Ellipse
    {
        /// <summary>
        /// set the data for a Circle by prompting the user to enter the radius
        /// </summary>
        public override void SetData()
        {
            Console.Write("Enter the radius: ");
            //parse the input as double, if success, value will be stored in the radius var
            //'out' is to indicate that radius will receive the parsed value
            if (double.TryParse(Console.ReadLine(), out double radius))
            {
                //set both major and minor axes to the radius
                MajorAxis = radius;
                MinorAxis = radius;
            }
            else
            {
                //if the parsing fails
                Console.WriteLine("Invalid input for radius.");
            }
        }

        /// <summary>
        /// override the ToString method to provide a formatted string of info
        /// </summary>
        /// <returns>a string that represents the Circle shape</returns>
        public override string ToString()
        {
            string volumeString = CalculateVolume() > 0 ? $"Volume: {CalculateVolume():F2}" : string.Empty;
            return $"{MajorAxis:F2} r";
        }

    }
}
