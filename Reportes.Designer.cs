namespace REGISTRO_DE_ALMACEN
{
    partial class FrmReportes
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
            label2 = new Label();
            label3 = new Label();
            dtpDesde = new DateTimePicker();
            dtpHasta = new DateTimePicker();
            cboTipoReporte = new ComboBox();
            btnBuscarReporte = new Button();
            btnImprimirReporte = new Button();
            dataGridView1 = new DataGridView();
            FECHA = new DataGridViewTextBoxColumn();
            TIPO = new DataGridViewTextBoxColumn();
            PRODUCTO = new DataGridViewTextBoxColumn();
            CANTIDAD = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 35);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 0;
            label1.Text = "Desde:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 141);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "Hasta:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 246);
            label3.Name = "label3";
            label3.Size = new Size(124, 20);
            label3.TabIndex = 2;
            label3.Text = " Tipo de Reporte:";
            // 
            // dtpDesde
            // 
            dtpDesde.Location = new Point(161, 28);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(696, 27);
            dtpDesde.TabIndex = 3;
            // 
            // dtpHasta
            // 
            dtpHasta.Location = new Point(161, 134);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(696, 27);
            dtpHasta.TabIndex = 4;
            // 
            // cboTipoReporte
            // 
            cboTipoReporte.FormattingEnabled = true;
            cboTipoReporte.Items.AddRange(new object[] { "Entradas", "Salidas", "General" });
            cboTipoReporte.Location = new Point(161, 243);
            cboTipoReporte.Name = "cboTipoReporte";
            cboTipoReporte.Size = new Size(696, 28);
            cboTipoReporte.TabIndex = 5;
            // 
            // btnBuscarReporte
            // 
            btnBuscarReporte.Location = new Point(763, 309);
            btnBuscarReporte.Name = "btnBuscarReporte";
            btnBuscarReporte.Size = new Size(94, 29);
            btnBuscarReporte.TabIndex = 6;
            btnBuscarReporte.Text = "Buscar";
            btnBuscarReporte.UseVisualStyleBackColor = true;
            // 
            // btnImprimirReporte
            // 
            btnImprimirReporte.Location = new Point(763, 386);
            btnImprimirReporte.Name = "btnImprimirReporte";
            btnImprimirReporte.Size = new Size(94, 29);
            btnImprimirReporte.TabIndex = 7;
            btnImprimirReporte.Text = "Imprimir";
            btnImprimirReporte.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { FECHA, TIPO, PRODUCTO, CANTIDAD });
            dataGridView1.Location = new Point(12, 450);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(556, 292);
            dataGridView1.TabIndex = 8;
            // 
            // FECHA
            // 
            FECHA.HeaderText = "FECHA";
            FECHA.MinimumWidth = 6;
            FECHA.Name = "FECHA";
            FECHA.Width = 125;
            // 
            // TIPO
            // 
            TIPO.HeaderText = "TIPO";
            TIPO.MinimumWidth = 6;
            TIPO.Name = "TIPO";
            TIPO.Width = 125;
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
            // FrmReportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(976, 754);
            Controls.Add(dataGridView1);
            Controls.Add(btnImprimirReporte);
            Controls.Add(btnBuscarReporte);
            Controls.Add(cboTipoReporte);
            Controls.Add(dtpHasta);
            Controls.Add(dtpDesde);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmReportes";
            Text = "REPORTES";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpDesde;
        private DateTimePicker dtpHasta;
        private ComboBox cboTipoReporte;
        private Button btnBuscarReporte;
        private Button btnImprimirReporte;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn FECHA;
        private DataGridViewTextBoxColumn TIPO;
        private DataGridViewTextBoxColumn PRODUCTO;
        private DataGridViewTextBoxColumn CANTIDAD;
    }
}