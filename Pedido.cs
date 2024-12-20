using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial
{
    public abstract class   Pedido
    {
        private static int contadorId = 1;
        public int IdPedido { get;private set; }
        public DateOnly FechaCreacion { get; set; }
        public double MontoBase { get; set; }

        public Pedido( DateOnly FechaCreacion, double montoBase)
        {
            this.IdPedido = contadorId ++;
            this.FechaCreacion = FechaCreacion;

            this.MontoBase = montoBase;
        }
        public abstract double CalcularPrecioFinal();
    }
}
