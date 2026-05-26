using System;

    public interface ISilla
    {
        string Sentarse();
        string GetDetalles();
    }

    public interface IMesa
    {
        string ColocarPlato();
        string GetDetalles();
    }

    public class SillaMinimalista : ISilla
    {
        public string Material { get; set; } = string.Empty;
        public string Color { get; set; } = string.Empty;

        public string Sentarse() => "Te has sentado en una silla minimalista.";
        public string GetDetalles() => $"Silla Minimalista de {Material}, color {Color}.";
    }

    public class MesaMinimalista : IMesa
    {
        public string Material { get; set; } = string.Empty;
        public int Patas { get; set; }

        public string ColocarPlato() => "Plato en mesa de cristal.";
        public string GetDetalles() => $"Mesa Minimalista de {Material} con {Patas} patas.";
    }

    public class SillaVictoriana : ISilla
    {
        public string TipoMadera { get; set; } = string.Empty;
        public bool TapizadoTerciopelo { get; set; }

        public string Sentarse() => "Te has sentado en una silla victoriana.";
        public string GetDetalles() => $"Silla Victoriana de {TipoMadera}{(TapizadoTerciopelo ? " con tapizado de terciopelo" : " sin tapizado")}.";
    }

    public class MesaVictoriana : IMesa
    {
        public string TipoMadera { get; set; } = string.Empty;
        public bool DetallesTallados { get; set; }

        public string ColocarPlato() => "Plato en mesa de roble tallado.";
        public string GetDetalles() => $"Mesa Victoriana de {TipoMadera}{(DetallesTallados ? " con acabados tallados a mano" : " lisa")}.";
    }

    public interface IMuebleBuilder<T>
    {
        void Reset();
        T Build();
    }

    public class SillaMinimalistaBuilder : IMuebleBuilder<SillaMinimalista>
    {
        private SillaMinimalista silla = new SillaMinimalista();

        public void Reset() => silla = new SillaMinimalista();

        public SillaMinimalistaBuilder SetMaterial(string material)
        {
            silla.Material = material;
            return this;
        }

        public SillaMinimalistaBuilder SetColor(string color)
        {
            silla.Color = color;
            return this;
        }

        public SillaMinimalista Build()
        {
            var result = silla;
            Reset();
            return result;
        }
    }

    public class MesaMinimalistaBuilder : IMuebleBuilder<MesaMinimalista>
    {
        private MesaMinimalista mesa = new MesaMinimalista();

        public void Reset() => mesa = new MesaMinimalista();

        public MesaMinimalistaBuilder SetMaterial(string material)
        {
            mesa.Material = material;
            return this;
        }

        public MesaMinimalistaBuilder SetPatas(int patas)
        {
            mesa.Patas = patas;
            return this;
        }

        public MesaMinimalista Build()
        {
            var result = mesa;
            Reset();
            return result;
        }
    }

    public class SillaVictorianaBuilder : IMuebleBuilder<SillaVictoriana>
    {
        private SillaVictoriana silla = new SillaVictoriana();

        public void Reset() => silla = new SillaVictoriana();

        public SillaVictorianaBuilder SetTipoMadera(string madera)
        {
            silla.TipoMadera = madera;
            return this;
        }

        public SillaVictorianaBuilder SetTapizado(bool tapizado)
        {
            silla.TapizadoTerciopelo = tapizado;
            return this;
        }

        public SillaVictoriana Build()
        {
            var result = silla;
            Reset();
            return result;
        }
    }

    public class MesaVictorianaBuilder : IMuebleBuilder<MesaVictoriana>
    {
        private MesaVictoriana mesa = new MesaVictoriana();

        public void Reset() => mesa = new MesaVictoriana();

        public MesaVictorianaBuilder SetTipoMadera(string madera)
        {
            mesa.TipoMadera = madera;
            return this;
        }

        public MesaVictorianaBuilder SetDetallesTallados(bool tallado)
        {
            mesa.DetallesTallados = tallado;
            return this;
        }

        public MesaVictoriana Build()
        {
            var result = mesa;
            Reset();
            return result;
        }
    }

    public interface IMueblesFactory
    {
        ISilla CreateSilla();
        IMesa CreateMesa();
    }

    public class MinimalistaFactory : IMueblesFactory
    {
        public ISilla CreateSilla()
        {
            return new SillaMinimalistaBuilder()
                .SetMaterial("Aluminio y Plástico")
                .SetColor("Blanco Mate")
                .Build();
        }

        public IMesa CreateMesa()
        {
            return new MesaMinimalistaBuilder()
                .SetMaterial("Cristal Templado")
                .SetPatas(1)
                .Build();
        }
    }

    public class VictorianaFactory : IMueblesFactory
    {
        public ISilla CreateSilla()
        {
            return new SillaVictorianaBuilder()
                .SetTipoMadera("Caoba")
                .SetTapizado(true)
                .Build();
        }

        public IMesa CreateMesa()
        {
            return new MesaVictorianaBuilder()
                .SetTipoMadera("Roble Oscuro")
                .SetDetallesTallados(true)
                .Build();
        }
    }

    public class Client
    {
        public void Main()
        {
            Console.WriteLine("--- Tienda de Muebles ---");
            Console.WriteLine("1. Minimalista");
            Console.WriteLine("2. Victoriano");
            Console.Write("Seleccione el estilo de su habitación: ");

            string opcion = Console.ReadLine() ?? string.Empty;
            IMueblesFactory factory;

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

            Console.WriteLine("\nClient: Obteniendo muebles de la fábrica...\n");
            ClientMethod(factory);
        }

        public void ClientMethod(IMueblesFactory factory)
        {
            var silla = factory.CreateSilla();
            var mesa = factory.CreateMesa();

            Console.WriteLine(silla.GetDetalles());
            Console.WriteLine(mesa.GetDetalles());
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            new Client().Main();
        }
    }
