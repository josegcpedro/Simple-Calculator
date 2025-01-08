using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bienvenue à cette simple calculatrice!");
        Console.WriteLine("Veuillez choisir les options suivantes :");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Multiplication");
        Console.WriteLine("3. Soustraction");
        Console.WriteLine("4. Division");

        string choix = Console.ReadLine();

        Console.WriteLine(choix);


        switch (choix)
        {
            case "Addition":
                Addition();
                break;
            case "Multiplication":
                Multiplication();
                break;
            case "Soustraction":
                Soustraction();
                break;
            case "Division":
                Division();
                break;
            default:
                Console.ReadLine("erreur");
                break;
        }
    }


}