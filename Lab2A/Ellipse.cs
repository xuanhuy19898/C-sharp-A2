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
/// this class is to configure the Ellipse shape 
/// </summary>
namespace Lab2A
{
    /// <summary>
    /// Ellipse inherits from Shape
    /// </summary>
    class Ellipse : Shape
    {
        // gets or sets the length of the semi-major axis 
        protected double MajorAxis { get; set; }
        // sets or sets the length of the semi-minor axis
        protected double MinorAxis { get; set; }

        /// <summary>
        /// set data for ellipse by obtaining lengths of semi-major and semi-minor axes
        /// </summary>
        public override void SetData()
        {
            double tempMajorAxis;
            double tempMinorAxis;

            Console.Write("Enter the semi-major axis length: ");
            if (double.TryParse(Console.ReadLine(), out tempMajorAxis))
            {
                Console.Write("Enter the semi-minor axis length: ");
                if (double.TryParse(Console.ReadLine(), out tempMinorAxis))
                {
                    //input successfully parsed
                    MajorAxis = tempMajorAxis;
                    MinorAxis = tempMinorAxis;
                }
                else
                {
                    //invalid input for semi-minor axis
                    Console.WriteLine("Invalid input for semi-minor axis.");
                }
            }
            else
            {
                //invalid input for semi-major exis
                Console.WriteLine("Invalid input for semi-major axis.");
            }
        }

        /// <summary>
        /// calculate and return the area of ellipse
        /// </summary>
        /// <returns>the area of ellipse</returns>
        public override double CalculateArea()
        {
            double area = Math.PI * MajorAxis * MinorAxis;
            return area;
        }

        /// <summary>
        /// calculate and return the volume of ellipse
        /// but ellipse is a 2D shape, it doesn't have volume, --> return 0
        /// </summary>
        /// <returns>0 because it doesn't have volume</returns>
        public override double CalculateVolume()
        {
            return 0;
        }

        /// <summary>
        /// return a formatted string representing ellipse info
        /// </summary>
        /// <returns>a string representation of ellipse</returns>
        public override string ToString()
        {
            string volumeString = CalculateVolume() > 0 ? $"Volume: {CalculateVolume():F2}" : string.Empty;
            return $"{MajorAxis:F2} s.major x {MinorAxis:F2} s.minor";
        }
    }
}
