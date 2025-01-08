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
            case "1":
                Addition();
                break;
            case "2":
                //Multiplication();
                break;
            case "3":
                //Soustraction();
                break;
            case "4":
                //Division();
                break;
            default:
                Console.WriteLine("erreur");
                break;
        }
    }

    static void Addition()
    {
        Console.WriteLine("Donnez votre premier chiffre");
        string reponse1 = Console.ReadLine();
        Console.WriteLine("Donnez votre deuxième chiffre");
        string reponse2 = Console.ReadLine();

        if (int.TryParse(reponse1, out int chiffre1) && int.TryParse(reponse2, out int chiffre2)){
            int resultat = chiffre1 + chiffre2;
            Console.WriteLine("Le resultat de votre opération est de: " + resultat);
        } else {
            Console.WriteLine("Chiffre pas normal");
        }
    }
}