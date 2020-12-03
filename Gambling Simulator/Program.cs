using System;

namespace Gambling_Simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Gambling simulator");
            Gambling_Simulation gambling = new Gambling_Simulation();
            gambling.WinLoose();
            Console.ReadKey();
        }
    }
}
