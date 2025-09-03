using System.Security.Cryptography.X509Certificates;
using Actividad_1_MP;

public class Program
{
    // Ejercicio 5 - Implementar funcion Llenar

    private static Random unicoRandomGlobal = new Random();
    public static void Llenar(Coleccionable col)
    {
        for (int i = 0; i < 20; i++) {

            int valor = unicoRandomGlobal.Next(1,100);
            Comparable com = new Numero(valor);
            col.Agregar(com);
        }

    }

    public static string GenerarString(int longitud)
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        Random rnd = new Random();
        char[] buffer = new char[longitud];

        for (int i = 0; i < longitud; i++)
        {
            buffer[i] = chars[rnd.Next(chars.Length)];
        }

        return new string(buffer);
    }

    // Ejercicio 6 - Implementar funcion informar 
    public static void Informar(Coleccionable c)
    {
        System.Console.WriteLine(c.Cuantos());
        System.Console.WriteLine(c.Minimo());
        System.Console.WriteLine(c.Maximo());

        Console.WriteLine("Por favor ingrese un numero: ");
        int num = int.Parse(Console.ReadLine());
        Comparable com = new Numero(num);

        if (c.Contiene(com)) { Console.WriteLine("El elemento ya se encuentra en la coleccion"); }
        else { Console.WriteLine("El elemento no se encuentra en la coleccion"); }

    }

    public static void LlenarAlumnos(Coleccionable c)
    {
        for (int i = 0; i < 20; i++) { 
        
        

        
        }

    }


    // Ejercicio 7 - Implementar modulo main

    public static void Main(string[] args)
    {

        Pila p = new Pila();
        Cola cl = new Cola();
        //Ejercicio 9 - Modificar Main para crear coleccion multiple
        ColeccionMultiple multiple = new ColeccionMultiple(p, cl);

        Llenar(p);
        Llenar(cl);

        Informar(p);
        Informar(cl);
        Informar(multiple);



    }
}
