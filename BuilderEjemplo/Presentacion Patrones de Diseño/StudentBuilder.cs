using System;

public class StudentBuilder : IPersonBuilder<Student>
{
    public string Nombre { get; private set; } = "";
    public string ApellidoPaterno { get; private set; } = "";
    public string ApellidoMaterno { get; private set; } = "";
    public string Matricula { get; private set; } = "";
    public string Email { get; private set; } = "";
    public DateTime FechaCreacion { get; private set; }

    public StudentBuilder()
    {
        Reset();
    }

    public void Reset()
    {
        Nombre = "";
        ApellidoPaterno = "";
        ApellidoMaterno = "";
        Matricula = "";
        Email = "";
        FechaCreacion = default;
    }
    public StudentBuilder SetNombre(string nombre)
    {
        Nombre = nombre;
        return this;
    }

    public StudentBuilder SetApellidoPaterno(string apellidoPaterno)
    {
        ApellidoPaterno = apellidoPaterno;
        return this;
    }

    public StudentBuilder SetApellidoMaterno(string apellidoMaterno)
    {
        ApellidoMaterno = apellidoMaterno;
        return this;
    }

    public StudentBuilder SetMatricula(string matricula)
    {
        Matricula = matricula;
        return this;
    }

    public StudentBuilder SetEmail(string email)
    {
        Email = email;
        return this;
    }

    public StudentBuilder SetFechaCreacion(DateTime fechaCreacion)
    {
        FechaCreacion = fechaCreacion;
        return this;
    }

    public Student Build()
    {
        if (FechaCreacion == default)
        {
            FechaCreacion = DateTime.Now;
        }

        Student student = new Student(this);

        Reset();

        return student;
    }
}