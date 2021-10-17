using System;

namespace TicTacToeGame
{
    class Program
    {

        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        static int player = 1; 

        static int choice;    


        static void Main(string[] args)
        {


            Console.WriteLine("Player1:X and Player2:O");

            Console.WriteLine("\n");

            if (player % 2 == 0)

            {

                Console.WriteLine("Player 2 Chance");

            }

            else

            {

                Console.WriteLine("Player 1 Chance");

            }

            Console.WriteLine("\n");
            Board();
            choice = int.Parse(Console.ReadLine());

        }

       
        private static void Board()

        {

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);

            Console.WriteLine("     |     |      ");
        }
    }
}