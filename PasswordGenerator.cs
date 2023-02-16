using System;
using System.Text;

class Program {
    static void Main() {
        string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZ" + "abcdefghijklmnopqrstuvwxyz" + "0123456789" + "%$#@!";

        Console.WriteLine("Hello, my name is Rafael. Welcome to my password generator!");
        Console.WriteLine("Choose the number of characters:");

        // Validação de entrada do usuario
        int quantidade;
        if (!int.TryParse(Console.ReadLine(), out quantidade)) {
            Console.WriteLine("Invalid entry. Please enter a valid number.");
            return;
        }

        Console.WriteLine("Would you like to include special characters in your password? If yes, enter 1; otherwise, enter 2: ");

        // Ocultação do usuario e leitura de uma tecla
        int escolha = Console.ReadKey(true).KeyChar - '0';
        if (escolha == 1) {
            Random aleatorio = new Random();
            StringBuilder senha = new StringBuilder();

            for (int i = 0; i < quantidade; i++) {
                int indice = aleatorio.Next(caracteres.Length);
                senha.Append(caracteres[indice]);
            }

            Console.WriteLine("Your password is: {0}", senha);
        }
        else if (escolha == 2) {
            // Seleciona 62 caracteres 
            caracteres = caracteres.Substring(0, 62);
            Random aleatorio = new Random();
            StringBuilder senha = new StringBuilder();

            for (int i = 0; i < quantidade; i++) {
                int indice = aleatorio.Next(caracteres.Length);
                senha.Append(caracteres[indice]);
            }

            Console.WriteLine("Your password is: {0}", senha);
        }
        else {
            Console.WriteLine("Invalid entry. Please enter 1 or 2.");
            return;
        }

        Console.WriteLine("I hope I've been helpful. Come back whenever you need to.");
        Console.WriteLine("Press any key to terminate.");
        Console.ReadKey();
    }
}