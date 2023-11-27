namespace ComidApp.Core;

public class Pedido
{
    public int IdCliente {get;set;}
    public int numero {get;set;}
    public short IdRestaurant {get;set;}
    public int IdPlato {get;set;}
    public DateTime fecha {get;set;}
    public float Valoracion {get;set;}
    public  required string descripcion {get;set;}

    public Pedido (int IdCliente, int numero, short IdRestaurant, int IdPlato, DateTime fecha, float Valoracion, string descripcion)
    {
        this.IdCliente=IdCliente;
        this.numero=numero;
        this.IdRestaurant=IdRestaurant;
        this.IdPlato=IdPlato;
        this.fecha=fecha;
        this.Valoracion=Valoracion;
        this.descripcion=descripcion;
    }
}