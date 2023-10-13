//Author: Sierro Félix
//Date: 13.10.2023
//Place: ETML - Vennes
//Description: code for the game MasterMind

using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMind
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userChoice = 0;
            String name;

            //Welcome message
            Console.Write("Bienvenue sur Mastermind! Veuillez entrer votre prénom: ");
            name = Console.ReadLine();
            Console.WriteLine("\nBonjour " + name + " que voulez-vous faire?" + "\n");

            //Allows to go to the main menu
            do
            {
                userChoice = ShowMenu();
                PerformChoice(userChoice);
            } while (userChoice != 4);

            int ShowMenu()

            {
                int choice;

                //Shows the main menu
                Console.WriteLine("[1] Mode facile");
                Console.WriteLine("[2] Mode difficile");
                Console.WriteLine("[3] Règles");
                Console.WriteLine("[4] Quitter\n");

                //Allows to choose between 1, 2, 3 and for and nothing else
                while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4)
                {
                    Console.WriteLine("\nVeuillez entrer un chiffre entre 1 et 4\n");
                }
                return choice;
            }

            void PerformChoice(int choice)
            {
                switch (choice)
                {
                    case 1:
                        Easy();
                        break;

                    case 2:
                        Hard();
                        break;

                    case 3:
                        Rules();
                        break;

                    case 4:
                        Environment.Exit(0);
                        break;
                }
            }

            void Rules()
            {
                //Clears the UI
                Console.Clear();

                //Shows the rules
                Console.WriteLine("\n******************************************************************************************************************\n******************************************************************************************************************");
                Console.WriteLine("Vous devez trouver la combianaison de couleur secrete avec les couleurs suivantes : \nG (vert), Y (jaune), W (blanc), R (rouge), B (bleu), M (magenta) et C (cyan)\n\nCertain code peuvent comporter plusieurs fois la même couleur." +
                                    "\n\nVous avez plusieurs essaies mais attention, vous n'en avez que 10\n");
                Console.WriteLine("Si vous placez une ou plusieurs couleurs correctement, la console vous l'indiquera en écrivant et en indiquant le \nnombre de caractères correcte en-dessous à coté du terme *Ok*\n");
                Console.WriteLine("Si vous placez une ou plusieurs bonnes couleurs mais pas au bon endroit, la console vous l'indiquera avec le terme\n*presque* suivit du nombre de couleur à corriger.\n");
                Console.WriteLine("Dans le mode facile [1], vous devez trouver la bonne combinaison de 4 couleurs.\nDans le mode difficile [2], vous devez trouver la bonne combinaison de 6 couleurs.");
                Console.WriteLine("******************************************************************************************************************\n******************************************************************************************************************\n");
            }

            //Easy mode
            void Easy()
            {
                //Clears the UI
                Console.Clear();

                //Shows the possibility of input
                Console.WriteLine("Couleurs possibles: G Y W R B M C\nTrouvez le code en 4 couleurs\n");

                //Creates the random code with the allowed inputs
                int n = 4;
                var random = new Random();
                char[] colors = { 'G', 'Y', 'W', 'R', 'B', 'M', 'C' };

                string secret = "";

                //Lenght of the secret code
                for (int i = 0; i < n; i++)
                {
                    var symbolIndex = random.Next(colors.Length);
                    secret += colors[symbolIndex];
                }

                //Shows the secret code for the tests
                //Console.WriteLine($"secret is:{secret}");

                //Limits the number of tries
                int g = 10;
                String input;

                //Shows the remaining number of tries
                for (int j = 0; j < g; j++)
                {
                    //Limits the number of inputs to 4 and makes it possible for the input to be written in lower caps
                    do
                    {
                        Console.Write("******************\nEssaie no " + (j + 1) + " : ");
                        input = Console.ReadLine().ToUpper();
                    } while (input.Length != 4);

                    //Congratulation message
                    if (secret == input)
                    {
                        Console.WriteLine("\n*******************************\nFélicitation, vous avez gagné !\n*******************************\n\n\nQue voulez-vous faire maintenant ?\n");
                        break;
                    }

                    //Losing message
                    else if (j == 9)
                    {
                        Console.WriteLine("\n\nPas de chance, vous avez perdu.\n\nQue voulez-vous faire maintenant ?");
                    }

                    else
                    {
                        int ok = 0;
                        int notOk = 0;

                        //Table that stocks the number of instances of every letters in the code and the user's input
                        int[] secretLetterCounts = new int[colors.Length];
                        int[] inputLetterCounts = new int[colors.Length];

                        //Counts the number of letters in every letters in the code
                        foreach (char letter in secret)
                        {
                            secretLetterCounts[Array.IndexOf(colors, letter)]++;
                        }

                        //Counts the number of instances of every letters in the user's input
                        foreach (char letter in input)
                        {
                            //Checks if the input is a letter and if it is in the table
                            if (char.IsLetter(letter) && Array.Exists(colors, element => element == char.ToUpper(letter)))
                            {
                                inputLetterCounts[Array.IndexOf(colors, char.ToUpper(letter))]++;
                            }
                        }
                        
                        for (int i = 0; i < secret.Length; i++)
                        {
                            switch (colors[i])
                            {
                                case 'G':
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    break;

                                case 'Y':
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    break;

                                case 'W':
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    break;

                                case 'R':
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    break;

                                case 'B':
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    break;

                                case 'M':
                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                    break;

                                case 'C':
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    break;

                            }

                            //Right color and right place
                            if (input[i] == secret[i])
                            {
                                Console.Write(input[i]);
                                ok++;
                            }

                            //Wrong color
                            else if (input[i] != secret[i])
                            {
                                Console.Write("_");
                                Console.ResetColor();
                            }
                        }

                        //Right color but in the wrong place
                        for (int i = 0; i < colors.Length; i++)
                        {
                            notOk += Math.Min(secretLetterCounts[i], inputLetterCounts[i]);
                        }

                        notOk -= ok;
                        
                        Console.WriteLine("\nok : " + ok);
                        Console.WriteLine("presque : " + notOk + "\n******************\n\n");

                        Console.ResetColor();
                    }
                }
            }

            //Hard mode
            void Hard()
            {
                //Clears the UI
                Console.Clear();

                //Shows the possibility of input
                Console.WriteLine("Couleurs possibles: G Y W R B M C\nTrouvez le code en 6 couleurs\n");

                //Creates the random code with the allowed inputs
                int n = 6;
                var random = new Random();
                char[] colors = { 'G', 'Y', 'W', 'R', 'B', 'M', 'C' };

                string secret = "";

                //Lenght of the secret code
                for (int i = 0; i < n; i++)
                {
                    var symbolIndex = random.Next(colors.Length);
                    secret += colors[symbolIndex];
                }

                //Shows the secret code for the tests
                //Console.WriteLine($"secret is:{secret}");

                //Limits the number of tries
                int g = 10;
                String input;

                //Shows the remaining number of tries
                for (int j = 0; j < g; j++)
                {
                    //Limits the number of inputs to 4 and makes it possible for the input to be written in lower caps
                    do
                    {
                        Console.Write("********************\nEssaie no " + (j + 1) + " : ");
                        input = Console.ReadLine().ToUpper();
                    } while (input.Length != 6);


                    //Congratulation message
                    if (secret == input)
                    {
                        Console.WriteLine("\n*******************************\nFélicitation, vous avez gagné !\n*******************************\n\n\nQue voulez-vous faire maintenant ?\n");
                        break;
                    }

                    //Losing message
                    else if (j == 9)
                    {
                        Console.WriteLine("\n\nPas de chance, vous avez perdu.\n\nQue voulez-vous faire maintenant ?");
                    }

                    else
                    {
                        int ok = 0;
                        int notOk = 0;

                        //Table that stocks the number of instances of every letters in the code and the user's input
                        int[] secretLetterCounts = new int[colors.Length];
                        int[] inputLetterCounts = new int[colors.Length];

                        //Counts the number of letters in every letters in the code
                        foreach (char letter in secret)
                        {
                            secretLetterCounts[Array.IndexOf(colors, letter)]++;
                        }

                        //Counts the number of instances of every letters in the user's input
                        foreach (char letter in input)
                        {
                            //Checks if the input is a letter and if it is in the table
                            if (char.IsLetter(letter) && Array.Exists(colors, element => element == char.ToUpper(letter)))
                            {
                                inputLetterCounts[Array.IndexOf(colors, char.ToUpper(letter))]++;
                            }
                        }

                        for (int i = 0; i < secret.Length; i++)
                        {
                            //Right color and right place
                            if (input[i] == secret[i])
                            {
                                ok++;
                            }

                            //Wrong color
                            else if (input[i] != secret[i])
                            {
                            }
                        }

                        //Right color but in the wrong place
                        for (int i = 0; i < colors.Length; i++)
                        {
                            notOk += Math.Min(secretLetterCounts[i], inputLetterCounts[i]);
                        }

                        notOk -= ok;

                        Console.WriteLine("\nok : " + ok);
                        Console.WriteLine("presque : " + notOk + "\n********************\n\n");
                    }
                }
            }
        }
    }
}

