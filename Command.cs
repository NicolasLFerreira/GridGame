using System;
using System.Collections.Generic;
using System.Text;

namespace GridGame
{
    class Command
    {
        public void DotContinue()
        {
            Console.Write("...");
            Console.ReadKey();
        }

        public void KeyContinue()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        public bool Option()
        {

            //Greetings

            Console.WriteLine("###########################");
            Console.WriteLine("#Welcome to Grid Game v.1!#");
            Console.WriteLine("###########################");

            //Variable declaration

            var input = new InputCapturer();
            int choice = input.Choice("\n\t1 - Continue\n\t2 - Skip",1,2);
            bool option = false;

            //Checking the value

            if (choice == 1)
            {
                option = true;
            }
            else
            {
                option = false;
            }
            return option;
        }

        public void Introduction()
        {

            //Introduction text

            Console.Clear();

            Console.WriteLine("###########################");
            Console.WriteLine("#Welcome to Grid Game v.1!#");
            Console.WriteLine("###########################");

            DotContinue();

            Console.WriteLine("\nIn this game, your objective is to simply wander through the 'map' ");

            DotContinue();

            Console.WriteLine("\n\tThe commands are very simple:");
            Console.WriteLine("\t\t'w' - up");
            Console.WriteLine("\t\t's' - down");
            Console.WriteLine("\t\t'a' - left");
            Console.WriteLine("\t\t'd' - right");

            DotContinue();

            Console.WriteLine("\nEvery time you reach an edge, you will appear in the other side.");

            DotContinue();

            Console.WriteLine("\nIf you want to move faster, simply press BUTTON to jump two units per move.");

            DotContinue();

            Console.WriteLine("\nFor now, these are the only things you can do in this game, but there is more to come.");

            DotContinue();

            Console.Write("\n---Click any button to start---\n");

            DotContinue();
        }
    }
}
