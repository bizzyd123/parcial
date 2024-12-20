using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial
{
    public class PedidoPapelMensual:Pedido
    {
        public DateOnly FechaEntrega { get; set; }
        public int CantidadResmas { get; set; }
        
        public PedidoPapelMensual( DateOnly fechaCreacion, double montoBase, DateOnly fechaEntrega, int cantidadResmas): base( fechaCreacion, montoBase) 
        {
            this.FechaEntrega = fechaEntrega;
            this.CantidadResmas = cantidadResmas;
           
        }

        public override double CalcularPrecioFinal()
        {
            return MontoBase * CantidadResmas;
        }
        public override string ToString()
        {
            return $"pedido: {IdPedido}, Fecha de creacion: {FechaCreacion}, Monto Base: {MontoBase}, Fecha deentrega: {FechaEntrega}, Cantidad de resmas: {CantidadResmas}, Precio final: {CalcularPrecioFinal()}";
        }

    }
}
