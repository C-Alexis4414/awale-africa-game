using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Awale.Interfaces
{
    public class ArrayConstructor
    {
        private int[,] cells = new int[2, 6];
        public ArrayConstructor()
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    cells[i, j] = 0;
                }
            }
        }
        public void SendToDisplaying()
        {
            string[] letters = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L" };
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write(" " + letters[i * 6 + j] + " ");
                }
                Console.WriteLine();

                for (int j = 0; j < 6; j++)
                {
                    Console.Write("(" + cells[i, j] + ")");
                }
                Console.WriteLine();
            }
        }
    }
}
