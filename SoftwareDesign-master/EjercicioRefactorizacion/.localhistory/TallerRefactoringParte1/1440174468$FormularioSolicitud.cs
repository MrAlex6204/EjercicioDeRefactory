using System;
using System.Collections.Generic;
using System.IO;
namespace TallerRefactoringParte1 {

    public class ArchivoAdjunto {
        public struct MimeTypeInfo {
            private string _Extension;
            private string _MimeType;

            public string Extension { get { return _Extension; } }
            public string MimeType { get { return _MimeType; } }

            internal MimeTypeInfo(string Extension, string MimeType) {
                _Extension = Extension;
                _MimeType = MimeType;
            }

        }
        private FileInfo _Info;
        private string _MimeType;
        private static MimeTypeInfo[] _FormatosValidos = { 
                                                           new MimeTypeInfo(".pdf", "application/pdf"), 
                                                           new MimeTypeInfo(".txt","text/plain"),
                                                           new MimeTypeInfo(".xls","application/excel"),
                                                           new MimeTypeInfo(".doc","application/msword") 
                                                         };

        public ArchivoAdjunto(string RutaDelArchivo) {
            _Info = new FileInfo(RutaDelArchivo);

            if (!_Info.Exists) {
                throw new FileNotFoundException("El archivo no existe!");
            }

            if (!ArchivoAdjunto.FormatoEsValido(RutaDelArchivo)) {
                throw new Exception("Extension no valida!");
            }

            _MimeType = ArchivoAdjunto.ObtenerMimeType(RutaDelArchivo);
            
        }

        public FileInfo Info { get { return _Info; } }
        public string MimeType { get { return _MimeType;  } }

        public static string ObtenerMimeType(string RutaDelArchivo) {
            var Extension = Path.GetExtension(RutaDelArchivo);
            var MimeType = "application/mime";

            foreach (MimeTypeInfo iMimeType in _FormatosValidos) {
                if (Extension == iMimeType.Extension) {
                    MimeType = iMimeType.MimeType;
                    break;
                }
            }

            return MimeType;
        }
        public static bool FormatoEsValido(string RutaDelArchivo) {
            var Extension = Path.GetExtension(RutaDelArchivo);
            var EsValido = false;

            foreach(MimeTypeInfo iFormato in _FormatosValidos) {
                if (iFormato.Extension == Extension) {
                    EsValido = true;
                    break;
                }
            }

            return EsValido;
        }
    }

    public class Solicitud {

        public List<ArchivoAdjunto> ArchivosAdjuntos { get; set; }
        public string RolResponsable { get; set; }
        public int Tipo { get; set; }
        public DateTime FechaEnvio { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Descuento { get; set; }
    }

    public class RepositorioSolicitud {
        public void Guardar(Solicitud solicitud) {

        }
    }

    public class FormularioSolicitud {

        public void Registrar(Solicitud solicitud) {
            try {

                if (solicitud.FechaEnvio.Year > DateTime.Now.Year) {
                    if (solicitud.Cantidad > 1000) {
                        if (solicitud.Tipo == 1) {
                            solicitud.RolResponsable = "Responsable1";
                        } else {
                            solicitud.RolResponsable = "Responsable2";
                        }
                    } else {
                        solicitud.RolResponsable = "Supervisor";
                    }
                } else {
                    solicitud.RolResponsable = "Administrador";
                }
                                

                if (solicitud.Tipo == 2 && solicitud.Cantidad > 10 && solicitud.Precio < 100) {
                    solicitud.Descuento = 0.5M;
                } else {
                    solicitud.Descuento = 0M;
                }

                switch (solicitud.Tipo) {
                    case 1:
                        EnviarCorreo(solicitud.Tipo);
                        CalcularSolicitudes(solicitud.Tipo);
                        //Codigo
                        ActivarBanderas(solicitud.Tipo);
                        break;
                    case 2:
                        EnviarCorreo(solicitud.Tipo);
                        //Codigo
                        DesactivarBanderas(solicitud.Tipo);
                        break;
                    case 3:
                        EnviarCorreo(solicitud.Tipo);
                        //Codigo
                        ActivarBanderas(solicitud.Tipo);
                        break;
                    default:
                        EnviarCorreo(solicitud.Tipo);
                        //Codigo
                        CalcularSolicitudes(solicitud.Tipo);
                        DesactivarBanderas(solicitud.Tipo);
                        break;
                }

                var repositorioSolicitud = new RepositorioSolicitud();
                repositorioSolicitud.Guardar(solicitud);
            } catch (Exception ex) {
                var mensaje = ex.Message + "\n";
                mensaje += ex.Source + "\n";
                mensaje += ex.StackTrace + "\n";
                File.WriteAllText("c:\\logs\\logError.txt", mensaje);
            }
        }

        private void EnviarCorreo(int tipo) {
            //Codigo
        }

        private void CalcularSolicitudes(int tipo) {
            //Codigo
        }

        private void DesactivarBanderas(int tipo) {
            //Codigo
        }

        private void ActivarBanderas(int tipo) {
            //Codigo
        }

     

    }
}
