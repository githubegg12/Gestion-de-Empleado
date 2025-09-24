namespace GestionEmpleado;

public class Empleado : Persona
{
    public String Posicion { get; private set; }
    public Double Salario { get; private set; }

    public Empleado(string nombre, string apellido, string numeroDeIdentificacion,byte edad, string posicion, double salario ): base(nombre, apellido,numeroDeIdentificacion,edad)
    {
        Posicion = posicion;
        Salario = salario;
    }

    private double CalcularBonificacion()
    {
        return Salario * 0.1;
    }    
    
    public override void MostrarInformacion()
    {
        Console.WriteLine("\nInformación de la venta:");
        Console.WriteLine($"Id: {Id}");
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Apellido: {Apellido}");
        Console.WriteLine($"Identificacion: {NumeroDeIdentificacion}");
        Console.WriteLine($"Edad: {Edad}");
        Console.WriteLine($"Posicion: {Posicion}");
        Console.WriteLine($"Salario(+ Bono 10%): {Salario+CalcularBonificacion():c}");
    }

    public override void ActualizarDatos(string nombre, string apellido, byte edad )
        :base (string newPosicion, string newSalario)
    {
        Nombre = newNombre;
        Apellido = newApellido;
        NumeroDeIdentificacion = numeroIdentificacion;
        Edad = edad;
        Posicion = posicion;
        Salario = salario;
    }

}