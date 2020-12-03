﻿using System;
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
        public bool WinLoose()
        {
            Random random = new Random();
            int checkWinOrLoose = random.Next(0, 2);
            if (checkWinOrLoose == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Play the Game uto 50percent of the money
        /// </summary>
        public void GambleGame()
        {
            int tempMoney = STAKE;
            while(tempMoney>50 &&tempMoney<150)
            {
                if (WinLoose())
                {
                    tempMoney = tempMoney + BET;
                }
                else
                {
                    tempMoney = tempMoney - BET;
                }
            }
            int money = tempMoney - STAKE;
            if (money < 0)
            {
                Console.WriteLine("Resigned for a day with loss of:" + money);
            }
            else
            {
                Console.WriteLine("Resigned for a day with gain of :" + money);
            }
        }
    }
}
