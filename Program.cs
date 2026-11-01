namespace Braquage_train;

class Program
{
    static void Main(string[] args)
    {
        /*
         * Consignes :
           - Utiliser une première boucle pour parcourir les quatre wagons.
           - Utiliser une deuxième boucle à l'intérieur pour parcourir les trois coffres de chaque wagon.
           - Afficher chaque coffre inspecté avec son numéro de wagon.
           - Compter le nombre total de coffres inspectés.
           
           Exemple :
               Inspection des 4 wagons du train
               Wagon 1 - Coffre 1 inspecté
               Wagon 1 - Coffre 2 inspecté
               Wagon 1 - Coffre 3 inspecté
               Wagon 2 - Coffre 1 inspecté
               ...
               Total : 12 coffres inspectés.
            
            BONUS 1 : permettre à l'utilisateur de choisir le nombre de wagons
            BONUS 2 : enregistrer l'ensemble du butin trouvé et l'afficher à la fin
         */

        Dictionary<string, int> Butin = new Dictionary<string, int>
        {
            { "Dollars", 0 },
            { "Munitions", 0 },
            { "Cartes", 0 }
        };
        Console.WriteLine("Combien de wagons faut-il inspecter?");
        int totalWagon = Convert.ToInt32(Console.ReadLine());
        int totalCoffres = 0;
        Console.WriteLine("Inspection des "+totalWagon+" wagons du train...");
        for (int wagon = 1;  wagon <= totalWagon; wagon++)
        {
            for (int coffre = 1; coffre <= 3; coffre++)
            {
                totalCoffres++;
                Console.WriteLine("Wagon "+wagon+" - Coffre "+coffre+" inspecté");
                Random rnd = new Random();
                Butin["Dollars"] += rnd.Next(0, 41);
                Butin["Munitions"] += rnd.Next(0, 11);
                Butin["Cartes"] += rnd.Next(0, 2);
            }
        }
        Console.WriteLine("Total: "+totalCoffres+ " coffres inspectés!\n");
        Console.WriteLine("Voici ton butin:\n");
        Console.WriteLine($"+${Butin["Dollars"]}");
        Console.WriteLine($"+{Butin["Munitions"]} Munitions.");
        Console.WriteLine($"+{Butin["Cartes"]} Cartes de paquets de cigarettes.");
    }
}