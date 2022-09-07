using RabatBeregner.UI.Services;

namespace RabatBeregner.UI;

internal static class Program
{
    private static void Main()
    {
        var rabatBeregnerService = new RabatBeregnerService();

        Console.WriteLine(@" _____       _           _     _                                                   ");
        Console.WriteLine(@"|  __ \     | |         | |   | |                                                  ");
        Console.WriteLine(@"| |__) |__ _| |__   __ _| |_  | |__   ___ _ __ ___  __ _ _ __   ___ _ __ ___ _ __  ");
        Console.WriteLine(@"|  _  // _` | '_ \ / _` | __| | '_ \ / _ \ '__/ _ \/ _` | '_ \ / _ \ '__/ _ \ '_ \ ");
        Console.WriteLine(@"| | \ \ (_| | |_) | (_| | |_  | |_) |  __/ | |  __/ (_| | | | |  __/ | |  __/ | | |");
        Console.WriteLine(@"|_|  \_\__,_|_.__/ \__,_|\__| |_.__/ \___|_|  \___|\__, |_| |_|\___|_|  \___|_| |_|");
        Console.WriteLine(@"                                                    __/ |                          ");
        Console.WriteLine(@"                                                   |___/                           ");
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Denne beregner kan udregne rabat ud fra følgende:");
        Console.WriteLine("  1. Køber man for mere end 1.000 kr. får man 3% rabat på det samlede beløb.");
        Console.WriteLine("  2. Køber man flere end 10 varer, får man 2% rabat på det samlede beløb.");
        Console.WriteLine("  3. Opfylder man begge ovenstående kriterier, får man begge rabatter - dvs 5% rabat på det samlede beløb.");
        Console.WriteLine();
        Console.WriteLine();
        
        Console.WriteLine("Indtast antal varer for køb");
        var antalVarer = Console.ReadLine();
        Console.WriteLine();

        Console.WriteLine("Indtast stykpris");
        var stykpris = Console.ReadLine();
        Console.WriteLine();

        var (pris, rabat) = rabatBeregnerService.GetPrisEfterRabat(
            int.Parse(antalVarer!),
            int.Parse(stykpris!)
        );

        Console.WriteLine($"Pris for {antalVarer} varer er: {pris:C} og rabat er {rabat:C}");
        Console.Read();
    }
}