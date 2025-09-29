using System.Drawing;
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

    // funcion para generar nombres aleatorios (cadenas de caracteres)
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

    // Ejercicio 13 - Implementar funcion llenar alumnos
    public static void LlenarAlumnos(Coleccionable c)
    {
        for (int i = 0; i < 20; i++) {

            string nombreRandom = GenerarString(4);
            int dniRandom = unicoRandomGlobal.Next(1,10);
            Numero dr = new Numero(dniRandom);
            int legajoRandom = unicoRandomGlobal.Next(1, 10);
            Numero lr = new Numero(legajoRandom);
            int promedioRandom = unicoRandomGlobal.Next(1, 10);
            Numero pr = new Numero(promedioRandom);

            Alumno alumno = new Alumno(nombreRandom, dr, lr, pr);

            c.Agregar(alumno);

        }

    }


    // Ejercicio 7 & 14 - Implementar modulo main
    
    public static void Main(string[] args)
    {

        Pila p = new Pila();
        Cola cl = new Cola();
        //Ejercicio 9 - Modificar Main para crear coleccion multiple

        LlenarAlumnos(p);
        LlenarAlumnos(cl);

        ColeccionMultiple multiple = new ColeccionMultiple(p, cl);

        Informar(p);
        Informar(cl);
        Informar(multiple);



    }

    /*
     
    Ejercicio 16

    Para reflexionar. Responda ¿Podría haber hecho esto mismo sin interfaces? ¿A qué costo?

    Sí se puede hacer sin interfaces, pero el costo es perder reutilización, polimorfismo y flexibilidad. 
    El código se vuelve rígido, repetitivo y difícil de mantener.
     
     */
}
