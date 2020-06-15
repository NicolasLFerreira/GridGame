using System;
using System.Collections.Generic;
using System.Text;

namespace GridGame
{
    class InputCapturer
    {
        public int IntegerInput()
        {

            //Variable declaration

            Console.Write("\n\tEnter an integer: ");
            char read = Console.ReadKey().KeyChar;
            int input;

            //Checking if the input is an integer

            while (!int.TryParse(read.ToString(), out input))
            {
                Console.WriteLine("Enter an integer value");
                read = Console.ReadKey().KeyChar;
            }

            return input;
        }

        public char Key(string text)
        {
            //Asking for and returning the character value

            Console.WriteLine(text);
            int read = Console.ReadKey().KeyChar;
            return Convert.ToChar(read);
        }

        //Movement inputs
        private int WASD()
        {

            //Variable declaration

            int read = Key("Move direction: ");
            bool pass = false;

            //Checking if the value is either W,A,S,D

            while (!pass)
            {
                if (read == 100 | read == 97 | read == 115 | read == 119)
                {
                    pass = true;
                }
                else
                {
                    Console.WriteLine("\n\tCommand: ");
                    read = 0;
                    read = Console.ReadKey().KeyChar;
                }
            }


            return read;
        }

        public int Direction()
        {

            //Variable declaration

            int command = WASD();
            int direction = 0;

            //Setting the direction value according to the command value

            switch (command)
            {
                case 119:
                    direction = 1;
                    break;
                case 97:
                    direction = 2;
                    break;
                case 115:
                    direction = 3;
                    return direction;
                case 100:
                    direction = 4;
                    break;
            }

            return direction;
        }

        public int Choice(string text, int n1, int n2)
        {

            //Variable declaration

            Console.WriteLine(text);
            int input = IntegerInput();

            //Checking if the value will be either true or false

            while (input < n1 ^ input > n2)
            {
                Console.WriteLine("Enter a value between {0} and {1}", n1, n2);
            }

            return input;
        }
    }
}
