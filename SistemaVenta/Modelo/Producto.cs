//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemaVenta.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Producto
    {
        public int id { get; set; }
        public string nombrePizza { get; set; }
        public string tamanoPizza { get; set; }
        public string tamanoBebida { get; set; }
        public string nombreBebida { get; set; }
        public double precioPizza { get; set; }
        public double precioBebida { get; set; }
        public double precioTotal { get; set; }
        public int cantidadPizza { get; set; }
        public int cantidadBebida { get; set; }
        public string estadoPedido { get; set; }
    }
}