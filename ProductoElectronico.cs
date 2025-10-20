namespace ejercicio_integrador
{
  public class ProductoElectronico : Producto
  {
    protected int mesesGarantia;

    public int MesesGarantia { get => mesesGarantia; set => mesesGarantia = value; }

    public ProductoElectronico(int id, string nombre, double precioBase, int mesesGarantia) : base(id, nombre, precioBase)
    {
      this.mesesGarantia = mesesGarantia;
    }
    public override void MostrarInfo()
    {
      base.MostrarInfo();
      Console.WriteLine($"Meses Garantia: {mesesGarantia}");
    }
  }
}
