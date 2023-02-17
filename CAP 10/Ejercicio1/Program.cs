
    internal class Program
    {
        static void Main(string[] args)
        {
            inventario inventario1 = new inventario(5);
            inventario1.AgregarArticulo("Perfume", 5, 6.4);
            inventario1.AgregarArticulo("ropas", 5, 6.4);

            Console.WriteLine("Artículos en el inventario:");
            for (int i = 0; i < inventario1.Pos; i++)
            {
                Console.WriteLine(inventario1.NombreArticulo1[i] + " " + inventario1.CantidadArticulo1[i] + " " + inventario1.PreciArticulo1[i]);
            }

        }
        //Ejercicio1
        class inventario
        {
            private string[] NombreArticulo;
            private int[] CantidadArticulo;
            private Double[] PreciArticulo;
            private int pos;
            public inventario(int tam)
            {
                NombreArticulo = new string[tam];
                CantidadArticulo = new int[tam];
                PreciArticulo = new double[tam];
            }
            public string[] NombreArticulo1 { get => NombreArticulo; set => NombreArticulo = value; }
            public int[] CantidadArticulo1 { get => CantidadArticulo; set => CantidadArticulo = value; }
            public double[] PreciArticulo1 { get => PreciArticulo; set => PreciArticulo = value; }
            public int Pos { get => pos; set => pos = value; }
            public void AgregarArticulo(string nombre, int cantidad, double precio)
            {
                NombreArticulo[pos] = nombre;
                CantidadArticulo[pos] = cantidad;
                PreciArticulo[pos] = precio;
                pos++;
            }
        }
    }

