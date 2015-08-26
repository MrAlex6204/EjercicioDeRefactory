﻿using System;
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
        
        public List<ArchivoAdjunto> ArchivosAdjuntos { get; set; }
        public string RolResponsable { get { return _RolResponsable; } }
        public Tipo TipoDeSolicitud { get; set; }
        public DateTime FechaEnvio { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Descuento { get { return _Descuento;} }
                
        public bool Registrar() {
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
                RepositorioSolicitud.Guardar(this);
                return true;
            } catch (Exception ex) {
                var mensaje = ex.Message + "\n";
                mensaje += ex.Source + "\n";
                mensaje += ex.StackTrace + "\n";
                File.WriteAllText("c:\\logs\\logError.txt", mensaje);
                return false;   
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

    public class RepositorioSolicitud {
        public static void Guardar(Solicitud solicitud) {

        }
    }

}
