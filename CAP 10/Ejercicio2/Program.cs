
    internal class Program
    {
        static void Main(string[] args)
        {
            RegistroEstudiante registro1 = new RegistroEstudiante(5);
            registro1.AgregarEstudiante("Emill" , "4A");
            registro1.printEstudiante();
            

        }
        //Ejercicio2
        class RegistroEstudiante
        {
            private string[] Nombre;
            private string[] Grado;
            private int pos;
            public RegistroEstudiante(int tam)
            {
                Nombre = new string[tam];
                Grado = new string[tam];
                pos = 0;
            }
            public void AgregarEstudiante(string nombre, string grado)
            {
                Nombre[pos] = nombre;
                Grado[pos] = grado;
                pos++;
            }
            public void printEstudiante(){
            for (int i = 0; i < pos; i++)
            {
                Console.WriteLine(Nombre[i] + " " + Grado[i] + " ");
            }
            }
        }
    }
