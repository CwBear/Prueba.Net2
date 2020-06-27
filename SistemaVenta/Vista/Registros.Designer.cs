namespace SistemaVenta.Vista
{
    partial class Registros
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
            this.registrosGridView = new System.Windows.Forms.DataGridView();
            this.nombrePizzaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tamanoPizzaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadPizzaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreBebidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tamanoBebidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadBebidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.registrosDataSet1 = new SistemaVenta.Controlador.RegistrosDataSet();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registrosDataSet = new SistemaVenta.Controlador.RegistrosDataSet();
            this.productoTableAdapter = new SistemaVenta.Controlador.RegistrosDataSetTableAdapters.ProductoTableAdapter();
            this.btnFinalizarPedido = new System.Windows.Forms.Button();
            this.btnActualizarGrid = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarCajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revisarPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.registrosGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrosDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrosDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // registrosGridView
            // 
            this.registrosGridView.AllowUserToAddRows = false;
            this.registrosGridView.AllowUserToDeleteRows = false;
            this.registrosGridView.AutoGenerateColumns = false;
            this.registrosGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.registrosGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombrePizzaDataGridViewTextBoxColumn,
            this.tamanoPizzaDataGridViewTextBoxColumn,
            this.cantidadPizzaDataGridViewTextBoxColumn,
            this.nombreBebidaDataGridViewTextBoxColumn,
            this.tamanoBebidaDataGridViewTextBoxColumn,
            this.cantidadBebidaDataGridViewTextBoxColumn,
            this.estadoPedido});
            this.registrosGridView.DataSource = this.productoBindingSource1;
            this.registrosGridView.Location = new System.Drawing.Point(27, 56);
            this.registrosGridView.Name = "registrosGridView";
            this.registrosGridView.ReadOnly = true;
            this.registrosGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.registrosGridView.Size = new System.Drawing.Size(664, 342);
            this.registrosGridView.TabIndex = 0;
            // 
            // nombrePizzaDataGridViewTextBoxColumn
            // 
            this.nombrePizzaDataGridViewTextBoxColumn.DataPropertyName = "nombrePizza";
            this.nombrePizzaDataGridViewTextBoxColumn.HeaderText = "Tipo Pizza";
            this.nombrePizzaDataGridViewTextBoxColumn.Name = "nombrePizzaDataGridViewTextBoxColumn";
            this.nombrePizzaDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombrePizzaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tamanoPizzaDataGridViewTextBoxColumn
            // 
            this.tamanoPizzaDataGridViewTextBoxColumn.DataPropertyName = "tamanoPizza";
            this.tamanoPizzaDataGridViewTextBoxColumn.HeaderText = "Tamano Pizza";
            this.tamanoPizzaDataGridViewTextBoxColumn.Name = "tamanoPizzaDataGridViewTextBoxColumn";
            this.tamanoPizzaDataGridViewTextBoxColumn.ReadOnly = true;
            this.tamanoPizzaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // cantidadPizzaDataGridViewTextBoxColumn
            // 
            this.cantidadPizzaDataGridViewTextBoxColumn.DataPropertyName = "cantidadPizza";
            this.cantidadPizzaDataGridViewTextBoxColumn.HeaderText = "Cantidad Pizza";
            this.cantidadPizzaDataGridViewTextBoxColumn.Name = "cantidadPizzaDataGridViewTextBoxColumn";
            this.cantidadPizzaDataGridViewTextBoxColumn.ReadOnly = true;
            this.cantidadPizzaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cantidadPizzaDataGridViewTextBoxColumn.Width = 60;
            // 
            // nombreBebidaDataGridViewTextBoxColumn
            // 
            this.nombreBebidaDataGridViewTextBoxColumn.DataPropertyName = "nombreBebida";
            this.nombreBebidaDataGridViewTextBoxColumn.HeaderText = "Tipo Bebida";
            this.nombreBebidaDataGridViewTextBoxColumn.Name = "nombreBebidaDataGridViewTextBoxColumn";
            this.nombreBebidaDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreBebidaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tamanoBebidaDataGridViewTextBoxColumn
            // 
            this.tamanoBebidaDataGridViewTextBoxColumn.DataPropertyName = "tamanoBebida";
            this.tamanoBebidaDataGridViewTextBoxColumn.HeaderText = "Tamano Bebida";
            this.tamanoBebidaDataGridViewTextBoxColumn.Name = "tamanoBebidaDataGridViewTextBoxColumn";
            this.tamanoBebidaDataGridViewTextBoxColumn.ReadOnly = true;
            this.tamanoBebidaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // cantidadBebidaDataGridViewTextBoxColumn
            // 
            this.cantidadBebidaDataGridViewTextBoxColumn.DataPropertyName = "cantidadBebida";
            this.cantidadBebidaDataGridViewTextBoxColumn.HeaderText = "Cantidad Bebida";
            this.cantidadBebidaDataGridViewTextBoxColumn.Name = "cantidadBebidaDataGridViewTextBoxColumn";
            this.cantidadBebidaDataGridViewTextBoxColumn.ReadOnly = true;
            this.cantidadBebidaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cantidadBebidaDataGridViewTextBoxColumn.Width = 60;
            // 
            // estadoPedido
            // 
            this.estadoPedido.DataPropertyName = "estadoPedido";
            this.estadoPedido.HeaderText = "Estado Pedido";
            this.estadoPedido.Name = "estadoPedido";
            this.estadoPedido.ReadOnly = true;
            this.estadoPedido.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // productoBindingSource1
            // 
            this.productoBindingSource1.DataMember = "Producto";
            this.productoBindingSource1.DataSource = this.registrosDataSet1;
            // 
            // registrosDataSet1
            // 
            this.registrosDataSet1.DataSetName = "RegistrosDataSet";
            this.registrosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "Producto";
            this.productoBindingSource.DataSource = this.registrosDataSet;
            // 
            // registrosDataSet
            // 
            this.registrosDataSet.DataSetName = "RegistrosDataSet";
            this.registrosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // btnFinalizarPedido
            // 
            this.btnFinalizarPedido.Location = new System.Drawing.Point(716, 91);
            this.btnFinalizarPedido.Name = "btnFinalizarPedido";
            this.btnFinalizarPedido.Size = new System.Drawing.Size(115, 48);
            this.btnFinalizarPedido.TabIndex = 1;
            this.btnFinalizarPedido.Text = "Finalizar Pedido";
            this.btnFinalizarPedido.UseVisualStyleBackColor = true;
            this.btnFinalizarPedido.Click += new System.EventHandler(this.btnFinalizarPedido_Click);
            // 
            // btnActualizarGrid
            // 
            this.btnActualizarGrid.Location = new System.Drawing.Point(716, 169);
            this.btnActualizarGrid.Name = "btnActualizarGrid";
            this.btnActualizarGrid.Size = new System.Drawing.Size(115, 48);
            this.btnActualizarGrid.TabIndex = 2;
            this.btnActualizarGrid.Text = "Actualizar Vista";
            this.btnActualizarGrid.UseVisualStyleBackColor = true;
            this.btnActualizarGrid.Click += new System.EventHandler(this.btnActualizarGrid_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sesionToolStripMenuItem,
            this.operacionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(843, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sesionToolStripMenuItem
            // 
            this.sesionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarCajaToolStripMenuItem});
            this.sesionToolStripMenuItem.Name = "sesionToolStripMenuItem";
            this.sesionToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.sesionToolStripMenuItem.Text = "Sesion";
            // 
            // cerrarCajaToolStripMenuItem
            // 
            this.cerrarCajaToolStripMenuItem.Name = "cerrarCajaToolStripMenuItem";
            this.cerrarCajaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cerrarCajaToolStripMenuItem.Text = "Cerrar Caja";
            this.cerrarCajaToolStripMenuItem.Click += new System.EventHandler(this.cerrarCajaToolStripMenuItem_Click);
            // 
            // operacionesToolStripMenuItem
            // 
            this.operacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarProductoToolStripMenuItem,
            this.revisarPedidoToolStripMenuItem});
            this.operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
            this.operacionesToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.operacionesToolStripMenuItem.Text = "Operaciones";
            // 
            // agregarProductoToolStripMenuItem
            // 
            this.agregarProductoToolStripMenuItem.Name = "agregarProductoToolStripMenuItem";
            this.agregarProductoToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.agregarProductoToolStripMenuItem.Text = "Agregar Producto";
            this.agregarProductoToolStripMenuItem.Click += new System.EventHandler(this.agregarProductoToolStripMenuItem_Click);
            // 
            // revisarPedidoToolStripMenuItem
            // 
            this.revisarPedidoToolStripMenuItem.Name = "revisarPedidoToolStripMenuItem";
            this.revisarPedidoToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.revisarPedidoToolStripMenuItem.Text = "Revisar Pedido";
            this.revisarPedidoToolStripMenuItem.Click += new System.EventHandler(this.revisarPedidoToolStripMenuItem_Click);
            // 
            // Registros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 450);
            this.Controls.Add(this.btnActualizarGrid);
            this.Controls.Add(this.btnFinalizarPedido);
            this.Controls.Add(this.registrosGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Registros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registros";
            this.Load += new System.EventHandler(this.Registros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.registrosGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrosDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrosDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView registrosGridView;
        private Controlador.RegistrosDataSet registrosDataSet;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private Controlador.RegistrosDataSetTableAdapters.ProductoTableAdapter productoTableAdapter;
        private Controlador.RegistrosDataSet registrosDataSet1;
        private System.Windows.Forms.BindingSource productoBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrePizzaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tamanoPizzaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadPizzaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreBebidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tamanoBebidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadBebidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnFinalizarPedido;
        private System.Windows.Forms.Button btnActualizarGrid;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarCajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revisarPedidoToolStripMenuItem;
    }
}