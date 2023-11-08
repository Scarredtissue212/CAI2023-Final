using System;
using System.Collections.Generic;
using System.Text;
using CAI2023Entidades;
using CAI2023Datos;


namespace CAI2023Negocio
{
    class ClienteNegocio
    {
        private readonly ClientesDatos clienteDatos;

        public ClienteNegocio()
        {
            clienteDatos = new ClientesDatos();
        }
        public List<Cliente> TraerClientes()
        {
            List<Cliente> clientes = clienteDatos.TraerTodos();

            return clientes;
        }

        public void CrearCliente(Cliente cliente)
        {
            clienteDatos.AgregarCliente(cliente);
        }

        public void BajaCliente(Cliente cliente)
        {
            clienteDatos.BajaCliente(cliente);
        }

        public void ActualizarCliente(Cliente cliente)
        {
            clienteDatos.ActualizarCliente(cliente);
        }

        public void ReactivarCliente(Cliente cliente)
        {
            clienteDatos.ReactivarCliente(cliente);
        }
    }
}
