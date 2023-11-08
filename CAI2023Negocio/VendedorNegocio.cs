﻿using System;
using System.Collections.Generic;
using System.Text;
using CAI2023Datos;
using CAI2023Entidades;

namespace CAI2023Negocio
{
    public class VendedorNegocio
    {
        public Venta RegistrarNuevaVenta(int idCliente, int idProducto, int cantidad, int idUsuario)
        {
            int nuevaVentaId = GenerarNuevoIdDeVenta(); // Generar un nuevo ID de venta
            DateTime fechaActual = DateTime.Now;
            string estadoInicial = "Pendiente";

            return new Venta(nuevaVentaId, idCliente, idProducto, cantidad, fechaActual, estadoInicial, idUsuario);
        }

        public int GenerarNuevoIdDeVenta()
        {
            return 1;
            // Lógica para generar un nuevo ID de venta
            // Retorna el nuevo ID
        }


        //private static int GenerarNuevoIdDeVenta()
        //{
        // Simula obtener el último ID de venta registrado en una base de datos.
        // int ultimoIdRegistrado = VentaDatos.UltimoidReg();

        // Incrementa el último ID en uno para obtener el nuevo ID.
        //int nuevoId = ultimoIdRegistrado + 1;

        //return nuevoId;
        //}

        public void DevolverVenta()
        {
            // Lógica para procesar la devolución de la venta
            //   if (Estado != "Devuelta")
            //     {
            //  Estado = "Devuelta";
            //  Console.WriteLine($"Venta con ID {Id} devuelta exitosamente.");
            //   }
            //  else
            //  {
            //  Console.WriteLine($"La venta con ID {Id} ya ha sido devuelta previamente.");
            //   }
        }
    }
}
