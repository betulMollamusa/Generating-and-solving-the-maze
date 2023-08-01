# Generating-and-solving-the-maze
The maze in the file path specified in the console application will be read and assigned to the matrix, or the computer randomly generates this maze and prints it to the text file, then reads it from the file and assigns it to the matrix. It contains two-dimensional (30x30) labyrinths with multiple entrances and exits, an exit path, and dead ends. The wall 1 character is represented by the path 0 character and vice versa.
Bombs are randomly assigned to 3 points of the paths of this maze matrix.
There is a class that finds its way out of the maze. The strategy for finding the way out is this. It should take input from the first column and update the way coordinates until it reaches the exit way by trying all the ways. If it reaches the dead end, different alternatives will be tried.
Finally, it prints the coordinates of the Output path (row, column) from the first column to the output coordinate in the last column.
It does not print the other paths it has tried.
If it encounters a bomb on its way to the exit point, it ends with an audible warning.
At the last stage, if the user presses the X key, the road coordinates are printed, if he presses the B key, the coordinates of the bombs, and if he presses the L key, the original state of the maze is printed.
