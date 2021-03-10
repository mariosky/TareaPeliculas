using System;
using System.Collections.Generic;

namespace Pelicula
{

    public class Pelicula
    {
        //Campos
        private List<Actor> actores = new List<Actor>();

        private string titulo;
        private Int16 año;
        //Constructores
        public Pelicula()
        { }

        public Pelicula(string t, Int16 a)
        {
            titulo = t;
            año = a;
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

        public string GetTitulo() => titulo;

        public Int16 GetAño() => año;

        public void Imprime()
        {
            Console.WriteLine($"{titulo} ({año})");

        }

        public void ImprimeActores()
        {
            foreach (var a in actores)
                a.Imprime();
        }

        public void AgregaActor(Actor a)
        {
            actores.Add(a);
        }

    }

    public class Actor
    {
        //Atributos
        private string nombre;
        private int año;

        //Propiedades

        //Constructores

        public Actor(string n, int a)
        {
            Nombre = n;
            Año = a;

        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Año { get => año; set => año = value; }

        //Métodos 
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
            Pelicula p = new Pelicula("La la land", 2016);
            p.Imprime();
            Pelicula p1 = new Pelicula("La La Land", 2016);
            p1.AgregaActor(new Actor("Ryan Gosling", 1980));
            p1.AgregaActor(new Actor("Emma Stone", 1988));

            p1.ImprimeActores();

        }
    }
}
