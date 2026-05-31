namespace Farmano.Views
{
    partial class RegistroForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();

            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();

            this.btnGuardar = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // lblTitulo

            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font(
                "Microsoft Sans Serif",
                14F,
                System.Drawing.FontStyle.Bold);

            this.lblTitulo.Location =
            new System.Drawing.Point(120, 20);

            this.lblTitulo.Name = "lblTitulo";

            this.lblTitulo.Size =
            new System.Drawing.Size(180, 24);

            this.lblTitulo.Text = "Registro Usuario";

            // label2

            this.label2.AutoSize = true;
            this.label2.Location =
            new System.Drawing.Point(50, 80);

            this.label2.Text = "Nombre";

            // txtNombre

            this.txtNombre.Location =
            new System.Drawing.Point(150, 80);

            this.txtNombre.Size =
            new System.Drawing.Size(180, 20);

            // label3

            this.label3.AutoSize = true;
            this.label3.Location =
            new System.Drawing.Point(50, 120);

            this.label3.Text = "Apellidos";

            // txtApellidos

            this.txtApellidos.Location =
            new System.Drawing.Point(150, 120);

            this.txtApellidos.Size =
            new System.Drawing.Size(180, 20);

            // label4

            this.label4.AutoSize = true;
            this.label4.Location =
            new System.Drawing.Point(50, 160);

            this.label4.Text = "Correo";

            // txtCorreo

            this.txtCorreo.Location =
            new System.Drawing.Point(150, 160);

            this.txtCorreo.Size =
            new System.Drawing.Size(180, 20);

            // label5

            this.label5.AutoSize = true;
            this.label5.Location =
            new System.Drawing.Point(50, 200);

            this.label5.Text = "Telefono";

            // txtTelefono

            this.txtTelefono.Location =
            new System.Drawing.Point(150, 200);

            this.txtTelefono.Size =
            new System.Drawing.Size(180, 20);

            // label6

            this.label6.AutoSize = true;
            this.label6.Location =
            new System.Drawing.Point(50, 240);

            this.label6.Text = "Usuario";

            // txtUsuario

            this.txtUsuario.Location =
            new System.Drawing.Point(150, 240);

            this.txtUsuario.Size =
            new System.Drawing.Size(180, 20);

            // label7

            this.label7.AutoSize = true;
            this.label7.Location =
            new System.Drawing.Point(50, 280);

            this.label7.Text = "Contraseña";

            // txtPassword

            this.txtPassword.Location =
            new System.Drawing.Point(150, 280);

            this.txtPassword.Size =
            new System.Drawing.Size(180, 20);

            this.txtPassword.UseSystemPasswordChar = true;

            

            // btnGuardar

            this.btnGuardar.Location =
            new System.Drawing.Point(150, 370);

            this.btnGuardar.Size =
            new System.Drawing.Size(100, 30);

            this.btnGuardar.Text = "Guardar";

            // RegistroForm

            this.AutoScaleDimensions =
            new System.Drawing.SizeF(6F, 13F);

            this.AutoScaleMode =
            System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize =
            new System.Drawing.Size(420, 450);

            this.Controls.Add(this.lblTitulo);

            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);

            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtApellidos);

            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCorreo);

            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTelefono);

            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtUsuario);

            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPassword);

            this.Controls.Add(this.btnGuardar);

            this.Name = "RegistroForm";

            this.Text = "Registro Usuario";

            this.ResumeLayout(false);

            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnGuardar;
    }
}