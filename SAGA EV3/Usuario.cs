using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace SAGA_EV3
{
    public class Usuario
    {
        private string nombre;
        private string hash;
        private string fechaCreacion;
        private string rol;

        public string _Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string _Hash
        {
            get { return hash; }
            set { hash = value; }
        }
        public string _FechaCreacion
        {
            get { return fechaCreacion; }
            set { fechaCreacion = value; }
        }
        public string _Rol
        {
            get { return rol; }
            set { rol = value; }
        }
        public Usuario(string nombre, string hash, string rol, string fechaCreacion)
        {
            this._Nombre = nombre;
            this._FechaCreacion = fechaCreacion;
            this._Rol = rol;
            this._Hash = hash;
        }
        public string GetNombre()
        {
            return _Nombre;
        }
        public string GetRol()
        {
            return _Rol;
        }
        public string GetFechaCreacion()
        {
            return _FechaCreacion;
        }
        public string GetHash()
        {
            return _Hash; 
        }
        public void establecer_contraseña(string contraseña)
        {
            _Hash = Argon2Hasher.HashPassword(contraseña);
        }
        public bool VerificarContraseña(string contraseña)
        {
            return Argon2Hasher.Verify(contraseña, this._Hash);
        }
    }
}
