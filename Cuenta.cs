namespace ejercicio_integrador
{
  internal partial class Program
  {
    public abstract class Cuenta
    {
      protected int numeroCuenta;
      protected string titular;
      protected double saldo;

      public int NumeroCuenta { get => numeroCuenta; set => numeroCuenta = value; }
      public string Titular { get => titular; set => titular = value; }
      public double Saldo { get => saldo; set => saldo = value; }
      protected Cuenta(string titular, int saldo)
      {
        Random random = new Random();
        this.numeroCuenta = random.Next(0000001, 9999999); // generador de numero de cuenta
        this.titular = titular;
        this.saldo = saldo;
      }
      public virtual void MostrarInfo()
      {
        Console.WriteLine($"\nNumero de Cuenta: {numeroCuenta}\nTitular: {titular}\nSaldo: ${saldo}");
      }
      public virtual void RealizarDeposito(float monto)
      {
        this.saldo += monto;
      }
      public virtual void RealizarExtraccion(float monto)
      {
        if (saldo >= monto)
        {
          this.saldo -= monto;
          Console.WriteLine($"${monto} extraidos exitosamente.");
        }
        else
        {
          Console.WriteLine("Saldo insuficiente.");
        }
      }
    }
  }
}
