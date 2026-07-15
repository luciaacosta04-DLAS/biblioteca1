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
            text_idenusuario = new TextBox();
            text_nombre = new TextBox();
            lbl_idenusuario = new Label();
            lbl_nombre = new Label();
            lblContraseña = new Label();
            textContraseña = new TextBox();
            btnEntrar = new Button();
            SuspendLayout();
            // 
            // text_idenusuario
            // 
            text_idenusuario.Location = new Point(658, 105);
            text_idenusuario.Name = "text_idenusuario";
            text_idenusuario.Size = new Size(287, 31);
            text_idenusuario.TabIndex = 19;
            // 
            // text_nombre
            // 
            text_nombre.Location = new Point(658, 239);
            text_nombre.Name = "text_nombre";
            text_nombre.Size = new Size(287, 31);
            text_nombre.TabIndex = 20;
            // 
            // lbl_idenusuario
            // 
            lbl_idenusuario.AutoSize = true;
            lbl_idenusuario.Location = new Point(749, 65);
            lbl_idenusuario.Name = "lbl_idenusuario";
            lbl_idenusuario.Size = new Size(97, 25);
            lbl_idenusuario.TabIndex = 22;
            lbl_idenusuario.Text = "Id_usuario:";
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Location = new Point(764, 199);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(82, 25);
            lbl_nombre.TabIndex = 23;
            lbl_nombre.Text = "Nombre:";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(749, 328);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(105, 25);
            lblContraseña.TabIndex = 24;
            lblContraseña.Text = "Contraseña:";
            // 
            // textContraseña
            // 
            textContraseña.Location = new Point(658, 370);
            textContraseña.Name = "textContraseña";
            textContraseña.Size = new Size(287, 31);
            textContraseña.TabIndex = 25;
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(749, 447);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(112, 34);
            btnEntrar.TabIndex = 26;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1097, 637);
            Controls.Add(btnEntrar);
            Controls.Add(textContraseña);
            Controls.Add(lblContraseña);
            Controls.Add(lbl_nombre);
            Controls.Add(lbl_idenusuario);
            Controls.Add(text_nombre);
            Controls.Add(text_idenusuario);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox text_idenusuario;
        private TextBox text_nombre;
        private Label lbl_idenusuario;
        private Label lbl_nombre;
        private Label lblContraseña;
        private TextBox textContraseña;
        private Button btnEntrar;
    }
}
