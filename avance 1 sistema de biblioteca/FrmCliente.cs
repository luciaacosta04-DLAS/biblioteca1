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
    public partial class FrmCliente : Form
    {
        // Cadena de conexion a base de datos
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\adria\Desktop\momo\avance 1 sistema de biblioteca\biblioteca.accdb;";

        // Variable global para almacenar el ID del cliente seleccionado en la tabla
        private int idClienteSeleccionado = -1;

        public FrmCliente()
        {
            InitializeComponent();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
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
                    string query = "SELECT Id_Cliente, Nombre_Cliente, Telefono_Cliente, Correo_Cliente FROM Cliente";
                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvCliente.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar clientes: " + ex.Message);
                }
            }

        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdClienteNuevo.Text) || string.IsNullOrEmpty(txtNombreCliente.Text))
            {
                MessageBox.Show("Por favor, complete al menos el ID y el Nombre del cliente.");
                return;
            }

            using (OleDbConnection con = new OleDbConnection(connectionString))
            {
                try
                {
                    con.Open();
                    // campos correspondientes a tabla en Access
                    string query = "INSERT INTO Cliente (Id_Cliente, Nombre_Cliente, Telefono_Cliente, Correo_Cliente) VALUES (?, ?, ?, ?)";

                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtIdClienteNuevo.Text));
                        cmd.Parameters.AddWithValue("@nombre", txtNombreCliente.Text);
                        cmd.Parameters.AddWithValue("@telefono", txtTelefonoCliente.Text);
                        cmd.Parameters.AddWithValue("@correo", txtCorreoCliente.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cliente agregado correctamente.");
                    }
                    CargarDatos();
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar cliente: " + ex.Message);
                }
            }
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            if (idClienteSeleccionado == -1)
            {
                MessageBox.Show("Por favor, seleccione un cliente de la lista para modificar.");
                return;
            }

            using (OleDbConnection con = new OleDbConnection(connectionString))
            {
                try
                {
                    con.Open();
                    // Modificamos basandonos en las columnas de Access
                    string query = "UPDATE Cliente SET Nombre_Cliente = ?, Telefono_Cliente = ?, Correo_Cliente = ? WHERE Id_Cliente = ?";

                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@nombre", txtNombreCliente.Text);
                        cmd.Parameters.AddWithValue("@telefono", txtTelefonoCliente.Text);
                        cmd.Parameters.AddWithValue("@correo", txtCorreoCliente.Text);

                        // El ID va al final debido al WHERE
                        cmd.Parameters.AddWithValue("@id", idClienteSeleccionado);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cliente modificado correctamente.");
                    }
                    CargarDatos();
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar cliente: " + ex.Message);
                }
            }
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            if (idClienteSeleccionado == -1)
            {
                MessageBox.Show("Por favor, seleccione un cliente de la lista para eliminar.");
                return;
            }

            DialogResult result = MessageBox.Show("¿Está seguro de eliminar este cliente?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No) return;

            using (OleDbConnection con = new OleDbConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "DELETE FROM Cliente WHERE Id_Cliente = ?";

                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", idClienteSeleccionado);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cliente eliminado correctamente.");
                    }
                    CargarDatos();
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar cliente: " + ex.Message);
                }
            }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            string busqueda = txtBuscarCliente.Text.Trim();

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
                    // Busca coincidencias parciales en el nombre o una coincidencia exacta de ID
                    string query = "SELECT Id_Cliente, Nombre_Cliente, Telefono_Cliente, Correo_Cliente FROM Cliente WHERE " +
                                   "Nombre_Cliente LIKE ? OR CStr(Id_Cliente) = ?";

                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@nombre", "%" + busqueda + "%");
                        cmd.Parameters.AddWithValue("@id", busqueda);

                        OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dgvCliente.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en la búsqueda: " + ex.Message);
                }
            }
        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvCliente.Rows[e.RowIndex];

                // Guardamos el ID en la variable global
                idClienteSeleccionado = Convert.ToInt32(fila.Cells["Id_Cliente"].Value);

                // Rellenamos los TextBox de la interfaz
                txtIdClienteNuevo.Text = fila.Cells["Id_Cliente"].Value.ToString();
                txtNombreCliente.Text = fila.Cells["Nombre_Cliente"].Value.ToString();
                txtTelefonoCliente.Text = fila.Cells["Telefono_Cliente"].Value.ToString();
                txtCorreoCliente.Text = fila.Cells["Correo_Cliente"].Value.ToString();
            }
        }

        private void LimpiarCampos()
        {
            txtIdClienteNuevo.Clear();
            txtNombreCliente.Clear();
            txtTelefonoCliente.Clear();
            txtCorreoCliente.Clear();
            txtBuscarCliente.Clear();

            idClienteSeleccionado = -1; // Reiniciamos la variable de control
        }
    }
}

