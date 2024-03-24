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
            // Demander à l'utilisateur s'il veut débuter une partie
            Console.WriteLine("Voulez-vous débuter une partie ? (oui/non)");
            string response = Console.ReadLine();
            if (response == "oui")
            {
                Console.WriteLine("La partie va commencer");
            }
            else
            {
                Console.WriteLine("À une prochaine fois");
            }
            // Si la réponse de l'utilisateur est 'oui', demander au joueur 1 d'entrer son nom
            if (response == "oui")
            {
                Console.WriteLine("Joueur 1, entrez votre nom : ");
                // Va stocker le nom du joueur 1 dans la propriété Name de la classe Player
                Player player = new Player();
                player.Name = Console.ReadLine();
                Console.WriteLine("Bienvenue " + player.Name);
            }
            if (response == "oui")
            {
                Console.WriteLine("Joueur 2, entrez votre nom : ");
                // Va stocker le nom du joueur 2 dans la propriété Name de la classe Player
                Player player = new Player();
                player.Name = Console.ReadLine();
                Console.WriteLine("Bienvenue " + player.Name);
            }
        }
    }
}
