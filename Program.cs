namespace ejercicio_integrador
{
  internal partial class Program
  {
    // Ejercicio 1 – Gestión de vehículos
    static List<Vehiculo> listaVehiculos = new List<Vehiculo>();

    static void AgregarVehiculo(Vehiculo v)
    {
      listaVehiculos.Add(v);
    }

    static void MostrarListaVehiculos()
    {
      foreach (Vehiculo v in listaVehiculos)
      {
        v.MostrarInfo();
      }
    }

    static void ModificarVehiculo(int id, string marca, string modelo, int anio, int extra)
    {
      foreach (Vehiculo v in listaVehiculos)
      {
        if (v.Id == id)
        {
          v.Marca = marca;
          v.Modelo = modelo;
          v.Anio = anio;
          if (v is Auto a)
          {
            a.CantidadPuertas = extra;
          }
          if (v is Moto m)
          {
            m.Cilindrada = extra;
          }
          if (v is Camion c)
          {
            c.CapacidadCarga = extra;
          }
          Console.WriteLine("Vehiculo modificado.");
          return;
        }
      }
      Console.WriteLine("No existe un vehiculo con ese id en la lista.");
    }

    static void EliminarVehiculo(int id)
    {
      if (listaVehiculos.Count == 0)
      {
        Console.WriteLine("No hay vehiculos en la lista.");
      }
      else
      {
        listaVehiculos.RemoveAll(v => v.Id == id);
        Console.WriteLine("Se elimino el vehiculo de la lista.");
      }
    }

    // Ejercicio 2 – Sistema de empleados
    static List<Empleado> listaEmpleados = new List<Empleado>();

    static void AgregarEmpleado(Empleado e)
    {
      listaEmpleados.Add(e);
    }
    static void MostrarListaEmpleados()
    {
      foreach (Empleado e in listaEmpleados)
      {
        e.MostrarInfo();
      }
    }
    // Metodo sobrecargado para modificar empleado temporal
    static void ModificarEmpleado(int id, string nombre, string apellido, int sueldoBase)
    {
      foreach (Empleado e in listaEmpleados)
      {
        if (e.Id == id)
        {
          e.Nombre = nombre;
          e.Apellido = apellido;
          e.SueldoBase = sueldoBase;
          Console.WriteLine("Datos del empleado modificados con exito.");
          return;
        }
      }
      Console.WriteLine("No existe un empleado con ese id en la empresa.");
    }
    // Metodo sobrecargado para modificar empleado permanente
    static void ModificarEmpleado(int id, string nombre, string apellido, int sueldoBase, int antiguedad)
    {
      foreach (Empleado e in listaEmpleados)
      {
        if (e.Id == id && e is EmpleadoPermanente ep)
        {
          e.Nombre = nombre;
          e.Apellido = apellido;
          e.SueldoBase = sueldoBase;
          ep.Antiguedad = antiguedad;
          Console.WriteLine("Datos del empleado modificados con exito.");
          return;
        }
      }
      Console.WriteLine("No existe un empleado con ese id en la empresa.");
    }
    static void DesvincularEmpleado(int id)
    {
      if (listaEmpleados.Count == 0)
      {
        Console.WriteLine("No existe un empleado con ese id.");
      }
      else
      {
        listaEmpleados.RemoveAll(e => e.Id == id);
        Console.WriteLine($"Se desvinculó al empleado con el id {id}.");
      }
    }

    // Ejercicio 3 – Inventario de productos

    static List<Producto> listaProductos = new List<Producto>();

    static void AgregarProducto(Producto p)
    {
      listaProductos.Add(p);
    }
    static void MostrarListaProductos()
    {
      foreach (Producto p in listaProductos)
      {
        p.MostrarInfo();
        if (p is ProductoAlimenticio)
        {
          Console.WriteLine("Tipo de prod: Alimenticio");
        }
        if (p is ProductoElectronico)
        {
          Console.WriteLine("Tipo de prod: Electronico");
        }
      }
    }

    // Metodo sobrecargado para modificar producto alimenticio
    static void ModificarProducto(int id, string nombre, double precioBase, string fechaVencimiento)
    {
      foreach (Producto p in listaProductos)
      {
        if (p.Id == id && p is ProductoAlimenticio pa)
        {
          p.Nombre = nombre;
          p.PrecioBase = precioBase;
          pa.FechaVencimiento = fechaVencimiento;
          Console.WriteLine($"Datos del producto con id {id} modificados con exito.");
          return;
        }
      }
      Console.WriteLine($"No existe un producto con id {id} en la empresa.");
    }

    // Metodo sobrecargado para modificar producto electronico
    static void ModificarProducto(int id, string nombre, double precioBase, int mesesGarantia)
    {
      foreach (Producto p in listaProductos)
      {
        if (p.Id == id && p is ProductoElectronico pa)
        {
          p.Nombre = nombre;
          p.PrecioBase = precioBase;
          pa.MesesGarantia = mesesGarantia;
          Console.WriteLine($"Datos del producto con id {id} modificados con exito.");
          return;
        }
      }
      Console.WriteLine($"No existe en la lista un producto con id {id}.");
    }

    static void EliminarProducto(int id)
    {
      if (listaProductos.Count == 0)
      {
        Console.WriteLine("No hay productos en la lista.");
      }
      else
      {
        listaProductos.RemoveAll(p => p.Id == id);
        Console.WriteLine($"Se elimino de la lista el producto con id {id}.");
      }
    }
    // Ejercicio 4 – Gestión educativa

    static List<Persona> listaPersonas = new List<Persona>();

    static void AgregarPersona(Persona p)
    {
      listaPersonas.Add(p);
    }
    static void MostrarListaPersonas()
    {
      Console.WriteLine("\nAlumnos:");
      foreach (Persona p in listaPersonas)
      {
        if (p is Alumno)
        {
          p.MostrarInfo();
        }
      }
      Console.WriteLine("\nProfesores:");
      foreach (Persona p in listaPersonas)
      {
        if (p is Profesor)
        {
          p.MostrarInfo();
        }
      }
    }
    // Metodo sobrecargado para modificar alumno
    static void ModificarPersona(int id, string nombre, int edad, int legajo, float promedio)
    {
      foreach (Persona p in listaPersonas)
      {
        if (p.Id == id && p is Alumno pa)
        {
          p.Nombre = nombre;
          p.Edad = edad;
          pa.Legajo = legajo;
          pa.Promedio = promedio;
          Console.WriteLine($"Datos del alumno con id {id} modificados con exito.");
          return;
        }
      }
      Console.WriteLine($"No existe en la lista un alumno con id {id}.");
    }
    // Metodo sobrecargado para modificar profesor
    static void ModificarPersona(int id, string nombre, int edad, string materia, float sueldo)
    {
      foreach (Persona p in listaPersonas)
      {
        if (p.Id == id && p is Profesor pp)
        {
          p.Nombre = nombre;
          p.Edad = edad;
          pp.Materia = materia;
          pp.Sueldo = sueldo;
          Console.WriteLine($"Datos del profesor con id {id} modificados con exito.");
          return;
        }
      }
      Console.WriteLine($"No existe en la lista un profesor con id {id}.");
    }
    static void RemoverPersona(int id)
    {
      if (listaPersonas.Count == 0)
      {
        Console.WriteLine($"No existe en la lista una persona con id {id}.");
      }
      else
      {
        listaPersonas.RemoveAll(p => p.Id == id);
        Console.WriteLine($"Se elimino de la lista a la persona con id {id}.");
      }
    }

    // Ejercicio 5 – Sistema bancario

    static List<Cuenta> listaCuentas = new List<Cuenta>();
    static void RegistrarCuenta(Cuenta c)
    {
      listaCuentas.Add(c);
    }
    static void MostrarListaCuentas()
    {
      foreach (Cuenta c in listaCuentas)
      {
        c.MostrarInfo();
        if (c is CajaAhorro)
        {
          Console.WriteLine("Tipo de cuenta: Caja de Ahorro");
        }
        if (c is CuentaCorriente)
        {
          Console.WriteLine("Tipo de cuenta: Cuenta Corriente");
        }
      }
    }
    static void AplicarIntereses(Cuenta cuenta, float interes)
    {
      if (cuenta is CajaAhorro ca)
      {
        ca.ModificarTasaInteres(interes);
        Console.WriteLine("\nSe modifico con exito la tasa de interes.");
      }
      else
      {
        Console.WriteLine("\nEsta cuenta no es una caja de ahorro.");
      }
    }

    static void ActualizarSaldo(Cuenta cuenta, float saldo)
    {
      cuenta.Saldo = saldo;
    }

    static void Main(string[] args)
    {
      Console.WriteLine("\n++++++++++++++++++++++++++++++++++++++");
      Console.WriteLine("Ejercicio 1 – Gestión de vehículos");
      Console.WriteLine("++++++++++++++++++++++++++++++++++++++");

      AgregarVehiculo(new Auto(23, "Ford", "Festichola", 2004, 5));
      AgregarVehiculo(new Moto(16, "Kawasaki", "Naruto", 2016, 200));
      AgregarVehiculo(new Camion(90, "Scania", "Basurita", 1998, 4500));

      Console.WriteLine("\nLista inicial:");
      MostrarListaVehiculos();
      Console.WriteLine("\nModificando vehiculo con id 16");
      ModificarVehiculo(16, "Moto", "Neta", 2025, 250);
      MostrarListaVehiculos();
      Console.WriteLine("\nEliminando vehiculo con id 90");
      EliminarVehiculo(90);
      Console.WriteLine("\nLista final:");
      MostrarListaVehiculos();

      Console.WriteLine("\n++++++++++++++++++++++++++++++++++++++");
      Console.WriteLine("Ejercicio 2 – Sistema de empleados");
      Console.WriteLine("++++++++++++++++++++++++++++++++++++++");

      AgregarEmpleado(new EmpleadoTemporal(1, "Juan", "Proot", 350_967));
      AgregarEmpleado(new EmpleadoPermanente(2, "Lautaro", "Muñoz", 506_345, 4));
      AgregarEmpleado(new EmpleadoTemporal(3, "Mariela", "", 390_621));
      AgregarEmpleado(new EmpleadoPermanente(4, "Pablo", "Avellaneda", 614_979, 3));

      Console.WriteLine("\nLista inicial:");
      MostrarListaEmpleados();
      Console.WriteLine("\nModificando empleado con id 2.");
      ModificarEmpleado(2, "El", "Profe", 2_000_000, 5);
      Console.WriteLine("\nModificando empleado con id 1.");
      ModificarEmpleado(1, "Nacho", "Proot", 546_753);
      MostrarListaEmpleados();
      Console.WriteLine("\nEliminando empleado con id 1.");
      DesvincularEmpleado(1);
      Console.WriteLine("\nLista final:");
      MostrarListaEmpleados();

      Console.WriteLine("\n++++++++++++++++++++++++++++++++++++++");
      Console.WriteLine("Ejercicio 3 – Inventario de productos");
      Console.WriteLine("++++++++++++++++++++++++++++++++++++++");

      AgregarProducto(new ProductoAlimenticio(1, "Chizitos", 850, "24-09-2026"));
      AgregarProducto(new ProductoAlimenticio(2, "Bananas", 3000, "15-03-2025"));
      AgregarProducto(new ProductoElectronico(3, "Licuadora", 15_500, 6));
      AgregarProducto(new ProductoElectronico(4, "TV HD Sorny", 899_999, 12));
      Console.WriteLine("\nLista inicial:");
      MostrarListaProductos();
      Console.WriteLine("\nModificando producto con id 2");
      ModificarProducto(2, "Manzanas", 3500, "24-12-2025");
      Console.WriteLine("\nModificando producto con id 4");
      ModificarProducto(4, "TV 4K Philips", 750_500, 16);
      MostrarListaProductos();
      Console.WriteLine("\nEliminando producto con id 3");
      EliminarProducto(3);
      Console.WriteLine("\nLista final:");
      MostrarListaProductos();

      Console.WriteLine("\n++++++++++++++++++++++++++++++++++++++");
      Console.WriteLine("Ejercicio 4 – Gestión educativa");
      Console.WriteLine("++++++++++++++++++++++++++++++++++++++");

      AgregarPersona(new Alumno(1, "Juan", 26, 50_967, 7.4f));
      AgregarPersona(new Profesor(2, "Lucas", 45, "Modelado", 550_350));
      AgregarPersona(new Alumno(3, "Mariela", 46, 90_621, 9.5f));
      AgregarPersona(new Profesor(4, "Christian", 60, "Base de Datos", 489_657));

      Console.WriteLine("\nLista inicial:");
      MostrarListaPersonas();
      Console.WriteLine("\nModificando persona con id 2.");
      ModificarPersona(2, "Karina", 38, "Analisis", 650_800);
      Console.WriteLine("\nModificando persona con id 1.");
      ModificarPersona(1, "Nacho", 39, 46_753, 10);
      MostrarListaPersonas();
      Console.WriteLine("\nEliminando empleado con id 1.");
      RemoverPersona(1);
      Console.WriteLine("\nLista final:");
      MostrarListaPersonas();

      Console.WriteLine("\n++++++++++++++++++++++++++++++++++++++");
      Console.WriteLine("Ejercicio 5 – Sistema bancario");
      Console.WriteLine("++++++++++++++++++++++++++++++++++++++");

      Cuenta cuenta1 = new CajaAhorro("Tito Puente", 250_054, 23);
      Cuenta cuenta2 = new CuentaCorriente("Beto Velez", 45_345, 50_000);
      Cuenta cuenta3 = new CajaAhorro("Lalo Landa", 123_579, 40);
      Cuenta cuenta4 = new CuentaCorriente("Sara Bustani", 452_799, 600_000);
      RegistrarCuenta(cuenta1);
      RegistrarCuenta(cuenta2);
      RegistrarCuenta(cuenta3);
      RegistrarCuenta(cuenta4);

      Console.WriteLine("\nLista inicial:");
      MostrarListaCuentas();
      Console.WriteLine("\nDepositando en la cuenta 2");
      cuenta2.RealizarDeposito(123425.25f);
      Console.WriteLine("\nExtrayendo de la cuenta 3");
      cuenta3.RealizarExtraccion(34000f);
      Console.WriteLine("\nActualizando tasa de interes.");
      AplicarIntereses(cuenta2, 54); // probando con cuenta corriente para ver si tira error
      AplicarIntereses(cuenta1, 54); // modificando interes en la caja de ahorro
      ActualizarSaldo(cuenta4, 100_234_468); // actualizando saldo desde el banco
      Console.WriteLine("\nLista final");
      MostrarListaCuentas();

    }
  }
}
