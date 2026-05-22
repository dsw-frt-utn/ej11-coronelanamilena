using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    
    public static void EjemploList()
    {
        CasoList gestorList = new CasoList();

        //Agregar 3 alumnos a la lista
        Alumno a1 = new Alumno(1, "Morena Garcia", 9.0);
        Alumno a2 = new Alumno(2, "Pablo Perez", 6.7);
        Alumno a3 = new Alumno(3, "Anastacia Lopez", 8.3);
        gestorList.AgregarAlumno(a1);
        gestorList.AgregarAlumno(a2);
        gestorList.AgregarAlumno(a3);

        //Listar por consola los alumnos
        Console.WriteLine("Lista de Alumnos");
        List<Alumno> listaActual = gestorList.RetornaLista();
        foreach (Alumno alumno in listaActual)
        {
            Console.WriteLine(alumno);
        }
        Console.WriteLine();

        //Buscar por nombre un alumno que exista y mostrar por consola
        Console.WriteLine("Buscando al alumno Anastacia Lopez");
        Alumno alumnoEncontrado = gestorList.BuscarAlumno("anastacia lopez");

        if (alumnoEncontrado != null)
            Console.WriteLine($"Encontrado: {alumnoEncontrado}");
        else 
            Console.WriteLine("No existe en el listado");
            Console.WriteLine();

        //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
        Console.WriteLine("Buscando al alumno Maria Marta Ruiz");
        Alumno alumnoInexistente = gestorList.BuscarAlumno("maria marta ruiz");

        if (alumnoInexistente != null)
        {
            Console.WriteLine($"Encontrado: {alumnoInexistente}");
        }
        else
            Console.WriteLine("No existe"); 
            Console.WriteLine();

        //Eliminar un alumno y listar por consola los alumnos
        Console.WriteLine("Eliminando al alumno Pablo Perez de la lista");
        gestorList.EliminarAlumno(a2);

        foreach (Alumno alumno in gestorList.RetornaLista())
        {
            Console.WriteLine(alumno);
        }
        Console.WriteLine();

        //Eliminar el primer elemento de la lista y listar por consola los alumnos
        Console.WriteLine("Eliminando al primer alumno del listado");
        gestorList.EliminarAlumnoPosicion(0); 

        foreach (Alumno alumno in gestorList.RetornaLista())
        { Console.WriteLine(alumno); }

    }

    public static void EjemploDictionary()
    {
        CasoDictionary gestorD = new CasoDictionary();
        //Agregar 3 alumnos al diccionario
        Alumno a1 = new Alumno(245, "Mariana Gomez", 6.0);
        Alumno a2 = new Alumno(246, "Leandro Miranda", 8.7);
        Alumno a3 = new Alumno(247, "Ana Moron", 7.3);
        gestorD.AgregarAlumno(a1);
        gestorD.AgregarAlumno(a2);
        gestorD.AgregarAlumno(a3);

        //Listar por consola los alumnos
        Dictionary<int, Alumno> diccionarioActual = gestorD.RetornaDic();
        foreach (KeyValuePair<int, Alumno> par in diccionarioActual)

        { Console.WriteLine($"Legajo: {par.Key}- Alumno: {par.Value}"); }

        Console.WriteLine();

        //Buscar un alumno por clave y mostrar por consola
        Console.WriteLine("Buscando alumno con legajo '247'");
        int legajoBuscado = 247;
        Alumno? alumnoEncontrado = gestorD.BuscarAlumnoLegajo(legajoBuscado);

        if (alumnoEncontrado != null)
        {
            Console.WriteLine($"Encontrado: {alumnoEncontrado}");
        }
        else
        {
            Console.WriteLine("No existe alumno con el legajo ingresado");
        }
        Console.WriteLine();

        //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
        Console.WriteLine("Buscando alumno con legajo '249'");
        int legajoInexistente = 249;
        Alumno? alumnoInexistente = gestorD.BuscarAlumnoLegajo(legajoInexistente);

        if (alumnoInexistente!= null)
        {  Console.WriteLine($"Encontrado: {alumnoInexistente}");  }
        else
        {
            Console.WriteLine("No existe");
        }
        Console.WriteLine();

        //Eliminar un alumno por clave y listar por consola los alumnos
        Console.WriteLine("Eliminando al alumno con legajo '246' ");
        gestorD.EliminarAlumnoLegajo(246);
        foreach (KeyValuePair<int, Alumno> par in gestorD.RetornaDic())
    {
            Console.WriteLine($"Legajo: {par.Key}- Alumno: {par.Value}");
        }

    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        CasoLinq gestorLinq = new CasoLinq();

        Console.WriteLine("Primer Libro");
        Libro primerLibro = gestorLinq.GetPrimero();
        Console.WriteLine($"Título: {primerLibro?.Titulo} - Precio: {primerLibro?.Precio:C}\n");

        Console.WriteLine("Último Libro");
        Libro ultimoLibro = gestorLinq.GetUltimo();
        Console.WriteLine($"Título: {ultimoLibro?.Titulo} - Precio: {ultimoLibro?.Precio:C}\n");

        Console.WriteLine("Suma total de Precios");
        decimal total = (decimal)gestorLinq.GetTotalPrecios();
        Console.WriteLine($"Total de toda la librería: {total:C}\n");

        Console.WriteLine("Promedio de Precios");
        decimal promedio = (decimal)gestorLinq.GetPromedioPrecios();
        Console.WriteLine($"Promedio de precios es de: {promedio:C}\n");

        Console.WriteLine("Libros con Id mayor a 15");
        List<Libro> librosMayor15 = gestorLinq.GetListById();
        foreach (var libro in librosMayor15)
        {
            Console.WriteLine($"[Id: {libro.Id}] - Título: {libro.Titulo}");
        }
        Console.WriteLine();

        Console.WriteLine("Libros Formateados");
        List<string> textosLibros = gestorLinq.GetLibros();
        foreach (var texto in textosLibros)
        {
            Console.WriteLine(texto);
        }
        Console.WriteLine();

        Console.WriteLine("Libro más Caro");
        Libro masCaro = gestorLinq.GetMayorPrecio();
        Console.WriteLine($"Título: {masCaro?.Titulo} - Precio: {masCaro?.Precio:C}\n");

        Console.WriteLine("Libro más Barato");
        Libro masBarato = gestorLinq.GetMenorPrecio();
        Console.WriteLine($"Título: {masBarato?.Titulo} - Precio: {masBarato?.Precio:C}\n");
        
        Console.WriteLine("Libros con precio Mayor al Promedio");
        List<Libro> librosCaros = gestorLinq.GetMayorPromedio();
        foreach (var libro in librosCaros)
        {
            Console.WriteLine($"- {libro.Titulo} ({libro.Precio:C})");
        }
        Console.WriteLine();

        Console.WriteLine("Libros Ordenados por Título (de Z a la A)");
        List<Libro> librosOrdenados = gestorLinq.GetOrdenadosPorTituloDescendente();
        foreach (var libro in librosOrdenados)
        {
            Console.WriteLine($"- {libro.Titulo}");
        }












    }
}
