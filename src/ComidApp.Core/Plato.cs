namespace ComidApp.Core;

public class Plato
{
    public required string plato { get; set; }
    public required string decripcion { get; set; }
    public short IdRestaurant { get; set; }
    public bool Disponible { get; set; }
    public int IdPlato { get; set; }

    public Plato(string plato, string descripcion, short IdRestaurant, bool Disponible, int IdPlato)
    {
        this.plato = plato;
        this.decripcion = descripcion;
        this.IdRestaurant = IdRestaurant;
        this.Disponible = Disponible;
        this.IdPlato = IdPlato;
    }
}