//Jeffrey Martin

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment2
{
    /// <summary>
    /// Takes the printChoice and prints out the Maze format chosen.
    /// </summary>
    class UserInterface
    {
        /// <summary>
        /// Print the version of the maze chosen by the user.
        /// </summary>
        /// <param name="Maze">char[,]</param>
        /// <param name="PrintChoice">int</param>
        public void PrintMaze(char[,] Maze, int PrintChoice)
        {
            if (PrintChoice == 1)
            {
                PrintCompleteMaze(Maze);
            }
            else
            {
                PrintMazeOverwrite(Maze);
            }
        }

        /// <summary>
        /// Prints a Complete Maze
        /// </summary>
        /// <param name="Maze">char[,]</param>
        public void PrintCompleteMaze(char[,] Maze)
        {
            // Loops through the X,Y index of the Array and outputs its data.

            for ( int x = 0; x < Maze.GetLength(0); x++ ) //Row
            {
                for (int y = 0; y < Maze.GetLength(1); y++)//Collumn
                {
                    char tempChar = Maze[x, y]; //Create a variable to be used for switch/case

                    //Colorizes the maze based on the type of character.
                    switch (tempChar)
                    {
                        case 'X':
                            Console.ForegroundColor = ConsoleColor.Red;
                            break;
                        case 'O':
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                    }
                    Console.Write(tempChar + " "); //Print color character with a blank space for easier reading
                }
                Console.WriteLine(); //Bring cursor to new line since a row has finished priting
            }
            Console.WriteLine();// Maze is done printing so add a new line to differentiate with next line of output.
        }

        /// <summary>
        /// Prints Overwrite of the Maze
        /// </summary>
        /// <param name="Maze">char[,]</param>
        public void PrintMazeOverwrite(char[,] Maze)
        {//Overwrite is simple to achieve by clearing out the console before each PrintCompleteMaze is done and
            // adding in a pause after PrintCompleteMase

            Console.Clear();
            PrintCompleteMaze(Maze);
            System.Threading.Thread.Sleep(500);

        }
        /// <summary>
        /// Prints a start menu and gets users choice of maze print
        /// </summary>
        public int StartConsole()
        {
            Console.BufferHeight = Int16.MaxValue /20; //Increase buffer size so entire list can be displayed.

            Console.WriteLine("Maze Bot"); //Title of the program
            Console.WriteLine();

            //Create a start menu and read in the users choices
            string startMenu = "Start Menu" + Environment.NewLine + "1) Print the mazes as a list of step." +
                                Environment.NewLine + "2) Print a single maze following the progress inside." +
                                Environment.NewLine + "Enter the number of the item you wish to do.";
            Console.Write(startMenu);
            ConsoleKeyInfo inputChar = Console.ReadKey();
            Console.WriteLine();

            //Check to make sure the users choice is a valid one
            while (inputChar.KeyChar !='1' && inputChar.KeyChar !='2')
            {
                Console.WriteLine("Invalid Entry please try again");
                Console.Write(startMenu);
                inputChar = Console.ReadKey();
                Console.WriteLine();
            }
            //return the input as an integer
            return int.Parse(inputChar.KeyChar.ToString());
        }


        /// <summary>
        /// Gives Exit Found message and pauses the program.
        /// </summary>
        public void ExitFound()
        {
            Console.WriteLine("Exit found!");
            Console.WriteLine("Press any key to continue. . .");
            ConsoleKeyInfo inputChar = Console.ReadKey();

        }
    }
}
