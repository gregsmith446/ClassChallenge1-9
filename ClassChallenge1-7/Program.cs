using System;


/* 
Create the following function/method:

drawBoard()
The function currently accepts no parameters however will print out a variation of a Tic Tac Toe board.
For additional challenge make the board larger with more ascii characters
3 chars: |, +, -

 | |
-+-+-
 | |
-+-+-
 | |
*/

namespace ClassChallenge1_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // create an instance of the MakeBoard class
            var callClass = new MakeBoard();

            // use the callClass variable to access on the ticTac function
            callClass.ticTac();
        }
    }

    class MakeBoard
    {
        public string ticTac()
        {
            string line1 = " | | ";
            string line2 = "-+-+-";

            for (int i = 0; i < 2; i++)
            {
                Console.Write(line1 + "\n" + line2 + "\n");
            }

            Console.Write(line1 + "\n");

            return "yes, you have made a tic tac toe board";

        }
    }

}
