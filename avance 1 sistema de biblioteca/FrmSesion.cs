namespace avance_1_sistema_de_biblioteca
{
    public partial class FrmSesion : Form
    {
        public FrmSesion()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
          
        {
            string usuario = text_idenusuario.Text;
            string contraseña = textContraseña.Text;

            if (usuario == "admin" && contraseña == "1234")
            {
                MessageBox.Show("Bienvenido al Sistema de Biblioteca",
                                "Acceso correcto",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                frmDashboard menu = new frmDashboard();
                menu.Show();

                this.Hide();

            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                textContraseña.Clear();
                textContraseña.Focus();
            }
        }
    }
 }

