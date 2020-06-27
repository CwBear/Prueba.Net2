using SistemaVenta.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVenta.Vista
{
    public partial class Menu : Form
    {
        private float precioPizza, precioBebida, precioTotal;
        private string tipoPizza, tipoBebida, tamanoPizza, tamanoBebida;
        private int cantidadPizza, cantidadBebida;

        public Menu()
        {
            InitializeComponent();
        }

        private void caerrarCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros registros = new Registros();
            MessageBox.Show("El Total Recaudado es:" + registros.SumaTotal());
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void agregarPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void revisarPedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros registros = new Registros();
            registros.Show();
            this.Hide();

        }
        private void txtNombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }
        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtCantidadPizza_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtCantidadBebida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtNumeroDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void btnAgregarPedido_Click(object sender, EventArgs e)
        {
            if(txtCantidadPizza.TextLength != 0 && txtNombreCliente.TextLength != 0)
            {
                AgregarPedido();
                AgregarCliente();
            }
            else
            {
                MessageBox.Show("Complete los Campos faltantes Porfavor");
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void btnCalcularPedido_Click(object sender, EventArgs e)
        {
            lblPrecioPedido.Text = Convert.ToString(PrecioTotal());
        }

        private void AgregarCliente()
        {
            using (SistemaVenta.Modelo.ConnectDB bd = new ConnectDB())
            {
                Cliente oCliente = new Cliente();
                oCliente.nombre = txtNombreCliente.Text.Trim();
                oCliente.phone = Convert.ToInt32(txtTelefono.Text.Trim());
                oCliente.direccion = Direccion();
                bd.Cliente.Add(oCliente);
                bd.SaveChanges();
            }
        }

        private string Direccion()
        {
            string direccion = (txtDireccion.Text.Trim() + " " + txtNumeroDireccion.Text.Trim());
            return direccion;
        }

        private void AgregarPedido()
        {
            using (SistemaVenta.Modelo.ConnectDB bd = new SistemaVenta.Modelo.ConnectDB())
            {
                Producto oProducto = new Producto();
                oProducto.id = ContadorRegistros();
                oProducto.nombrePizza = TipoPizza();
                oProducto.nombreBebida = TipoBebida();
                oProducto.tamanoPizza = TamanoPizza();
                oProducto.tamanoBebida = TamanoBebida();
                oProducto.cantidadPizza = CantidadPizza();
                oProducto.cantidadBebida = CantidadBebida();
                oProducto.precioPizza = PrecioPizza();
                oProducto.precioBebida = PrecioBebida();
                oProducto.precioTotal = PrecioTotal();
                oProducto.estadoPedido = "PENDIENTE";
                bd.Producto.Add(oProducto);
                bd.SaveChanges();
            }
        }
        private void Limpiar()
        {
            cmbTamano.Text = string.Empty;
            cmbTipoPizza.Text = string.Empty;
            cmbTipoBebida.Text = string.Empty;
            cmbTamanoBebida.Text = string.Empty;
            txtCantidadBebida.Text = string.Empty;
            txtCantidadPizza.Text = string.Empty;
        }

        private int ContadorRegistros()
        {
            using (SistemaVenta.Modelo.ConnectDB bd = new SistemaVenta.Modelo.ConnectDB())
            {
                int LastRecord = (from c in bd.Producto orderby c.id descending select c.id).Count();
                return LastRecord;
            }
        }

        private string TipoPizza()
        {
            if (txtCantidadPizza.TextLength != 0)
            {
                tipoPizza = cmbTipoPizza.SelectedItem.ToString();
            }
            else
            {
                tipoPizza = "N/A";
            }
            
            return tipoPizza;
        }

        private string TipoBebida()
        {
            if(txtCantidadBebida.TextLength != 0)
            {
                tipoBebida = cmbTipoBebida.SelectedItem.ToString();
            }
            else
            {
                tipoBebida = "N/A";
            }
            return tipoBebida;
        }

        private string TamanoPizza()
        {
            if(txtCantidadPizza.TextLength != 0)
            {
                tamanoPizza = cmbTamano.SelectedItem.ToString();
            }
            else
            {
                tamanoPizza = "N/A";
            }
            return tamanoPizza;
        }



        private string TamanoBebida()
        {
            if(txtCantidadBebida.TextLength != 0)
            {
                tamanoBebida = cmbTamanoBebida.SelectedItem.ToString();
            }
            else
            {
                tamanoBebida = "N/A";
            }
            return tamanoBebida;
        }

        private int CantidadPizza()
        {
            if(txtCantidadPizza.TextLength != 0)
            {
                cantidadPizza = Convert.ToInt32(txtCantidadPizza.Text);
            }
            else
            {
                cantidadPizza = 0;
            }
            return cantidadPizza;
        }

        private int CantidadBebida()
        {
            if(txtCantidadBebida.TextLength != 0)
            {
                cantidadBebida = Convert.ToInt32(txtCantidadBebida.Text);
            }
            else
            {
                cantidadBebida = 0;
            }
            return cantidadBebida;
        }

        private float PrecioPizza()
        {
            if(txtCantidadPizza.TextLength != 0)
            {
                int menu = cmbTamano.SelectedIndex;
                int cantidad = Convert.ToInt32(txtCantidadPizza.Text);


                switch (menu)
                {
                    case 0:
                        precioPizza = (cantidad * 22000);
                        break;
                    case 1:
                        precioPizza = (cantidad * 12000);
                        break;
                    case 2:
                        precioPizza = (cantidad * 8000);
                        break;
                }
            }
            else
            {
                precioPizza = 0;
            }
            return precioPizza;
        }

        private float PrecioBebida()
        {
            if(txtCantidadBebida.TextLength != 0)
            {
                int menu = cmbTamanoBebida.SelectedIndex;
                int cantidad = Convert.ToInt32(txtCantidadBebida.Text);


                switch (menu)
                {
                    case 0:
                        precioBebida = (cantidad * 5000);
                        break;
                    case 1:
                        precioBebida = (cantidad * 1500);
                        break;

                }
            }
            else
            {
                precioBebida = 0;
            }
            return precioBebida;
        }


        private float PrecioTotal()
        {
            if(txtCantidadPizza.TextLength != 0 && txtCantidadBebida.TextLength == 0)
            {
                precioTotal = PrecioPizza();
            }
            else if (txtCantidadPizza.TextLength == 0 && txtCantidadBebida.TextLength != 0)
            {
                precioTotal = PrecioBebida();
            }
            else if (txtCantidadPizza.TextLength != 0 && txtCantidadBebida.TextLength != 0)
            {
                precioTotal = (PrecioPizza() + PrecioBebida());
            }

            return precioTotal;
        }
    }
}
