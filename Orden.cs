using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jose_Caso_de_Uso
{
    public class Orden
    {

		public int NumeroOrdenInterna { get; set; }

		public int NumeroOrdenExterna { get; set; }

        public string Producto { get; set; }

        public int Cantidad { get; set; }

        public string Cliente { get; set; }

        public EstadoEnum Estado { get; set; }

        public bool ListoParaEntrega { get; set; }

        public DateTime FechaCreacion { get; set; }

        public DateTime FechaModificacion { get; set; }
    }
}
