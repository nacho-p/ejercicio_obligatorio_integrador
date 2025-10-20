namespace ejercicio_integrador
{
  internal partial class Program
  {
    public abstract class Persona
    {
      protected int id;
      protected string nombre;
      protected int edad;

      public int Id { get => id; set => id = value; }
      public string Nombre { get => nombre; set => nombre = value; }
      public int Edad { get => edad; set => edad = value; }
      protected Persona(int id, string nombre, int edad)
      {
        this.id = id;
        this.nombre = nombre;
        this.edad = edad;
      }
      public virtual void MostrarInfo()
      {
        Console.WriteLine($"\nId: {id}\nNombre: {nombre}\nEdad: {edad}");
      }
    }
  }
}
