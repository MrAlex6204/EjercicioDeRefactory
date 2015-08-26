using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
namespace TallerRefactoringParte1 {


    public class FormularioSolicitud : System.Windows.Forms.Form {
        #region Windows Designer
        
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdAdjuntar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTipoDeSolicitudes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtRegistroLog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox lstArchivosAdjuntos;
        
        private void InitializeComponent() {
            this.lstArchivosAdjuntos = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdAdjuntar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTipoDeSolicitudes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRegistroLog = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmd = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.cmdAdjuntar.Click += new System.EventHandler(this.cmdAdjuntar_Click);
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
            this.cmbTipoDeSolicitudes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(131, 55);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(74, 20);
            this.txtCantidad.TabIndex = 5;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(131, 81);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(74, 20);
            this.txtPrecio.TabIndex = 7;
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
            // cmd
            // 
            this.cmd.Location = new System.Drawing.Point(552, 251);
            this.cmd.Name = "cmd";
            this.cmd.Size = new System.Drawing.Size(86, 23);
            this.cmd.TabIndex = 10;
            this.cmd.Text = "Borrar";
            this.cmd.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(460, 251);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Registrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormularioSolicitud
            // 
            this.ClientSize = new System.Drawing.Size(650, 286);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRegistroLog);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTipoDeSolicitudes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormularioSolicitud";
            this.ShowIcon = false;
            this.Text = "Solicitud";
            this.Load += new System.EventHandler(this.FormularioSolicitud_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public FormularioSolicitud() {
            InitializeComponent();
        }
        #endregion

        private void button2_Click(object sender, EventArgs e) {
            System.Registro.Solicitud solicitud = new System.Registro.Solicitud();
            solicitud.RegistrandoSolicitud += new System.Registro.Solicitud.DlgRegistrandoSolicitud(RegistrandoSolicitudEvent);

            txtRegistroLog.Text = "";
            txtRegistroLog.AppendText("Registrando solicitud...*\n");

            solicitud.Cantidad = int.Parse(txtCantidad.Text);
            solicitud.Precio = int.Parse(txtPrecio.Text);
            solicitud.TipoDeSolicitud = (System.Registro.Solicitud.Tipo)Enum.Parse(typeof(System.Registro.Solicitud.Tipo), cmbTipoDeSolicitudes.Text);
            solicitud.Registrar();
            System.Registro.RepositorioSolicitud.Guardar(solicitud);
            MessageBox.Show("Solicitud Registrada!");
        }

        private void FormularioSolicitud_Load(object sender, EventArgs e) {
            cmbTipoDeSolicitudes.DataSource = Enum.GetNames(typeof(System.Registro.Solicitud.Tipo));
        }

        private void RegistrandoSolicitudEvent(object sender, object e) {
            txtRegistroLog.AppendText(e + "\n");
        }

        private void cmdAdjuntar_Click(object sender, EventArgs e) {
            OpenFileDialog dlgOpen = new OpenFileDialog();

            dlgOpen.Filter = String.Join(",", System.Registro.ArchivoAdjunto.FormatosValidos);
            dlgOpen.ShowDialog();
        }
    }
}
