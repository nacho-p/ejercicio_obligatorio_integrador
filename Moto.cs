namespace ejercicio_integrador
{
  public class Moto : Vehiculo
  {
    private int cilindrada;
    public int Cilindrada { get => cilindrada; set => cilindrada = value; }
    public Moto(int id, string marca, string modelo, int anio, int cilindrada) : base(id, marca, modelo, anio)
    {
      this.cilindrada = cilindrada;
    }
    public override void MostrarInfo()
    {
      base.MostrarInfo();
      Console.WriteLine($"Cilindrada: {this.cilindrada}cc\n");
    }
  }
}

