using System;
using System.Collections.Generic;

namespace Pelicula
{

    public class Pelicula
    {
        //Campos
        public string titulo;
        public int año;
        public string país;
        public string director;

        private List<Actor> actores = new List<Actor>();
        
        //Constructores
        public Pelicula (string t, int a, string p, string d)
        {
            titulo = t;
            año = a;
            país = p;
            director = d;
        }
     
        //Métodos
     
        public void Imprime()
        {
            //Console.WriteLine($"{titulo} {año}");
            Console.WriteLine("La pelicula es {0}, que se estreno en el año {1}." , titulo , año);
        }


    }

    public class Actor
    {
        //Propiedades

        //Constructores


        //Métodos 
        /*public void Imprime()
        {
            Console.WriteLine($"{Nombre} ({Año})");
        }*/
    }

    // Puedes probar tu código en Main() pero lo importante
    // es que pase las pruebas

    class Program
    {


        static void Main(string[] args)
        {
            Pelicula p1 = new Pelicula("La la land", 2016, "Estados Unidos", "Damien Chazelle");
            Pelicula p2 = new Pelicula("El renacido", 2015, "Estados Unidos", "Alejandro Gonzáles Iñárritu");
            p1.Imprime();
            p2.Imprime();
        }
    }
}
