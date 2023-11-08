using System;
using System.Collections.Generic;
using System.Text;
using CAI2023Entidades;

namespace CAI2023Entidades
{
    public class Proveedor
    {
        public int Id { get; set; }
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime FechaBaja { get; set; } // FechaBaja es nullable (puede ser null)
        public string CUIT { get; set; }
        public string Email { get; set; }
        public string Apellido { get; set; }
        public int IdUsuario { get; set; }


        public enum EstadoProveedor
        {
            Inactivo,
            Activo
        }

        // Constructor
        public Proveedor(int id, int idProducto, string nombre, DateTime fechaAlta, DateTime fechaBaja, string cuit, string email, string apellido, int idUsuario)
        {
            Id = id;
            IdProducto = idProducto;
            Nombre = nombre;
            FechaAlta = fechaAlta;
            FechaBaja = fechaBaja;
            CUIT = cuit;
            Email = email;
            Apellido = apellido;
            IdUsuario = idUsuario;
        }
    }
}
