using System;
using System.Collections.Generic;
using System.Text;
using CAI2023Datos;
using CAI2023Entidades;

namespace CAI2023Negocio
{
    public class ProveedorNegocio
    {
        private readonly ProveedorDatos proveedorDatos;

        public List<Proveedor> TraerProveedores()
        {
            List<Proveedor> proveedores = proveedorDatos.TraerTodos();

            return proveedores;
        }

        public void CrearProveedor(Proveedor proveedor)
        {
            proveedorDatos.Insertar(proveedor);
        }

        public void EliminarProveedor(Proveedor proveedor)
        {
            proveedorDatos.EliminarProveedor(proveedor);
        }

        public void ActualizarProveedor(Proveedor proveedor)
        {
            proveedorDatos.ModificarProveedor(proveedor);
        }

        public void ReactivarProveedor(Proveedor proveedor)
        {
            proveedorDatos.Reactivar(proveedor);
        }

    }
}
