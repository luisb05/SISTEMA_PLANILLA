﻿
namespace Sistema_Planilla.Views.Asistencia
{
    partial class AsistenciaVista
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtcodigoEmpleado = new System.Windows.Forms.TextBox();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblapellido = new System.Windows.Forms.Label();
            this.lblfecharactual = new System.Windows.Forms.Label();
            this.lblhoraactual = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.lblhora = new System.Windows.Forms.Label();
            this.lblmensaje = new System.Windows.Forms.Label();
            this.FechaHora = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtcodigoEmpleado
            // 
            this.txtcodigoEmpleado.Location = new System.Drawing.Point(190, 85);
            this.txtcodigoEmpleado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtcodigoEmpleado.Name = "txtcodigoEmpleado";
            this.txtcodigoEmpleado.Size = new System.Drawing.Size(167, 20);
            this.txtcodigoEmpleado.TabIndex = 0;
            this.txtcodigoEmpleado.TextChanged += new System.EventHandler(this.txtcodigoEmpleado_TextChanged);
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(187, 117);
            this.lblcodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(46, 15);
            this.lblcodigo.TabIndex = 1;
            this.lblcodigo.Text = "Codigo";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(260, 117);
            this.lblnombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(52, 15);
            this.lblnombre.TabIndex = 2;
            this.lblnombre.Text = "Nombre";
            // 
            // lblapellido
            // 
            this.lblapellido.AutoSize = true;
            this.lblapellido.Location = new System.Drawing.Point(378, 117);
            this.lblapellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblapellido.Name = "lblapellido";
            this.lblapellido.Size = new System.Drawing.Size(51, 15);
            this.lblapellido.TabIndex = 3;
            this.lblapellido.Text = "Apellido";
            // 
            // lblfecharactual
            // 
            this.lblfecharactual.AutoSize = true;
            this.lblfecharactual.Location = new System.Drawing.Point(472, 42);
            this.lblfecharactual.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblfecharactual.Name = "lblfecharactual";
            this.lblfecharactual.Size = new System.Drawing.Size(77, 15);
            this.lblfecharactual.TabIndex = 4;
            this.lblfecharactual.Text = "Fecha Actual";
            this.lblfecharactual.Click += new System.EventHandler(this.lblfecharactual_Click);
            // 
            // lblhoraactual
            // 
            this.lblhoraactual.AutoSize = true;
            this.lblhoraactual.Location = new System.Drawing.Point(551, 42);
            this.lblhoraactual.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblhoraactual.Name = "lblhoraactual";
            this.lblhoraactual.Size = new System.Drawing.Size(70, 15);
            this.lblhoraactual.TabIndex = 5;
            this.lblhoraactual.Text = "Hora Actual";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Location = new System.Drawing.Point(569, 117);
            this.lblfecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(41, 15);
            this.lblfecha.TabIndex = 6;
            this.lblfecha.Text = "Fecha";
            // 
            // lblhora
            // 
            this.lblhora.AutoSize = true;
            this.lblhora.Location = new System.Drawing.Point(673, 117);
            this.lblhora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(34, 15);
            this.lblhora.TabIndex = 7;
            this.lblhora.Text = "Hora";
            // 
            // lblmensaje
            // 
            this.lblmensaje.AutoSize = true;
            this.lblmensaje.Location = new System.Drawing.Point(187, 148);
            this.lblmensaje.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblmensaje.Name = "lblmensaje";
            this.lblmensaje.Size = new System.Drawing.Size(55, 15);
            this.lblmensaje.TabIndex = 8;
            this.lblmensaje.Text = "Mensaje";
            // 
            // FechaHora
            // 
            this.FechaHora.Enabled = true;
            this.FechaHora.Tick += new System.EventHandler(this.FechaHora_Tick);
            // 
            // AsistenciaVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 267);
            this.ControlBox = false;
            this.Controls.Add(this.lblmensaje);
            this.Controls.Add(this.lblhora);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.lblhoraactual);
            this.Controls.Add(this.lblfecharactual);
            this.Controls.Add(this.lblapellido);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.lblcodigo);
            this.Controls.Add(this.txtcodigoEmpleado);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AsistenciaVista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AsistenciaVista_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcodigoEmpleado;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblapellido;
        private System.Windows.Forms.Label lblfecharactual;
        private System.Windows.Forms.Label lblhoraactual;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Label lblmensaje;
        private System.Windows.Forms.Timer FechaHora;
    }
}