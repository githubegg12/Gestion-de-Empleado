namespace GestionEmpleado;

public class Empresa
{
    String Nombre {get; set;}
    String Direccion {get; set;}
    public List<Persona> ListaEmpleados { get; private set; } 
    public List<Persona> ListaClientes { get; private set; }
    public Empresa(string nombre, string direccion)
    {
        Nombre = nombre;
        Direccion = direccion;
        ListaClientes = new List<Persona>();
        ListaEmpleados = new List<Persona>();
    }

    public void AgregarEmpleado(Persona persona)
    {
        ListaEmpleados.Add(persona);
        Console.WriteLine($"Empleado {persona.Nombre} {persona.Apellido}");
    }

    public bool EliminarEmpleado(string nombre, string apellido)
    {
        var empleado = ListaEmpleados.FirstOrDefault(e => e.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase) && e.Apellido.Equals(apellido, StringComparison.OrdinalIgnoreCase));
        if (empleado != null)
        {
            ListaEmpleados.Remove(empleado);
            Console.WriteLine($"Empleado {nombre} {apellido} eliminado.");
            return true;
        }
        Console.WriteLine($"Empleado {nombre} {apellido} no encontrado.");
        return false;
    }
   

    public void MostrarTodosLosEmpleados()
    {
        Console.WriteLine($"\nEmpleados en la empresa {Nombre}:");
        if (ListaEmpleados.Count == 0)
        {
            Console.WriteLine("No hay empleados registrados.");
            return;
        }
        foreach (var empleado in ListaEmpleados)
        {
            empleado.MostrarInformacion();
        }
    }

    public bool ActualizarEmpleado(string numeroDeIdentificacion, string nuevoNombre, string nuevoApellido, byte nuevaEdad, string nuevaPosicion, double nuevoSalario)
    {
        var empleado = ListaEmpleados.FirstOrDefault(e => e.NumeroDeIdentificacion == numeroDeIdentificacion);
        if (empleado != null)
        {
            empleado.ActualizarDatos(nuevoNombre, nuevoApellido, nuevaEdad, nuevaPosicion, nuevoSalario);
            Console.WriteLine($"Empleado con ID {numeroDeIdentificacion} actualizado.");
            return true;
        }
        Console.WriteLine($"Empleado con ID {numeroDeIdentificacion} no encontrado.");
        return false;
    }

    public Persona BuscarEmpleado(string numeroDeIdentificacion)
    {
        var empleado = ListaEmpleados.FirstOrDefault(e => e.NumeroDeIdentificacion == numeroDeIdentificacion);
        if (empleado == null)
        {
            Console.WriteLine($"Empleado con ID {numeroDeIdentificacion} no encontrado.");
        }
        return empleado;
    }

    public void MostrarEmpleadosPorCargo(string cargo)
    {
        var empleadosPorCargo = ListaEmpleados.Where(e => e.Posicion.Equals(cargo, StringComparison.OrdinalIgnoreCase)).ToList();

        Console.WriteLine($"\nEmpleados con el cargo '{cargo}':");
        if (empleadosPorCargo.Count == 0)
        {
            Console.WriteLine("No se encontraron empleados con ese cargo.");
            return;
        }
        foreach (var empleado in empleadosPorCargo)
        {
            empleado.MostrarInformacion();
        }
        
    }
}
