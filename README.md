## Programa básico Películas 

De acuerdo a los ejemplos vistos en clase y la lectura. Implementa en c# la clase *Pelicula*  con los siguientes atributos **publicos**:


### Pelicula
| atributo             | tipo           |
| ---------------------|----------------|
| titulo               | String         |
| año                  | Int16          |
| país                 | String         |
| director             | String         |


1. Como primer paso crea solo la clase con los atributos públicos e inicializalos en **Program.Main()** directamente.
2. Crea dos objetos tipo Pelicula con dos peliculas ganadoras de un Oscar. 
3. Imprime en la consola el titulo y año de las peliculas. 
Sube la primera versión a GitHub.
4. Ahora cambia los atributos a **private**. Agrega los métodos necesarios para crear los objetos de la siguiente manera:

```csharp
class Program 
{
static void Main(){

    Pelicula p1 = new Pelicula();
    p1.SetTitulo("La La Land");
    p1.SetAño(2016); 
    Console.WriteLine("{0}({1})", p1.GetTitulo(), p1.GetAño());

}
} 
```
Actualiza la versión a GitHub.

5. Por último agrega dos constructores: *Pelicula()* y *Pelicula(string titulo, Int16 año )* y el método imprime().
Actualiza la versión a GitHub.

## Lista de Películas 

Utilizando la bibliteca *System.Collections.Generic* crea una lista de 5 peliculas. Utilizando la lista genérica **List<Pelicula>**.
1. Crea la lista en *Main()* y agrega directamente las peliculas a la lista, por ejemplo para la clase **Persona** sería de esta manera (fragmento):

```csharp
List<Persona> personas = new List<Persona>();

persona.Add(new Persona ("pam"));
persona.Add(new Persona ("tom"));
persona.Add(new Persona ("jim"));

```
2. Utiliza un ciclo **foreach** para iterar por la lista e imprimir las peliculas.

## Actores 
Agrega a tu clase **Pelicula** un atributo **actores** de tipo **List<Actor>**
Tu clase debe permitir el siguiente funcionamiento:

```csharp
class Program 
{
static void Main(){

    Pelicula p1 = new Pelicula("La La Land", 2016);
    p1.AgregarActor(new Actor("Ryan Gosling", 1980));
    p1.AgregarActor(new Actor("Emma Stone", 1988));

    p1.ImprimeActores();

}
} 
```
.
