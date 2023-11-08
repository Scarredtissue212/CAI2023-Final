using System;
using System.Collections.Generic;
using System.Text;
using CAI2023Datos;
using CAI2023Entidades;

namespace CAI2023Negocio
{
    public class UsuarioNegocio
    {
        private readonly UsuarioDatos usuarioDatos;

        public List<Usuario> TraerUsuarios()
    {
        List<Usuario> usuarios = usuarioDatos.TraerUsuariosActivos();
        return usuarios;
    }

    public void Login(Usuario usuario)
    {
        usuarioDatos.Login(usuario);
    }

    public void CambiarContrasena(Usuario usuario)
    {
        usuarioDatos.Cambiarcontrasena(usuario);
    }

    public void AgregarUsuario(Usuario usuario)
    {
        usuarioDatos.Agregarusuario(usuario);
    }

    static int CalcularDiferenciaDias(DateTime fechaInicio, DateTime fechaFin)
    {
        // Calcular la diferencia en días utilizando el método Subtract
        TimeSpan diferencia = fechaFin - fechaInicio;

        // La propiedad TotalDays de TimeSpan devuelve la diferencia en días
        int diferenciaDias = (int)diferencia.TotalDays;

        return Math.Abs(diferenciaDias); // Math.Abs() para asegurarse de que el resultado sea siempre positivo
    }

        public static bool ValidarUsuario(Usuario usuario)
        {
            bool valid = true;

            if (string.IsNullOrEmpty(usuario.Nombre))
            {
                Console.WriteLine("Completar nombre de usuario");
                valid = false;
            }
            else if (usuario.Nombre.Length < 8 || usuario.Nombre.Length > 15)
            {
                Console.WriteLine("El nombre de usuario debe tener entre 8 y 15 caracteres.");
                valid = false;
            }
            else if (usuario.Nombre.Contains(usuario.Nombre) || usuario.Nombre.Contains(usuario.Apellido))
            {
                Console.WriteLine("El nombre de usuario no puede contener ni el nombre ni el apellido del usuario.");
                valid = false;
            }

            return valid;
        }

       //void CambiarContrasena(Usuario sring nuevacontraseña)
        //{
         //   usuario.Contraseña= nuevaContrasena;
          //  Console.WriteLine("Contraseña cambiada con éxito.");
        //}
    }
}


