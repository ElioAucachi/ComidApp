namespace ComidApp.Core;
public class Restaurant
{
    public short IdRestaurant { get; set; }
    public required string Restaurante { get; set; }
    public required string Domicilio { get; set; }
    public required string Email { get; set; }
    public required string Pasword { get; set; }

    public Restaurant(short idRestaurant , string restaurante, string domicilio, string email, string pasword)
    {
        this.IdRestaurant = idRestaurant;
        this.Restaurante = restaurante;
        this.Domicilio = domicilio;
        this.Email = email;
        this.Pasword = pasword;
    }

}