namespace avance_1_sistema_de_biblioteca
{
    partial class FrmPrestamos
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
            dgvPrestamo = new DataGridView();
            btnEliminarPrestamo = new Button();
            btnModificarPrestamo = new Button();
            btnAgregarPrestamo = new Button();
            btnBuscarPrestamo = new Button();
            txtIdClientePrestamo = new TextBox();
            txtIdLibroPrestramo = new TextBox();
            dtpFecha = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            rbNoDevueltoLibro = new RadioButton();
            rbDevueltoLibro = new RadioButton();
            txtBuscarPrestamo = new TextBox();
            label5 = new Label();
            lblIdPrestamoHidden = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPrestamo).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvPrestamo
            // 
            dgvPrestamo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrestamo.Location = new Point(173, 296);
            dgvPrestamo.Name = "dgvPrestamo";
            dgvPrestamo.RowHeadersWidth = 62;
            dgvPrestamo.Size = new Size(670, 262);
            dgvPrestamo.TabIndex = 0;
            dgvPrestamo.CellContentClick += dgvPrestamo_CellContentClick;
            // 
            // btnEliminarPrestamo
            // 
            btnEliminarPrestamo.Location = new Point(527, 172);
            btnEliminarPrestamo.Name = "btnEliminarPrestamo";
            btnEliminarPrestamo.Size = new Size(112, 34);
            btnEliminarPrestamo.TabIndex = 1;
            btnEliminarPrestamo.Text = "Eliminar";
            btnEliminarPrestamo.UseVisualStyleBackColor = true;
            btnEliminarPrestamo.Click += btnEliminarPrestamo_Click;
            // 
            // btnModificarPrestamo
            // 
            btnModificarPrestamo.Location = new Point(357, 172);
            btnModificarPrestamo.Name = "btnModificarPrestamo";
            btnModificarPrestamo.Size = new Size(112, 34);
            btnModificarPrestamo.TabIndex = 2;
            btnModificarPrestamo.Text = "Modificar";
            btnModificarPrestamo.UseVisualStyleBackColor = true;
            btnModificarPrestamo.Click += btnModificarPrestamo_Click;
            // 
            // btnAgregarPrestamo
            // 
            btnAgregarPrestamo.Location = new Point(158, 172);
            btnAgregarPrestamo.Name = "btnAgregarPrestamo";
            btnAgregarPrestamo.Size = new Size(112, 34);
            btnAgregarPrestamo.TabIndex = 3;
            btnAgregarPrestamo.Text = "Agregar";
            btnAgregarPrestamo.UseVisualStyleBackColor = true;
            btnAgregarPrestamo.Click += btnAgregarPrestamo_Click;
            // 
            // btnBuscarPrestamo
            // 
            btnBuscarPrestamo.Location = new Point(632, 241);
            btnBuscarPrestamo.Name = "btnBuscarPrestamo";
            btnBuscarPrestamo.Size = new Size(93, 37);
            btnBuscarPrestamo.TabIndex = 4;
            btnBuscarPrestamo.Text = "Buscar";
            btnBuscarPrestamo.UseVisualStyleBackColor = true;
            btnBuscarPrestamo.Click += btnBuscarPrestamo_Click;
            // 
            // txtIdClientePrestamo
            // 
            txtIdClientePrestamo.Location = new Point(284, 8);
            txtIdClientePrestamo.Name = "txtIdClientePrestamo";
            txtIdClientePrestamo.Size = new Size(150, 31);
            txtIdClientePrestamo.TabIndex = 5;
            // 
            // txtIdLibroPrestramo
            // 
            txtIdLibroPrestramo.Location = new Point(284, 48);
            txtIdLibroPrestramo.Name = "txtIdLibroPrestramo";
            txtIdLibroPrestramo.Size = new Size(150, 31);
            txtIdLibroPrestramo.TabIndex = 6;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(319, 115);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(300, 31);
            dtpFecha.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(146, 14);
            label1.Name = "label1";
            label1.Size = new Size(86, 25);
            label1.TabIndex = 8;
            label1.Text = "Id Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(146, 48);
            label2.Name = "label2";
            label2.Size = new Size(69, 25);
            label2.TabIndex = 9;
            label2.Text = "Id libro";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(146, 124);
            label3.Name = "label3";
            label3.Size = new Size(147, 25);
            label3.TabIndex = 10;
            label3.Text = "Fecha de entrega";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 159);
            label4.Name = "label4";
            label4.Size = new Size(0, 25);
            label4.TabIndex = 11;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbNoDevueltoLibro);
            groupBox1.Controls.Add(rbDevueltoLibro);
            groupBox1.Location = new Point(481, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(108, 101);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Devuelto";
            // 
            // rbNoDevueltoLibro
            // 
            rbNoDevueltoLibro.AutoSize = true;
            rbNoDevueltoLibro.Location = new Point(3, 66);
            rbNoDevueltoLibro.Name = "rbNoDevueltoLibro";
            rbNoDevueltoLibro.Size = new Size(61, 29);
            rbNoDevueltoLibro.TabIndex = 1;
            rbNoDevueltoLibro.TabStop = true;
            rbNoDevueltoLibro.Text = "No";
            rbNoDevueltoLibro.UseVisualStyleBackColor = true;
            // 
            // rbDevueltoLibro
            // 
            rbDevueltoLibro.AutoSize = true;
            rbDevueltoLibro.Location = new Point(3, 30);
            rbDevueltoLibro.Name = "rbDevueltoLibro";
            rbDevueltoLibro.Size = new Size(51, 29);
            rbDevueltoLibro.TabIndex = 0;
            rbDevueltoLibro.TabStop = true;
            rbDevueltoLibro.Text = "Si";
            rbDevueltoLibro.UseVisualStyleBackColor = true;
            // 
            // txtBuscarPrestamo
            // 
            txtBuscarPrestamo.Location = new Point(439, 244);
            txtBuscarPrestamo.Name = "txtBuscarPrestamo";
            txtBuscarPrestamo.Size = new Size(150, 31);
            txtBuscarPrestamo.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(158, 244);
            label5.Name = "label5";
            label5.Size = new Size(249, 25);
            label5.TabIndex = 15;
            label5.Text = "Buscar Prestamo (Nombre, Id)";
            // 
            // lblIdPrestamoHidden
            // 
            lblIdPrestamoHidden.AutoSize = true;
            lblIdPrestamoHidden.Location = new Point(632, 28);
            lblIdPrestamoHidden.Name = "lblIdPrestamoHidden";
            lblIdPrestamoHidden.Size = new Size(119, 25);
            lblIdPrestamoHidden.TabIndex = 16;
            lblIdPrestamoHidden.Text = "ID Prestamo: ";
            lblIdPrestamoHidden.Visible = false;
            // 
            // FrmPrestamos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1156, 634);
            Controls.Add(lblIdPrestamoHidden);
            Controls.Add(label5);
            Controls.Add(txtBuscarPrestamo);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtpFecha);
            Controls.Add(txtIdLibroPrestramo);
            Controls.Add(txtIdClientePrestamo);
            Controls.Add(btnBuscarPrestamo);
            Controls.Add(btnAgregarPrestamo);
            Controls.Add(btnModificarPrestamo);
            Controls.Add(btnEliminarPrestamo);
            Controls.Add(dgvPrestamo);
            Name = "FrmPrestamos";
            Text = "Form5";
            Load += FrmPrestamos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPrestamo).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPrestamo;
        private Button btnEliminarPrestamo;
        private Button btnModificarPrestamo;
        private Button btnAgregarPrestamo;
        private Button btnBuscarPrestamo;
        private TextBox txtIdClientePrestamo;
        private TextBox txtIdLibroPrestramo;
        private DateTimePicker dtpFecha;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox groupBox1;
        private RadioButton rbNoDevueltoLibro;
        private RadioButton rbDevueltoLibro;
        private TextBox txtBuscarPrestamo;
        private Label label5;
        private Label lblIdPrestamoHidden;
    }
}