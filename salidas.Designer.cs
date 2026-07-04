namespace REGISTRO_DE_ALMACEN
{
    partial class FrmSalidas
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
            label1 = new Label();
            cboProducto = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            dtpFechaSalida = new DateTimePicker();
            txtCantidad = new TextBox();
            btnGuardarSalida = new Button();
            btnCancelarSalida = new Button();
            dgvSalidas = new DataGridView();
            idsalida = new DataGridViewTextBoxColumn();
            FECHA = new DataGridViewTextBoxColumn();
            PRODUCTO = new DataGridViewTextBoxColumn();
            CANTIDAD = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvSalidas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 38);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 0;
            label1.Text = "Producto:";
            // 
            // cboProducto
            // 
            cboProducto.FormattingEnabled = true;
            cboProducto.Location = new Point(152, 30);
            cboProducto.Name = "cboProducto";
            cboProducto.Size = new Size(749, 28);
            cboProducto.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 147);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 2;
            label2.Text = "Fecha:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 259);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 3;
            label3.Text = "Cantidad:";
            // 
            // dtpFechaSalida
            // 
            dtpFechaSalida.Location = new Point(152, 142);
            dtpFechaSalida.Name = "dtpFechaSalida";
            dtpFechaSalida.Size = new Size(749, 27);
            dtpFechaSalida.TabIndex = 4;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(152, 252);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(749, 27);
            txtCantidad.TabIndex = 5;
            // 
            // btnGuardarSalida
            // 
            btnGuardarSalida.Location = new Point(200, 370);
            btnGuardarSalida.Name = "btnGuardarSalida";
            btnGuardarSalida.Size = new Size(94, 29);
            btnGuardarSalida.TabIndex = 6;
            btnGuardarSalida.Text = "Guardar";
            btnGuardarSalida.UseVisualStyleBackColor = true;
            // 
            // btnCancelarSalida
            // 
            btnCancelarSalida.Location = new Point(356, 370);
            btnCancelarSalida.Name = "btnCancelarSalida";
            btnCancelarSalida.Size = new Size(94, 29);
            btnCancelarSalida.TabIndex = 7;
            btnCancelarSalida.Text = "Cancelar";
            btnCancelarSalida.UseVisualStyleBackColor = true;
            // 
            // dgvSalidas
            // 
            dgvSalidas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSalidas.Columns.AddRange(new DataGridViewColumn[] { idsalida, FECHA, PRODUCTO, CANTIDAD });
            dgvSalidas.Location = new Point(12, 405);
            dgvSalidas.Name = "dgvSalidas";
            dgvSalidas.RowHeadersWidth = 51;
            dgvSalidas.Size = new Size(552, 309);
            dgvSalidas.TabIndex = 8;
            // 
            // idsalida
            // 
            idsalida.HeaderText = "ID SALIDA";
            idsalida.MinimumWidth = 6;
            idsalida.Name = "idsalida";
            idsalida.Width = 125;
            // 
            // FECHA
            // 
            FECHA.HeaderText = "FECHA";
            FECHA.MinimumWidth = 6;
            FECHA.Name = "FECHA";
            FECHA.Width = 125;
            // 
            // PRODUCTO
            // 
            PRODUCTO.HeaderText = "PRODUCTO";
            PRODUCTO.MinimumWidth = 6;
            PRODUCTO.Name = "PRODUCTO";
            PRODUCTO.Width = 125;
            // 
            // CANTIDAD
            // 
            CANTIDAD.HeaderText = "CANTIDAD";
            CANTIDAD.MinimumWidth = 6;
            CANTIDAD.Name = "CANTIDAD";
            CANTIDAD.Width = 125;
            // 
            // FrmSalidas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 726);
            Controls.Add(dgvSalidas);
            Controls.Add(btnCancelarSalida);
            Controls.Add(btnGuardarSalida);
            Controls.Add(txtCantidad);
            Controls.Add(dtpFechaSalida);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cboProducto);
            Controls.Add(label1);
            Name = "FrmSalidas";
            Text = "SALIDAS";
            ((System.ComponentModel.ISupportInitialize)dgvSalidas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboProducto;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpFechaSalida;
        private TextBox txtCantidad;
        private Button btnGuardarSalida;
        private Button btnCancelarSalida;
        private DataGridView dgvSalidas;
        private DataGridViewTextBoxColumn idsalida;
        private DataGridViewTextBoxColumn FECHA;
        private DataGridViewTextBoxColumn PRODUCTO;
        private DataGridViewTextBoxColumn CANTIDAD;
    }
}