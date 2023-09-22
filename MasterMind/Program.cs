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
            String reponse = "o";


            //message de bienvenue guide pour selectionner le mode de jeu
            Console.Write("Bienvenue sur Mastermind! Veuillez entrer votre prénom: ");
            name = Console.ReadLine();
            Console.WriteLine("Bonjour " + name + " que voulez-vous faire?" + "\n");

            //permet de recommencer
            do
            {
                int nb;
                String reponse2;
                bool hasHelped = false;



                //permet de ne pas inscrir autre chose que 1, 2 ou 3
                do
                {
                    Console.WriteLine("[1] mode facile" + "\n" + "[2] mode difficile" + "\n" + "[3] règles" + "\n");
                    reponse2 = Console.ReadLine();
                    nb = Convert.ToInt32(reponse2);

                } while (nb < 1 || nb > 3);


                if (reponse2 == "3")
                {
                    //règles
                    Console.WriteLine("\n" + "******************************************************************************************************************" + "\n" + "******************************************************************************************************************");
                    Console.WriteLine("Vous devez trouver la combianaison de couleur secrete avec les couleurs suivantes : G (vert), Y (jaune), W (blanc)" + "\n" + "R(rouge), B(bleu), M(magenta) et C(cyan)");
                    Console.WriteLine("Si vous placez une ou plusieurs couleurs correctement, la console vous l'indiquera avec au terme *juste* suivit du" + "\n" + "nombre de couleur bien placée.");
                    Console.WriteLine("Si vous placez une ou plusieurs bonnes couleurs mais pas au bon endroit, la console vous l'indiquera avec le terme" + "\n" + "* presque* suivit du nombre de couleur correcte.");
                    Console.WriteLine("******************************************************************************************************************" + "\n" + "******************************************************************************************************************" + "\n");

                    hasHelped = true;
                }


                else if (reponse2 == "1")
                {
                    //mode facile
                    Console.WriteLine("\n" + "Couleurs possibles: GYWRBMC" + "\n" + "Trouvez le code en 4 couleurs" + "\n");



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

                    //Console.WriteLine($"secret is:{secret}");

                    //ca c'est pour les essaies
                    int g = 10;
                    String input;

                    //message du nombre d'essaie actuel
                    for (int j = 0; j < g; j++)
                       {

                        Console.Write("Essaie no " + (j + 1) +" : ");
                        input = Console.ReadLine();

                        if (secret == input) break;
                    }

                }


                else if (reponse2 == "2")
                {
                    //mode facile
                    Console.Write("Couleurs possibles: GYWRBMC" + "\n" + "devine le code en 6 couleurs");
                    Console.Read();


                    //n c'est le nombre qui va permettre de definir combien de fois le for va faire d'aller-retour avant de s'arreter
                    int n = 6;

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

                    for (int j = 0; j < g; j++)
                    {

                    }

                }

                //pour revenir du menu [r] sans avoir à le demander
                if (hasHelped == false)
                {

                    Console.Write("Voulez-vous reessayer ? [o/n] : ");
                    reponse = Console.ReadLine();
                    Console.WriteLine();
                }

                

            } while (reponse == "o") ;
           



        }                       
    }
}
