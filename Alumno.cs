namespace ejercicio_integrador
{
  internal partial class Program
  {
    public class Alumno : Persona
    {
      private int legajo;
      private float promedio;

      public int Legajo { get => legajo; set => legajo = value; }
      public float Promedio { get => promedio; set => promedio = value; }

      public Alumno(int id, string nombre, int edad, int legajo, float promedio) : base(id, nombre, edad)
      {
        this.legajo = legajo;
        this.promedio = promedio;
      }
      public override void MostrarInfo()
      {
        base.MostrarInfo();
        Console.WriteLine($"Legajo: {legajo}\nPromedio: {promedio}");
      }
    }
  }
}
