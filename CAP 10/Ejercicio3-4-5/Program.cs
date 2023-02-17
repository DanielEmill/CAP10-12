
internal class Program
    {
        static void Main(string[] args)
        {
            Poligono poligono1 = new Poligono(4, 5.6);
            System.Console.WriteLine(poligono1.ToString());
            Poligono poligono2 = new Poligono(7, 6.86);
            System.Console.WriteLine(poligono2.ToString());
        }
    }
public class Poligono
{
    private int lados;
    private double longitudLado;

    public Poligono(int lado, double longitud)
    {
        if (lado < 3)
        {
            System.Console.WriteLine("El polígono debe tener al menos 3 lados");
        }
        if (longitud <= 0)
        {
            System.Console.WriteLine("La longitud de los lados debe ser positiva");
        }
        else if(lado > 3 && longitud > 0){  
            this.lados = lado;
            this.longitudLado = longitud;
        }

    }
    public override string ToString()
    {
        String mensaje = "";
        mensaje = ($"Polígono de {lados} lados, cada uno de longitud {longitudLado}");
        return mensaje;
    }

}