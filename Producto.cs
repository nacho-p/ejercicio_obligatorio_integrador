namespace ejercicio_integrador
{
  public abstract class Producto
  {
    protected int id;
    protected string nombre;
    protected double precioBase;

    public int Id { get => id; set => id = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public double PrecioBase { get => precioBase; set => precioBase = value; }

    public Producto(int id, string nombre, double precioBase)
    {
      this.id = id;
      this.nombre = nombre;
      this.precioBase = precioBase;
    }
    public virtual void MostrarInfo()
    {
      Console.WriteLine($"\nId: {id}\nNombre: {nombre}\nPrecio Base: ${precioBase}");
    }
  }
}
