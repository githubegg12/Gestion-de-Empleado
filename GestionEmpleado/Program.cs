// See https://aka.ms/new-console-template for more information

using GestionEmpleado;

// Crear empleados
Persona emp1 = new Persona("Juan", "Perez", "12345678", 30, "Desarrollador", 2500);
Persona emp2 = new Persona("Ana", "Gomez", "87654321", 28, "Analista", 2300);

// Crear empresa
Empresa empresa = new Empresa("Tech Solutions", "Calle Falsa 123");

// Agregar empleados
empresa.AgregarEmpleado(emp1);
empresa.AgregarEmpleado(emp2);

// Mostrar empleados
empresa.ListaEmpleado.ForEach(e => e.MostrarInformacion());
