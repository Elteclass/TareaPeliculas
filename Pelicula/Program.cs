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

        public string V1 { get; }
        public int V2 { get; }

        //Constructores
        public Pelicula()
        {

        }
        public Pelicula(string t, Int16 a, string p, string d)
        {
            titulo = t;
            año = a;
            país = p;
            director = d;
        }

        public Pelicula(string v1, Int16 v2)
        {
            titulo = v1;
            año = v2;
        }

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
     
        public void Imprime()
        {
            Console.WriteLine($"{titulo} ({año})");
        }


        public void AgregaActor(Actor actor)
        {
            actores.Add(actor);
        }

        public void ImprimeActores()
        {
            foreach (var act in actores)
            {
                Console.WriteLine("{0} ({1})", act.Getnombre(), act.Getaño());
            }

        }
    }

    public class Actor
    {
        //Propiedades
        public string Nombre;
        public Int16 Año;
        //Constructores
        public Actor( string nom, Int16 a)
        {
            Nombre = nom;
            Año = a;
        }
        //Métodos 
        public void Setnombre(string nom)
        {
            Nombre = nom;
        }
        public string Getnombre()
        {
            return Nombre;
        }
        public void Setaño(Int16 a)
        {
            Año = a;
        }
        public Int16 Getaño()
        {
            return Año;
        }
        public void Imprime()
        {
            Console.WriteLine($"{Nombre} ({Año})");
        }
    }

    // Puedes probar tu código en Main() pero lo importante
    // es que pase las pruebas

    class Program
    {


        static void Main(string[] args)
        {
            
            /*Pelicula p1 = new Pelicula("La la land", 2016, "Estados Unidos", "Damien Chazelle");
            Pelicula p2 = new Pelicula("El renacido", 2015, "Estados Unidos", "Alejandro Gonzáles Iñárritu");
            p1.Imprime();
            p2.Imprime();
            */
            Pelicula p1 = new Pelicula();
            p1.SetTitulo("La La Land");
            p1.SetAño(2016);
            Console.WriteLine("{0}({1})", p1.GetTitulo(), p1.GetAño());
            

            //Lista de peliculas
            List <string> peliculas = new List<string>();

            peliculas.Add("Jobs");
            peliculas.Add("Noche del demonio");
            peliculas.Add("Forest Gump");
            peliculas.Add("El naúfrago");
            peliculas.Add("La monja");

            Console.WriteLine ("Las peliculas de la lista son:");

            foreach (var peli in peliculas)
            {
                Console.WriteLine(peli);
            }

            //Lista de actores
            Pelicula p2 = new Pelicula("La La Land", 2016);
            p2.AgregaActor(new Actor("Ryan Gosling", 1980));
            p2.AgregaActor(new Actor("Emma Stone", 1988));

            Console.WriteLine("Los actores son:");
            p2.Imprime();
            p2.ImprimeActores();
            
        }
    }
}
