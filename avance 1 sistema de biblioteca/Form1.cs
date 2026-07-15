namespace avance_1_sistema_de_biblioteca
{
    public partial class Form1 : Form
    {
        public Form1()
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

