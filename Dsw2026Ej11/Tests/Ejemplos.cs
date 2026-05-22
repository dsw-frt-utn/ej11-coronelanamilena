using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    
    public static void EjemploList()
    {
        CasoList gestor = new CasoList();

        //Agregar 3 alumnos a la lista
        Alumno a1 = new Alumno(1, "Morena Garcia", 9.0);
        Alumno a2 = new Alumno(2, "Pablo Perez", 6.7);
        Alumno a3 = new Alumno(3, "Anastacia Lopez", 8.3);
        gestor.AgregarAlumno(a1);
        gestor.AgregarAlumno(a2);
        gestor.AgregarAlumno(a3);

        //Listar por consola los alumnos
        Console.WriteLine("Lista de Alumnos");
        List<Alumno> listaActual = gestor.RetornaLista();
        foreach (Alumno alumno in listaActual)
        {
            Console.WriteLine(alumno);
        }
        Console.WriteLine();

        //Buscar por nombre un alumno que exista y mostrar por consola
        Console.WriteLine("Buscando al alumno Anastacia Lopez");
        Alumno alumnoEncontrado = gestor.BuscarAlumno("anastacia lopez");

        if (alumnoEncontrado != null)
            Console.WriteLine($"Encontrado: {alumnoEncontrado}");
        else 
            Console.WriteLine("No existe en el listado");
            Console.WriteLine();

        //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
        Console.WriteLine("Buscando al alumno Maria Marta Ruiz");
        Alumno alumnoInexistente = gestor.BuscarAlumno("maria marta ruiz");

        if (alumnoInexistente != null)
        {
            Console.WriteLine($"Encontrado: {alumnoInexistente}");
        }
        else
            Console.WriteLine("No existe"); 
            Console.WriteLine();

        //Eliminar un alumno y listar por consola los alumnos
        Console.WriteLine("Eliminando al alumno Pablo Perez de la lista");
        gestor.EliminarAlumno(a2);

        foreach (Alumno alumno in gestor.RetornaLista())
        {
            Console.WriteLine(alumno);
        }
        Console.WriteLine();

        //Eliminar el primer elemento de la lista y listar por consola los alumnos
        Console.WriteLine("Eliminando al primer alumno del listado");
        gestor.EliminarAlumnoPosicion(0); 

        foreach (Alumno alumno in gestor.RetornaLista())
        { Console.WriteLine(alumno); }

    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {

    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {

    }
}
