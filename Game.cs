using System;

namespace GridGame
{
    class Game
    {
        static void Main()
        {

            //Class instance

            var command = new Command();
            var grid = new Grid();

            //Introduction

            bool option = command.Option();

            if (option)
            {
                command.Introduction();
            }

            Console.Clear();

            //Grid/game/movement

            grid.Matrix();

            while (true)
            {
                grid.Movement();
            }
        }
    }
}