using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;
using Objetos;
using System.Collections.Generic;

namespace Datos
{
    public class BDUsuarios
    {
        public NpgsqlCommand cmd;
        public NpgsqlConnection conexionRetorno;
        Conexion conexion = new Conexion();

        public void InsertarUsuariosBD(ObjUsuarios est)
        {
            conexionRetorno = conexion.ConexionBD();
            cmd = new NpgsqlCommand("INSERT INTO usuario (cedula, nombre, genero, peso, altura) " +
                                    "VALUES ('" + est.cedula + "', '" + est.nombre + "', '" + est.genero + "', '" + est.peso + "', '" + est.altura + "')", conexionRetorno);
            cmd.ExecuteNonQuery();
        }

        public void ModificarUsuariosBD(ObjUsuarios est)
        {
            conexionRetorno = conexion.ConexionBD();
            cmd = new NpgsqlCommand(
                "UPDATE usuario SET nombre = '" + est.nombre + "', " +
                "genero = '" + est.genero + "', " +
                "peso = " + est.peso + ", " +
                "altura = " + est.altura + " " +
                "WHERE cedula = '" + est.cedula + "'",
                conexionRetorno
            );
            cmd.ExecuteNonQuery();
        }

        public void EliminarUsuariosBD(string cedula)
        {
            conexionRetorno = conexion.ConexionBD();
            cmd = new NpgsqlCommand("DELETE FROM usuario " +
                                    "WHERE cedula = '" + cedula + "'", conexionRetorno);
            cmd.ExecuteNonQuery();
        }

        public void MostrarUsuarios(DataGridView dgv)
        {
            conexionRetorno = conexion.ConexionBD();
            DataTable dataTable = new DataTable();
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(
                "SELECT cedula, nombre, genero, peso, altura " +
                "FROM usuario",
                conexionRetorno);
            adapter.Fill(dataTable);
            dgv.DataSource = dataTable;
        }

        // EXTRA
        public void MostrarUsuarios1(DataGridView dgv)
        {
            conexionRetorno = conexion.ConexionBD();
            DataTable dataTable = new DataTable();
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(
                "SELECT u.cedula, u.nombre, u.genero, u.peso, u.altura, i.imc, d.diagnostico " +
                "FROM usuario u " +
                "JOIN imcusuarios i ON u.cedula = i.cedula " +
                "JOIN diagnosticosimc d ON i.iddiagnostico = d.id", 
                conexionRetorno);
            adapter.Fill(dataTable);
            dgv.DataSource = dataTable;
        }

        public void InsertarIMCBD(ObjUsuarios est)
        {
            int imc = CalcularIMC(est.peso, est.altura);
            int idDiagnostico = ObtenerDiagnosticoBD(imc);
            NpgsqlConnection conexionRetorno = conexion.ConexionBD();
            NpgsqlCommand cmd = new NpgsqlCommand(
                "INSERT INTO imcusuarios (cedula, imc, iddiagnostico) VALUES ('" + est.cedula + "', " + imc + ", " + idDiagnostico + ")",
                conexionRetorno
            );
            cmd.ExecuteNonQuery();
        }

        public string ObtenerIMCBD(ObjUsuarios est)
        {
            NpgsqlConnection conexionRetorno = conexion.ConexionBD();
            NpgsqlCommand cmd = new NpgsqlCommand(
                "SELECT u.nombre, i.imc, d.diagnostico FROM imcusuarios i " +
                "JOIN usuario u ON i.cedula = u.cedula " +
                "JOIN diagnosticosimc d ON i.iddiagnostico = d.id " +
                "WHERE u.cedula = '" + est.cedula + "'",
                conexionRetorno
            );

            NpgsqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string nombre = reader.GetString(0);
                decimal imc = reader.GetDecimal(1);
                string diagnostico = reader.GetString(2);
                return "Estimado " + nombre + ", su IMC es " + imc.ToString("0.00") + " y el diagnóstico es: " + diagnostico;
            }
            return "Usuario no encontrado.";
        }

        public int ObtenerDiagnosticoBD(int imc)
        {
            NpgsqlConnection conexionRetorno = conexion.ConexionBD();
            NpgsqlCommand cmd = new NpgsqlCommand(
                "SELECT id FROM diagnosticosimc WHERE " + imc + " BETWEEN imcmin AND imcmax",
                conexionRetorno
            );

            NpgsqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return reader.GetInt32(0);
            }
            return 0;
        }

        public int CalcularIMC(int peso, int altura)
        {
            return (peso * 10000) / (altura * altura);
        }
    }
}
