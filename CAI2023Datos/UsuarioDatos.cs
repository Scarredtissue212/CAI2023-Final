using System;
using Microsoft.Win32;
using System.Collections.Specialized;
using Newtonsoft.Json;
using System.Data.SqlTypes;
using System.Text.RegularExpressions;
using CAI2023Datos.Utilidades;
using CAI2023Entidades;
using System.Collections.Generic;

namespace CAI2023Datos
{
    public class UsuarioDatos

    {
        public TransactionResult Agregarusuario(Usuario usuario)
        {
            NameValueCollection obj = ReverseMap(usuario);

            string json = WebHelper.Post("Usuario/AgregarUsuario", obj);

            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);

            return lst;
        }

        public TransactionResult Cambiarcontrasena(Usuario usuario)
        {
            NameValueCollection obj = ReverseMap(usuario);

            string json = WebHelper.Patch("Usuario/CambiarContraseña", obj);

            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);

            return lst;
        }

        public TransactionResult Login(Usuario usuario)
        {
            NameValueCollection obj = ReverseMap(usuario); //serializacion -> json

            string json = WebHelper.Post("Usuario/Login", obj);

            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);

            return lst;
        }

        public List<UsuarioDatos> TraerUsuariosActivos()
        {
            string json2 = WebHelper.Get("Usuario/TraerUsuariosActivos" + ToString()); // trae un texto en formato json de una web
            List<UsuarioDatos> resultado = MapList(json2);
            return resultado;
        }

        public TransactionResult EliminarUsuario(Usuario usuario)
        {
            NameValueCollection obj = ReverseMap(usuario);

            string json = WebHelper.Delete("Usuario/BajaUsuario", obj);

            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);

            return lst;
        }

        public TransactionResult Reactivarusuario(Usuario usuario)
        {
            NameValueCollection obj = ReverseMap(usuario);

            string json = WebHelper.Patch("Usuario/ReactivarUsuario", obj);

            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);

            return lst;
        }
        private NameValueCollection ReverseMap(Usuario usuario)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("id", usuario.Id.ToString());
            n.Add("Nombre", usuario.Nombre);
            n.Add("Apellido", usuario.Apellido);
            n.Add("Direccion", usuario.Direccion);
            n.Add("Telefono", usuario.Telefono);
            n.Add("Email", usuario.Email);
            n.Add("FechaAlta", usuario.FechaAlta.ToString("yyyy-MM-dd"));
            n.Add("FechaNacimiento", usuario.FechaNacimiento.ToString("yyyy-MM-dd"));
            n.Add("FechaBaja", usuario.FechaBaja.ToString("yyyy-MM-dd"));
            n.Add("IdUsuario", usuario.IdUsuario.ToString());
            n.Add("Host", usuario.Host.ToString());
            n.Add("Dni", usuario.DNI.ToString());
            return n;
        }

        private List<UsuarioDatos> MapList(string json)
        {
            List<UsuarioDatos> lst = JsonConvert.DeserializeObject<List<UsuarioDatos>>(json); // deserializacion
            return lst;
        }

        private UsuarioDatos MapObj(string json)
        {
            UsuarioDatos lst = JsonConvert.DeserializeObject<UsuarioDatos>(json); // deserializacion
            return lst;
        }
    }
}
