namespace ComidApp.Core;

public class VentaResto
{
    public int IdResto { get; set; }
    public int IdPlato { get; set; }
    public DateTime anio { get; set; }
    public DateTime mes { get; set; }
    public decimal monto { get; set; }

    public VentaResto(int IdResto, int IdPlato, DateTime anio, DateTime mes, decimal monto)
    {
        this.IdResto = IdResto;
        this.IdPlato = IdPlato;
        this.anio = anio;
        this.mes = mes;
        this.monto = monto;
    }
}