using System;


    public interface IRecord
    {
        string GetFullName();
        string GetEmail();
        string GetState();
        string GetPhoneNumber();
        DateTime GetCreatedAt();
    }

    public class PersonDirector
    {
        public Person CreateCompletePerson(
            string name,
            string paternalLastName,
            string maternalLastName,
            string email,
            string state,
            string phoneNumber)
        {
            return new Person.PersonBuilder()
                .SetName(name)
                .SetPaternalLastName(paternalLastName)
                .SetMaternalLastName(maternalLastName)
                .SetEmail(email)
                .SetState(state)
                .SetPhoneNumber(phoneNumber)
                .SetCreatedAt(DateTime.Now)
                .Build();
        }

        public Person CreateBasicPerson(
            string name,
            string paternalLastName,
            string email)
        {
            return new Person.PersonBuilder()
                .SetName(name)
                .SetPaternalLastName(paternalLastName)
                .SetEmail(email)
                .SetState("No especificado")
                .SetPhoneNumber("Sin teléfono")
                .SetCreatedAt(DateTime.Now)
                .Build();
        }
    }

    public class Person : IRecord
    {
        private readonly string name;
        private readonly string paternalLastName;
        private readonly string maternalLastName;
        private readonly string email;
        private readonly string state;
        private readonly string phoneNumber;
        private readonly DateTime createdAt;

        private Person(PersonBuilder builder)
        {
            name = builder.Name ?? string.Empty;
            paternalLastName = builder.PaternalLastName ?? string.Empty;
            maternalLastName = builder.MaternalLastName ?? string.Empty;
            email = builder.Email ?? string.Empty;
            state = builder.State ?? string.Empty;
            phoneNumber = builder.PhoneNumber ?? string.Empty;
            createdAt = builder.CreatedAt;
        }

        public string GetFullName()
        {
            if (string.IsNullOrWhiteSpace(maternalLastName))
            {
                return $"{name} {paternalLastName}";
            }
            return $"{name} {paternalLastName} {maternalLastName}";
        }

        public string GetEmail() => email;
        public string GetState() => state;
        public string GetPhoneNumber() => phoneNumber;
        public DateTime GetCreatedAt() => createdAt;

        // BUILDER INTERNO (ConcreteBuilder)
        public class PersonBuilder
        {
            public string? Name { get; private set; }
            public string? PaternalLastName { get; private set; }
            public string? MaternalLastName { get; private set; }
            public string? Email { get; private set; }
            public string? State { get; private set; }
            public string? PhoneNumber { get; private set; }
            public DateTime CreatedAt { get; private set; }

            public PersonBuilder SetName(string name)
            {
                Name = name;
                return this;
            }

            public PersonBuilder SetPaternalLastName(string paternalLastName)
            {
                PaternalLastName = paternalLastName;
                return this;
            }

            public PersonBuilder SetMaternalLastName(string maternalLastName)
            {
                MaternalLastName = maternalLastName;
                return this;
            }

            public PersonBuilder SetEmail(string email)
            {
                Email = email;
                return this;
            }

            public PersonBuilder SetState(string state)
            {
                State = state;
                return this;
            }

            public PersonBuilder SetPhoneNumber(string phoneNumber)
            {
                PhoneNumber = phoneNumber;
                return this;
            }

            public PersonBuilder SetCreatedAt(DateTime createdAt)
            {
                CreatedAt = createdAt;
                return this;
            }

            // Esto es como el exodia manifiestate
            public Person Build()
            {
                if (CreatedAt == default)
                {
                    CreatedAt = DateTime.Now;
                }

                if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(PaternalLastName))
                {
                    throw new InvalidOperationException("El nombre y el apellido paterno son obligatorios.");
                }

                return new Person(this);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            PersonDirector director = new PersonDirector();

            // 1. Cliente solicita una construcción básica al Director
            Person basicPerson = director.CreateBasicPerson(
                "José",
                "Contreras",
                "jose@gmail.com"
            );

            // 2. Cliente solicita una construcción completa al Director
            Person completePerson = director.CreateCompletePerson(
                "María",
                "López",
                "Hernández",
                "maria@gmail.com",
                "Veracruz",
                "2281234567"
            );

            Console.WriteLine("=== BUILD DE 2 PERSONAS ===");
            Console.WriteLine("\nPERSONA BÁSICA:");
            Console.WriteLine("-------------------");
            Console.WriteLine("Nombre:   " + basicPerson.GetFullName());
            Console.WriteLine("Correo:   " + basicPerson.GetEmail());
            Console.WriteLine("Estado:   " + basicPerson.GetState());
            Console.WriteLine("Teléfono: " + basicPerson.GetPhoneNumber());
            Console.WriteLine("Fecha:    " + basicPerson.GetCreatedAt());

            Console.WriteLine("\nPERSONA COMPLETA:");
            Console.WriteLine("-------------------");
            Console.WriteLine("Nombre:   " + completePerson.GetFullName());
            Console.WriteLine("Correo:   " + completePerson.GetEmail());
            Console.WriteLine("Estado:   " + completePerson.GetState());
            Console.WriteLine("Teléfono: " + completePerson.GetPhoneNumber());
            Console.WriteLine("Fecha:    " + completePerson.GetCreatedAt());

            Console.WriteLine("\n===========================================");
            Console.WriteLine("CREA UNA TERCERA PERSONA");
            Console.WriteLine("===========================================");

            Person.PersonBuilder dynamicBuilder = new Person.PersonBuilder();

            // Datos obligatorios
            string name = "";
            while (string.IsNullOrWhiteSpace(name))
            {
                Console.Write("Ingrese Nombre (OBLIGATORIO): ");
                name = Console.ReadLine() ?? "";
            }
            dynamicBuilder.SetName(name);

            string paternalLastName = "";
            while (string.IsNullOrWhiteSpace(paternalLastName))
            {
                Console.Write("Ingrese Apellido Paterno (OBLIGATORIO): ");
                paternalLastName = Console.ReadLine() ?? "";
            }
            dynamicBuilder.SetPaternalLastName(paternalLastName);

            // Datos opcionales
            Console.Write("Ingrese Apellido Materno (Opcional - Enter para saltar): ");
            string maternalLastName = Console.ReadLine() ?? "";
            if (!string.IsNullOrWhiteSpace(maternalLastName)) dynamicBuilder.SetMaternalLastName(maternalLastName);

            Console.Write("Ingrese Correo (Opcional - Enter para saltar): ");
            string email = Console.ReadLine() ?? "";
            if (!string.IsNullOrWhiteSpace(email)) dynamicBuilder.SetEmail(email);

            Console.Write("Ingrese Estado (Opcional - Enter para saltar): ");
            string state = Console.ReadLine() ?? "";
            if (!string.IsNullOrWhiteSpace(state)) dynamicBuilder.SetState(state);

            Console.Write("Ingrese Teléfono (Opcional - Enter para saltar): ");
            string phone = Console.ReadLine() ?? "";
            if (!string.IsNullOrWhiteSpace(phone)) dynamicBuilder.SetPhoneNumber(phone);

            Person customPerson = dynamicBuilder.Build();

            Console.WriteLine("\nPERSONA CREADA DINÁMICAMENTE:");
            Console.WriteLine("-------------------");
            Console.WriteLine("Nombre:   " + (string.IsNullOrWhiteSpace(customPerson.GetFullName()) ? "No especificado" : customPerson.GetFullName()));
            Console.WriteLine("Correo:   " + (string.IsNullOrWhiteSpace(customPerson.GetEmail()) ? "No especificado" : customPerson.GetEmail()));
            Console.WriteLine("Estado:   " + (string.IsNullOrWhiteSpace(customPerson.GetState()) ? "No especificado" : customPerson.GetState()));
            Console.WriteLine("Teléfono: " + (string.IsNullOrWhiteSpace(customPerson.GetPhoneNumber()) ? "No especificado" : customPerson.GetPhoneNumber()));
            Console.WriteLine("Fecha:    " + customPerson.GetCreatedAt());
        }
    }