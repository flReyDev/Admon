using AdminServices.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminServices.ModelServives
{
    public class Productos
    {

        public int id_tipo { get; set; }
        public string code { get; set; }
        public string descripcion { get; set; }
        public int codigo_estandar { get; set; }
        public int um { get; set; }
        public float precioUnitario { get; set; }
        public int tipoImpuesto { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public int cantidadXpaquete { get; set; }
        public int cantidadReal { get; set; }
        public int mandato { get; set; }
        public int transporte { get; set; }

    }
}
