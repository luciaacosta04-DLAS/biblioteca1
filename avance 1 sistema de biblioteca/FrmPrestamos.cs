using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;


namespace avance_1_sistema_de_biblioteca
{
    public partial class FrmPrestamos : Form
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\adria\Desktop\momo\avance 1 sistema de biblioteca\biblioteca.accdb;";

        public FrmPrestamos()
        {
            InitializeComponent();
        }

        private void FrmPrestamos_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

       
        private void CargarDatos()
        {
            using (OleDbConnection con = new OleDbConnection(connectionString))
            {
                try
                {
                    con.Open();
                    // campos exactos de tabla Prestamo
                    string query = "SELECT Id_Prestamo, Id_Libro, Id_Usuario, Fecha, Devuelto FROM Prestamos";
                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvPrestamo.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar préstamos: " + ex.Message);
                }
            }
        }


        private void CargarPrestamos()
        {



        }




        private void btnAgregarPrestamo_Click(object sender, EventArgs e)
        {
            using (OleDbConnection con = new OleDbConnection(connectionString))
            {
                try
                {
                    con.Open();
                    
                    string query = "INSERT INTO Prestamos (Id_Libro, Id_Usuario, Fecha, Devuelto) VALUES (?, ?, ?, ?)";

                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@idLibro", Convert.ToInt32(txtIdLibroPrestramo.Text));
                        cmd.Parameters.AddWithValue("@idCliente", Convert.ToInt32(txtIdClientePrestamo.Text));

                        // Capturamos el valor de la fecha
                        cmd.Parameters.AddWithValue("@fecha", dtpFecha.Value.Date);

                        // Guardamos estado booleano de los RadioButtons
                        bool devuelto = rbDevueltoLibro.Checked;
                        cmd.Parameters.AddWithValue("@devuelto", devuelto);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Préstamo registrado correctamente.");

                        int idLibroActual = Convert.ToInt32(txtIdLibroPrestramo.Text);
                        bool estadoDisponible = rbDevueltoLibro.Checked;
                        ActualizarDisponibilidadLibro(idLibroActual, estadoDisponible);
                    }
                    CargarDatos();
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar préstamo: " + ex.Message);
                }
            }
        }

        private void btnEliminarPrestamo_Click(object sender, EventArgs e)
        {
            

            DialogResult result = MessageBox.Show("¿Está seguro de eliminar este registro de préstamo?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No) return;

            using (OleDbConnection con = new OleDbConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "DELETE FROM Prestamos WHERE Id_Prestamo = ?";

                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@idPrestamo", Convert.ToInt32(lblIdPrestamoHidden.Text));
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Préstamo eliminado correctamente.");
                    }
                    CargarDatos();
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar préstamo: " + ex.Message);
                }
            }
        }

        private void btnModificarPrestamo_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(lblIdPrestamoHidden.Text))
            {
                MessageBox.Show("Por favor, seleccione un préstamo de la lista para modificar.");
                return;
            }

            using (OleDbConnection con = new OleDbConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "UPDATE Prestamos SET Id_Libro = ?, Id_Usuario = ?, Fecha = ?, Devuelto = ? WHERE Id_Prestamo = ?";

                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@idLibro", Convert.ToInt32(txtIdLibroPrestramo.Text));
                        cmd.Parameters.AddWithValue("@idCliente", Convert.ToInt32(txtIdClientePrestamo.Text));
                        cmd.Parameters.AddWithValue("@fecha", dtpFecha.Value.Date);
                        cmd.Parameters.AddWithValue("@devuelto", rbDevueltoLibro.Checked);

                        cmd.Parameters.AddWithValue("@idPrestamo", Convert.ToInt32(lblIdPrestamoHidden.Text));

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Préstamo actualizado correctamente.");

                        int idLibroActual = Convert.ToInt32(txtIdLibroPrestramo.Text);
                        bool estadoDisponible = rbDevueltoLibro.Checked;
                        ActualizarDisponibilidadLibro(idLibroActual, estadoDisponible);
                    }
                    CargarDatos();
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar préstamo: " + ex.Message);
                }
            }
        }

        private void btnBuscarPrestamo_Click(object sender, EventArgs e)
        {
            string busqueda = txtBuscarPrestamo.Text.Trim();

            if (string.IsNullOrEmpty(busqueda))
            {
                CargarDatos();
                return;
            }

            using (OleDbConnection con = new OleDbConnection(connectionString))
            {
                try
                {
                    con.Open();
                    // comparamos transformando los IDs a texto 
                    string query = "SELECT Id_Prestamo, Id_Libro, Id_Usuario, Fecha, Devuelto FROM Prestamos WHERE " +
                                   "CStr(Id_Prestamo) = ? OR CStr(Id_Libro) = ? OR CStr(Id_Usuario) = ?";

                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@idP", busqueda);
                        cmd.Parameters.AddWithValue("@idL", busqueda);
                        cmd.Parameters.AddWithValue("@idU", busqueda);

                        OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dgvPrestamo.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en la búsqueda: " + ex.Message);
                }
            }
        }

        private void dgvPrestamo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvPrestamo.Rows[e.RowIndex];

                // Guardamos el Id_Prestamo en una variable oculta 
                lblIdPrestamoHidden.Text = fila.Cells["Id_Prestamo"].Value.ToString();

                txtIdLibroPrestramo.Text = fila.Cells["Id_Libro"].Value.ToString();
                txtIdClientePrestamo.Text = fila.Cells["Id_Usuario"].Value.ToString();
                dtpFecha.Value = Convert.ToDateTime(fila.Cells["Fecha"].Value);

                bool devuelto = Convert.ToBoolean(fila.Cells["Devuelto"].Value);
                if (devuelto)
                    rbDevueltoLibro.Checked = true;
                else
                    rbNoDevueltoLibro.Checked = true;
            }
        }

        private void LimpiarCampos()
        {
            txtIdLibroPrestramo.Clear();
            txtIdClientePrestamo.Clear();
            txtBuscarPrestamo.Clear();
            dtpFecha.Value = DateTime.Now;
            rbNoDevueltoLibro.Checked = true;
            lblIdPrestamoHidden.Text = ""; // Reseteamos el ID temporal
        }


        private void ActualizarDisponibilidadLibro(int idLibro, bool nuevoEstadoDisponible)
        {
            using (OleDbConnection con = new OleDbConnection(connectionString))
            {
                try
                {
                    con.Open();
                    // Consulta para actualizar la tabla Libros
                    string query = "UPDATE Libros SET Disponible = ? WHERE Id_Libro = ?";

                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@disponible", nuevoEstadoDisponible);
                        cmd.Parameters.AddWithValue("@idLibro", idLibro);

                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error automático al actualizar la disponibilidad del libro: " + ex.Message, "Aviso");
                }
            }
        }
    }
}
