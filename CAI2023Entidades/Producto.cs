using System;
using System.Collections.Generic;
using System.Text;

namespace CAI2023Entidades
{
    public class Producto
    {
        public int Id { get; set; }
        public int IdCategoria { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime FechaBaja { get; set; }
        public double Precio { get; set; }
        public int Stock { get; set; }
        public int IdUsuario { get; set; }
        public int IdProveedor { get; set; }

        // public List<Categoria> Categorias { get; set; } = new List<Categoria>();

        public Producto(int id, int idCategoria, string nombre, DateTime fechaAlta, DateTime fechaBaja, double precio, int stock, int idUsuario, int idProveedor)
        {
            Id = id;
            IdCategoria = idCategoria;
            Nombre = nombre;
            FechaAlta = fechaAlta;
            FechaBaja = fechaBaja;
            Precio = precio;
            Stock = stock;
            IdUsuario = idUsuario;
            IdProveedor = idProveedor;
        }
    }
}
