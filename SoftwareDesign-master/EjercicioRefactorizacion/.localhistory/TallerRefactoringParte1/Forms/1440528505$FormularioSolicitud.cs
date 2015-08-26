using System;
using System.Collections.Generic;
using System.IO;

namespace TallerRefactoringParte1 {


    public class FormularioSolicitud : System.Windows.Forms.Form {
        private System.Windows.Forms.ListBox lstArchivosAdjuntos;




        private void InitializeComponent() {
            this.lstArchivosAdjuntos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstArchivosAdjuntos
            // 
            this.lstArchivosAdjuntos.FormattingEnabled = true;
            this.lstArchivosAdjuntos.Location = new System.Drawing.Point(473, 28);
            this.lstArchivosAdjuntos.Name = "lstArchivosAdjuntos";
            this.lstArchivosAdjuntos.Size = new System.Drawing.Size(165, 290);
            this.lstArchivosAdjuntos.TabIndex = 0;
            // 
            // FormularioSolicitud
            // 
            this.ClientSize = new System.Drawing.Size(650, 429);
            this.Controls.Add(this.lstArchivosAdjuntos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormularioSolicitud";
            this.ShowIcon = false;
            this.Text = "Solicitud";
            this.ResumeLayout(false);

        }
    }
}
