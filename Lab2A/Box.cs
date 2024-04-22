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
/// this class is to configure the box shape 
/// </summary>
namespace Lab2A
{
    //Box inherits from Shape
    class Box : Shape
    {
        //declare the instance variables
        //using 'protected' makes these variables accessible within Box class and any derived class that inherit from it
        protected double length;
        protected double width;
        protected double height;

        /// <summary>
        /// prompts user to input length, width and height of the shape
        /// validates the input
        /// </summary>
        public override void SetData()
        {
            Console.Write("Enter the length: ");
            //attempt to parse the user input as a double
            if (double.TryParse(Console.ReadLine(), out length))
            {
                //if parsing is successful, prompt the user to enter width after that
                Console.Write("Enter the width: ");
                //attempt to parse the user input as a double for width
                if (double.TryParse(Console.ReadLine(), out width))
                {
                    //if success, prompt to enter height
                    Console.Write("Enter the height: ");
                    //attempt to parse user input as double for height
                    if (double.TryParse(Console.ReadLine(), out height))
                    {
                        //input successfully parsed, all 3 dimensions are set
                    }
                    else
                    {
                        //invalid input for height
                        Console.WriteLine("Invalid input for height.");
                    }
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
        /// calculate and then return the area of the box
        /// </summary>
        /// <returns>the area of the box</returns>
        public override double CalculateArea()
        {
            //formula to calculate the area
            double surfaceArea = 2 * (length * width + length * height + width * height);
            return surfaceArea;
        }

        /// <summary>
        /// calculate and return the area of box
        /// </summary>
        /// <returns>the volumn</returns>
        public override double CalculateVolume()
        {
            double volume = length * width * height;
            return volume;
        }

        /// <summary>
        /// return a string representation of the box
        /// </summary>
        /// <returns>a formatted string containing length, width, height
        /// if the box has no volume, the volumn part is empty</returns>
        public override string ToString()
        {
            string volumeString = CalculateVolume() > 0 ? $"Volume: {CalculateVolume():F2}" : string.Empty;
            return $"{length:F2} l x {width:F2} w x {height:F2} h";
        }

    }
}
