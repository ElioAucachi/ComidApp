using ComidApp.Core;

namespace ComidApp.Dapper.Test;

public class TestAdoRestaurant : TestAdo
{
    [Theory]
    [InlineData("pollos@gmail.com", "pollos x2", "tolft")]
    [InlineData("Simba@gmail.com", "Carne Simba", "23456")]
    public void TraerRestaurante(string email, string restaurante, string pasword)
    {
        var restaurant = Ado.RestaurantPorPass(email, pasword);

        Assert.NotNull(restaurant);
        Assert.Equal(restaurante, restaurant.Restaurante);
        Assert.Equal(email, restaurant.Email);
    }

    [Theory]
    [InlineData("polloalabrocheta@gmail.com", "123456")]
    [InlineData("Cangrejoscaseros@gmail.com", "Callesimba")]
    public void RestaNoExiste(string email, string pasword)
    {
        var restaurant = Ado.RestaurantPorPass(email, pasword);

        Assert.Null(restaurant);
    }
    [Fact]
    public void AltaRestaurante()
    {
        short idRestaurant = 11;
        string pasword = "tolft";
        string restaurante = "Pollos x2";
        string email = "pollos@gmail.com";
        string Domicilio="shot1500";

        var restaurant = Ado.RestaurantPorPass(email, pasword);

        Assert.Null(restaurant);

        var nuevoEmilio = new Restaurant( idRestaurant,restaurante,  Domicilio,  email,  pasword)
        {
            IdRestaurant= idRestaurant,
            Restaurante = restaurante,
            Domicilio =Domicilio,
            Email=email,
            Pasword=pasword
        
        };

        Ado.AltaRestaurante(nuevoEmilio);

        var mismoRestaurante = Ado.RestaurantPorPass(email, pasword);

        Assert.NotNull(mismoRestaurante);
        Assert.Equal(restaurante, mismoRestaurante.Restaurante);
        Assert.Equal(pasword, mismoRestaurante.Pasword);
    }
}