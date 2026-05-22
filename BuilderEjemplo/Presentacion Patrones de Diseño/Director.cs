using System;

public class Director
{
    public Person CrearPersona()
    {
        return new PersonBuilder()
            .SetNombre("Jose Maria")
            .SetApellidoPaterno("Contreras")
            .SetApellidoMaterno("Mota")
            .SetEmail("correochema@gmail.com")
            .SetTelefono("2281874642")
            .SetFechaCreacion(DateTime.Now)
            .Build();
    }

    public Student CrearEstudiante()
    {
        return new StudentBuilder()
            .SetNombre("Lenin Jesus")
            .SetApellidoPaterno("Hernandez")
            .SetApellidoMaterno("Ramirez")
            .SetMatricula("S24012345")
            .SetEmail("zS24012345@estudiantes.uv.mx")
            .SetFechaCreacion(DateTime.Now)
            .Build();
    }
}