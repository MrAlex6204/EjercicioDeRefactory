using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerRefactoringParte1.Despues {
    class FormularioSolicitud {

        public void Registrar(Solicitud solicitud) {

            if (!solicitud.Registrar()) {
                //===>No se pudo registrar la solicitud y salir de la rutina.
                return;
            } 

            //===>Se a registrado exitosamente!
        }

    }
}
