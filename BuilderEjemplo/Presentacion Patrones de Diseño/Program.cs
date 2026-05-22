using System;

public class Program
{
    public static void Main(string[] args)
    {
        Director director = new Director();

        Person persona = director.CrearPersona();
        Student estudiante = director.CrearEstudiante();

        Console.WriteLine("=== PERSONA COMUN ===");
        Console.WriteLine("Nombre: " + persona.GetNombreCompleto());
        Console.WriteLine("Email: " + persona.GetEmail());
        Console.WriteLine("Telefono: " + persona.GetTelefono());
        Console.WriteLine("Fecha Creacion: " + persona.GetFechaCreacion());

        Console.WriteLine();

        Console.WriteLine("=== ESTUDIANTE ===");
        Console.WriteLine("Nombre: " + estudiante.GetNombreCompleto());
        Console.WriteLine("Matricula: " + estudiante.GetMatricula());
        Console.WriteLine("Email: " + estudiante.GetEmail());
        Console.WriteLine("FechaCreacion: " + estudiante.GetFechaCreacion());
    }
}