using System.ComponentModel.DataAnnotations;

namespace ComidApp.Core;
public class Cliente
{
    public int IdCliente {get; set;}
    public required string email {get; set;}
    public required string cliente {get; set;}
    public required string apellido {get; set;}
    public required string pasword {get; set;}

    public Cliente (int IdCliente, string email, string cliente, string apellido,string pasword)
    {
        this.IdCliente=IdCliente;
        this.email=email;
        this.cliente=cliente;
        this.apellido=apellido;
        this.pasword=pasword;

        
    }
}