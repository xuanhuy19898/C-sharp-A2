//I, Xuan Huy Pham, 000899551 certify that this material is my original work.  No other person's work has been used without due acknowledgement.
using System;
using System.Collections.Generic;
using Lab2;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2A
{
    /// <summary>
    /// Xuan Huy Pham, 000899551
    /// Assignment 2A
    /// this assignment is to make use of an abstract class called Shape, which is unmodified
    /// this is the main class for the Lab2 program and it manages the user interface, shape management and to display the result table
    /// </summary>
    class Lab2
    {
        //create a list to store instances of Shape objjects
        private List<Shape> shapes = new List<Shape>();

        /// <summary>
        /// run the shape selection menu and data entry process until user chooses to exit
        /// </summary>
        public void Run()
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine(new string('=', 80));
                Console.WriteLine($"Choose a shape: \n");
                Console.WriteLine("A. Rectangle     C. Box      E. Ellipse      G. Cylinder         I. Triangle");
                Console.WriteLine("B. Square        D. Cube     F. Circle       H. Sphere           J. Tetrahedron");
                Console.WriteLine("\n0. List all shapes and exit");
                Console.WriteLine(new string('=', 80));
                //use GetCount to display the total Shapes counted
                Console.WriteLine($"({Shape.GetCount()} shape(s) entered so far)\n"); 
                Console.Write($"Enter your choice: ");
                string input = Console.ReadLine().Trim().ToUpper();

                //if input is 0, display the shape table then exit
                if (input == "0")
                {
                    DisplayShapesTable();
                    exit = true;
                }

                else
                {
                    //proceed to create a new shape if user enters valid letters
                    Shape newShape = CreateShape(input);
                    //if the new shape is created and it's not null, then clear the console to proceed to the next input
                    if (newShape != null)
                    {
                        Console.Clear();//clear the console screen
                        shapes.Add(newShape);//add the new shape to the list of shapes
                    }
                }
            }
        }

        /// <summary>
        /// create a shape object based on the user's choice
        /// </summary>
        /// <param name="choice">a string/letter that presents the user's choice of shape</param>
        /// <returns>a Shape object</returns>
        private Shape CreateShape(string choice)
        {
            switch (choice)
            {
                case "A":
                    Rectangle rectangle = new Rectangle();
                    rectangle.SetData();
                    return rectangle;

                case "B":
                    Square square = new Square();
                    square.SetData();
                    return square;

                case "C":
                    Box box = new Box();
                    box.SetData();
                    return box;

                case "D":
                    Cube cube = new Cube();
                    cube.SetData();
                    return cube;

                case "E":
                    Ellipse ellipse = new Ellipse();
                    ellipse.SetData();
                    return ellipse;

                case "F":
                    Circle circle = new Circle();
                    circle.SetData();
                    return circle;

                case "G":
                    Cylinder cylinder = new Cylinder();
                    cylinder.SetData();
                    return cylinder;

                case "H":
                    Sphere sphere = new Sphere();
                    sphere.SetData();
                    return sphere;

                case "I":
                    Triangle triangle = new Triangle();
                    triangle.SetData();
                    return triangle;

                case "J":
                    Tetrahedron tetrahedron = new Tetrahedron();
                    tetrahedron.SetData();
                    return tetrahedron;


                default:
                    //if input is invaid
                    Console.WriteLine("Invalid choice of shape.");
                    return null;
            }
        }

        /// <summary>
        /// display a result table of shapes with their names, areas, volume (for 3d shapes) and details
        /// </summary>
        private void DisplayShapesTable()
        {
            //clear the console first to start with a new screen
            Console.Clear();
            //table's headers
            Console.WriteLine("{0,-15}{1,-15}{2,-15}{3,-25}", "Shape", "Area", "Volume", "Details");
            Console.WriteLine(new string('-', 70));

            //interate through the list of shape and display them
            foreach (var shape in shapes)
            {
                //get the name of the shape's type
                string shapeName = shape.GetType().Name;
                //calculate the area
                double area = shape.CalculateArea();
                //calculte the volume (for 3d shapes)
                double volume = shape.CalculateVolume();
                //get the details of the shape
                string details = shape.ToString();
                //print the shape's info
                Console.WriteLine("{0,-15}{1,-15:F2}{2,-15:F2}{3,-25}", shapeName, area, volume, details);
            }
            //displa the total count of shapes entered
            Console.WriteLine("\nTotal shapes entered: {0}", Shape.GetCount());
        }
    }
}
