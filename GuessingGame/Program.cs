using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Node firstNode = new Node();
            Tree firstTree = new Tree();

            firstTree.startGame();

            Console.ReadKey();
        }
    }
}
