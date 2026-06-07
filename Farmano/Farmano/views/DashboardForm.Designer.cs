using System;

namespace Farmano.Views
{
    partial class DashboardForm
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlUsuarios = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlClientes = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlProveedores = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pnlProducto = new System.Windows.Forms.Panel();
            this.pnlInventario = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pnlVentas = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.pnlReportes = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlUsuarios.SuspendLayout();
            this.pnlClientes.SuspendLayout();
            this.pnlProveedores.SuspendLayout();
            this.pnlProducto.SuspendLayout();
            this.pnlInventario.SuspendLayout();
            this.pnlVentas.SuspendLayout();
            this.pnlReportes.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.Teal;
            this.panelMenu.Controls.Add(this.lblTitulo);
            this.panelMenu.Controls.Add(this.pictureBox1);
            this.panelMenu.Controls.Add(this.label2);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1284, 103);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(572, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(173, 37);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "FARMANOVA";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Farmano.Properties.Resources.c2862b5b_0268_4aaa_9ef0_764998920f48;
            this.pictureBox1.Location = new System.Drawing.Point(0, -15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Teal;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(591, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sistema Farmacéutico";
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.Black;
            this.btnCerrarSesion.Location = new System.Drawing.Point(12, 397);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(117, 40);
            this.btnCerrarSesion.TabIndex = 5;
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(310, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "FARMANOVA";
            // 
            // pnlUsuarios
            // 
            this.pnlUsuarios.BackColor = System.Drawing.Color.White;
            this.pnlUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUsuarios.Controls.Add(this.label6);
            this.pnlUsuarios.Controls.Add(this.label3);
            this.pnlUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlUsuarios.Location = new System.Drawing.Point(206, 119);
            this.pnlUsuarios.Name = "pnlUsuarios";
            this.pnlUsuarios.Size = new System.Drawing.Size(150, 100);
            this.pnlUsuarios.TabIndex = 1;
            this.pnlUsuarios.Click += new System.EventHandler(this.pnlUsuarios_Click);
            this.pnlUsuarios.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlUsuarios_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(54, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 30);
            this.label6.TabIndex = 9;
            this.label6.Text = "👤";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Usuarios";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Clientes ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Proveedores";
            // 
            // pnlClientes
            // 
            this.pnlClientes.BackColor = System.Drawing.Color.White;
            this.pnlClientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlClientes.Controls.Add(this.label8);
            this.pnlClientes.Controls.Add(this.label4);
            this.pnlClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlClientes.Location = new System.Drawing.Point(443, 119);
            this.pnlClientes.Name = "pnlClientes";
            this.pnlClientes.Size = new System.Drawing.Size(150, 100);
            this.pnlClientes.TabIndex = 6;
            this.pnlClientes.Click += new System.EventHandler(this.pnlClientes_Click);
            this.pnlClientes.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlClientes_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(57, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 25);
            this.label8.TabIndex = 3;
            this.label8.Text = "🧑";
            // 
            // pnlProveedores
            // 
            this.pnlProveedores.BackColor = System.Drawing.Color.White;
            this.pnlProveedores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProveedores.Controls.Add(this.label5);
            this.pnlProveedores.Controls.Add(this.label9);
            this.pnlProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlProveedores.Location = new System.Drawing.Point(709, 119);
            this.pnlProveedores.Name = "pnlProveedores";
            this.pnlProveedores.Size = new System.Drawing.Size(150, 100);
            this.pnlProveedores.TabIndex = 8;
            this.pnlProveedores.Click += new System.EventHandler(this.pnlProveedores_Click);
            this.pnlProveedores.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlProveedores_Paint);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(55, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 25);
            this.label9.TabIndex = 9;
            this.label9.Text = "🚚";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 25);
            this.label10.TabIndex = 10;
            this.label10.Text = "Productos";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(56, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 25);
            this.label11.TabIndex = 11;
            this.label11.Text = "💊  ";
            // 
            // pnlProducto
            // 
            this.pnlProducto.BackColor = System.Drawing.Color.White;
            this.pnlProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProducto.Controls.Add(this.label10);
            this.pnlProducto.Controls.Add(this.label11);
            this.pnlProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlProducto.Location = new System.Drawing.Point(216, 268);
            this.pnlProducto.Name = "pnlProducto";
            this.pnlProducto.Size = new System.Drawing.Size(150, 100);
            this.pnlProducto.TabIndex = 12;
            this.pnlProducto.Click += new System.EventHandler(this.pnlProducto_Click);
            this.pnlProducto.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlProducto_Paint);
            // 
            // pnlInventario
            // 
            this.pnlInventario.BackColor = System.Drawing.Color.White;
            this.pnlInventario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInventario.Controls.Add(this.label12);
            this.pnlInventario.Controls.Add(this.label13);
            this.pnlInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlInventario.Location = new System.Drawing.Point(443, 265);
            this.pnlInventario.Name = "pnlInventario";
            this.pnlInventario.Size = new System.Drawing.Size(150, 100);
            this.pnlInventario.TabIndex = 13;
            this.pnlInventario.Click += new System.EventHandler(this.pnlInventario_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(20, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 25);
            this.label12.TabIndex = 15;
            this.label12.Text = "Inventario";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(47, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 25);
            this.label13.TabIndex = 16;
            this.label13.Text = "📦";
            // 
            // pnlVentas
            // 
            this.pnlVentas.BackColor = System.Drawing.Color.White;
            this.pnlVentas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlVentas.Controls.Add(this.label14);
            this.pnlVentas.Controls.Add(this.label15);
            this.pnlVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlVentas.Location = new System.Drawing.Point(709, 268);
            this.pnlVentas.Name = "pnlVentas";
            this.pnlVentas.Size = new System.Drawing.Size(150, 100);
            this.pnlVentas.TabIndex = 14;
            this.pnlVentas.Click += new System.EventHandler(this.pnlVentas_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(47, 49);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 25);
            this.label14.TabIndex = 17;
            this.label14.Text = "Ventas";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(55, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(33, 25);
            this.label15.TabIndex = 15;
            this.label15.Text = "🛒";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(27, 58);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 25);
            this.label16.TabIndex = 16;
            this.label16.Text = "Reportes ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(49, 32);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(33, 25);
            this.label17.TabIndex = 17;
            this.label17.Text = "📊";
            // 
            // pnlReportes
            // 
            this.pnlReportes.BackColor = System.Drawing.Color.White;
            this.pnlReportes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlReportes.Controls.Add(this.label16);
            this.pnlReportes.Controls.Add(this.label17);
            this.pnlReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlReportes.Location = new System.Drawing.Point(443, 451);
            this.pnlReportes.Name = "pnlReportes";
            this.pnlReportes.Size = new System.Drawing.Size(150, 100);
            this.pnlReportes.TabIndex = 18;
            this.pnlReportes.Click += new System.EventHandler(this.pnlReportes_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1284, 711);
            this.Controls.Add(this.pnlReportes);
            this.Controls.Add(this.pnlVentas);
            this.Controls.Add(this.pnlInventario);
            this.Controls.Add(this.pnlProducto);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.pnlProveedores);
            this.Controls.Add(this.pnlClientes);
            this.Controls.Add(this.pnlUsuarios);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(40, 140);
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Farmanova Dashboard";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlUsuarios.ResumeLayout(false);
            this.pnlUsuarios.PerformLayout();
            this.pnlClientes.ResumeLayout(false);
            this.pnlClientes.PerformLayout();
            this.pnlProveedores.ResumeLayout(false);
            this.pnlProveedores.PerformLayout();
            this.pnlProducto.ResumeLayout(false);
            this.pnlProducto.PerformLayout();
            this.pnlInventario.ResumeLayout(false);
            this.pnlInventario.PerformLayout();
            this.pnlVentas.ResumeLayout(false);
            this.pnlVentas.PerformLayout();
            this.pnlReportes.ResumeLayout(false);
            this.pnlReportes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Panel pnlUsuarios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlClientes;
        private System.Windows.Forms.Panel pnlProveedores;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel pnlProducto;
        private System.Windows.Forms.Panel pnlInventario;
        private System.Windows.Forms.Panel pnlVentas;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel pnlReportes;
    }
}
