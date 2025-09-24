namespace GestionEmpleado;

public class Empleado : Persona
{
    public Guid Id { get; private set; }    
    public String NumeroDeIdentificacion { get; private set; }
    public String Posicion { get; private set; }
    public Double Salario { get; private set; }

    public Empleado(string nombre, string apellido,byte edad,string numeroDeIdentificacion, string posicion, double salario ): base(nombre, apellido,edad)
    
    {
        Id = Guid.NewGuid();
        NumeroDeIdentificacion = numeroDeIdentificacion;
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

    public void ActualizarDatos(string numeroDeIdentificacion, string posicion, double salario)
    {

        base.ActualizarDatos(Nombre, Apellido, Edad);
        NumeroDeIdentificacion = numeroDeIdentificacion;
        Posicion = posicion;
        Salario = salario;
    }

}