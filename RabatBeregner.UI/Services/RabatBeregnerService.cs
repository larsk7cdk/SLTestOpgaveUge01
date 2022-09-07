namespace RabatBeregner.UI.Services;

public class RabatBeregnerService : IRabatBeregnerService
{
    public (double pris, double rabat) GetPrisEfterRabat(int antalVarer, double stykPris)
    {
        var bruttoPris = antalVarer * stykPris;
        var rabatSum = 0.0;
        if (bruttoPris > 1000)
        {
            // Indkøb over 1000 kr. giver 3% rabat
            var rabat = bruttoPris * 0.03;
            rabatSum += rabat;
        }

        if (antalVarer > 10)
        {
            // Flere end 10 varer giver 2% rabat
            var rabat = bruttoPris * 0.02;
            rabatSum += rabat;
        }

        var pris = bruttoPris - rabatSum;
        return (pris, rabatSum);
    }
}