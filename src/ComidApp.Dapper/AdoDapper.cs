using System.Data;
using ComidApp.Core;
using Dapper;
using MySqlConnector;

namespace ComidApp.Dapper;
public class AdoDapper : IAdo
{
    private readonly IDbConnection _conexion;
    public AdoDapper(IDbConnection conexion) => _conexion = conexion;
    public AdoDapper(string cadena)
        => _conexion = new MySqlConnection(cadena);

    #region Cliente 
    private static readonly string _queryClientePass
        = @"select *
        from Cliente
        where email = @unEmail
        and pasword = SHA2(@unPasword, 256)
        LIMIT 1;";
    public void RegistrarCliente(Cliente cliente)
    {
        var parametros = new DynamicParameters();
        parametros.Add("@unIdCliente",direction: ParameterDirection.Output);
        parametros.Add("@unEmail", cliente.email);
        parametros.Add("@uncliente", cliente.cliente);
        parametros.Add("@unApellido",cliente.apellido);
        parametros.Add("@unpassword",cliente.pasword);

        _conexion.Execute("RegistrarCliente",parametros);
        cliente.IdCliente = parametros.Get<int>("@unIdCliente");
    }

    public Cliente? ClientePorPass(string email, string pasword)
    
        => _conexion.QueryFirstOrDefault<Cliente>(_queryClientePass, new {unEmail = email, unPasword = pasword});

#endregion
#region Restaurant
private static readonly string _queryRestaPass
    =@"select *
    from Restaurant
    where email = @unEmail
    and pasword= SHA2(@unPasword, 256)
    limit 1;";
    public void AltaRestaurante(Restaurant restaurant)
    {
        var parametros = new DynamicParameters();
        parametros.Add("@unIdRestaurant",direction: ParameterDirection.Output);
    parametros.Add("@unRestaurante", restaurant.Restaurante);
    parametros.Add("@unDomicilio", restaurant.Domicilio);
    parametros.Add("@unPasword",restaurant.Pasword);
    parametros.Add("@unEmail",restaurant.Email);

    _conexion.Execute("AltaRestaurante",parametros);
    restaurant.IdRestaurant = parametros.Get<short>("@unIdRestaurant");
    }

    public Restaurant? RestaurantPorPass(string email, string pasword)
        => _conexion.QueryFirstOrDefault<Restaurant>(_queryRestaPass, new {unEmail = email, unPasword = pasword});
    
#endregion
#region Plato
private static readonly string _quieryObtenerPlatos
=@"select *
from Plato
where IdPlato = @Id;

select IdPlato, plato, Plato.IdRestaurant
from Plato
join Restaurant using (IdRestaurant)
where IdPlato=@Id;";
    public void AltaPlato(Plato plato)
    {
        var parametros = new DynamicParameters();
        parametros.Add("@UnIdPlato",direction: ParameterDirection.Output);
        parametros.Add("@unPlato", plato.plato);
        parametros.Add("@unDescripcion", plato.decripcion);
        parametros.Add("@UnIdRestaurant", plato.IdRestaurant);
        parametros.Add("@UnDisponible", plato.Disponible);
        
        _conexion.Execute("altaPlato", parametros);

        //Obtengo el valor de parametro de tipo salida
        plato.IdPlato = parametros.Get<int>("@unIdPlato");
    }

    public Plato? ObtenerPlatos(int IdPlato, int IdRestaurant)
    {

        throw new NotImplementedException();
    }
    #endregion
#region Pedido
    private static readonly string _quieryPedidoPorRest
        = @"select *
        from Pedido
        where numero=@numero;";

    public void AltaPedido(Pedido pedido)
    {
        var parametros = new DynamicParameters();
        parametros.Add("@UnNumero",direction: ParameterDirection.Output);
        parametros.Add("@unIdPlato", pedido.IdPlato);
        parametros.Add("@unIdRestaurant", pedido.IdRestaurant);
        parametros.Add("@UnIdPlato", pedido.IdPlato);
        parametros.Add("@UnFecha", pedido.fecha);
        parametros.Add("@UnValoracion", pedido.Valoracion);
        parametros.Add("@UnDescripcion", pedido.descripcion);

        _conexion.Execute("altaPlato", parametros);

        //Obtengo el valor de parametro de tipo salida
        pedido.numero = parametros.Get<int>("@unNumero");
        
    }

    public Pedido? PedidoPorRest(int numero)
    {
        throw new NotImplementedException();
    }
#endregion
#region PlatoPedido
    public void AltaPlatoPedido(PlatoPedido platoPedido)
    {

    }

    public List<PlatoPedido> ObtenerPlatoPedido()
    {
        throw new NotImplementedException();
    }

    #endregion




}