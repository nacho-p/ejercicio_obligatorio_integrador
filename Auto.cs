namespace ejercicio_integrador
{
  public class Auto : Vehiculo
  {
    private int cantidadPuertas;

    public int CantidadPuertas { get => cantidadPuertas; set => cantidadPuertas = value; }
    public Auto(int id, string marca, string modelo, int anio, int cantidadPuertas) : base(id, marca, modelo, anio)
    {
      this.cantidadPuertas = cantidadPuertas;
    }
    public override void MostrarInfo()
    {
      base.MostrarInfo();
      Console.WriteLine($"Puertas: {this.cantidadPuertas}\n");
    }
  }
}

