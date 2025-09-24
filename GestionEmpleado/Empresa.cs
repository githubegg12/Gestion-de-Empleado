namespace GestionEmpleado;

public class Empresa
{
    String Nombre {get; set;}
    String Direccion {get; set;}
    public List<Empleado> ListaEmpleados { get; private set; } 
    public List<Cliente> ListaClientes { get; private set; }
    public Empresa(string nombre, string direccion)
    {
        Nombre = nombre;
        Direccion = direccion;
        ListaClientes = new List<Cliente>();
        ListaEmpleados = new List<Empleado>();
    }

    public void AgregarEmpleado(Empleado empleado)
    {
        ListaEmpleados.Add(empleado);
        Console.WriteLine($"Empleado {empleado.Nombre} {empleado.Apellido} agregado.");
    }

    public bool EliminarEmpleado(string nombre, string apellido)
    {
        var empleado = ListaEmpleados.FirstOrDefault(e =>
            e.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase) &&
            e.Apellido.Equals(apellido, StringComparison.OrdinalIgnoreCase));

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

        if (!ListaEmpleados.Any())
        {
            Console.WriteLine("No hay empleados registrados.");
            return;
        }

        foreach (var empleado in ListaEmpleados)
        {
            empleado.MostrarInformacion();
        }
    }

    public bool ActualizarEmpleado(string nuevoNombre,string nuevoApellido, string nuevaEdad, 
        string numeroDeIdentificacionActual, string nuevoNumeroDeIdentificacion, string nuevaPosicion, double nuevoSalario)
    {
        var empleado = ListaEmpleados.FirstOrDefault(e =>
            e.NumeroDeIdentificacion.Equals(numeroDeIdentificacionActual, StringComparison.OrdinalIgnoreCase));

        if (empleado != null)
        {
            empleado.ActualizarDatos(nuevoNombre,nuevoApellido,nuevaEdad,nuevoNumeroDeIdentificacion, nuevaPosicion, nuevoSalario);
            Console.WriteLine($"✅ Empleado con ID {numeroDeIdentificacionActual} actualizado.");
            return true;
        }

        Console.WriteLine($"⚠️ Empleado con ID {numeroDeIdentificacionActual} no encontrado.");
        return false;
    }

    public Empleado BuscarEmpleado(string numeroDeIdentificacion)
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
        var empleadosPorCargo = ListaEmpleados
            .Where(e => e.Posicion.Equals(cargo, StringComparison.OrdinalIgnoreCase))
            .ToList();

        Console.WriteLine($"\nEmpleados con el cargo '{cargo}':");

        if (!empleadosPorCargo.Any())
        {
            Console.WriteLine("No se encontraron empleados con ese cargo.");
            return;
        }

        foreach (var empleado in empleadosPorCargo)
        {
            empleado.MostrarInformacion();
        }
    }

    public void AgregarCliente(Cliente cliente)
    {
        ListaClientes.Add(cliente);
        Console.WriteLine($"Cliente {cliente.Nombre} {cliente.Apellido} agregado.");

    }
    
    public bool EliminarCliente(string nombre, string apellido)
    {
        var cliente = ListaClientes.FirstOrDefault(e =>
            e.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase) &&
            e.Apellido.Equals(apellido, StringComparison.OrdinalIgnoreCase));

        if (cliente != null)
        {
            ListaClientes.Remove(cliente);
            Console.WriteLine($"Cliente {nombre} {apellido} eliminado.");
            return true;
        }

        Console.WriteLine($"Cliente {nombre} {apellido} no encontrado.");
        return false;
    }

    public void MostrarTodosLosClientes()
    {
        Console.WriteLine($"\nClientes en la empresa {Nombre}:");

        if (!ListaClientes.Any())
        {
            Console.WriteLine("No hay clientes registrados.");
            return;
        }

        foreach (var cliente in ListaClientes)
        {
            cliente.MostrarInformacion();
        }
    }

    
}


