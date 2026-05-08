using System;

namespace RefactoringGuru.DesignPatterns.AbstractFactory.Furniture
{
    // AbstractFactory declara métodos para la creación de productos (muebles)
    public interface IMueblesFactory
    {
        ISilla CreateSilla();

        IMesa CreateMesa();
    }

    // Concrete Factories implementan los métodos de creación
    // pero devolviendo productos concretos (estilo Minimalista)
    class MinimalistaFactory : IMueblesFactory
    {
        public ISilla CreateSilla()
        {
            return new SillaMinimalista();
        }

        public IMesa CreateMesa()
        {
            return new MesaMinimalista();
        }
    }

    // Cada ConcreteFactory construye productos de un tipo (estilo Victoriano)
    class VictorianaFactory : IMueblesFactory
    {
        public ISilla CreateSilla()
        {
            return new SillaVictoriana();
        }

        public IMesa CreateMesa()
        {
            return new MesaVictoriana();
        }
    }

    // Los productos base se representan como interfaces
    public interface ISilla
    {
        string Sentarse();
    }

    // Los Concrete Products implementan la base 
    class SillaMinimalista : ISilla
    {
        public string Sentarse()
        {
            return "Te has sentado en una silla minimalista de líneas rectas.";
        }
    }

    class SillaVictoriana : ISilla
    {
        public string Sentarse()
        {
            return "Te has sentado en una silla victoriana con terciopelo.";
        }
    }

    // La base indica las características primordiales del producto
    public interface IMesa
    {
        string ColocarPlato();

        // En nuestro ejemplo tenemos que los productos pertenecen a una categoría definida
        // por las fábricas concretas, pero también está la colaboración:
        string ColocarPlatoCercaDeSilla(ISilla collaborator);
    }

    // Los ConcreteProduct implementan los métodos abstractos de sus bases
    class MesaMinimalista : IMesa
    {
        public string ColocarPlato()
        {
            return "Has colocado un plato sobre una mesa de cristal minimalista.";
        }

        // Aquí se ilustra la compatibilidad brindada por la relación de los objetos base
        public string ColocarPlatoCercaDeSilla(ISilla collaborator)
        {
            var result = collaborator.Sentarse();

            return $"Mesa Minimalista: Colocando plato mientras ({result})";
        }
    }

    class MesaVictoriana : IMesa
    {
        public string ColocarPlato()
        {
            return "Has colocado un plato sobre una mesa de roble tallado victoriana.";
        }

        public string ColocarPlatoCercaDeSilla(ISilla collaborator)
        {
            var result = collaborator.Sentarse();

            return $"Mesa Victoriana: Colocando plato mientras ({result})";
        }
    }

    class Client
    {
        public void Main()
        {
            Console.WriteLine("--- Tienda de Muebles ---");
            Console.WriteLine("1. Minimalista");
            Console.WriteLine("2. Victoriano");
            Console.Write("Seleccione el estilo de su habitación: ");
            
            string opcion = Console.ReadLine();
            IMueblesFactory factory = null;

            // El switch decide qué fábrica concreta utilizar según la elección
            switch (opcion)
            {
                case "1":
                    factory = new MinimalistaFactory();
                    break;
                case "2":
                    factory = new VictorianaFactory();
                    break;
                default:
                    Console.WriteLine("Opción no válida, usando Minimalista por defecto.");
                    factory = new MinimalistaFactory();
                    break;
            }

            Console.WriteLine("\nClient: Configurando la habitación con la fábrica seleccionada...");
            ClientMethod(factory);
        }

        public void ClientMethod(IMueblesFactory factory)
        {
            var silla = factory.CreateSilla();
            var mesa = factory.CreateMesa();

            Console.WriteLine(mesa.ColocarPlato());
            Console.WriteLine(mesa.ColocarPlatoCercaDeSilla(silla));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            new Client().Main();
        }
    }
}
