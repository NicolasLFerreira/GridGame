using System;
using System.Collections.Generic;
using System.Text;

namespace GridGame
{
    class Grid
    {
        //Common variable declaration

        private int row = 0;
        private int col = 0;
        private char player = '@';
        private char map = '.';

        private char[,] grid = new char[15, 30];

        public void Matrix()
        {
            //Input class instance

            var input = new InputCapturer();

            Console.Write("\n");

            //Building the grid

            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    grid[i, j] = map;
                    grid[row, col] = player;
                    Console.Write($"{grid[i, j]}");
                }
                Console.Write("\n");
            }
        }


        public void Movement()
        {

            //Variable declaration

            var input = new InputCapturer();
            int direction = input.Direction();

            Console.Clear();

            //Player movement

            switch (direction)
            {
                case 1: //W

                    if (row >= 1)
                    {
                        row--;
                    }
                    else
                    {
                        row = grid.GetLength(0) - 1;
                    }

                    break;
                case 2: //A

                    if (col >= 1)
                    {
                        col--;
                    }
                    else
                    {
                        col = grid.GetLength(1) - 1;
                    }

                    break;
                case 3: //S

                    if (row <= grid.GetLength(0) - 2)
                    {
                        row++;
                    }
                    else
                    {
                        row = 0;
                    }

                    break;
                case 4: //D

                    if (col <= grid.GetLength(1) - 2)
                    {
                        col++;
                    }
                    else
                    {
                        col = 0;
                    }

                    break;
                default:
                    break;
            }

            Array.Clear(grid, 0, grid.Length);

            grid[row, col] = player;

            //Grid print

            Matrix();
        }

    }
}
