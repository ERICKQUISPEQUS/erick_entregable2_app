using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiApp.Models;
namespace MiApp.Services
{
    public interface IUsuarioService

    {
        Task<Usuario> GetUsuarioAsync(string nombreUsuario);
        Task<bool> RegistrarUsuarioAsync(string nombreUsuario, string contrasena);
        Task<bool> AutenticarUsuarioAsync(string nombreUsuario, string contrasena);
    }
}
