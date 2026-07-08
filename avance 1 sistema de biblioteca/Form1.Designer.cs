namespace avance_1_sistema_de_biblioteca
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            lbl_Idlibro = new Label();
            lbl_autor = new Label();
            lbl_titulo = new Label();
            lbl_disponible = new Label();
            text_Idlibro = new TextBox();
            text_autor = new TextBox();
            text_titulo = new TextBox();
            radio_si = new RadioButton();
            radio_no = new RadioButton();
            lbl_prestamos = new Label();
            lbl_idenlibro = new Label();
            lbl_idusuario = new Label();
            lbl_fecha = new Label();
            text_idenlibro = new TextBox();
            text_idusuario = new TextBox();
            text_idenusuario = new TextBox();
            text_nombre = new TextBox();
            lbl_idenusuario = new Label();
            lbl_nombre = new Label();
            lbl_usuario = new Label();
            dateTimePicker1 = new DateTimePicker();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(449, 9);
            label1.Name = "label1";
            label1.Size = new Size(184, 25);
            label1.TabIndex = 0;
            label1.Text = "sistema de biblioteca ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 98);
            label2.Name = "label2";
            label2.Size = new Size(60, 25);
            label2.TabIndex = 1;
            label2.Text = "libros:";
            // 
            // lbl_Idlibro
            // 
            lbl_Idlibro.AutoSize = true;
            lbl_Idlibro.Location = new Point(29, 155);
            lbl_Idlibro.Name = "lbl_Idlibro";
            lbl_Idlibro.Size = new Size(75, 25);
            lbl_Idlibro.TabIndex = 2;
            lbl_Idlibro.Text = "Id_libro:";
            // 
            // lbl_autor
            // 
            lbl_autor.AutoSize = true;
            lbl_autor.Location = new Point(30, 243);
            lbl_autor.Name = "lbl_autor";
            lbl_autor.Size = new Size(61, 25);
            lbl_autor.TabIndex = 3;
            lbl_autor.Text = "Autor:";
            // 
            // lbl_titulo
            // 
            lbl_titulo.AutoSize = true;
            lbl_titulo.Location = new Point(31, 200);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(60, 25);
            lbl_titulo.TabIndex = 4;
            lbl_titulo.Text = "Titulo:";
            // 
            // lbl_disponible
            // 
            lbl_disponible.AutoSize = true;
            lbl_disponible.Location = new Point(32, 295);
            lbl_disponible.Name = "lbl_disponible";
            lbl_disponible.Size = new Size(99, 25);
            lbl_disponible.TabIndex = 5;
            lbl_disponible.Text = "disponible:";
            // 
            // text_Idlibro
            // 
            text_Idlibro.Location = new Point(154, 155);
            text_Idlibro.Name = "text_Idlibro";
            text_Idlibro.Size = new Size(150, 31);
            text_Idlibro.TabIndex = 7;
            // 
            // text_autor
            // 
            text_autor.Location = new Point(154, 243);
            text_autor.Name = "text_autor";
            text_autor.Size = new Size(150, 31);
            text_autor.TabIndex = 8;
            // 
            // text_titulo
            // 
            text_titulo.Location = new Point(154, 200);
            text_titulo.Name = "text_titulo";
            text_titulo.Size = new Size(150, 31);
            text_titulo.TabIndex = 9;
            // 
            // radio_si
            // 
            radio_si.AutoSize = true;
            radio_si.Location = new Point(154, 295);
            radio_si.Name = "radio_si";
            radio_si.Size = new Size(51, 29);
            radio_si.TabIndex = 10;
            radio_si.TabStop = true;
            radio_si.Text = "Si";
            radio_si.UseVisualStyleBackColor = true;
            // 
            // radio_no
            // 
            radio_no.AutoSize = true;
            radio_no.Location = new Point(222, 295);
            radio_no.Name = "radio_no";
            radio_no.Size = new Size(61, 29);
            radio_no.TabIndex = 11;
            radio_no.TabStop = true;
            radio_no.Text = "No";
            radio_no.UseVisualStyleBackColor = true;
            // 
            // lbl_prestamos
            // 
            lbl_prestamos.AutoSize = true;
            lbl_prestamos.Location = new Point(484, 99);
            lbl_prestamos.Name = "lbl_prestamos";
            lbl_prestamos.Size = new Size(100, 25);
            lbl_prestamos.TabIndex = 12;
            lbl_prestamos.Text = "prestamos:";
            // 
            // lbl_idenlibro
            // 
            lbl_idenlibro.AutoSize = true;
            lbl_idenlibro.Location = new Point(380, 151);
            lbl_idenlibro.Name = "lbl_idenlibro";
            lbl_idenlibro.Size = new Size(75, 25);
            lbl_idenlibro.TabIndex = 13;
            lbl_idenlibro.Text = "Id_libro:";
            // 
            // lbl_idusuario
            // 
            lbl_idusuario.AutoSize = true;
            lbl_idusuario.Location = new Point(380, 198);
            lbl_idusuario.Name = "lbl_idusuario";
            lbl_idusuario.Size = new Size(97, 25);
            lbl_idusuario.TabIndex = 14;
            lbl_idusuario.Text = "Id_usuario:";
            // 
            // lbl_fecha
            // 
            lbl_fecha.AutoSize = true;
            lbl_fecha.Location = new Point(380, 246);
            lbl_fecha.Name = "lbl_fecha";
            lbl_fecha.Size = new Size(58, 25);
            lbl_fecha.TabIndex = 15;
            lbl_fecha.Text = "fecha:";
            // 
            // text_idenlibro
            // 
            text_idenlibro.Location = new Point(482, 151);
            text_idenlibro.Name = "text_idenlibro";
            text_idenlibro.Size = new Size(150, 31);
            text_idenlibro.TabIndex = 16;
            // 
            // text_idusuario
            // 
            text_idusuario.Location = new Point(482, 200);
            text_idusuario.Name = "text_idusuario";
            text_idusuario.Size = new Size(150, 31);
            text_idusuario.TabIndex = 17;
            // 
            // text_idenusuario
            // 
            text_idenusuario.Location = new Point(873, 145);
            text_idenusuario.Name = "text_idenusuario";
            text_idenusuario.Size = new Size(150, 31);
            text_idenusuario.TabIndex = 19;
            // 
            // text_nombre
            // 
            text_nombre.Location = new Point(870, 192);
            text_nombre.Name = "text_nombre";
            text_nombre.Size = new Size(150, 31);
            text_nombre.TabIndex = 20;
            // 
            // lbl_idenusuario
            // 
            lbl_idenusuario.AutoSize = true;
            lbl_idenusuario.Location = new Point(770, 150);
            lbl_idenusuario.Name = "lbl_idenusuario";
            lbl_idenusuario.Size = new Size(97, 25);
            lbl_idenusuario.TabIndex = 22;
            lbl_idenusuario.Text = "Id_usuario:";
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Location = new Point(770, 192);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(82, 25);
            lbl_nombre.TabIndex = 23;
            lbl_nombre.Text = "Nombre:";
            // 
            // lbl_usuario
            // 
            lbl_usuario.AutoSize = true;
            lbl_usuario.Location = new Point(825, 98);
            lbl_usuario.Name = "lbl_usuario";
            lbl_usuario.Size = new Size(82, 25);
            lbl_usuario.TabIndex = 25;
            lbl_usuario.Text = "usuarios:";
            lbl_usuario.Click += label6_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(449, 246);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(365, 31);
            dateTimePicker1.TabIndex = 26;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(100, 379);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(891, 225);
            dataGridView1.TabIndex = 27;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1097, 637);
            Controls.Add(dataGridView1);
            Controls.Add(dateTimePicker1);
            Controls.Add(lbl_usuario);
            Controls.Add(lbl_nombre);
            Controls.Add(lbl_idenusuario);
            Controls.Add(text_nombre);
            Controls.Add(text_idenusuario);
            Controls.Add(text_idusuario);
            Controls.Add(text_idenlibro);
            Controls.Add(lbl_fecha);
            Controls.Add(lbl_idusuario);
            Controls.Add(lbl_idenlibro);
            Controls.Add(lbl_prestamos);
            Controls.Add(radio_no);
            Controls.Add(radio_si);
            Controls.Add(text_titulo);
            Controls.Add(text_autor);
            Controls.Add(text_Idlibro);
            Controls.Add(lbl_disponible);
            Controls.Add(lbl_titulo);
            Controls.Add(lbl_autor);
            Controls.Add(lbl_Idlibro);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lbl_Idlibro;
        private Label lbl_autor;
        private Label lbl_titulo;
        private Label lbl_disponible;
        private TextBox text_Idlibro;
        private TextBox text_autor;
        private TextBox text_titulo;
        private RadioButton radio_si;
        private RadioButton radio_no;
        private Label lbl_prestamos;
        private Label lbl_idenlibro;
        private Label lbl_idusuario;
        private Label lbl_fecha;
        private TextBox text_idenlibro;
        private TextBox text_idusuario;
        private TextBox text_idenusuario;
        private TextBox text_nombre;
        private Label lbl_idenusuario;
        private Label lbl_nombre;
        private Label lbl_usuario;
        private DateTimePicker dateTimePicker1;
        private DataGridView dataGridView1;
    }
}
