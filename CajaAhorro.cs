namespace ejercicio_integrador
{
  internal partial class Program
  {
    public class CajaAhorro : Cuenta
    {
      protected float tasaInteres;

      public float TasaInteres { get => tasaInteres; set => tasaInteres = value; }

      public CajaAhorro(string titular, int saldo, float tasaInteres) : base(titular, saldo)
      {
        this.tasaInteres = tasaInteres;
      }

      public void ModificarTasaInteres(float nuevaTasa)
      {
        tasaInteres = nuevaTasa;
      }
      public override void MostrarInfo()
      {
        base.MostrarInfo();
        Console.WriteLine($"Tasa Interes: {tasaInteres}%");
      }
    }
  }
}
