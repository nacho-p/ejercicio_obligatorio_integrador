namespace ejercicio_integrador
{
  class Camion : Vehiculo
  {
    int capacidadCarga;
    public int CapacidadCarga { get => capacidadCarga; set => capacidadCarga = value; }
    public Camion(int id, string marca, string modelo, int anio, int capacidadCarga) : base(id, marca, modelo, anio)
    {
      this.capacidadCarga = capacidadCarga;
    }
    public override void MostrarInfo()
    {
      base.MostrarInfo();
      Console.WriteLine($"Capacidad: {this.capacidadCarga}kg\n");
    }
  }
}

