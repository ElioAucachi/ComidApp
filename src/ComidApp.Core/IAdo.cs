namespace ComidApp.Core;
public interface IAdo
{
    void RegistrarCliente (Cliente cliente);
    Cliente? ClientePorPass(string email, string pasword);
    void AltaRestaurante(Restaurant restaurant);
    Restaurant? RestaurantPorPass(string email,string pasword);
    void AltaPlato(Plato plato);
    Plato? ObtenerPlatos(int IdPlato, int Restaurant);
    void AltaPedido(Pedido pedido);
    Pedido? PedidoPorRest(int numero);
    void AltaPlatoPedido(PlatoPedido platoPedido);
    List<PlatoPedido> ObtenerPlatoPedido();   
}