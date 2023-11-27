namespace ComidApp.Core;
public class PlatoPedido
{
    public int IdPlato { get; set; }
    public int numero { get; set; }
    public byte CantPlatos { get; set; }
    public decimal detalle { get; set; }

    public PlatoPedido(int IdPlato, int numero, byte CantPlatos, decimal detalle)
    {
        this.IdPlato = IdPlato;
        this.numero = numero;
        this.CantPlatos = CantPlatos;
        this.detalle = detalle;
    }
}