namespace GestionEmpleado;

public abstract class Persona
{
    public String Nombre { get; private set; }
    public String Apellido { get; private set; }
    public Byte Edad { get; private set; }


    public Persona(string nombre, string apellido,byte edad)
    {
        Nombre = nombre;
        Apellido = apellido;
        Edad = edad;
    }
    public abstract void MostrarInformacion();

    public virtual void ActualizarDatos(string nombre, string apellido, byte edad)
     {
        Nombre = nombre;
        Apellido = apellido;
        Edad = edad;
    }
}

