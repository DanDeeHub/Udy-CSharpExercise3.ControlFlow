using System;

namespace CSharpExercise3.ControlFlow
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Height: "); // Prompt user to enter height
            var height = Convert.ToInt32(Console.ReadLine()); // Read height from console
            Console.Write("Enter Width: "); // Prompt user to enter width
            var width = Convert.ToInt32(Console.ReadLine()); // Read width from console

            var orientation = width > height ? ImageOrientation.Landscape : ImageOrientation.Portrait; // Determine orientation
            Console.WriteLine("Image is " + orientation); // Output orientation
        }
    }
}
