using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol_Almacen.Presentacion
{
    public class P_articulos
    {
        public int Codigo_ar { get; set; }
        public string Descripcion_ar { get; set; }
        public string Marca_ar { get; set; }
        public int Codigo_um { get; set; }
        public int Codigo_ca { get; set; }
        public decimal stock_actual { get; set; }
        public string FechaCrea_ar { get; set; }
        public string FechaModifica_ar { get; set; }


    }
}
