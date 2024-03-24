using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Awale.Components
{
    public class Player
    {
        // Nom choisi par le joueur dans la fonction StartGame de la classe ReadyToPlay
        private string _name;

        public string Name 
        { 
            get => _name; 
            set 
            {
                // Si le nom du joueur comprend entre 1 et 20 caractères, retourner le nom du joueur
                if (value.Length > 0 && value.Length < 20)
                {
                    _name = value;
                    Console.WriteLine("Bienvenue " + _name);

                }
                // Si différent, afficher un message d'erreur et redemander le nom du joueur
                else
                {
                    Console.WriteLine("Le nom doit comprendre entre 1 et 20 caractères");
                    _name = Console.ReadLine();
                }
            } 
        }
        // 
    }
}
