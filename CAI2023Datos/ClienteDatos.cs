using System;
using Microsoft.Win32;
using System.Collections.Specialized;
using Newtonsoft.Json;
using System.Text.RegularExpressions;
using System.Diagnostics;
using CAI2023Datos.Utilidades;
using CAI2023Entidades;
using System.Collections.Generic;



namespace CAI2023Datos
{
    public class ClientesDatos
    {
            public List<Cliente> TraerTodos()
            {
                string json2 = WebHelper.Get("/cliente/GetClientes" + ToString()); // trae un texto en formato json de una web
                List<Cliente> resultado = MapList(json2);
                return resultado;
            }

            public List<Cliente> TraerCliente()
            {
                string json2 = WebHelper.Get("/cliente/GetCliente" + ToString()); // trae un texto en formato json de una web
                List<Cliente> resultado = MapList(json2);
                return resultado;
            }

            public TransactionResult AgregarCliente(Cliente cliente)
            {
                NameValueCollection obj = ReverseMap(cliente); //serializacion -> json

                string json = WebHelper.Post("Cliente/AgregarCliente", obj);

                TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);

                return lst;
            }

            public TransactionResult BajaCliente(Cliente cliente)
            {
                NameValueCollection obj = ReverseMap(cliente);

                string json = WebHelper.Delete("Cliente/BajaCliente", obj);

                TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);

                return lst;
            }

            public TransactionResult ActualizarCliente(Cliente cliente)
            {
                NameValueCollection obj = ReverseMap(cliente);

                string json = WebHelper.Patch("Cliente/PatchCliente", obj);

                TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);

                return lst;
            }


            public TransactionResult ReactivarCliente(Cliente cliente)
            {
                NameValueCollection obj = ReverseMap(cliente);

                string json = WebHelper.Patch("Cliente/ReactivarCliente", obj);

                TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);

                return lst;
            }

            private List<Cliente> MapList(string json)
            {
                List<Cliente> lst = JsonConvert.DeserializeObject<List<Cliente>>(json); // deserializacion
                return lst;
            }

            private Cliente MapObj(string json)
            {
                Cliente lst = JsonConvert.DeserializeObject<Cliente>(json); // deserializacion
                return lst;
            }

            private NameValueCollection ReverseMap(Cliente cliente)
            {
                NameValueCollection n = new NameValueCollection();
                n.Add("Nombre", cliente.Nombre);
                n.Add("Apellido", cliente.Apellido);
                n.Add("Direccion", cliente.Direccion);
                n.Add("Telefono", cliente.Telefono.ToString());
                n.Add("Email", cliente.Email);
                n.Add("Usuario", cliente.NombreUsuario.ToString());
                n.Add("Contraseña", cliente.Contraseña);
                return n;
            }
        }
}