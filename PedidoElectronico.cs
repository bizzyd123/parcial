using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial
{
    public class PedidoElectronico:Pedido
    {
        public  string Motivo { get; set; }

        
        public double PorcentajeExtra { get; set; }
        public PedidoElectronico( DateOnly fechaCreacion, double montoBase, string motivo, double porcentajeExtra): base( fechaCreacion, montoBase) 
        {
            this.Motivo = motivo;
            this.PorcentajeExtra = porcentajeExtra;
        }

        public override double CalcularPrecioFinal()
        {
            return MontoBase + (MontoBase * PorcentajeExtra / 100);
        }
       
        public override string ToString()
        {
            return $"Pedido: {IdPedido}, Fecha: {FechaCreacion}, Monto base: {MontoBase}, Motivo: {Motivo}, Porcentaje extra: {PorcentajeExtra}%";
        }
    }
}
