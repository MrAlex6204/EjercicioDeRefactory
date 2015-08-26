using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Registro{

    public sealed class Solicitud {
        
        public enum Tipo{//===>Tipos de registros diponibles
            Normal = 1,
            Supervisores = 2,
            Gerencia = 3,
            Otro = 999

        }        
        

        public List<ArchivoAdjunto> ArchivosAdjuntos { get; set; }
        public string RolResponsable { get; set; }
        public Tipo TipoDeSolicitud { get; set; }
        public DateTime FechaEnvio { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Descuento { get; set; }


        public void Registrar() {
            try {

                if (this.FechaEnvio.Year > DateTime.Now.Year) {
                    if (this.Cantidad > 1000) {
                        if (this.TipoDeSolicitud == Solicitud.Tipo.Normal) {
                            this.RolResponsable = "Responsable1";
                        } else {
                            this.RolResponsable = "Responsable2";
                        }
                    } else {
                        this.RolResponsable = "Supervisor";
                    }
                } else {
                    this.RolResponsable = "Administrador";
                }


                if (this.TipoDeSolicitud == Solicitud.Tipo.Supervisores && this.Cantidad > 10 && this.Precio < 100) {
                    this.Descuento = 0.5M;
                } else {
                    this.Descuento = 0M;
                }

                switch (this.TipoDeSolicitud) {
                    case Solicitud.Tipo.Normal:
                        //Codigo
                        _CalcularSolicitudes();
                        _ActivarBanderas();
                        break;
                    case Solicitud.Tipo.Supervisores:
                        //Codigo
                        _DesactivarBanderas();
                        break;
                    case Solicitud.Tipo.Gerencia:
                        //Codigo
                        _ActivarBanderas();
                        break;
                    default:
                        //Codigo
                        _CalcularSolicitudes();
                        _DesactivarBanderas();
                        break;
                }
                _EnviarCorreo();

                var repositorioSolicitud = new RepositorioSolicitud();
                repositorioSolicitud.Guardar(solicitud);
            } catch (Exception ex) {
                var mensaje = ex.Message + "\n";
                mensaje += ex.Source + "\n";
                mensaje += ex.StackTrace + "\n";
                File.WriteAllText("c:\\logs\\logError.txt", mensaje);
            }
        }

        private void _EnviarCorreo() {
            //Codigo
        }

        private void _CalcularSolicitudes() {
            //Codigo
        }

        private void _DesactivarBanderas() {
            //Codigo
        }

        private void _ActivarBanderas() {
            //Codigo
        }

    }


}
