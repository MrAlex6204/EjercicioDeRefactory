using System;
using System.Collections.Generic;
using System.IO;

namespace TallerRefactoringParte1 {


    public class FormularioSolicitud : System.Windows.Forms.Form {

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdAdjuntar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox lstArchivosAdjuntos;
        

        private void InitializeComponent() {
            this.lstArchivosAdjuntos = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdAdjuntar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstArchivosAdjuntos
            // 
            this.lstArchivosAdjuntos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstArchivosAdjuntos.FormattingEnabled = true;
            this.lstArchivosAdjuntos.Location = new System.Drawing.Point(7, 19);
            this.lstArchivosAdjuntos.Name = "lstArchivosAdjuntos";
            this.lstArchivosAdjuntos.Size = new System.Drawing.Size(187, 342);
            this.lstArchivosAdjuntos.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdAdjuntar);
            this.groupBox1.Controls.Add(this.lstArchivosAdjuntos);
            this.groupBox1.Location = new System.Drawing.Point(438, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 405);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Archivos";
            // 
            // cmdAdjuntar
            // 
            this.cmdAdjuntar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdAdjuntar.Location = new System.Drawing.Point(7, 376);
            this.cmdAdjuntar.Name = "cmdAdjuntar";
            this.cmdAdjuntar.Size = new System.Drawing.Size(187, 23);
            this.cmdAdjuntar.TabIndex = 1;
            this.cmdAdjuntar.Text = "Abrir archivo...";
            this.cmdAdjuntar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tipo de solicitud :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(106, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(167, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // FormularioSolicitud
            // 
            this.ClientSize = new System.Drawing.Size(650, 429);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormularioSolicitud";
            this.ShowIcon = false;
            this.Text = "Solicitud";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
