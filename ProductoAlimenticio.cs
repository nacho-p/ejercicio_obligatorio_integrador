namespace ejercicio_integrador
{
  public class ProductoAlimenticio : Producto
  {
    protected string fechaVencimiento;

    public string FechaVencimiento { get => fechaVencimiento; set => fechaVencimiento = value; }

    public ProductoAlimenticio(int id, string nombre, double precioBase, string fechaVencimiento) : base(id, nombre, precioBase)
    {
      this.fechaVencimiento = fechaVencimiento;
    }
    public override void MostrarInfo()
    {
      base.MostrarInfo();
      Console.WriteLine($"Fecha Vencimiento: {fechaVencimiento}");
    }
  }
}
