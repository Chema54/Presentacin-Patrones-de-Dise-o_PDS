using System;

public class Person
{
    private readonly string nombre;
    private readonly string apellidoPaterno;
    private readonly string apellidoMaterno;
    private readonly string email;
    private readonly string telefono;
    private readonly DateTime fechaCreacion;

    public Person(PersonBuilder builder)
    {
        nombre = builder.Nombre;
        apellidoPaterno = builder.ApellidoPaterno;
        apellidoMaterno = builder.ApellidoMaterno;
        email = builder.Email;
        telefono = builder.Telefono;
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

    public string GetEmail()
    {
        return email;
    }

    public string GetTelefono()
    {
        return telefono;
    }

    public DateTime GetFechaCreacion()
    {
        return fechaCreacion;
    }
}