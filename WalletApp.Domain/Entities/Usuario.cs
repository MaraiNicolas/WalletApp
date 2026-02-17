using System;
using System.Collections.Generic;
using System.Text;
using WalletApp.Domain.Core.Primitivos;

namespace WalletApp.Domain.Entities
{
    public class Usuario : Entidad<int>
    {
        public Usuario()
        {
            this.Guid = Guid.NewGuid();
            this.FechaAlta = DateTime.Now;
        }
        #region Atributos
        public Guid Guid { get; private set; }
        public string Nombre { get; private set; }
        public string Apellido { get; private set; }
        public string NumeroDoc { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        #endregion
        #region Metodos
        public static Usuario Create(string nombre, string apellido, string numeroDoc, string email, string password)
        {
            Usuario rNew = new Usuario();
            rNew.Nombre = nombre;
            rNew.Apellido = apellido;
            rNew.NumeroDoc = numeroDoc;
            rNew.Email = email;
            rNew.Password = password;
            return rNew;
        }
        #endregion
    }
}
