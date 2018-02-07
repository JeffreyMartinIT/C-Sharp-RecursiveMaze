## Author
Jeffrey Martin

## Description

A program to traverse a 12 x 12 maze and find a successful path from a starting point to an exit. You are given a hard coded maze in the program, as well as some starting coordinates. Each spot in the maze is represented by either a '#' or a '.' (dot). The #'s represent the walls of the maze, and the dots represent paths through the maze. Moves can be made only up, down, left, or right (not diagonally), one spot at a time, and only over paths (not into or across a wall). The exit will be any spot that is on the outside of the array. As the program attempts to find a path leading to the exit, it should place the character 'X' in each spot along the path. If a dead end is reached, the program should replace the X’s with '0'. But, the spots with '0' should be marked back to 'X' if these spots are part of a successful path leading to a final state. The output of the program is the maze configuration after each move. 

There is a method stub in the main program for transposing the 2D array. The program is setup to solve both the original maze, and the transposed maze. 

## Outside Resources Used
https://www.daniweb.com/programming/software-development/threads/475572/changing-color-of-font-within-a-single-console-writeline

http://stackoverflow.com/questions/5449956/how-to-add-a-delay-for-a-2-or-3-seconds
## Known Problems, Issues, And/Or Errors in the Program
None