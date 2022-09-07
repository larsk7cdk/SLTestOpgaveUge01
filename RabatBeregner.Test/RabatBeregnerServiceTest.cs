using RabatBeregner.UI.Services;
using Xunit;

namespace RabatBeregner.Test;

public class RabatBeregnerServiceTest
{
    private readonly IRabatBeregnerService sut = new RabatBeregnerService();

    /// <summary>
    // Normalpris er 1 x 100 = 100
    // Forventet pris efter rabat er 100
    /// </summary>
    [Fact]
    public void En_vare_skal_ikke_give_rabat()
    {
        // Arrange 
        const int antalVarer = 1;
        const int stykpris = 100;
        const double expectedPris = 100.0;
        const double expectedRabat = 0.0;

        // Act
        var (pris, rabat) = sut.GetPrisEfterRabat(antalVarer, stykpris);

        // Assert
        Assert.Equal(expectedPris, pris);
        Assert.Equal(expectedRabat, rabat);
    }

    /// <summary>
    // Normalpris er 15 x 10 = 150
    // 2% rabat er 3
    // Forventet pris efter rabat er 147
    /// </summary>
    [Fact]
    public void Femten_varer_giver_rabat()
    {
        // Arrange 
        const int antalVarer = 15;
        const int stykpris = 10;
        const double expectedPris = 147.0;
        const double expectedRabat = 3.0;

        // Act
        var (pris, rabat) = sut.GetPrisEfterRabat(antalVarer, stykpris);

        // Assert
        Assert.Equal(expectedPris, pris);
        Assert.Equal(expectedRabat, rabat);
    }

    /// <summary>
    // Normalpris er 1 x 10000 = 10000
    // 3% rabat er 300
    // Forventetpris efter rabat er 9700
    /// </summary>
    [Fact]
    public void Stor_ordre_giver_rabat()
    {
        // Arrange 
        const int antalVarer = 1;
        const int stykpris = 10000;
        const double expectedPris = 9700.0;
        const double expectedRabat = 300.0;

        // Act
        var (pris, rabat) = sut.GetPrisEfterRabat(antalVarer, stykpris);

        // Assert
        Assert.Equal(expectedPris, pris);
        Assert.Equal(expectedRabat, rabat);
    }

    /// <summary>
    // Normalpris er 15 x 1000 = 15000
    // 3% rabat er 450 og 2% rabat er 300 = 750
    // Forventetpris efter rabat er 14250
    /// </summary>
    [Fact]
    public void Mange_varer_og_stor_ordrer_giver_stor_rabat()
    {
        // Arrange 
        const int antalVarer = 15;
        const int stykpris = 1000;
        const double expectedPris = 14250.0;
        const double expectedRabat = 750.0;

        // Act
        var (pris, rabat) = sut.GetPrisEfterRabat(antalVarer, stykpris);

        // Assert
        Assert.Equal(expectedPris, pris);
        Assert.Equal(expectedRabat, rabat);
    }
}