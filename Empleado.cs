namespace ejercicio_integrador
{
  internal partial class Program
  {
    public abstract class Empleado
    {
      protected int id;
      protected string nombre;
      protected string apellido;
      protected double sueldoBase;

      public int Id { get => id; set => id = value; }
      public string Nombre { get => nombre; set => nombre = value; }
      public string Apellido { get => apellido; set => apellido = value; }
      public double SueldoBase { get => sueldoBase; set => sueldoBase = value; }
      public Empleado(int id, string nombre, string apellido, double sueldoBase)
      {
        this.id = id;
        this.nombre = nombre;
        this.apellido = apellido;
        this.sueldoBase = sueldoBase;
      }
      public virtual void MostrarInfo()
      {
        Console.WriteLine($"\nId: {id}\nNombre: {nombre}\nApellido: {apellido}\nSueldo Base: ${sueldoBase}");
      }
      public abstract double CalcularSueldo();
    }
  }
}
