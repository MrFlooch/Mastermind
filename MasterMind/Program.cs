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

            String name, reponse ="o";


            
            //message de bienvenue guide pour selectionner le mode de jeu
            Console.Write("Bienvenue sur Mastermind! Veuillez entrer votre prénom: ");
            name = Console.ReadLine();
            Console.WriteLine("Bonjour " + name + " que voulez-vous faire?");

            //permet de recommencer
            do
            {
                Console.WriteLine("mode facile, tapez 1" + "\n" + "mode difficile, tapez 2" + "\n" + "voir les règles, tapez rules");
                Console.ReadLine();

                //mode facile
                Console.Write("Couleurs possibles: GYWRBMC" + "\n" + "devine le code en 4 couleurs");
                Console.Read();


                //n c'est le nombre qui va permettre de definir combien de fois le for va faire d'aller-retour avant de s'arreter
                int n = 4;

                //ca c'est pour generer l'aléatoire
                var random = new Random();

                string secret = "";
                //i c'est le nombre qui va être répété par l'ordi pour se rapprocher de n, i++ ca veut dire en gros: a chaque fois que tu compte i tu en rajoute un apres
                for (int i = 0; i < n; i++)
                {

                    //avec ca le programme peut générer aleatoirement un code avec les lettres proposer
                    var symbolIndex = random.Next(7);

                    if (symbolIndex == 0)
                    {
                        secret = secret + "G";
                    }

                    else if (symbolIndex == 1)
                    {
                        secret = secret + "Y";
                    }

                    else if (symbolIndex == 2)
                    {
                        secret = secret + "W";
                    }

                    else if (symbolIndex == 3)
                    {
                        secret = secret + "R";
                    }

                    else if (symbolIndex == 4)
                    {
                        secret = secret + "B";
                    }

                    else if (symbolIndex == 5)
                    {
                        secret = secret + "M";
                    }

                    else if (symbolIndex == 6)
                    {
                        secret = secret + "C";
                    }

                }

                Console.WriteLine($"secret is:{secret}");

                //ca c'est pour les essaies
                int g = 10;

                for (int i = 0; i < g; i++)
                {
                    if ()
                }


                Console.WriteLine("Voulez-vous reessayer ? [o/n] : ");
                reponse = Console.ReadLine();

            } while (reponse == "o") ;
           



        }                       
    }
}
