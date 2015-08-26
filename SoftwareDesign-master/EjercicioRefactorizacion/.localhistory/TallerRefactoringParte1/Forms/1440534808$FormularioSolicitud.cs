using System;
using System.Collections.Generic;
using System.IO;

namespace TallerRefactoringParte1 {


    public class FormularioSolicitud : System.Windows.Forms.Form {

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdAdjuntar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTipoDeSolicitudes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtRegistroLog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstArchivosAdjuntos;
        
        private void InitializeComponent() {
            this.lstArchivosAdjuntos = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdAdjuntar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTipoDeSolicitudes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRegistroLog = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
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
            this.lstArchivosAdjuntos.Size = new System.Drawing.Size(187, 173);
            this.lstArchivosAdjuntos.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdAdjuntar);
            this.groupBox1.Controls.Add(this.lstArchivosAdjuntos);
            this.groupBox1.Location = new System.Drawing.Point(438, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 228);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Archivos";
            // 
            // cmdAdjuntar
            // 
            this.cmdAdjuntar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdAdjuntar.Location = new System.Drawing.Point(7, 199);
            this.cmdAdjuntar.Name = "cmdAdjuntar";
            this.cmdAdjuntar.Size = new System.Drawing.Size(187, 23);
            this.cmdAdjuntar.TabIndex = 1;
            this.cmdAdjuntar.Text = "Abrir archivo...";
            this.cmdAdjuntar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(11, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tipo de solicitud :";
            // 
            // cmbTipoDeSolicitudes
            // 
            this.cmbTipoDeSolicitudes.FormattingEnabled = true;
            this.cmbTipoDeSolicitudes.Location = new System.Drawing.Point(131, 28);
            this.cmbTipoDeSolicitudes.Name = "cmbTipoDeSolicitudes";
            this.cmbTipoDeSolicitudes.Size = new System.Drawing.Size(167, 21);
            this.cmbTipoDeSolicitudes.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(55, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cantidad :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(74, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(131, 81);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(74, 20);
            this.textBox2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(69, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Precio :";
            // 
            // txtRegistroLog
            // 
            this.txtRegistroLog.Location = new System.Drawing.Point(2, 151);
            this.txtRegistroLog.Name = "txtRegistroLog";
            this.txtRegistroLog.ReadOnly = true;
            this.txtRegistroLog.Size = new System.Drawing.Size(430, 89);
            this.txtRegistroLog.TabIndex = 8;
            this.txtRegistroLog.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(4, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Eventos de registro";
            // 
            // FormularioSolicitud
            // 
            this.ClientSize = new System.Drawing.Size(650, 255);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRegistroLog);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTipoDeSolicitudes);
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

        public FormularioSolicitud() {
            InitializeComponent();
        }
    }
}
