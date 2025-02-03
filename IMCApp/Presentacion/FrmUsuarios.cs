using System;
using System.Windows.Forms;
using Negocio;
using Objetos;

namespace Presentacion
{
    public partial class FrmUsuarios : Form
    {
        Usuarios usuarios = new Usuarios();

        public FrmUsuarios()
        {
            InitializeComponent();
        }

        public void LimpiarCampos()
        {
            txtCedula.Clear();
            txtCedula.Enabled = true;
            txtNombre.Clear();
            cmbGenero.SelectedIndex = -1;
            txtPeso.Clear();
            txtAltura.Clear();
        }

        public void MostrarDatos()
        {
            usuarios.MostrarUsuarios(dtgUsuarios);
            usuarios.MostrarUsuarios1(dtgUsuarios1);
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            ObjUsuarios usuario = new ObjUsuarios
            {
                cedula = txtCedula.Text,
                nombre = txtNombre.Text,
                genero = cmbGenero.SelectedItem.ToString(),
                peso = Convert.ToInt32(txtPeso.Text),
                altura = Convert.ToInt32(txtAltura.Text),
            };
            usuarios.InsertarUsuarios(usuario);
            usuarios.InsertarIMC(usuario);
            MostrarDatos();
            LimpiarCampos();
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            ObjUsuarios usuario = new ObjUsuarios
            {
                cedula = txtCedula.Text,
                nombre = txtNombre.Text,
                genero = cmbGenero.SelectedItem.ToString(),
                peso = Convert.ToInt32(txtPeso.Text),
                altura = Convert.ToInt32(txtAltura.Text),
            };
            usuarios.ModificarUsuarios(usuario);
            MostrarDatos();
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ObjUsuarios usuario = new ObjUsuarios
            {
                cedula = txtCedula.Text,
            };
            usuarios.EliminarUsuarios(usuario.cedula);
            MostrarDatos();
            LimpiarCampos();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void FrmEstudiantes_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void dtgUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtCedula.Enabled = false;
                DataGridViewRow row = dtgUsuarios.Rows[e.RowIndex];
                txtCedula.Text = row.Cells["cedula"].Value.ToString();
                txtNombre.Text = row.Cells["nombre"].Value.ToString();
                cmbGenero.SelectedItem = row.Cells["genero"].Value.ToString();
                txtPeso.Text = row.Cells["peso"].Value.ToString();
                txtAltura.Text = row.Cells["altura"].Value.ToString();
            }
        }

        private void dtgUsuarios1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtCedula1.Enabled = false;
                DataGridViewRow row = dtgUsuarios1.Rows[e.RowIndex];
                txtCedula1.Text = row.Cells["cedula"].Value.ToString();
                txtNombre1.Text = row.Cells["nombre"].Value.ToString();
                txtGenero1.Text = row.Cells["genero"].Value.ToString();
                txtPeso1.Text = row.Cells["peso"].Value.ToString();
                txtAltura1.Text = row.Cells["altura"].Value.ToString();
                ObjUsuarios usuario = new ObjUsuarios();
                usuario.cedula = row.Cells["cedula"].Value.ToString();
                txtIMC.Text = usuarios.ObtenerIMC(usuario);
            }
        }
    }
}
