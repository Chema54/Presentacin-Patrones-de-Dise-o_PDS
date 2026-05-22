public class Student
{
    private readonly string nombre;
    private readonly string apellidoPaterno;
    private readonly string apellidoMaterno;
    private readonly string matricula;
    private readonly string email;
    private readonly DateTime fechaCreacion;

    public Student(StudentBuilder builder)
    {
        nombre = builder.Nombre;
        apellidoPaterno = builder.ApellidoPaterno;
        apellidoMaterno = builder.ApellidoMaterno;
        matricula = builder.Matricula;
        email = builder.Email;
        fechaCreacion = builder.FechaCreacion;
    }

    public string GetNombreCompleto()
    {
        if (string.IsNullOrWhiteSpace(apellidoMaterno))
        {
            return $"{nombre} {apellidoPaterno}";
        }
        return $"{nombre} {apellidoPaterno} {apellidoMaterno}";
    }

    public string GetMatricula()
    {
        return matricula;
    }

    public string GetEmail()
    {
        return email;
    }

    public DateTime GetFechaCreacion()
    {
        return fechaCreacion;
    }
}