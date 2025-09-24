namespace GestionEmpleado;

public class Cliente: Persona
{
    public String Email { get; private set; }
    public String Telefono { get; private set; }

    public Cliente(string nombre, string apellido, string numeroDeIdentificacion,byte edad, string email, string telefono ): base(nombre, apellido,numeroDeIdentificacion,edad)
    {
        Email = email;
        Telefono = telefono;
    }
    public override void MostrarInformacion()
    {
        Console.WriteLine("\nInformación de la venta:");
        Console.WriteLine($"Id: {Id}");
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Apellido: {Apellido}");
        Console.WriteLine($"Identificacion: {NumeroDeIdentificacion}");
        Console.WriteLine($"Edad: {Edad}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"Telefono): {Telefono}");
    }
    
}