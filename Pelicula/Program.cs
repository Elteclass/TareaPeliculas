using System;
using System.Collections.Generic;

namespace Pelicula
{

    public class Pelicula
    {
        //Campos
        private string titulo;
        private Int16 año;
        private string país;
        private string director;

        private List<Actor> actores = new List<Actor>();
        
        //Constructores
     
        //Métodos
        public void SetTitulo(string t)
        {
            titulo = t;
        }

         public void SetAño(Int16 a)
        {
            año = a;
        }
        public string GetTitulo ()
        {
            return titulo;
        }
        public int GetAño ()
        {
            return año;
        }
     
        /*public void Imprime()
        {
            //Console.WriteLine($"{titulo} {año}");
            Console.WriteLine("La pelicula es {0}, que se estreno en el año {1}." , titulo , año);
        }*/


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
            /*
            Pelicula p1 = new Pelicula("La la land", 2016, "Estados Unidos", "Damien Chazelle");
            Pelicula p2 = new Pelicula("El renacido", 2015, "Estados Unidos", "Alejandro Gonzáles Iñárritu");
            p1.Imprime();
            p2.Imprime();
            */
            Pelicula p1 = new Pelicula();
            p1.SetTitulo("La La Land");
            p1.SetAño(2016);
            Console.WriteLine("{0}({1})", p1.GetTitulo(), p1.GetAño());
            
        }
    }
}
