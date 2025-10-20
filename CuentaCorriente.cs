namespace ejercicio_integrador
{
  internal partial class Program
  {
    public class CuentaCorriente : Cuenta
    {
      protected float limiteDescubierto;

      public float LimiteDescubierto { get => limiteDescubierto; set => limiteDescubierto = value; }

      public CuentaCorriente(string titular, int saldo, float limiteDescubierto) : base(titular, saldo)
      {
        this.limiteDescubierto = limiteDescubierto;
      }
      public override void MostrarInfo()
      {
        base.MostrarInfo();
        Console.WriteLine($"Limite Descubierto: ${limiteDescubierto}");
      }
    }
  }
}
