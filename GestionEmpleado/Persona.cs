namespace GestionEmpleado;

public abstract class Persona
{
    public Guid Id { get; private set; }
    public String Nombre { get; private set; }
    public String Apellido { get; private set; }
    public String NumeroDeIdentificacion { get; private set; }
    public Byte Edad { get; private set; }


    public Persona(string nombre, string apellido, string numeroDeIdentificacion,byte edad)
    {
        Id = Guid.NewGuid();
        Nombre = nombre;
        Apellido = apellido;
        NumeroDeIdentificacion = numeroDeIdentificacion;
        Edad = edad;
    }
    public abstract void MostrarInformacion();

    public virtual void ActualizarDatos(string nombre, string apellido, string numeroIdentificacion, byte edad)
     {
        Nombre = nombre;
        Apellido = apellido;
        NumeroDeIdentificacion = numeroIdentificacion;
        Edad = edad;
    }
}

