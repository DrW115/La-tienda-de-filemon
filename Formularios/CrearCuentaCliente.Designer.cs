namespace ProyectoFinal2.Formularios
{
    partial class CrearCuentaCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.txtPasswordConfirmacion = new System.Windows.Forms.TextBox();
            this.txtPasswordUsuario = new System.Windows.Forms.TextBox();
            this.txtCorreoUsuario = new System.Windows.Forms.TextBox();
            this.btnCrearCuenta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Correo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Confirme la contraseña";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(344, 123);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(100, 22);
            this.txtNombreUsuario.TabIndex = 4;
            // 
            // txtPasswordConfirmacion
            // 
            this.txtPasswordConfirmacion.Location = new System.Drawing.Point(344, 249);
            this.txtPasswordConfirmacion.Name = "txtPasswordConfirmacion";
            this.txtPasswordConfirmacion.Size = new System.Drawing.Size(100, 22);
            this.txtPasswordConfirmacion.TabIndex = 5;
            // 
            // txtPasswordUsuario
            // 
            this.txtPasswordUsuario.Location = new System.Drawing.Point(344, 203);
            this.txtPasswordUsuario.Name = "txtPasswordUsuario";
            this.txtPasswordUsuario.Size = new System.Drawing.Size(100, 22);
            this.txtPasswordUsuario.TabIndex = 6;
            // 
            // txtCorreoUsuario
            // 
            this.txtCorreoUsuario.Location = new System.Drawing.Point(344, 160);
            this.txtCorreoUsuario.Name = "txtCorreoUsuario";
            this.txtCorreoUsuario.Size = new System.Drawing.Size(100, 22);
            this.txtCorreoUsuario.TabIndex = 7;
            // 
            // btnCrearCuenta
            // 
            this.btnCrearCuenta.Location = new System.Drawing.Point(276, 317);
            this.btnCrearCuenta.Name = "btnCrearCuenta";
            this.btnCrearCuenta.Size = new System.Drawing.Size(95, 23);
            this.btnCrearCuenta.TabIndex = 8;
            this.btnCrearCuenta.Text = "Crear cuenta";
            this.btnCrearCuenta.UseVisualStyleBackColor = true;
            this.btnCrearCuenta.Click += new System.EventHandler(this.btnCrearCuenta_Click);
            // 
            // CrearCuentaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCrearCuenta);
            this.Controls.Add(this.txtCorreoUsuario);
            this.Controls.Add(this.txtPasswordUsuario);
            this.Controls.Add(this.txtPasswordConfirmacion);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CrearCuentaCliente";
            this.Text = "CrearCuentaCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.TextBox txtPasswordConfirmacion;
        private System.Windows.Forms.TextBox txtPasswordUsuario;
        private System.Windows.Forms.TextBox txtCorreoUsuario;
        private System.Windows.Forms.Button btnCrearCuenta;
    }
}