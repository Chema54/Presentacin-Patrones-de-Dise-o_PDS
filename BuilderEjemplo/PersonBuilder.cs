using System;

public class PersonBuilder : IPersonBuilder<Person>
{
    public string Nombre { get; private set; } = "";
    public string ApellidoPaterno { get; private set; } = "";
    public string ApellidoMaterno { get; private set; } = "";
    public string Email { get; private set; } = "";
    public string Telefono { get; private set; } = "";
    public DateTime FechaCreacion { get; private set; }

    public PersonBuilder()
    {
        Reset();
    }

    public void Reset()
    {
        Nombre = "";
        ApellidoPaterno = "";
        ApellidoMaterno = "";
        Email = "";
        Telefono = "";
        FechaCreacion = default;
    }
    public PersonBuilder SetNombre(string nombre)
    {
        Nombre = nombre;
        return this;
    }

    public PersonBuilder SetApellidoPaterno(string apellidoPaterno)
    {
        ApellidoPaterno = apellidoPaterno;
        return this;
    }

    public PersonBuilder SetApellidoMaterno(string apellidoMaterno)
    {
        ApellidoMaterno = apellidoMaterno;
        return this;
    }

    public PersonBuilder SetEmail(string email)
    {
        Email = email;
        return this;
    }

    public PersonBuilder SetTelefono(string telefono)
    {
        Telefono = telefono;
        return this;
    }

    public PersonBuilder SetFechaCreacion(DateTime fechaCreacion)
    {
        FechaCreacion = fechaCreacion;
        return this;
    }

    public Person Build()
    {
        if (FechaCreacion == default)
        {
            FechaCreacion = DateTime.Now;
        }

        Person person = new Person(this);

        Reset();

        return person;
    }
}