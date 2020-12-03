using System;
using System.Collections.Generic;
using System.Text;

namespace Gambling_Simulator
{
    class Gambling_Simulation
    {
        //constants
        public const int STAKE = 100;
        public const int BET= 1;

        /// <summary>
        /// checking wether gambler win or loose
        /// </summary>
        /// <returns></returns>
        public void WinLoose()
        {
            Random random = new Random();
            int checkWinOrLoose = random.Next(0, 2);
            Console.WriteLine(checkWinOrLoose);
            if (checkWinOrLoose == 0)
            {
                Console.WriteLine("Gambler win $1");
            }
            else
            {
                Console.WriteLine("Gambler loose $1");
            }
        }
    }
}
