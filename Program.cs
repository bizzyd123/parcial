using parcial;

public class Program
{
    public static void Main(string[] args)
    {
        List<Pedido> listaPedidos = new List<Pedido>();

        Sistema sistema = new Sistema(listaPedidos);
        //1
        Console.WriteLine("\ntest 1");
        try
        {
            sistema.AgregarPedidoMensual(new DateOnly(2020, 12, 12), 2500, new DateOnly(2020, 12, 15), 5);
            foreach (var pedido in listaPedidos)
            {
                Console.WriteLine(pedido.ToString());
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al agregar el pedido: " + ex.Message);
        }
        // 1.2
        Console.WriteLine("\ntest 1.2");
        try
        {
            sistema.AgregarPedidoElectronico(new DateOnly(2020, 12, 12), 3000, "PC no funciona", 200.0);
            foreach (var pedido in listaPedidos)
            {
                Console.WriteLine(pedido.ToString());
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al agregar el pedido: " + ex.Message);
        }
        //
        Console.WriteLine("\ntest 1.3");
        try
        {
            sistema.AgregarPedidoMensual(new DateOnly(2020, 12, 12), 2500, new DateOnly(2020, 12, 15), 0);
            foreach (var pedido in listaPedidos)
            {
                Console.WriteLine(pedido.ToString());
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al agregar el pedido: " + ex.Message);
        }
        

        try
        {
            sistema.AgregarPedidoElectronico(new DateOnly(2020, 12, 12), 3000, "", 200.0);
            foreach (var pedido in listaPedidos)
            {
                Console.WriteLine(pedido.ToString());
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al agregar el pedido: " + ex.Message);
        }
        //2.1
        Console.WriteLine("\ntest 2-1");

        try
        {
            Pedido pedido1 = sistema.TraerPedido(1); 
            Pedido pedido2 = sistema.TraerPedido(2); 
            if (pedido1 != null)
            {
                Console.WriteLine("pedido 1:");
                Console.WriteLine(pedido1.ToString());
            }
            else
            {
                Console.WriteLine("no se encontro el pedido con ID 1.");
            }

            if (pedido2 != null)
            {
                Console.WriteLine("pdido 2:");
                Console.WriteLine(pedido2.ToString()); 
            }
            else
            {
                Console.WriteLine("no se encontro el pedido con ID 2.");
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine("wrror al agregar el pedido: " + ex.Message);
        }

        //3


        Console.WriteLine("\ntest 3");
        try
        {
            sistema.AgregarPedidoMensual(new DateOnly(2020, 12, 12), 2500, new DateOnly(2020, 12, 15), 3);
            sistema.AgregarPedidoElectronico(new DateOnly(2020, 12, 12), 3000, "PC no funciona", 200.0);
            sistema.AgregarPedidoElectronico(new DateOnly(2020, 12, 12), 3000, "Monitor no funciona", 210.0);
            foreach (var pedido in listaPedidos)
            {
                Console.WriteLine(pedido.ToString());
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al agregar el pedido: " + ex.Message);
        }

        // 4.1 

        Console.WriteLine("\ntest 4-1");
            
        try
        {
            List<Pedido> pedidosConMotivo = sistema.TraerPedido("PC no funciona");

                foreach (var pedido in pedidosConMotivo)
                {
                    if (pedido is PedidoElectronico pedidoElectronico)
                    {
                        Console.WriteLine(pedidoElectronico.ToString());
                    }
                }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al traer el pedido: {ex.Message}");
        }
        Console.WriteLine("\ntest 4-2");
        //4.2
        try
        {
            var totalGeneral = sistema.CalcularTotalGeneral();
            Console.WriteLine($"total  a pagar por todos los pedidos: {totalGeneral}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al traer el pedido: {ex.Message}");
        }









    }
}
