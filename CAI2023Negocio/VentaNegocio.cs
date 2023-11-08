using System;
using System.Collections.Generic;
using System.Text;
using CAI2023Datos;
using CAI2023Entidades;

namespace CAI2023Negocio
{
    public class VentaNegocio
    {
        private readonly VentaDatos ventaDatos;

        public VentaNegocio()
        {
            ventaDatos = new VentaDatos();
        }
        public List<Venta> TraerVentas()
        {
            List<Venta> ventas = ventaDatos.TraerTodos();

            return ventas;
        }

        public List<Venta> VentasPorCategoria(int idCategoria)
        {
            List<Venta> ventas = ventaDatos.TraerTodos();
            List<Venta> ventasPorCategoria = new List<Venta>();

            foreach (Venta v in ventas)
            {
                if (v.IdProducto == idCategoria)
                {
                    ventasPorCategoria.Add(v);
                }
            }

            return ventasPorCategoria;
        }

        public List<Venta> VentasPorVendedor(int idUsuario)
        {
            List<Venta> ventas = ventaDatos.TraerTodos();
            List<Venta> ventasPorVendedor = new List<Venta>();

            foreach (Venta v in ventas)
            {
                if (v.IdUsuario == idUsuario)
                {
                    ventasPorVendedor.Add(v);
                }
            }

            return ventasPorVendedor;
        }
    }
}
