//Jeffrey Martin

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment2
{
    /// <summary>
    /// This class is used for solving a char array maze.
    /// You might want to add other methods to help you out.
    /// A print maze method would be very useful, and probably neccessary to print the solution.
    /// If you are real ambitious, you could make a seperate class to handle that.
    /// </summary>
    class MazeSolver
    {
        /// <summary>
        /// Class level memeber variable for the mazesolver class
        /// </summary>
        char[,] maze;
        char[,] printMaze;
        int xStart;
        int yStart;
        UserInterface ui = new UserInterface();
        bool exited;

        /// <summary>
        /// Default Constuctor to setup a new maze solver.
        /// </summary>
        public MazeSolver()
        {}


        /// <summary>
        /// This is the public method that will allow someone to use this class to solve the maze.
        /// Feel free to change the return type, or add more parameters if you like, but it can be done
        /// exactly as it is here without adding anything other than code in the body.
        /// </summary>
        public void SolveMaze(char[,] maze, int xStart, int yStart)
        {
            //Assign passed in variables to the class level ones. It was not done in the constuctor so that
            //a new maze could be passed in to this solve method without having to create a new instance.
            //The variables are assigned so they can be used anywhere they are needed within this class. 
            this.maze = maze;
            this.xStart = xStart;
            this.yStart = yStart;
            exited = false;
            int mazePrintChoice = 1;

            //Get users input for type of output of the maze.  Placed here so that the user can choose a different type of output for each maze.
            mazePrintChoice= ui.StartConsole();

            printMaze = this.maze;
            Console.WriteLine("Original Maze");
            ui.PrintMaze(this.maze, mazePrintChoice);

            mazeTraversal(printMaze, this.xStart, this.xStart, mazePrintChoice);
            //Do work needed to use mazeTraversal recursive call and solve the maze.
        }


        /// <summary>
        /// This should be the recursive method that gets called to solve the maze.
        /// Feel free to change the return type if you like, or pass in parameters that you might need.
        /// This is only a very small starting point.
        /// </summary>
        private void mazeTraversal(char[,] maze, int xPosition, int yPosition, int printChoice)
        {
            // Variables that hold the lengths of the array to make the if statement more readable
            int xLength = maze.GetLength(0);
            int yLength = maze.GetLength(1);

            if (!exited) //Continue the recursion until the exit is found.
            {
                if (maze[xPosition,yPosition] == '.' )// Used to find the path.
                    
                {
                    maze[xPosition, yPosition] = 'X';// Place an "X" on the path.
                    
                    ui.PrintMaze(maze, printChoice); // Print out the new path.

                    //Find out if on the exit.
                    if (xPosition == 0 || yPosition == 0 || xPosition == xLength - 1 || yPosition == yLength - 1)
                    {
                        exited = true;
                    }
                    else
                    {   //Since maze has not been exited try another direction.

                        mazeTraversal(maze, xPosition, yPosition + 1, printChoice); //Try going right

                        mazeTraversal(maze, xPosition, yPosition - 1, printChoice);//Try going left

                        mazeTraversal(maze, xPosition + 1, yPosition, printChoice);//Try going up

                        mazeTraversal(maze, xPosition - 1, yPosition, printChoice);//Try going down


                        if (!exited)//Stops the overwriting of the path taken as the recursion unwinds after exiting.
                        {
                            maze[xPosition, yPosition] = 'O';//Change the wrong path to "O"

                            ui.PrintMaze(maze, printChoice); //Print out the change from "X" to "O"
                        }

                                            }
                }
            }

        }
    }
}
