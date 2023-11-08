using System;
using System.Collections.Generic;
using System.Text;

namespace CAI2023Entidades
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public string Email { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }

        public Cliente(string nombre, string apellido, string direccion, int telefono, string email, string nombreusuario, string contraseña)
        {
            Nombre = nombre;
            Apellido = apellido;
            Direccion = direccion;
            Telefono = telefono;
            Email = email;
            NombreUsuario = nombreusuario;
            Contraseña = contraseña;
        }

        public override string ToString()
        {
            return this.Telefono + ") " + this.Apellido + ", " + this.Nombre;
        }
    }
}
