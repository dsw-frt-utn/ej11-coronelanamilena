using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un diccionario donde la clave sea el legajo y el valor el alumno
//Incluir un método para agregar un alumno al diccionario
//Incluir un método para buscar un alumno utilizando la clave
//Incluir un método para retornar el diccionario
//Incluir un método para eliminar un alumno utilizando la clave
public class CasoDictionary
{
    private Dictionary<int, Alumno> alumnosDiccionario = new Dictionary<int, Alumno>();

    public void AgregarAlumno (Alumno nuevoAlumno)
    {
        alumnosDiccionario.Add(nuevoAlumno.Id, nuevoAlumno);
    }
    public Alumno? BuscarAlumnoLegajo (int legajo)
    {
        if (alumnosDiccionario.ContainsKey(legajo))
        { return alumnosDiccionario[legajo]; }

        return null;
    }

    public Dictionary<int,Alumno> RetornaDic ()
    {
        return alumnosDiccionario;
    }

    public bool EliminarAlumnoLegajo(int legajo)
    {
        return alumnosDiccionario.Remove(legajo);
    }

}
