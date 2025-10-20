namespace ejercicio_integrador
{
  internal partial class Program
  {
    public class EmpleadoPermanente : Empleado
    {
      private int antiguedad;
      public int Antiguedad { get => antiguedad; set => antiguedad = value; }
      public EmpleadoPermanente(int id, string nombre, string apellido, double sueldoBase, int antiguedad) : base(id, nombre, apellido, sueldoBase)
      {
        this.antiguedad = antiguedad;
      }
      public override void MostrarInfo()
      {
        base.MostrarInfo();
        Console.WriteLine($"Antigüedad: {antiguedad}\nSueldo Final: ${CalcularSueldo()}");
      }
      public override double CalcularSueldo()
      {
        return this.sueldoBase + (this.sueldoBase * this.antiguedad * 0.02);
      }
    }
  }
}
