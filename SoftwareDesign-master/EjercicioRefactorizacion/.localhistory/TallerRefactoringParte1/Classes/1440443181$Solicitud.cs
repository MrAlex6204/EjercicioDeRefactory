using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Registro{

    public sealed class Solicitud {

        public class SolicitudCollection : System.Collections.CollectionBase {//===>Colleccion de solicitud
            public int AgregarSolicitud(Solicitud solicitud) {
                return this.List.Add(solicitud);//===>Agregar a la lista de solicitud y regresar el Index en el que fue agregado
            }
        }


        public enum Tipo{//===>Tipos de registros diponibles
            Normal = 1,
            Supervisores = 2,
            Gerencia = 3,
            Otro = 999

        }
        public static string[] ObtenerTiposDeSolicitudes() {//===>Regresar una lista de todos los tipos de nombres disponibles
            return Enum.GetNames((new Tipo()).GetType());
        }
        
        
        public List<ArchivoAdjunto> ArchivosAdjuntos { get; set; }
        public string RolResponsable { get; set; }
        public Tipo TipoDeSolicitud { get; set; }
        public DateTime FechaEnvio { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Descuento { get; set; }
    }


}
