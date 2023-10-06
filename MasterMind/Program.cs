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
                String gameMode;
                bool hasHelped = false;



                //permet de ne pas inscrir autre chose que 1, 2 ou 3
                do
                {
                    Console.WriteLine("[1] mode facile" + "\n" + "[2] mode difficile" + "\n" + "[3] règles" + "\n");
                    gameMode = Console.ReadLine();
                    nb = Convert.ToInt32(gameMode);

                } while (nb < 1 || nb > 3);


                if (gameMode == "3")
                {
                    //règles
                    Console.WriteLine("\n" + "******************************************************************************************************************" + "\n" + "******************************************************************************************************************");
                    Console.WriteLine("Vous devez trouver la combianaison de couleur secrete avec les couleurs suivantes : G (vert), Y (jaune), W (blanc)" + "\n" + "R(rouge), B(bleu), M(magenta) et C(cyan)" + "\n");
                    Console.WriteLine("Si vous placez une ou plusieurs couleurs correctement, la console vous l'indiquera et l'écrivant en dessous." + "\n");
                    Console.WriteLine("Si vous placez une ou plusieurs bonnes couleurs mais pas au bon endroit, la console vous l'indiquera avec le terme" + "\n" + "*presque* suivit du nombre de couleur à corriger." + "\n");
                    Console.WriteLine("Dans le mode facile [1], vous devez trouver la bonne combinaison de 4 couleurs." + "\n" + "Dans le mode difficile [2], vous devez trouver la bonne combinaison de 6 couleurs.");
                    Console.WriteLine("******************************************************************************************************************" + "\n" + "******************************************************************************************************************" + "\n");

                    hasHelped = true;
                }


                else if (gameMode == "1")
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

                    Console.WriteLine($"secret is:{secret}");

                    //ca c'est pour les essaies
                    int g = 10;
                    String input;

                    //message du nombre d'essaie actuel
                    for (int j = 0; j < g; j++)
                    {

                        Console.Write("Essaie no " + (j + 1) + " : ");
                        input = Console.ReadLine().ToUpper();//ça permet de mettre l'entrée de lutilisateur en majuscule pour éviter que cela ne fonctionne pas

                        Console.WriteLine("\n");

                        if (secret == input)
                        {
                            Console.WriteLine("\n" + "*******************************" + "\n" + "Félicitation, vous avez gagné !" + "\n" + "*******************************" + "\n");
                            break;
                        }

                        else
                        {
                            int ok = 0;

                            //si c'est juste
                            if (input[0] == secret[0])
                            {
                                Console.Write(input[0]);
                            }

                            //si c'est faux
                            if (input[0] != secret[0])
                            {
                                Console.Write("_");
                            }

                            //si c'est juste
                            if (input[1] == secret[1])
                            {
                                Console.Write(input[1]);
                            }
                            //si c'est faux
                            if (input[1] != secret[1])
                            {
                                Console.Write("_");
                            }


                            //si c'est juste
                            if (input[2] == secret[2])
                            {
                                Console.Write(input[2]);
                            }
                            //si c'est faux
                            if (input[2] != secret[2])
                            {
                                Console.Write("_");
                            }

                            //si c'est juste
                            if (input[3] == secret[3])
                            {
                                Console.Write(input[3]);
                            }
                            //si c'est faux
                            if (input[3] != secret[3])
                            {
                                Console.Write("_");
                            }


                            //pour les pas bien placés
                            if (input[0] == secret[1])
                            {
                                Console.WriteLine("presque : " + ok++);
                            }

                            Console.WriteLine("\n");
                        }

                    }

                }




                else if (gameMode == "2")
                {
                    //mode facile
                    Console.WriteLine("\n" + "Couleurs possibles: GYWRBMC" + "\n" + "devine le code en 6 couleurs" + "\n");



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
                    String input;

                    //message du nombre d'essaie actuel
                    for (int j = 0; j < g; j++)
                    {

                        Console.Write("Essaie no " + (j + 1) + " : ");
                        input = Console.ReadLine().ToUpper();//ça permet de mettre l'entrée de l'utilisateur en majuscule pour éviter que cela ne fonctionne pas



                        if (secret == input)
                        {
                            Console.WriteLine("\n" + "*******************************" + "\n" + "Félicitation, vous avez gagné !" + "\n" + "*******************************" + "\n");
                            break;
                        }

                        else
                        {
                            int ok = 0;

                            //si c'est juste
                            if (input[0] == secret[0])
                            {
                                Console.Write(input[0]);
                            }

                            //si c'est faux
                            if (input[0] != secret[0])
                            {
                                Console.Write("_");
                            }


                            //si c'est juste
                            if (input[1] == secret[1])
                            {
                                Console.Write(input[1]);
                            }
                            //si c'est faux
                            if (input[1] != secret[1])
                            {
                                Console.Write("_");
                            }


                            //si c'est juste
                            if (input[2] == secret[2])
                            {
                                Console.Write(input[2]);
                            }
                            //si c'est faux
                            if (input[2] != secret[2])
                            {
                                Console.Write("_");
                            }


                            //si c'est juste
                            if (input[3] == secret[3])
                            {
                                Console.Write(input[3]);
                            }
                            //si c'est faux
                            if (input[3] != secret[3])
                            {
                                Console.Write("_");
                            }


                            //si c'est juste
                            if (input[4] == secret[4])
                            {
                                Console.Write(input[4]);
                            }
                            //si c'est faux
                            if (input[4] != secret[4])
                            {
                                Console.Write("_");
                            }


                            //si c'est juste
                            if (input[5] == secret[5])
                            {
                                Console.Write(input[5]);
                            }
                            //si c'est faux
                            if (input[5] != secret[5])
                            {
                                Console.Write("_");
                            }

                            Console.WriteLine("\n");
                        }
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
