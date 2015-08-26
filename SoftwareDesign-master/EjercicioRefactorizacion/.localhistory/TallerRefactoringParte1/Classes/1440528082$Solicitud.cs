using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace System.Registro{

    public class ArchivoAdjunto {
        private struct MimeTypeInfo {
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
        private static MimeTypeInfo[] _FormatosValidos = { //===>Agregar aqui los MimeTypes aceptados
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
        public string MimeType { get { return _MimeType; } }

        public static string ObtenerMimeType(string RutaDelArchivo) {//===>Obtener el MimeType de un Archivo
            var Extension = Path.GetExtension(RutaDelArchivo);
            var MimeType = "application/mime";//===>MimeType por default!

            foreach (MimeTypeInfo iMimeType in _FormatosValidos) {
                if (Extension == iMimeType.Extension) {
                    MimeType = iMimeType.MimeType;
                    break;
                }
            }

            return MimeType;
        }
        public static bool FormatoEsValido(string RutaDelArchivo) {//====>Verificar si un archivo es del formato valido
            var Extension = Path.GetExtension(RutaDelArchivo);
            var EsValido = false;

            foreach (MimeTypeInfo iFormato in _FormatosValidos) {//===>Buscar la extension del archivo en la lista de MimeTypes validos.
                if (iFormato.Extension == Extension) {
                    EsValido = true;
                    break;
                }
            }

            return EsValido;
        }
    }

    [Serializable]//===>Atributo para poder serializar un objeto de Solicitud
    public sealed class Solicitud {
        private const int _CANTIDAD_MAXIMA_ = 1000;
        private const int _CANTIDAD_MINIMA_ = 10;
        private const decimal _PRECIO_MAXIMO_ = 100;
        private string _RolResponsable = "[NONE]";
        private decimal _Descuento = 0M;

        public enum Tipo{//===>Tipos de registros diponibles
            Normal = 1,
            Supervisores = 2,
            Gerencia = 3,
            Otro = 999

        }
        
        public delegate void DlgRegistrandoSolicitud(object sender, object e);
        public event DlgRegistrandoSolicitud RegistrandoSolicitud;

        public List<ArchivoAdjunto> ArchivosAdjuntos { get; set; }
        public string RolResponsable { get { return _RolResponsable; } }
        public Tipo TipoDeSolicitud { get; set; }
        public DateTime FechaEnvio { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Descuento { get { return _Descuento;} }
                
        public bool Registrar() {
            _NotificarStatusDeRegistro("Relizando registro de notificacion.");
            try {

                if (this.FechaEnvio.Year > DateTime.Now.Year) {
                    if (this.Cantidad >  _CANTIDAD_MAXIMA_) {
                        if (this.TipoDeSolicitud == Solicitud.Tipo.Normal) {
                            _RolResponsable = "Responsable1";
                        } else {
                            _RolResponsable = "Responsable2";
                        }
                    } else {
                        _RolResponsable = "Supervisor";
                    }
                } else {
                    _RolResponsable = "Administrador";
                }
                
                if (this.TipoDeSolicitud == Solicitud.Tipo.Supervisores && this.Cantidad > _CANTIDAD_MINIMA_ && this.Precio < _PRECIO_MAXIMO_) {
                    _Descuento = 0.5M;
                    _NotificarStatusDeRegistro("0.5% Descuento realizado...*");                    
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
                _NotificarStatusDeRegistro("Guardando en el repositorio...*");                
                RepositorioSolicitud.Guardar(this);
                return true;
            } catch (Exception ex) {
                _NotificarStatusDeRegistro("Error al registrar:" + ex.Message);
                var mensaje = ex.Message + "\n";
                mensaje += ex.Source + "\n";
                mensaje += ex.StackTrace + "\n";
                File.WriteAllText("c:\\logs\\logError.txt", mensaje);
                return false;   
            }
        }

        private void _NotificarStatusDeRegistro(string Msg) {//===>Esta funcion es para saber en que paso va el regitro de cada solicitud.
            if (RegistrandoSolicitud != null) {
                RegistrandoSolicitud(this, Msg);//===>Ejecutar evento.
                System.Threading.Thread.Sleep(500);//===>Hacer un delay para simular un proceso XD.
            }
        }

        private void _EnviarCorreo() {
            //Codigo
            _NotificarStatusDeRegistro("Enviando correo...*");
            _NotificarStatusDeRegistro("Correo enviado Satistactoriamente!");
        }

        private void _CalcularSolicitudes() {
            //Codigo1
            _NotificarStatusDeRegistro("Relizando calculo de solicitud...*");
        }

        private void _DesactivarBanderas() {
            //Codigo
            _NotificarStatusDeRegistro("Desactivando banderas...*");
        }

        private void _ActivarBanderas() {
            //Codigo
            _NotificarStatusDeRegistro("Activando banderas...*");
        }

    }

    public class RepositorioSolicitud {
        private static const string REPORSITORY_PATH = @"C:\Temp\Repository\";
        private static const string FILE_EXTENSION = ".sol";

        public static System.IO.DirectoryInfo RepositoryInfo {
            get {
                System.IO.DirectoryInfo repositorio = new DirectoryInfo(REPORSITORY_PATH);
                repositorio.Create();//===>Crear ruta del folder si no existe.
                return repositorio;
            }
        }
        
        public static bool Guardar(Solicitud solicitud) {//===>Serializar la solicitud para guardarlo en un file *.dat
            try {
                string Id = Guid.NewGuid().ToString();
                System.IO.FileInfo Documento = new System.IO.FileInfo(System.IO.Path.Combine(RepositoryInfo.FullName, Id + FILE_EXTENSION ));
                System.Runtime.Serialization.IFormatter FF = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                System.IO.FileStream FS = new System.IO.FileStream(Documento.FullName, FileMode.Create, FileAccess.Write, FileShare.None);
                FF.Serialize(FS, solicitud);
                return true;
            } catch (System.Runtime.Serialization.SerializationException ex) {
                throw ex;                
            }
        }

        public static System.IO.FileInfo[] ObtenerSolicitudesGuardadas() {
            //===>Regresar todas las solicitudes guardadas en el repositorio.
            string FileExtensionPattern = "*" + FILE_EXTENSION;
            return RepositoryInfo.GetFiles(FileExtensionPattern);
        }
               

    }

}
