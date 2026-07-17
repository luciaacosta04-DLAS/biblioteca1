namespace avance_1_sistema_de_biblioteca
{
    partial class FrmCliente
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
            dgvCliente = new DataGridView();
            btnAgregarCliente = new Button();
            btnEliminarCliente = new Button();
            btnModificarCliente = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtIdClienteNuevo = new TextBox();
            txtNombreCliente = new TextBox();
            txtTelefonoCliente = new TextBox();
            txtCorreoCliente = new TextBox();
            btnBuscarCliente = new Button();
            txtBuscarCliente = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCliente).BeginInit();
            SuspendLayout();
            // 
            // dgvCliente
            // 
            dgvCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCliente.Location = new Point(207, 324);
            dgvCliente.Name = "dgvCliente";
            dgvCliente.RowHeadersWidth = 62;
            dgvCliente.Size = new Size(601, 306);
            dgvCliente.TabIndex = 0;
            dgvCliente.CellContentClick += dgvCliente_CellContentClick;
            // 
            // btnAgregarCliente
            // 
            btnAgregarCliente.Location = new Point(186, 203);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(112, 34);
            btnAgregarCliente.TabIndex = 1;
            btnAgregarCliente.Text = "Agregar";
            btnAgregarCliente.UseVisualStyleBackColor = true;
            btnAgregarCliente.Click += btnAgregarCliente_Click;
            // 
            // btnEliminarCliente
            // 
            btnEliminarCliente.Location = new Point(494, 203);
            btnEliminarCliente.Name = "btnEliminarCliente";
            btnEliminarCliente.Size = new Size(112, 34);
            btnEliminarCliente.TabIndex = 2;
            btnEliminarCliente.Text = "Eliminar";
            btnEliminarCliente.UseVisualStyleBackColor = true;
            btnEliminarCliente.Click += btnEliminarCliente_Click;
            // 
            // btnModificarCliente
            // 
            btnModificarCliente.Location = new Point(342, 203);
            btnModificarCliente.Name = "btnModificarCliente";
            btnModificarCliente.Size = new Size(112, 34);
            btnModificarCliente.TabIndex = 3;
            btnModificarCliente.Text = "Modificar";
            btnModificarCliente.UseVisualStyleBackColor = true;
            btnModificarCliente.Click += btnModificarCliente_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(191, 12);
            label1.Name = "label1";
            label1.Size = new Size(90, 25);
            label1.TabIndex = 4;
            label1.Text = "Id Cliente:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(186, 46);
            label2.Name = "label2";
            label2.Size = new Size(140, 25);
            label2.TabIndex = 5;
            label2.Text = "Nombre Cliente:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(186, 89);
            label3.Name = "label3";
            label3.Size = new Size(141, 25);
            label3.TabIndex = 6;
            label3.Text = "Telefono Cliente:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(191, 130);
            label4.Name = "label4";
            label4.Size = new Size(124, 25);
            label4.TabIndex = 7;
            label4.Text = "Correo Cliente";
            // 
            // txtIdClienteNuevo
            // 
            txtIdClienteNuevo.Location = new Point(394, 9);
            txtIdClienteNuevo.Name = "txtIdClienteNuevo";
            txtIdClienteNuevo.Size = new Size(150, 31);
            txtIdClienteNuevo.TabIndex = 9;
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(394, 46);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(150, 31);
            txtNombreCliente.TabIndex = 10;
            // 
            // txtTelefonoCliente
            // 
            txtTelefonoCliente.Location = new Point(394, 83);
            txtTelefonoCliente.Name = "txtTelefonoCliente";
            txtTelefonoCliente.Size = new Size(150, 31);
            txtTelefonoCliente.TabIndex = 11;
            // 
            // txtCorreoCliente
            // 
            txtCorreoCliente.Location = new Point(394, 130);
            txtCorreoCliente.Name = "txtCorreoCliente";
            txtCorreoCliente.Size = new Size(150, 31);
            txtCorreoCliente.TabIndex = 12;
            // 
            // btnBuscarCliente
            // 
            btnBuscarCliente.Location = new Point(650, 268);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.Size = new Size(112, 34);
            btnBuscarCliente.TabIndex = 13;
            btnBuscarCliente.Text = "buscar";
            btnBuscarCliente.UseVisualStyleBackColor = true;
            btnBuscarCliente.Click += btnBuscarCliente_Click;
            // 
            // txtBuscarCliente
            // 
            txtBuscarCliente.Location = new Point(478, 266);
            txtBuscarCliente.Name = "txtBuscarCliente";
            txtBuscarCliente.Size = new Size(150, 31);
            txtBuscarCliente.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(333, 273);
            label5.Name = "label5";
            label5.Size = new Size(121, 25);
            label5.TabIndex = 16;
            label5.Text = "Buscar Cliente";
            // 
            // FrmCliente
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1187, 669);
            Controls.Add(label5);
            Controls.Add(txtBuscarCliente);
            Controls.Add(btnBuscarCliente);
            Controls.Add(txtCorreoCliente);
            Controls.Add(txtTelefonoCliente);
            Controls.Add(txtNombreCliente);
            Controls.Add(txtIdClienteNuevo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnModificarCliente);
            Controls.Add(btnEliminarCliente);
            Controls.Add(btnAgregarCliente);
            Controls.Add(dgvCliente);
            Name = "FrmCliente";
            Text = "Form4";
            Load += FrmCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCliente;
        private Button btnAgregarCliente;
        private Button btnEliminarCliente;
        private Button btnModificarCliente;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtIdClienteNuevo;
        private TextBox txtNombreCliente;
        private TextBox txtTelefonoCliente;
        private TextBox txtCorreoCliente;
        private Button btnBuscarCliente;
        private TextBox txtBuscarCliente;
        private Label label5;
    }
}