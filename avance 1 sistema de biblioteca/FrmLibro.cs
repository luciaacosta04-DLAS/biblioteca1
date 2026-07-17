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
    public partial class FrmLibro : Form
    {
        // conexion base de datos
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\adria\Desktop\momo\avance 1 sistema de biblioteca\biblioteca.accdb;";

        
        public FrmLibro()
        {
            InitializeComponent();
        }

       
        private void FrmLibro_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        // metodo CargarDatos
        private void CargarDatos()
        {
            using (OleDbConnection con = new OleDbConnection(connectionString))
            {
                try
                {
                    con.Open();
                    
                    string query = "SELECT Id_Libro, Titulo, Autor, Disponible, Categoria FROM Libros";
                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvLibro.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos: " + ex.Message);
                }
            }
        }

        private void LimpiarCampos()
        {
            txtIdLibroNuevo.Clear();
            txtTituloLibro.Clear();
            txtAutorLibro.Clear();
            txtCategoriaLibro.Clear();

            rbDisponibleLibro.Checked = true;
        }

        private void btnAgregarLibro_Click(object sender, EventArgs e)
        {
            using (OleDbConnection con = new OleDbConnection(connectionString))
            {
                try
                {
                    con.Open();
                  
                    string query = "INSERT INTO Libros (Id_Libro, Titulo, Autor, Disponible, Categoria) VALUES (?, ?, ?, ?, ?)";

                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    {
                        // Agregamos los parametros en el mismo orden que los signos de interrogacion '?'
                        cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtIdLibroNuevo.Text));
                        cmd.Parameters.AddWithValue("@titulo", txtTituloLibro.Text);
                        cmd.Parameters.AddWithValue("@autor", txtAutorLibro.Text);

                        // Evaluar el estado del RadioButton 
                        bool disponible = rbDisponibleLibro.Checked;
                        cmd.Parameters.AddWithValue("@disponible", disponible);

                        cmd.Parameters.AddWithValue("@categoria", txtCategoriaLibro.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Libro agregado correctamente.");
                    }
                    CargarDatos(); // Recargar el DataGridView
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar: " + ex.Message);
                }
            }
        }

        private void btnModificarLibro_Click(object sender, EventArgs e)
        {
            using (OleDbConnection con = new OleDbConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "UPDATE Libros SET Titulo = ?, Autor = ?, Disponible = ?, Categoria = ? WHERE Id_Libro = ?";

                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@titulo", txtTituloLibro.Text);
                        cmd.Parameters.AddWithValue("@autor", txtAutorLibro.Text);
                        cmd.Parameters.AddWithValue("@disponible", rbDisponibleLibro.Checked);
                        cmd.Parameters.AddWithValue("@categoria", txtCategoriaLibro.Text);
                        cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtIdLibroNuevo.Text)); // El ID va al final por el WHERE

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Libro modificado correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se encontró ningún libro con ese ID.");
                        }
                    }
                    CargarDatos();
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar: " + ex.Message);
                }
            }
        }

        private void btnEliminarLibro_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdLibroNuevo.Text))
            {
                MessageBox.Show("Por favor, introduce el ID del libro que deseas eliminar.");
                return;
            }

            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este libro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No) return;

            using (OleDbConnection con = new OleDbConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "DELETE FROM Libros WHERE Id_Libro = ?";

                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtIdLibroNuevo.Text));
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Libro eliminado correctamente.");
                    }
                    CargarDatos();
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message);
                }
            }
        }

        private void btnBuscarLibro_Click(object sender, EventArgs e)
        {
            string busqueda = txtBuscarLibro.Text.Trim();

            if (string.IsNullOrEmpty(busqueda))
            {
                CargarDatos(); // Si la busqueda esta vacia muestra todo de nuevo
                return;
            }

            using (OleDbConnection con = new OleDbConnection(connectionString))
            {
                try
                {
                    con.Open();
                    
                    string query = "SELECT Id_Libro, Titulo, Autor, Disponible, Categoria FROM Libros WHERE " +
                                   "Titulo LIKE ? OR Autor LIKE ? OR Categoria LIKE ? OR CStr(Id_Libro) = ?";

                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    {
                        // El '%' sirve para buscar coincidencias parciales
                        string parametroLike = "%" + busqueda + "%";
                        cmd.Parameters.AddWithValue("@titulo", parametroLike);
                        cmd.Parameters.AddWithValue("@autor", parametroLike);
                        cmd.Parameters.AddWithValue("@categoria", parametroLike);
                        cmd.Parameters.AddWithValue("@id", busqueda); // Coincidencia exacta para el ID como texto

                        OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dgvLibro.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en la búsqueda: " + ex.Message);
                }
            }
        }

       

    } 
}