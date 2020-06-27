namespace SistemaVenta.Vista
{
    partial class Menu
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
            this.cmbTipoPizza = new System.Windows.Forms.ComboBox();
            this.cmbTamano = new System.Windows.Forms.ComboBox();
            this.cmbTipoBebida = new System.Windows.Forms.ComboBox();
            this.cmbTamanoBebida = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCantidadPizza = new System.Windows.Forms.TextBox();
            this.txtCantidadBebida = new System.Windows.Forms.TextBox();
            this.btnAgregarPedido = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCalcularPedido = new System.Windows.Forms.Button();
            this.lblPrecioPedido = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caerrarCajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revisarPedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNumeroDireccion = new System.Windows.Forms.TextBox();
            this.cmbEntrega = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbTipoPizza
            // 
            this.cmbTipoPizza.FormattingEnabled = true;
            this.cmbTipoPizza.Items.AddRange(new object[] {
            "ESPAÑOLA",
            "PEPERONNI",
            "NAPOLITANNA",
            "CUATRO ESTACIONES",
            "TEJANA"});
            this.cmbTipoPizza.Location = new System.Drawing.Point(122, 214);
            this.cmbTipoPizza.Name = "cmbTipoPizza";
            this.cmbTipoPizza.Size = new System.Drawing.Size(237, 21);
            this.cmbTipoPizza.TabIndex = 0;
            // 
            // cmbTamano
            // 
            this.cmbTamano.FormattingEnabled = true;
            this.cmbTamano.Items.AddRange(new object[] {
            "FAMILIAR",
            "MEDIANA",
            "INDIVIDUAL"});
            this.cmbTamano.Location = new System.Drawing.Point(122, 254);
            this.cmbTamano.Name = "cmbTamano";
            this.cmbTamano.Size = new System.Drawing.Size(237, 21);
            this.cmbTamano.TabIndex = 1;
            // 
            // cmbTipoBebida
            // 
            this.cmbTipoBebida.FormattingEnabled = true;
            this.cmbTipoBebida.Items.AddRange(new object[] {
            "COCA COLA",
            "SPRITE",
            "FANTA",
            "7UP"});
            this.cmbTipoBebida.Location = new System.Drawing.Point(479, 214);
            this.cmbTipoBebida.Name = "cmbTipoBebida";
            this.cmbTipoBebida.Size = new System.Drawing.Size(237, 21);
            this.cmbTipoBebida.TabIndex = 2;
            // 
            // cmbTamanoBebida
            // 
            this.cmbTamanoBebida.FormattingEnabled = true;
            this.cmbTamanoBebida.Items.AddRange(new object[] {
            "FAMILIAR",
            "INDIVIDUAL"});
            this.cmbTamanoBebida.Location = new System.Drawing.Point(479, 254);
            this.cmbTamanoBebida.Name = "cmbTamanoBebida";
            this.cmbTamanoBebida.Size = new System.Drawing.Size(237, 21);
            this.cmbTamanoBebida.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tipo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tamaño";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(198, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Pizzas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(559, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Bebidas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(45, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "Cantidad";
            // 
            // txtCantidadPizza
            // 
            this.txtCantidadPizza.Location = new System.Drawing.Point(122, 296);
            this.txtCantidadPizza.Name = "txtCantidadPizza";
            this.txtCantidadPizza.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadPizza.TabIndex = 12;
            this.txtCantidadPizza.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadPizza_KeyPress);
            // 
            // txtCantidadBebida
            // 
            this.txtCantidadBebida.Location = new System.Drawing.Point(480, 296);
            this.txtCantidadBebida.Name = "txtCantidadBebida";
            this.txtCantidadBebida.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadBebida.TabIndex = 13;
            this.txtCantidadBebida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadBebida_KeyPress);
            // 
            // btnAgregarPedido
            // 
            this.btnAgregarPedido.Location = new System.Drawing.Point(48, 353);
            this.btnAgregarPedido.Name = "btnAgregarPedido";
            this.btnAgregarPedido.Size = new System.Drawing.Size(174, 62);
            this.btnAgregarPedido.TabIndex = 14;
            this.btnAgregarPedido.Text = "Agregar Pedido";
            this.btnAgregarPedido.UseVisualStyleBackColor = true;
            this.btnAgregarPedido.Click += new System.EventHandler(this.btnAgregarPedido_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(302, 353);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(174, 62);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "Limpiar Pedido";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCalcularPedido
            // 
            this.btnCalcularPedido.Location = new System.Drawing.Point(542, 353);
            this.btnCalcularPedido.Name = "btnCalcularPedido";
            this.btnCalcularPedido.Size = new System.Drawing.Size(174, 62);
            this.btnCalcularPedido.TabIndex = 16;
            this.btnCalcularPedido.Text = "Calcular Pedido";
            this.btnCalcularPedido.UseVisualStyleBackColor = true;
            this.btnCalcularPedido.Click += new System.EventHandler(this.btnCalcularPedido_Click);
            // 
            // lblPrecioPedido
            // 
            this.lblPrecioPedido.AutoSize = true;
            this.lblPrecioPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioPedido.Location = new System.Drawing.Point(751, 33);
            this.lblPrecioPedido.Name = "lblPrecioPedido";
            this.lblPrecioPedido.Size = new System.Drawing.Size(19, 20);
            this.lblPrecioPedido.TabIndex = 1;
            this.lblPrecioPedido.Text = "0";
            this.lblPrecioPedido.TextChanged += new System.EventHandler(this.btnCalcularPedido_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(636, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Precio Total:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(400, 213);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 18);
            this.label10.TabIndex = 18;
            this.label10.Text = "Tipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(400, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tamaño";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(400, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 18);
            this.label4.TabIndex = 20;
            this.label4.Text = "Cantidad";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sesionToolStripMenuItem,
            this.operacionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sesionToolStripMenuItem
            // 
            this.sesionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.caerrarCajaToolStripMenuItem});
            this.sesionToolStripMenuItem.Name = "sesionToolStripMenuItem";
            this.sesionToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.sesionToolStripMenuItem.Text = "Sesion";
            // 
            // caerrarCajaToolStripMenuItem
            // 
            this.caerrarCajaToolStripMenuItem.Name = "caerrarCajaToolStripMenuItem";
            this.caerrarCajaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.caerrarCajaToolStripMenuItem.Text = "Cerrar Caja";
            this.caerrarCajaToolStripMenuItem.Click += new System.EventHandler(this.caerrarCajaToolStripMenuItem_Click);
            // 
            // operacionesToolStripMenuItem
            // 
            this.operacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarPedidoToolStripMenuItem,
            this.revisarPedidosToolStripMenuItem});
            this.operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
            this.operacionesToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.operacionesToolStripMenuItem.Text = "Operaciones";
            // 
            // agregarPedidoToolStripMenuItem
            // 
            this.agregarPedidoToolStripMenuItem.Name = "agregarPedidoToolStripMenuItem";
            this.agregarPedidoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.agregarPedidoToolStripMenuItem.Text = "Agregar Pedido";
            this.agregarPedidoToolStripMenuItem.Click += new System.EventHandler(this.agregarPedidoToolStripMenuItem_Click);
            // 
            // revisarPedidosToolStripMenuItem
            // 
            this.revisarPedidosToolStripMenuItem.Name = "revisarPedidosToolStripMenuItem";
            this.revisarPedidosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.revisarPedidosToolStripMenuItem.Text = "Revisar Pedidos";
            this.revisarPedidosToolStripMenuItem.Click += new System.EventHandler(this.revisarPedidosToolStripMenuItem_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(45, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 18);
            this.label8.TabIndex = 22;
            this.label8.Text = "Telefono";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(45, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 18);
            this.label11.TabIndex = 23;
            this.label11.Text = "Nombre";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(45, 151);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 18);
            this.label12.TabIndex = 24;
            this.label12.Text = "Entrega";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(400, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 18);
            this.label13.TabIndex = 25;
            this.label13.Text = "Direccion";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(122, 75);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(237, 20);
            this.txtNombreCliente.TabIndex = 26;
            this.txtNombreCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreCliente_KeyPress);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(122, 115);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 32;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(477, 75);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(200, 20);
            this.txtDireccion.TabIndex = 28;
            this.txtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccion_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(400, 114);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 18);
            this.label14.TabIndex = 29;
            this.label14.Text = "Numero";
            // 
            // txtNumeroDireccion
            // 
            this.txtNumeroDireccion.Location = new System.Drawing.Point(480, 115);
            this.txtNumeroDireccion.Name = "txtNumeroDireccion";
            this.txtNumeroDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroDireccion.TabIndex = 1;
            this.txtNumeroDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroDireccion_KeyPress);
            // 
            // cmbEntrega
            // 
            this.cmbEntrega.Items.AddRange(new object[] {
            "LOCAL",
            "DELIVERY"});
            this.cmbEntrega.Location = new System.Drawing.Point(122, 152);
            this.cmbEntrega.Name = "cmbEntrega";
            this.cmbEntrega.Size = new System.Drawing.Size(121, 21);
            this.cmbEntrega.TabIndex = 0;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbEntrega);
            this.Controls.Add(this.txtNumeroDireccion);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblPrecioPedido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnCalcularPedido);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAgregarPedido);
            this.Controls.Add(this.txtCantidadBebida);
            this.Controls.Add(this.txtCantidadPizza);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTamanoBebida);
            this.Controls.Add(this.cmbTipoBebida);
            this.Controls.Add(this.cmbTamano);
            this.Controls.Add(this.cmbTipoPizza);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTipoPizza;
        private System.Windows.Forms.ComboBox cmbTamano;
        private System.Windows.Forms.ComboBox cmbTipoBebida;
        private System.Windows.Forms.ComboBox cmbTamanoBebida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCantidadPizza;
        private System.Windows.Forms.TextBox txtCantidadBebida;
        private System.Windows.Forms.Button btnAgregarPedido;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCalcularPedido;
        private System.Windows.Forms.Label lblPrecioPedido;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caerrarCajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarPedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revisarPedidosToolStripMenuItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtNumeroDireccion;
        private System.Windows.Forms.ComboBox cmbEntrega;
    }
}