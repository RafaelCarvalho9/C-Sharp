
using System;

namespace MiniRPG
{
    class Program
    {
        static void Main(string[] args)
        {
        //Player stats
            int playerLevel = 1;
            int playerExperience = 0;
            int maxExperience = 10;

            Console.WriteLine("Bem-vindo ao Mini RPG!\n");

           //Execution Loop
            while (true)
            {
                Console.WriteLine($"Level: {playerLevel}");
                Console.WriteLine($"Experiência: {playerExperience}/{maxExperience}\n");

                Console.WriteLine("O que você deseja fazer?");
                Console.WriteLine("1 - Enfrentar um monstro");
                Console.WriteLine("2 - Sair do jogo\n");

                Console.Write("Opção: ");
                string input = Console.ReadLine();

                if (input == "1")
                {
                    Console.WriteLine("Você encontrou um monstro!");
                    int enemyLevel = playerLevel + new Random().Next(1, 4);
                    int enemyExperience = enemyLevel * 2;
                    Console.WriteLine($"Nível do monstro: {enemyLevel}\n");

                    //Action Loop
                    while (true)
                    {
                        Console.WriteLine("O que você deseja fazer?");
                        Console.WriteLine("1 - Atacar");
                        Console.WriteLine("2 - Fugir\n");

                        Console.Write("Opção: ");
                        input = Console.ReadLine();
                  
                    //Attack condition
                        if (input == "1")
                        {
                    //Random Player damage and Random Enemy Damage        
                            int playerDamage = new Random().Next(1, 5);
                            int enemyDamage = new Random().Next(1, 5);
                            Console.WriteLine($"Você causou {playerDamage} de dano ao monstro.");
                            Console.WriteLine($"O monstro causou {enemyDamage} de dano a você.\n");

                            if (enemyDamage >= playerLevel)
                            {
                                Console.WriteLine("Você foi derrotado!");
                                Console.WriteLine("Fim de jogo.");
                                return;
                            }

                            if (playerDamage >= enemyLevel)
                            {
                                Console.WriteLine("Você derrotou o monstro!");
                                playerExperience += enemyExperience;
                                Console.WriteLine($"Você ganhou {enemyExperience} de experiência.\n");
                                break;
                            }
                        }

                        //Escape
                        else if (input == "2")
                        {
                            Console.WriteLine("Você fugiu do monstro.\n");
                            break;
                        }
                    }
                }
                else if (input == "2")
                {
                    Console.WriteLine("Até a próxima!");
                    return;
                }

                if (playerExperience >= maxExperience)
                {
                    playerLevel++;
                    playerExperience -= maxExperience;
                    maxExperience += 5;
                    Console.WriteLine("Parabéns, você subiu de nível!\n");
                }
            }
        }
    }
}
