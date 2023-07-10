namespace Cliente_Ejercicio15
{
    partial class frmCliente
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.chkTexto = new System.Windows.Forms.CheckBox();
            this.txtTextoAEnviar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnActualizarBinario = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtBinarioEnviar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.txtRecibidoBinario = new System.Windows.Forms.TextBox();
            this.txtRespuesta = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnProbar = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPuerto = new System.Windows.Forms.TextBox();
            this.txtIPServidor = new System.Windows.Forms.TextBox();
            this.btnConectar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnResolver = new System.Windows.Forms.Button();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkTexto
            // 
            this.chkTexto.AutoSize = true;
            this.chkTexto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTexto.Location = new System.Drawing.Point(886, 26);
            this.chkTexto.Margin = new System.Windows.Forms.Padding(4);
            this.chkTexto.Name = "chkTexto";
            this.chkTexto.Size = new System.Drawing.Size(67, 24);
            this.chkTexto.TabIndex = 74;
            this.chkTexto.Text = "Texto";
            this.chkTexto.UseVisualStyleBackColor = true;
            // 
            // txtTextoAEnviar
            // 
            this.txtTextoAEnviar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTextoAEnviar.Location = new System.Drawing.Point(296, 67);
            this.txtTextoAEnviar.Margin = new System.Windows.Forms.Padding(4);
            this.txtTextoAEnviar.Multiline = true;
            this.txtTextoAEnviar.Name = "txtTextoAEnviar";
            this.txtTextoAEnviar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTextoAEnviar.Size = new System.Drawing.Size(652, 127);
            this.txtTextoAEnviar.TabIndex = 73;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(292, 39);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(563, 20);
            this.label10.TabIndex = 72;
            this.label10.Text = "Puede emplear caracteres hexadecimales separados por espacio o solamente texto.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(292, 13);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 20);
            this.label9.TabIndex = 71;
            this.label9.Text = "Envío:";
            // 
            // btnActualizarBinario
            // 
            this.btnActualizarBinario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarBinario.Location = new System.Drawing.Point(806, 202);
            this.btnActualizarBinario.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizarBinario.Name = "btnActualizarBinario";
            this.btnActualizarBinario.Size = new System.Drawing.Size(144, 30);
            this.btnActualizarBinario.TabIndex = 70;
            this.btnActualizarBinario.Text = "Actualizar Binario";
            this.btnActualizarBinario.UseVisualStyleBackColor = true;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(680, 202);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(118, 30);
            this.btnEnviar.TabIndex = 69;
            this.btnEnviar.Text = "Enviar!";
            this.btnEnviar.UseVisualStyleBackColor = true;
            // 
            // txtBinarioEnviar
            // 
            this.txtBinarioEnviar.Enabled = false;
            this.txtBinarioEnviar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBinarioEnviar.Location = new System.Drawing.Point(296, 242);
            this.txtBinarioEnviar.Margin = new System.Windows.Forms.Padding(4);
            this.txtBinarioEnviar.Multiline = true;
            this.txtBinarioEnviar.Name = "txtBinarioEnviar";
            this.txtBinarioEnviar.Size = new System.Drawing.Size(652, 150);
            this.txtBinarioEnviar.TabIndex = 68;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(292, 222);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 20);
            this.label8.TabIndex = 67;
            this.label8.Text = "Datos enviados";
            // 
            // txtLog
            // 
            this.txtLog.Enabled = false;
            this.txtLog.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLog.Location = new System.Drawing.Point(31, 575);
            this.txtLog.Margin = new System.Windows.Forms.Padding(4);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(922, 77);
            this.txtLog.TabIndex = 66;
            // 
            // txtRecibidoBinario
            // 
            this.txtRecibidoBinario.Enabled = false;
            this.txtRecibidoBinario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecibidoBinario.Location = new System.Drawing.Point(31, 490);
            this.txtRecibidoBinario.Margin = new System.Windows.Forms.Padding(4);
            this.txtRecibidoBinario.Multiline = true;
            this.txtRecibidoBinario.Name = "txtRecibidoBinario";
            this.txtRecibidoBinario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRecibidoBinario.Size = new System.Drawing.Size(922, 77);
            this.txtRecibidoBinario.TabIndex = 65;
            // 
            // txtRespuesta
            // 
            this.txtRespuesta.Enabled = false;
            this.txtRespuesta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRespuesta.Location = new System.Drawing.Point(31, 405);
            this.txtRespuesta.Margin = new System.Windows.Forms.Padding(4);
            this.txtRespuesta.Multiline = true;
            this.txtRespuesta.Name = "txtRespuesta";
            this.txtRespuesta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRespuesta.Size = new System.Drawing.Size(922, 77);
            this.txtRespuesta.TabIndex = 64;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 380);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 63;
            this.label7.Text = "Resultados:";
            // 
            // btnProbar
            // 
            this.btnProbar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProbar.Location = new System.Drawing.Point(114, 330);
            this.btnProbar.Margin = new System.Windows.Forms.Padding(4);
            this.btnProbar.Name = "btnProbar";
            this.btnProbar.Size = new System.Drawing.Size(160, 28);
            this.btnProbar.TabIndex = 62;
            this.btnProbar.Text = "Probar Conexion";
            this.btnProbar.UseVisualStyleBackColor = true;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(178, 296);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(96, 20);
            this.lblEstado.TabIndex = 61;
            this.lblEstado.Text = "Desconocido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 296);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 20);
            this.label6.TabIndex = 60;
            this.label6.Text = "Puede Conectarse?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 265);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 20);
            this.label5.TabIndex = 59;
            this.label5.Text = "Prueba de Conexion:";
            // 
            // txtPuerto
            // 
            this.txtPuerto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPuerto.Location = new System.Drawing.Point(122, 180);
            this.txtPuerto.Margin = new System.Windows.Forms.Padding(4);
            this.txtPuerto.Name = "txtPuerto";
            this.txtPuerto.Size = new System.Drawing.Size(152, 27);
            this.txtPuerto.TabIndex = 58;
            // 
            // txtIPServidor
            // 
            this.txtIPServidor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIPServidor.Location = new System.Drawing.Point(122, 148);
            this.txtIPServidor.Margin = new System.Windows.Forms.Padding(4);
            this.txtIPServidor.Name = "txtIPServidor";
            this.txtIPServidor.Size = new System.Drawing.Size(152, 27);
            this.txtIPServidor.TabIndex = 57;
            // 
            // btnConectar
            // 
            this.btnConectar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConectar.Location = new System.Drawing.Point(181, 214);
            this.btnConectar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(93, 28);
            this.btnConectar.TabIndex = 56;
            this.btnConectar.Text = "Conectar!";
            this.btnConectar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 191);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 55;
            this.label4.Text = "Puerto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 157);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 54;
            this.label3.Text = "Direccion IP";
            // 
            // btnResolver
            // 
            this.btnResolver.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResolver.Location = new System.Drawing.Point(182, 108);
            this.btnResolver.Margin = new System.Windows.Forms.Padding(4);
            this.btnResolver.Name = "btnResolver";
            this.btnResolver.Size = new System.Drawing.Size(93, 30);
            this.btnResolver.TabIndex = 53;
            this.btnResolver.Text = "Resolver";
            this.btnResolver.UseVisualStyleBackColor = true;
            // 
            // txtServidor
            // 
            this.txtServidor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServidor.Location = new System.Drawing.Point(31, 76);
            this.txtServidor.Margin = new System.Windows.Forms.Padding(4);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(243, 27);
            this.txtServidor.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 51;
            this.label2.Text = "Nombre del Equipo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 50;
            this.label1.Text = "Conexión:";
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 666);
            this.Controls.Add(this.chkTexto);
            this.Controls.Add(this.txtTextoAEnviar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnActualizarBinario);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtBinarioEnviar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.txtRecibidoBinario);
            this.Controls.Add(this.txtRespuesta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnProbar);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPuerto);
            this.Controls.Add(this.txtIPServidor);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnResolver);
            this.Controls.Add(this.txtServidor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCliente";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkTexto;
        private System.Windows.Forms.TextBox txtTextoAEnviar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnActualizarBinario;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtBinarioEnviar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.TextBox txtRecibidoBinario;
        private System.Windows.Forms.TextBox txtRespuesta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnProbar;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPuerto;
        private System.Windows.Forms.TextBox txtIPServidor;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnResolver;
        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

