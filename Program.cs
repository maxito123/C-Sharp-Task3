using System.Collections.ObjectModel;
using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Function for Level 1(Easy) */
            int EasyLevel()
            {
                Console.WriteLine("WELCOME TO EASY LEVEL.\n Guess the hidden number. (Hint:from 1 to 10)");
                int chances = 6; 
                Random random = new Random();
                int hideNumb = random.Next( 11);

                while (chances > 0)
                {
                
                    Console.WriteLine("Enter Your Guess number \n> ");
                    int guess = int.Parse(Console.ReadLine());
                    if (guess == hideNumb)
                    {
                        Console.WriteLine("YOU GOT IT !");
                        Console.WriteLine();
                        Console.WriteLine("Do you want to play again or progress to the next level.\n Enter PLAY AGAIN or PROGRESS to move to a higher level or any key to quit");
                        string whatnext = Console.ReadLine().ToUpper();

                        if (whatnext == "PLAY AGAIN")
                        {
                            EasyLevel();
                            break;
                        }
                        else if (whatnext == "PROGRESS")
                        {
                            MediumLevel();
                            break;
                        }
                        else
                        {
                            break;
                        }
                    }
                    else if (guess != hideNumb)
                    {
                        Console.WriteLine("THAT WAS WRONG");
                        chances -= 1;
                        Console.WriteLine();
                        if (chances == 0)
                        {
                            continue;
                        }
                        Console.WriteLine("Try again, you have " +chances+ " chances" );
                    }
                
                }   
                

            return chances;

            }

            /* Function for Level 2(Medium) */
            int MediumLevel()
            {
                Console.WriteLine("WELCOME TO MEDIUM LEVEL\n Guess the hidden number.(Hint:from 1 to 20)");
                int chances = 4; 
                Random random = new Random();
                int hideNumb = random.Next(1, 20);

                while (chances > 0)
                {
                
                    Console.WriteLine("Enter Your Guess number. \n> ");
                    int guess = int.Parse(Console.ReadLine());
                    if (guess == hideNumb)
                    {
                        Console.WriteLine("YOU GOT IT !");
                        Console.WriteLine();
                        Console.WriteLine("Do you want to play again or progress to the next level.\n Enter PLAY AGAIN or PROGRESS to move to a higher level or enter any key to quit");
                        string whatnext = Console.ReadLine().ToUpper();

                        if (whatnext == "PLAY AGAIN")
                        {
                            MediumLevel();

                            break;
                        }
                        else if (whatnext == "PROGRESS")
                        {
                            HardLevel();

                            break;
                        }
                        else
                        {
                            break;
                        }
                    }
                    else if (guess != hideNumb)
                    {
                        Console.WriteLine("THAT WAS WRONG");
                        chances -= 1;
                        Console.WriteLine();
                        if (chances == 0)
                        {
                           continue;
                        }
                        Console.WriteLine("Try again, you have " +chances+ " chances" );
                    }
                   
                }   
                return chances;
            }

            /* Function for level 3 (Hard) */
            int HardLevel()
            {
               
                Console.WriteLine("WELCOME TO HARD LEVEL\n Guess the hidden number. (Hint:from 1 to 50)");
                int chances = 3; 
                Random random = new Random();
                int hideNumb = random.Next(1, 50);

                while (chances > 0)
                {
                
                    Console.WriteLine("Enter Your Guess number. \n> ");
                    int guess = int.Parse(Console.ReadLine());
                    if (guess == hideNumb)
                    {
                        Console.WriteLine("YOU GOT IT !");
                        Console.WriteLine();
                        Console.WriteLine("Do you want to play again or return to Easy level.\n Enter PLAY AGAIN or RETURN to move back to level 1 or enter any key to quit");
                        string whatnext = Console.ReadLine().ToUpper();

                        if (whatnext == "PLAY AGAIN")
                        {
                            HardLevel();

                            break;
                        }
                        else if (whatnext == "RETURN")
                        {
                            EasyLevel();

                            break;
                        }
                        else
                        {
                            break;
                        }
                    }
                    else if (guess != hideNumb)
                    {
                        Console.WriteLine("THAT WAS WRONG");
                        chances -= 1;
                        Console.WriteLine();
                        if (chances == 0)
                        {
                            continue;
                        }
                        Console.WriteLine("Try again, you have " +chances+ " chances" );
                    }
                
                }   
                return chances; 
            }

            /* Main Program */

            Console.WriteLine("\nWELCOME TO GUESSING GAME OF NUMBERS");
            Console.WriteLine();
            Console.WriteLine("We have 3 Levels in this game; EASY, MEDIUM and HARD. Kindly Enter the level you want to begin with\n > ");
            string level = Console.ReadLine().ToUpper();

            if (level == "EASY" )
            {
                EasyLevel();
                Console.WriteLine("GAME OVER");

            }
            else if (level == "MEDIUM")
            {
                MediumLevel();
                Console.WriteLine("GAME OVER");

            }
            else if (level == "HARD")
            {
                HardLevel();
                Console.WriteLine("GAME OVER");
            }
            else
            {
                Console.WriteLine("Invalid input");
                Console.WriteLine("GAME OVER");

            }

             
               

            




        }
    }
}
