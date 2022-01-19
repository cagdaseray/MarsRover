using System;
using System.Collections.Generic;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            Rover rover = null;
            Console.WriteLine("Plateau surface size :");
            string plateauSize = Console.ReadLine(); // 5 5
            while (true)
            {
                Console.WriteLine("\nRover position :");
                string roverPosition = Console.ReadLine(); // 1 2 N
                Console.WriteLine("Rover move :");
                string roverMove = Console.ReadLine(); // LMLMLMLMM

                string[] str = plateauSize.Split(" ");
                int row = Int32.Parse(str[0]);
                int col = Int32.Parse(str[1]);

                rover = new Rover(roverPosition, row, col);
                rover.Move(roverMove);
                Console.WriteLine("Rover last position : \n" + rover.x + " " + rover.y + " " + rover.dir);
                Console.WriteLine("\nDo you want to add another rover ? (Y/N)");
                var addRoverInput = Console.ReadLine();

                if (!addRoverInput.Equals("Y", StringComparison.InvariantCultureIgnoreCase))
                {
                    break;
                }
            }


        }
    }
}