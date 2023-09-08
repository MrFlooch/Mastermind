using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMind
{
    internal class Program
    {
        static void Main(string[] args)
        {

            String name;

            //message de bienvenue guide pour selectionner le mode de jeu
            Console.Write("Bienvenue sur Mastermind! Veuillez entrer votre prenom: ");
            name = Console.ReadLine();
            Console.WriteLine("Bonjour " + name + " que voulez-vous faire?" + "\n" + "Pour jouer contre l'ordinateur, tapez 1" + "\n" + "Pour jouer contre un ami, tapez 2" + "\n" + "Pour voire les règles, tapez règles");
            Console.ReadLine();

            //mode un joueur
            Console.WriteLine("Couleurs possibles: GYWRBMC" + "\n" + "devine le code en 4 couleurs");
            Console.ReadLine();
        }

        //le jeu

        //lettres possible dans la combinaison
        public static char[] letters = new char[] { 'G', 'Y', 'W', 'R', 'B', 'M', 'C' };

            //taille du code
            public static int codeSize = 4;

        //essaies permis
        public static int allowedAttemps = 10;



        //redirection
            
        
    }
}
