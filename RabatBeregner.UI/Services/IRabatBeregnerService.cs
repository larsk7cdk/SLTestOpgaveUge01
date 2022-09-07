namespace RabatBeregner.UI.Services;

public interface IRabatBeregnerService
{
    (double pris, double rabat) GetPrisEfterRabat(int antalVarer, double stykPris);
}