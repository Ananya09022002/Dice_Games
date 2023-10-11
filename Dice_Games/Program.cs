using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Games
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int p1num;
            int p2num;
            int p1sum = 0 ;
            int p2sum = 0 ;

            Random rand = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Press Enter to Roll a Dice");
                p1num = rand.Next(1,7);
                p2num = rand.Next(1,7);
                Console.ReadLine();
                Console.WriteLine("You roll a " + p1num);
                Console.WriteLine("Opponent rolled a " + p2num);
                Console.WriteLine("");
                p1sum += p1num;
                p2sum += p2num;
            }
            Console.WriteLine("Your total sum" + p1sum);
            Console.WriteLine("Opponents total sum" + p2sum);
            if (p1sum > p2sum) { Console.WriteLine("You won the game"); };
            if (p1sum < p2sum) { Console.WriteLine("Opponent won the game"); };
            if (p1sum == p2sum) { Console.WriteLine("Draw !!"); };
            Console.ReadLine();

        }
    }
}
