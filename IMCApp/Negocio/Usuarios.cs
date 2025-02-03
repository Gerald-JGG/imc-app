using Datos;
using System;
using System.Windows.Forms;
using Objetos;

namespace Negocio
{
    public class Usuarios
    {
        BDUsuarios bdUsuarios = new BDUsuarios();
        public void InsertarUsuarios(ObjUsuarios est)
        {
            bdUsuarios.InsertarUsuariosBD(est);
        }

        public void ModificarUsuarios(ObjUsuarios est)
        {
            bdUsuarios.ModificarUsuariosBD(est);
        }

        public void EliminarUsuarios(string cedula)
        {
            bdUsuarios.EliminarUsuariosBD(cedula);
        }

        public void MostrarUsuarios(DataGridView dgv)
        {
            bdUsuarios.MostrarUsuarios(dgv);
        }

        // EXTRA
        public void MostrarUsuarios1(DataGridView dgv)
        {
            bdUsuarios.MostrarUsuarios1(dgv);
        }

        public void InsertarIMC(ObjUsuarios usuario)
        {
            bdUsuarios.InsertarIMCBD(usuario);
        }

        public int ObtenerDiagnostico(int imc)
        {
            return bdUsuarios.ObtenerDiagnosticoBD(imc);
        }

        public string ObtenerIMC(ObjUsuarios usuario)
        {
            return bdUsuarios.ObtenerIMCBD(usuario);
        }
    }
}
