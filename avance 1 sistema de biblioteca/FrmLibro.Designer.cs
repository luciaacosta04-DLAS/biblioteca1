namespace avance_1_sistema_de_biblioteca
{
    partial class FrmLibro
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
            dgvLibro = new DataGridView();
            btnModificarLibro = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            rbDisponibleLibro = new RadioButton();
            rbNoDisponibleLibro = new RadioButton();
            groupBox1 = new GroupBox();
            btnAgregarLibro = new Button();
            txtIdLibroNuevo = new TextBox();
            txtAutorLibro = new TextBox();
            txtTituloLibro = new TextBox();
            btnEliminarLibro = new Button();
            btnBuscarLibro = new Button();
            txtBuscarLibro = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtCategoriaLibro = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvLibro).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvLibro
            // 
            dgvLibro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibro.Location = new Point(180, 273);
            dgvLibro.Name = "dgvLibro";
            dgvLibro.RowHeadersWidth = 62;
            dgvLibro.Size = new Size(696, 312);
            dgvLibro.TabIndex = 0;
            // 
            // btnModificarLibro
            // 
            btnModificarLibro.Location = new Point(314, 188);
            btnModificarLibro.Name = "btnModificarLibro";
            btnModificarLibro.Size = new Size(123, 40);
            btnModificarLibro.TabIndex = 1;
            btnModificarLibro.Text = "Modificar";
            btnModificarLibro.UseVisualStyleBackColor = true;
            btnModificarLibro.Click += btnModificarLibro_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(184, 48);
            label1.Name = "label1";
            label1.Size = new Size(56, 25);
            label1.TabIndex = 3;
            label1.Text = "Titulo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(180, 9);
            label2.Name = "label2";
            label2.Size = new Size(73, 25);
            label2.TabIndex = 4;
            label2.Text = "Id libro:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(196, 90);
            label3.Name = "label3";
            label3.Size = new Size(57, 25);
            label3.TabIndex = 5;
            label3.Text = "Autor";
            // 
            // rbDisponibleLibro
            // 
            rbDisponibleLibro.AutoSize = true;
            rbDisponibleLibro.Location = new Point(38, 44);
            rbDisponibleLibro.Name = "rbDisponibleLibro";
            rbDisponibleLibro.Size = new Size(51, 29);
            rbDisponibleLibro.TabIndex = 0;
            rbDisponibleLibro.TabStop = true;
            rbDisponibleLibro.Text = "Si";
            rbDisponibleLibro.UseVisualStyleBackColor = true;
            // 
            // rbNoDisponibleLibro
            // 
            rbNoDisponibleLibro.AutoSize = true;
            rbNoDisponibleLibro.Location = new Point(38, 79);
            rbNoDisponibleLibro.Name = "rbNoDisponibleLibro";
            rbNoDisponibleLibro.Size = new Size(61, 29);
            rbNoDisponibleLibro.TabIndex = 1;
            rbNoDisponibleLibro.TabStop = true;
            rbNoDisponibleLibro.Text = "No";
            rbNoDisponibleLibro.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbNoDisponibleLibro);
            groupBox1.Controls.Add(rbDisponibleLibro);
            groupBox1.Location = new Point(443, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(154, 108);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Esta disponible";
            // 
            // btnAgregarLibro
            // 
            btnAgregarLibro.Location = new Point(180, 188);
            btnAgregarLibro.Name = "btnAgregarLibro";
            btnAgregarLibro.Size = new Size(99, 45);
            btnAgregarLibro.TabIndex = 2;
            btnAgregarLibro.Text = "Agregar";
            btnAgregarLibro.UseVisualStyleBackColor = true;
            btnAgregarLibro.Click += btnAgregarLibro_Click;
            // 
            // txtIdLibroNuevo
            // 
            txtIdLibroNuevo.Location = new Point(273, 3);
            txtIdLibroNuevo.Name = "txtIdLibroNuevo";
            txtIdLibroNuevo.Size = new Size(150, 31);
            txtIdLibroNuevo.TabIndex = 7;
            // 
            // txtAutorLibro
            // 
            txtAutorLibro.Location = new Point(273, 89);
            txtAutorLibro.Name = "txtAutorLibro";
            txtAutorLibro.Size = new Size(150, 31);
            txtAutorLibro.TabIndex = 8;
            // 
            // txtTituloLibro
            // 
            txtTituloLibro.Location = new Point(273, 48);
            txtTituloLibro.Name = "txtTituloLibro";
            txtTituloLibro.Size = new Size(150, 31);
            txtTituloLibro.TabIndex = 9;
            // 
            // btnEliminarLibro
            // 
            btnEliminarLibro.Location = new Point(459, 188);
            btnEliminarLibro.Name = "btnEliminarLibro";
            btnEliminarLibro.Size = new Size(112, 34);
            btnEliminarLibro.TabIndex = 10;
            btnEliminarLibro.Text = "Eliminar";
            btnEliminarLibro.UseVisualStyleBackColor = true;
            btnEliminarLibro.Click += btnEliminarLibro_Click;
            // 
            // btnBuscarLibro
            // 
            btnBuscarLibro.Location = new Point(614, 235);
            btnBuscarLibro.Name = "btnBuscarLibro";
            btnBuscarLibro.Size = new Size(77, 32);
            btnBuscarLibro.TabIndex = 11;
            btnBuscarLibro.Text = "Buscar";
            btnBuscarLibro.UseVisualStyleBackColor = true;
            btnBuscarLibro.Click += btnBuscarLibro_Click;
            // 
            // txtBuscarLibro
            // 
            txtBuscarLibro.Location = new Point(443, 237);
            txtBuscarLibro.Name = "txtBuscarLibro";
            txtBuscarLibro.Size = new Size(150, 31);
            txtBuscarLibro.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(180, 236);
            label5.Name = "label5";
            label5.Size = new Size(227, 25);
            label5.TabIndex = 13;
            label5.Text = "Ingresa Libro, Categoria, ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(165, 144);
            label4.Name = "label4";
            label4.Size = new Size(88, 25);
            label4.TabIndex = 14;
            label4.Text = "Categoria";
            // 
            // txtCategoriaLibro
            // 
            txtCategoriaLibro.Location = new Point(273, 138);
            txtCategoriaLibro.Name = "txtCategoriaLibro";
            txtCategoriaLibro.Size = new Size(150, 31);
            txtCategoriaLibro.TabIndex = 15;
            // 
            // FrmLibro
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1130, 634);
            Controls.Add(txtCategoriaLibro);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(txtBuscarLibro);
            Controls.Add(btnBuscarLibro);
            Controls.Add(btnEliminarLibro);
            Controls.Add(txtTituloLibro);
            Controls.Add(txtAutorLibro);
            Controls.Add(txtIdLibroNuevo);
            Controls.Add(groupBox1);
            Controls.Add(btnAgregarLibro);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnModificarLibro);
            Controls.Add(dgvLibro);
            Name = "FrmLibro";
            Text = "Form3";
            Load += FrmLibro_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLibro).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvLibro;
        private Button btnModificarLibro;
        private Label label1;
        private Label label2;
        private Label label3;
        private RadioButton rbDisponibleLibro;
        private RadioButton rbNoDisponibleLibro;
        private GroupBox groupBox1;
        private Button btnAgregarLibro;
        private TextBox txtIdLibroNuevo;
        private TextBox txtAutorLibro;
        private TextBox txtTituloLibro;
        private Button btnEliminarLibro;
        private Button btnBuscarLibro;
        private TextBox txtBuscarLibro;
        private Label label5;
        private Label label4;
        private TextBox txtCategoriaLibro;
    }
}