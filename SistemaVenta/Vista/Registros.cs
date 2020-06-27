using SistemaVenta.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVenta.Vista
{
    public partial class Registros : Form
    {
        public Registros()
        {
            InitializeComponent();
        }

        private void Registros_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'registrosDataSet1.Producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.registrosDataSet1.Producto);
            // TODO: esta línea de código carga datos en la tabla 'registrosDataSet.Producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.registrosDataSet.Producto);
            // TODO: esta línea de código carga datos en la tabla 'registrosDataSet.Producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.registrosDataSet.Producto);

        }

        private void btnFinalizarPedido_Click(object sender, EventArgs e)
        {
            UpdateReg();
        }

        private void btnActualizarGrid_Click(object sender, EventArgs e)
        {
            Registros registros = new Registros();
            registros.Show();
            this.Hide();
        }

        private void UpdateReg()
        {
            using (SistemaVenta.Modelo.ConnectDB bd = new SistemaVenta.Modelo.ConnectDB())
            {
                if (registrosGridView.CurrentRow.Index != -1)
                {
                    var updateReg = (from c in bd.Producto where c.id == registrosGridView.CurrentRow.Index select c);
                    foreach (Producto c in updateReg)
                    {
                        c.estadoPedido = "FINALIZADO";
                    }
                    try
                    {
                        bd.SaveChanges();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un Pedido Porfavor");
                }
            }
        }
        public double SumaTotal()
        {
            using (SistemaVenta.Modelo.ConnectDB bd = new SistemaVenta.Modelo.ConnectDB())
            {
                var sumTotal = (from c in bd.Producto select c.precioTotal).Sum();
                return sumTotal;
            }
        }

        private void agregarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu mainMenu = new Menu();
            mainMenu.Show();
            this.Hide();
        }

        private void revisarPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cerrarCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El Total Recaudado es:" +" "+ SumaTotal());
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
