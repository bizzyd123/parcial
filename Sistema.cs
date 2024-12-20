using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial
{
    public class Sistema
    {

        //private int contadorId = 1;
        public List <Pedido> Pedidos { get; set; }
        public Sistema(List<Pedido> pedidos)
        {
            Pedidos = pedidos;
        }
        
        public bool AgregarPedidoMensual (DateOnly fechaCreacion, double montoBase, DateOnly fechaEntrega, int cantidadResmas)
        {
            {
            if (cantidadResmas <= 0)
                throw new Exception("la cantidad de resmas no puede ser 0");
            }
            PedidoPapelMensual nuevoPedido = new PedidoPapelMensual(fechaCreacion, montoBase, fechaEntrega, cantidadResmas);

            Pedidos.Add(nuevoPedido);
            return true;
        }
        public bool AgregarPedidoElectronico(DateOnly fechaCreacion, double montoBase,  string motivo, double porcentajeExtra)
        {
            if (motivo == null || motivo == "")
            {
                throw new Exception(" string vacio");
            }
            PedidoElectronico nuevoPedido = new PedidoElectronico(fechaCreacion, montoBase, motivo, porcentajeExtra);
            Pedidos.Add(nuevoPedido);

            return true;

        }
        public Pedido TraerPedido(int idPedido)
        {
            int i = 0;
            while (i < Pedidos.Count)
            {
                if (Pedidos[i].IdPedido == idPedido)
                {
                    return Pedidos[i];
                }
                i++;
            }
            return null;

        }
        public List<Pedido> TraerPedido(string motivo)
        {

            List<Pedido> pedidosConMotivo = new List<Pedido>();

            foreach (var pedido in Pedidos)
            {
                if (pedido is PedidoElectronico pedidoElectronico)
                {
                    if (pedidoElectronico.Motivo == motivo)
                    {
                        pedidosConMotivo.Add(pedido); 
                    }
                }
            }

            return pedidosConMotivo;
        }

        public double CalcularTotalGeneral()
        {
            double totalGeneral = 0;

            foreach (var pedido in Pedidos)
            {
                totalGeneral += pedido.CalcularPrecioFinal();//cada pedidos e suma al precio final
            }

            return totalGeneral;
        }
    }
}
