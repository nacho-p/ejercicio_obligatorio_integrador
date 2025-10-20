namespace ejercicio_integrador
{
  internal partial class Program
  {
    public class Profesor : Persona
    {
      private string materia;
      private float sueldo;

      public string Materia { get => materia; set => materia = value; }
      public float Sueldo { get => sueldo; set => sueldo = value; }

      public Profesor(int id, string nombre, int edad, string materia, float sueldo) : base(id, nombre, edad)
      {
        this.materia = materia;
        this.sueldo = sueldo;
      }
      public override void MostrarInfo()
      {
        base.MostrarInfo();
        Console.WriteLine($"Materia: {materia}\nSueldo: ${sueldo}");
      }
    }
  }
}
