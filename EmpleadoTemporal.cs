namespace ejercicio_integrador
{
  internal partial class Program
  {
    public class EmpleadoTemporal : Empleado
    {
      public EmpleadoTemporal(int id, string nombre, string apellido, double sueldoBase) : base(id, nombre, apellido, sueldoBase) { }
      public override double CalcularSueldo()
      {
        return this.sueldoBase;
      }
    }
  }
}
