using Dsw2026Ej11.Domain;
using System.Diagnostics;


namespace Dsw2026Ej11.Collections;

//Crear un campo que represente una lista de alumnos (List<>)
//Incluir un método para agregar alumnos a la lista
//Incluir un método para retornar la lista
//Incluir un método para buscar un alumno por nombre
//Incluir un método para eliminar un alumno (debe recibir un alumno)
//Incluir un método para eliminar un alumno en una determinada posición de la lista
public class CasoList
{
    private List<Alumno> alumnos = new List<Alumno>();
  
   

public void AgregarAlumno (Alumno nuevoAlumno)
    {
        alumnos.Add(nuevoAlumno);
    }

public List<Alumno> RetornaLista()
    {
        return alumnos;
    }

    public Alumno BuscarAlumno(string nombre) => alumnos.Find(alumno => alumno.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));


    public bool EliminarAlumno (Alumno alumnoEliminar)
    {
        return alumnos.Remove(alumnoEliminar);
    }

public void EliminarAlumnoPosicion(int posicion)
    {
        if (posicion >= 0 && posicion < alumnos.Count)
        {
            alumnos.RemoveAt(posicion);
        }
        
    }


}