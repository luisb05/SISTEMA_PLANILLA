﻿
namespace Sistema_Planilla.Views.Concepto
{
    partial class ConseptosVista
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxaplia = new System.Windows.Forms.ComboBox();
            this.cbxtipoconcepto = new System.Windows.Forms.ComboBox();
            this.txtcomentario = new System.Windows.Forms.TextBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtidconcepto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvUbicardatos = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btneliminar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btncargar = new System.Windows.Forms.Button();
            this.txtubicar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lblmodo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUbicardatos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(319, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modulo de Conceptos";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(284, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(903, 48);
            this.panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxaplia);
            this.groupBox1.Controls.Add(this.cbxtipoconcepto);
            this.groupBox1.Controls.Add(this.txtcomentario);
            this.groupBox1.Controls.Add(this.txtprecio);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtidconcepto);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(241, 75);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(495, 345);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Generales.";
            // 
            // cbxaplia
            // 
            this.cbxaplia.FormattingEnabled = true;
            this.cbxaplia.Items.AddRange(new object[] {
            "Directos",
            "Indirectos",
            "Temporales"});
            this.cbxaplia.Location = new System.Drawing.Point(173, 181);
            this.cbxaplia.Margin = new System.Windows.Forms.Padding(2);
            this.cbxaplia.Name = "cbxaplia";
            this.cbxaplia.Size = new System.Drawing.Size(142, 30);
            this.cbxaplia.TabIndex = 13;
            // 
            // cbxtipoconcepto
            // 
            this.cbxtipoconcepto.FormattingEnabled = true;
            this.cbxtipoconcepto.Items.AddRange(new object[] {
            "Ingreso",
            "Deduccion"});
            this.cbxtipoconcepto.Location = new System.Drawing.Point(173, 131);
            this.cbxtipoconcepto.Margin = new System.Windows.Forms.Padding(2);
            this.cbxtipoconcepto.Name = "cbxtipoconcepto";
            this.cbxtipoconcepto.Size = new System.Drawing.Size(142, 30);
            this.cbxtipoconcepto.TabIndex = 12;
            // 
            // txtcomentario
            // 
            this.txtcomentario.Location = new System.Drawing.Point(173, 265);
            this.txtcomentario.Margin = new System.Windows.Forms.Padding(2);
            this.txtcomentario.Name = "txtcomentario";
            this.txtcomentario.Size = new System.Drawing.Size(142, 30);
            this.txtcomentario.TabIndex = 11;
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(173, 221);
            this.txtprecio.Margin = new System.Windows.Forms.Padding(2);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(142, 30);
            this.txtprecio.TabIndex = 10;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(173, 81);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(142, 30);
            this.txtNombre.TabIndex = 7;
            // 
            // txtidconcepto
            // 
            this.txtidconcepto.Location = new System.Drawing.Point(173, 38);
            this.txtidconcepto.Margin = new System.Windows.Forms.Padding(2);
            this.txtidconcepto.Name = "txtidconcepto";
            this.txtidconcepto.Size = new System.Drawing.Size(142, 30);
            this.txtidconcepto.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 270);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 22);
            this.label7.TabIndex = 5;
            this.label7.Text = "Comentarios.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 226);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 22);
            this.label6.TabIndex = 4;
            this.label6.Text = "Cantidad/Precio.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 181);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "Aplia a Personal.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 136);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tipo de Concepto.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre del Concepto.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Id Concepto.";
            // 
            // dgvUbicardatos
            // 
            this.dgvUbicardatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUbicardatos.Location = new System.Drawing.Point(623, 222);
            this.dgvUbicardatos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvUbicardatos.Name = "dgvUbicardatos";
            this.dgvUbicardatos.RowHeadersWidth = 62;
            this.dgvUbicardatos.RowTemplate.Height = 28;
            this.dgvUbicardatos.Size = new System.Drawing.Size(602, 164);
            this.dgvUbicardatos.TabIndex = 3;
            this.dgvUbicardatos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUbicardatos_CellMouseClick);
            this.dgvUbicardatos.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUbicardatos_CellMouseDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btneliminar);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btncargar);
            this.groupBox2.Controls.Add(this.txtubicar);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(623, 105);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(602, 113);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Funciones.";
            // 
            // btneliminar
            // 
            this.btneliminar.Enabled = false;
            this.btneliminar.Location = new System.Drawing.Point(361, 83);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(93, 23);
            this.btneliminar.TabIndex = 11;
            this.btneliminar.Text = "Eliminar.";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(361, 47);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Cancelar.";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btncargar
            // 
            this.btncargar.Location = new System.Drawing.Point(361, 12);
            this.btncargar.Margin = new System.Windows.Forms.Padding(2);
            this.btncargar.Name = "btncargar";
            this.btncargar.Size = new System.Drawing.Size(93, 23);
            this.btncargar.TabIndex = 9;
            this.btncargar.Text = "Cargar.";
            this.btncargar.UseVisualStyleBackColor = true;
            this.btncargar.Click += new System.EventHandler(this.btncargar_Click);
            // 
            // txtubicar
            // 
            this.txtubicar.Location = new System.Drawing.Point(66, 84);
            this.txtubicar.Margin = new System.Windows.Forms.Padding(2);
            this.txtubicar.Name = "txtubicar";
            this.txtubicar.Size = new System.Drawing.Size(225, 27);
            this.txtubicar.TabIndex = 8;
            this.txtubicar.TextChanged += new System.EventHandler(this.txtubicar_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 87);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "Ubicar.";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(994, 394);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(230, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Salir.";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblmodo
            // 
            this.lblmodo.AutoSize = true;
            this.lblmodo.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmodo.ForeColor = System.Drawing.Color.Maroon;
            this.lblmodo.Location = new System.Drawing.Point(975, 75);
            this.lblmodo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblmodo.Name = "lblmodo";
            this.lblmodo.Size = new System.Drawing.Size(89, 31);
            this.lblmodo.TabIndex = 10;
            this.lblmodo.Text = "Modo.";
            // 
            // ConseptosVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1468, 421);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblmodo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvUbicardatos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ConseptosVista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ConseptosVista";
            this.Load += new System.EventHandler(this.ConseptosVista_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUbicardatos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtcomentario;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtidconcepto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvUbicardatos;
        private System.Windows.Forms.ComboBox cbxaplia;
        private System.Windows.Forms.ComboBox cbxtipoconcepto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btncargar;
        private System.Windows.Forms.TextBox txtubicar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblmodo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btneliminar;
    }
}