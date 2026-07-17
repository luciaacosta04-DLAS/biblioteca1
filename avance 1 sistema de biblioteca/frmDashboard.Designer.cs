namespace avance_1_sistema_de_biblioteca
{
    partial class frmDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelContenido = new Panel();
            btnLibros = new Button();
            btnPrestamos = new Button();
            btnClientes = new Button();
            SuspendLayout();
            // 
            // panelContenido
            // 
            panelContenido.Location = new Point(115, -2);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(990, 660);
            panelContenido.TabIndex = 0;
            // 
            // btnLibros
            // 
            btnLibros.Location = new Point(11, 104);
            btnLibros.Name = "btnLibros";
            btnLibros.Size = new Size(98, 43);
            btnLibros.TabIndex = 1;
            btnLibros.Text = "Libros";
            btnLibros.UseVisualStyleBackColor = true;
            btnLibros.Click += btnLibros_Click;
            // 
            // btnPrestamos
            // 
            btnPrestamos.Location = new Point(11, 181);
            btnPrestamos.Name = "btnPrestamos";
            btnPrestamos.Size = new Size(100, 45);
            btnPrestamos.TabIndex = 2;
            btnPrestamos.Text = "Prestamos";
            btnPrestamos.UseVisualStyleBackColor = true;
            btnPrestamos.Click += btnPrestamos_Click;
            // 
            // btnClientes
            // 
            btnClientes.Location = new Point(12, 254);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(89, 43);
            btnClientes.TabIndex = 3;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1117, 670);
            Controls.Add(btnClientes);
            Controls.Add(btnPrestamos);
            Controls.Add(btnLibros);
            Controls.Add(panelContenido);
            Name = "frmDashboard";
            Text = "Form2";
            Load += frmDashboard_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContenido;
        private Button btnLibros;
        private Button btnPrestamos;
        private Button btnClientes;
    }
}