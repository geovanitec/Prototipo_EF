
namespace CapaVistaMoviemiento
{
    partial class frmCuentaBancaria
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
            this.txtBuscarB = new System.Windows.Forms.TextBox();
            this.txtEstadoB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdCuentaB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCuentaB = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReporteB = new System.Windows.Forms.Button();
            this.btnAyudaB = new System.Windows.Forms.Button();
            this.btnEliminarB = new System.Windows.Forms.Button();
            this.btnBuscarB = new System.Windows.Forms.Button();
            this.btnModificarB = new System.Windows.Forms.Button();
            this.btnInsertarB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentaB)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBuscarB
            // 
            this.txtBuscarB.Location = new System.Drawing.Point(542, 158);
            this.txtBuscarB.Multiline = true;
            this.txtBuscarB.Name = "txtBuscarB";
            this.txtBuscarB.Size = new System.Drawing.Size(289, 37);
            this.txtBuscarB.TabIndex = 18;
            // 
            // txtEstadoB
            // 
            this.txtEstadoB.Location = new System.Drawing.Point(237, 391);
            this.txtEstadoB.Multiline = true;
            this.txtEstadoB.Name = "txtEstadoB";
            this.txtEstadoB.Size = new System.Drawing.Size(219, 37);
            this.txtEstadoB.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "ESTADO CUENTA";
            // 
            // txtNombreB
            // 
            this.txtNombreB.Location = new System.Drawing.Point(237, 313);
            this.txtNombreB.Multiline = true;
            this.txtNombreB.Name = "txtNombreB";
            this.txtNombreB.Size = new System.Drawing.Size(219, 37);
            this.txtNombreB.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "NOMBRE CUENTA";
            // 
            // txtIdCuentaB
            // 
            this.txtIdCuentaB.Location = new System.Drawing.Point(237, 212);
            this.txtIdCuentaB.Multiline = true;
            this.txtIdCuentaB.Name = "txtIdCuentaB";
            this.txtIdCuentaB.Size = new System.Drawing.Size(219, 37);
            this.txtIdCuentaB.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID CUENTA BANCARIA";
            // 
            // dgvCuentaB
            // 
            this.dgvCuentaB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuentaB.Location = new System.Drawing.Point(513, 201);
            this.dgvCuentaB.Name = "dgvCuentaB";
            this.dgvCuentaB.RowHeadersWidth = 45;
            this.dgvCuentaB.Size = new System.Drawing.Size(518, 250);
            this.dgvCuentaB.TabIndex = 11;
            this.dgvCuentaB.SelectionChanged += new System.EventHandler(this.dgvCuentaB_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnReporteB);
            this.panel1.Controls.Add(this.btnAyudaB);
            this.panel1.Controls.Add(this.btnEliminarB);
            this.panel1.Controls.Add(this.btnBuscarB);
            this.panel1.Controls.Add(this.btnModificarB);
            this.panel1.Controls.Add(this.btnInsertarB);
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(255, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(563, 80);
            this.panel1.TabIndex = 10;
            // 
            // btnReporteB
            // 
            this.btnReporteB.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnReporteB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReporteB.ForeColor = System.Drawing.Color.Black;
            this.btnReporteB.Image = global::CapaVistaMoviemiento.Properties.Resources.reportes;
            this.btnReporteB.Location = new System.Drawing.Point(463, 0);
            this.btnReporteB.Name = "btnReporteB";
            this.btnReporteB.Size = new System.Drawing.Size(98, 78);
            this.btnReporteB.TabIndex = 6;
            this.btnReporteB.Text = "REPORTES";
            this.btnReporteB.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReporteB.UseVisualStyleBackColor = false;
            this.btnReporteB.Click += new System.EventHandler(this.btnReporteB_Click);
            // 
            // btnAyudaB
            // 
            this.btnAyudaB.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAyudaB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAyudaB.ForeColor = System.Drawing.Color.Black;
            this.btnAyudaB.Image = global::CapaVistaMoviemiento.Properties.Resources.ayuda;
            this.btnAyudaB.Location = new System.Drawing.Point(368, 0);
            this.btnAyudaB.Name = "btnAyudaB";
            this.btnAyudaB.Size = new System.Drawing.Size(98, 78);
            this.btnAyudaB.TabIndex = 5;
            this.btnAyudaB.Text = "AYUDAS";
            this.btnAyudaB.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAyudaB.UseVisualStyleBackColor = false;
            this.btnAyudaB.Click += new System.EventHandler(this.btnAyudaB_Click);
            // 
            // btnEliminarB
            // 
            this.btnEliminarB.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnEliminarB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEliminarB.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarB.Image = global::CapaVistaMoviemiento.Properties.Resources.borrar;
            this.btnEliminarB.Location = new System.Drawing.Point(273, 0);
            this.btnEliminarB.Name = "btnEliminarB";
            this.btnEliminarB.Size = new System.Drawing.Size(98, 78);
            this.btnEliminarB.TabIndex = 4;
            this.btnEliminarB.Text = "ELIMINAR";
            this.btnEliminarB.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminarB.UseVisualStyleBackColor = false;
            this.btnEliminarB.Click += new System.EventHandler(this.btnEliminarB_Click);
            // 
            // btnBuscarB
            // 
            this.btnBuscarB.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBuscarB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuscarB.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarB.Image = global::CapaVistaMoviemiento.Properties.Resources.buscar;
            this.btnBuscarB.Location = new System.Drawing.Point(180, 0);
            this.btnBuscarB.Name = "btnBuscarB";
            this.btnBuscarB.Size = new System.Drawing.Size(98, 78);
            this.btnBuscarB.TabIndex = 3;
            this.btnBuscarB.Text = "BUSCAR";
            this.btnBuscarB.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscarB.UseVisualStyleBackColor = false;
            this.btnBuscarB.Click += new System.EventHandler(this.btnBuscarB_Click);
            // 
            // btnModificarB
            // 
            this.btnModificarB.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnModificarB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnModificarB.ForeColor = System.Drawing.Color.Black;
            this.btnModificarB.Image = global::CapaVistaMoviemiento.Properties.Resources.modificar;
            this.btnModificarB.Location = new System.Drawing.Point(90, 0);
            this.btnModificarB.Name = "btnModificarB";
            this.btnModificarB.Size = new System.Drawing.Size(96, 78);
            this.btnModificarB.TabIndex = 2;
            this.btnModificarB.Text = "MODIFICAR";
            this.btnModificarB.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModificarB.UseVisualStyleBackColor = false;
            this.btnModificarB.Click += new System.EventHandler(this.btnModificarB_Click);
            // 
            // btnInsertarB
            // 
            this.btnInsertarB.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnInsertarB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnInsertarB.ForeColor = System.Drawing.Color.Black;
            this.btnInsertarB.Image = global::CapaVistaMoviemiento.Properties.Resources.guardar;
            this.btnInsertarB.Location = new System.Drawing.Point(0, 0);
            this.btnInsertarB.Name = "btnInsertarB";
            this.btnInsertarB.Size = new System.Drawing.Size(96, 78);
            this.btnInsertarB.TabIndex = 1;
            this.btnInsertarB.Text = "INSERTAR";
            this.btnInsertarB.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInsertarB.UseVisualStyleBackColor = false;
            this.btnInsertarB.Click += new System.EventHandler(this.btnInsertarB_Click);
            // 
            // frmCuentaBancaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1104, 545);
            this.Controls.Add(this.txtBuscarB);
            this.Controls.Add(this.txtEstadoB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombreB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdCuentaB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCuentaB);
            this.Controls.Add(this.panel1);
            this.Name = "frmCuentaBancaria";
            this.Text = "frmCuentaBancaria";
            this.Load += new System.EventHandler(this.frmCuentaBancaria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentaB)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscarB;
        private System.Windows.Forms.TextBox txtEstadoB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdCuentaB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCuentaB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReporteB;
        private System.Windows.Forms.Button btnAyudaB;
        private System.Windows.Forms.Button btnEliminarB;
        private System.Windows.Forms.Button btnBuscarB;
        private System.Windows.Forms.Button btnModificarB;
        private System.Windows.Forms.Button btnInsertarB;
    }
}