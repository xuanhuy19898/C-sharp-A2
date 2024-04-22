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
/// this class is to configure the Cylinder shape 
/// </summary>
namespace Lab2A
{
    /// <summary>
    /// Cylinder inherits from Shape
    /// </summary>
    class Cylinder : Shape
    {
        //initialize the radius and height of the Cylinder
        private double radius;
        private double height;

        /// <summary>
        /// set the dimentions of the cylinder
        /// </summary>
        public override void SetData()
        {
            Console.Write("Enter the radius: ");
            //parse the input as double, if success, value will be stored in the radius var
            //'out' is to indicate that radius will receive the parsed value
            if (double.TryParse(Console.ReadLine(), out radius))
            {
                Console.Write("Enter the height: ");
                //parse the input as double, if success, value will be stored in the height var
                //'out' is to indicate that height will receive the parsed value
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
                //invalid input for raidus
                Console.WriteLine("Invalid input for radius.");
            }
        }

        /// <summary>
        /// calculate the area of cylinder
        /// </summary>
        /// <returns>the area of cylinder</returns>
        public override double CalculateArea()
        {
            //calculate area of one circular base
            double baseArea = Math.PI * radius * radius;
            //calculate the lateral surface area 
            double lateralSurfaceArea = 2 * Math.PI * radius * height;
            //calculate the total surface area of cylinder
            double totalSurfaceArea = 2 * baseArea + lateralSurfaceArea;
            return totalSurfaceArea;
        }

        /// <summary>
        /// calculate the volume of cylinder
        /// </summary>
        /// <returns>the volume of cylinder</returns>
        public override double CalculateVolume()
        {
            double volume = Math.PI * radius * radius * height;
            return volume;
        }

        /// <summary>
        /// a formatted string representing cylinder info
        /// </summary>
        /// <returns>a string representation of cylinder</returns>
        public override string ToString()
        {
            //check if cylinder has a positive volume and format it
            string volumeString = CalculateVolume() > 0 ? $"Volume: {CalculateVolume():F2}" : string.Empty;
            return $"{radius:F2} r x {height:F2} h";
        }
    }
}
