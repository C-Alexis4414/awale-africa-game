using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Awale.Components
{
    internal class ReadyToPlay
    {
        // Fonction isEmpty pour définir si toutes les cellules cells du plateau ArrayConstructor sont vides et si la partie peut commencer
        public bool isEmpty(int[,] cells)
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (cells[i, j] != 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        // Si isEmpty retourne true, la partie peut commencer
        public void StartGame()
        {
            Console.WriteLine("La partie peut commencer !");
        }
    }
}
