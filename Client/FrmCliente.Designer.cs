namespace Client
{
    partial class frmCliente
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
            this.gbxConexion = new System.Windows.Forms.GroupBox();
            this.lblPuerto = new System.Windows.Forms.Label();
            this.lblIPServidor = new System.Windows.Forms.Label();
            this.bntConectar = new System.Windows.Forms.Button();
            this.btnResolver = new System.Windows.Forms.Button();
            this.lblServidor = new System.Windows.Forms.Label();
            this.txtPuerto = new System.Windows.Forms.TextBox();
            this.txtIPServidor = new System.Windows.Forms.TextBox();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.gbxEnvio = new System.Windows.Forms.GroupBox();
            this.chkTexto = new System.Windows.Forms.CheckBox();
            this.lblDatosEnviados = new System.Windows.Forms.Label();
            this.lblEnvio = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtBinarioEnviar = new System.Windows.Forms.TextBox();
            this.btnActualizarBinario = new System.Windows.Forms.Button();
            this.txtTextoAEnviar = new System.Windows.Forms.TextBox();
            this.gbxPruebaConexion = new System.Windows.Forms.GroupBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblPuedeConectar = new System.Windows.Forms.Label();
            this.btnProbar = new System.Windows.Forms.Button();
            this.gbxResultados = new System.Windows.Forms.GroupBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.txtRecibidoBinario = new System.Windows.Forms.TextBox();
            this.txtRespuesta = new System.Windows.Forms.TextBox();
            this.gbxConexion.SuspendLayout();
            this.gbxEnvio.SuspendLayout();
            this.gbxPruebaConexion.SuspendLayout();
            this.gbxResultados.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxConexion
            // 
            this.gbxConexion.Controls.Add(this.lblPuerto);
            this.gbxConexion.Controls.Add(this.lblIPServidor);
            this.gbxConexion.Controls.Add(this.bntConectar);
            this.gbxConexion.Controls.Add(this.btnResolver);
            this.gbxConexion.Controls.Add(this.lblServidor);
            this.gbxConexion.Controls.Add(this.txtPuerto);
            this.gbxConexion.Controls.Add(this.txtIPServidor);
            this.gbxConexion.Controls.Add(this.txtServidor);
            this.gbxConexion.Location = new System.Drawing.Point(12, 12);
            this.gbxConexion.Name = "gbxConexion";
            this.gbxConexion.Size = new System.Drawing.Size(240, 192);
            this.gbxConexion.TabIndex = 0;
            this.gbxConexion.TabStop = false;
            this.gbxConexion.Text = "Conexión:";
            // 
            // lblPuerto
            // 
            this.lblPuerto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPuerto.AutoSize = true;
            this.lblPuerto.Location = new System.Drawing.Point(6, 138);
            this.lblPuerto.Name = "lblPuerto";
            this.lblPuerto.Size = new System.Drawing.Size(38, 13);
            this.lblPuerto.TabIndex = 5;
            this.lblPuerto.Text = "Puerto";
            // 
            // lblIPServidor
            // 
            this.lblIPServidor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblIPServidor.AutoSize = true;
            this.lblIPServidor.Location = new System.Drawing.Point(6, 112);
            this.lblIPServidor.Name = "lblIPServidor";
            this.lblIPServidor.Size = new System.Drawing.Size(65, 13);
            this.lblIPServidor.TabIndex = 4;
            this.lblIPServidor.Text = "Dirección IP";
            // 
            // bntConectar
            // 
            this.bntConectar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bntConectar.Location = new System.Drawing.Point(159, 161);
            this.bntConectar.Name = "bntConectar";
            this.bntConectar.Size = new System.Drawing.Size(75, 23);
            this.bntConectar.TabIndex = 3;
            this.bntConectar.Text = "Conectar!";
            this.bntConectar.UseVisualStyleBackColor = true;
            this.bntConectar.Click += new System.EventHandler(this.bntConectar_Click);
            // 
            // btnResolver
            // 
            this.btnResolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResolver.Location = new System.Drawing.Point(159, 65);
            this.btnResolver.Name = "btnResolver";
            this.btnResolver.Size = new System.Drawing.Size(75, 23);
            this.btnResolver.TabIndex = 3;
            this.btnResolver.Text = "Resolver";
            this.btnResolver.UseVisualStyleBackColor = true;
            this.btnResolver.Click += new System.EventHandler(this.btnResolver_Click);
            // 
            // lblServidor
            // 
            this.lblServidor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblServidor.AutoSize = true;
            this.lblServidor.Location = new System.Drawing.Point(6, 23);
            this.lblServidor.Name = "lblServidor";
            this.lblServidor.Size = new System.Drawing.Size(95, 13);
            this.lblServidor.TabIndex = 1;
            this.lblServidor.Text = "Nombre de Equipo";
            // 
            // txtPuerto
            // 
            this.txtPuerto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPuerto.Location = new System.Drawing.Point(77, 135);
            this.txtPuerto.Name = "txtPuerto";
            this.txtPuerto.Size = new System.Drawing.Size(157, 20);
            this.txtPuerto.TabIndex = 2;
            // 
            // txtIPServidor
            // 
            this.txtIPServidor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIPServidor.Location = new System.Drawing.Point(77, 109);
            this.txtIPServidor.Name = "txtIPServidor";
            this.txtIPServidor.Size = new System.Drawing.Size(157, 20);
            this.txtIPServidor.TabIndex = 2;
            // 
            // txtServidor
            // 
            this.txtServidor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtServidor.Location = new System.Drawing.Point(9, 39);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(225, 20);
            this.txtServidor.TabIndex = 2;
            // 
            // gbxEnvio
            // 
            this.gbxEnvio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxEnvio.Controls.Add(this.chkTexto);
            this.gbxEnvio.Controls.Add(this.lblDatosEnviados);
            this.gbxEnvio.Controls.Add(this.lblEnvio);
            this.gbxEnvio.Controls.Add(this.btnEnviar);
            this.gbxEnvio.Controls.Add(this.txtBinarioEnviar);
            this.gbxEnvio.Controls.Add(this.btnActualizarBinario);
            this.gbxEnvio.Controls.Add(this.txtTextoAEnviar);
            this.gbxEnvio.Location = new System.Drawing.Point(258, 12);
            this.gbxEnvio.Name = "gbxEnvio";
            this.gbxEnvio.Size = new System.Drawing.Size(497, 298);
            this.gbxEnvio.TabIndex = 0;
            this.gbxEnvio.TabStop = false;
            this.gbxEnvio.Text = "Envío:";
            // 
            // chkTexto
            // 
            this.chkTexto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkTexto.AutoSize = true;
            this.chkTexto.Checked = true;
            this.chkTexto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTexto.Location = new System.Drawing.Point(438, 19);
            this.chkTexto.Name = "chkTexto";
            this.chkTexto.Size = new System.Drawing.Size(53, 17);
            this.chkTexto.TabIndex = 0;
            this.chkTexto.Text = "Texto";
            this.chkTexto.UseVisualStyleBackColor = true;
            // 
            // lblDatosEnviados
            // 
            this.lblDatosEnviados.AutoSize = true;
            this.lblDatosEnviados.Location = new System.Drawing.Point(6, 181);
            this.lblDatosEnviados.Name = "lblDatosEnviados";
            this.lblDatosEnviados.Size = new System.Drawing.Size(82, 13);
            this.lblDatosEnviados.TabIndex = 1;
            this.lblDatosEnviados.Text = "Datos Enviados";
            // 
            // lblEnvio
            // 
            this.lblEnvio.AutoSize = true;
            this.lblEnvio.Location = new System.Drawing.Point(6, 20);
            this.lblEnvio.Name = "lblEnvio";
            this.lblEnvio.Size = new System.Drawing.Size(403, 13);
            this.lblEnvio.TabIndex = 1;
            this.lblEnvio.Text = "Puede emplear caracteres hexadecimales separados por espacio o solamente texto.";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnviar.Location = new System.Drawing.Point(299, 133);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 3;
            this.btnEnviar.Text = "Enviar!";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txtBinarioEnviar
            // 
            this.txtBinarioEnviar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBinarioEnviar.Location = new System.Drawing.Point(6, 200);
            this.txtBinarioEnviar.Multiline = true;
            this.txtBinarioEnviar.Name = "txtBinarioEnviar";
            this.txtBinarioEnviar.ReadOnly = true;
            this.txtBinarioEnviar.Size = new System.Drawing.Size(485, 90);
            this.txtBinarioEnviar.TabIndex = 2;
            // 
            // btnActualizarBinario
            // 
            this.btnActualizarBinario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizarBinario.Location = new System.Drawing.Point(380, 133);
            this.btnActualizarBinario.Name = "btnActualizarBinario";
            this.btnActualizarBinario.Size = new System.Drawing.Size(111, 23);
            this.btnActualizarBinario.TabIndex = 3;
            this.btnActualizarBinario.Text = "Actualizar Binario";
            this.btnActualizarBinario.UseVisualStyleBackColor = true;
            this.btnActualizarBinario.Click += new System.EventHandler(this.btnActualizarBinario_Click);
            // 
            // txtTextoAEnviar
            // 
            this.txtTextoAEnviar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTextoAEnviar.Location = new System.Drawing.Point(6, 39);
            this.txtTextoAEnviar.Multiline = true;
            this.txtTextoAEnviar.Name = "txtTextoAEnviar";
            this.txtTextoAEnviar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTextoAEnviar.Size = new System.Drawing.Size(485, 90);
            this.txtTextoAEnviar.TabIndex = 2;
            // 
            // gbxPruebaConexion
            // 
            this.gbxPruebaConexion.Controls.Add(this.lblEstado);
            this.gbxPruebaConexion.Controls.Add(this.lblPuedeConectar);
            this.gbxPruebaConexion.Controls.Add(this.btnProbar);
            this.gbxPruebaConexion.Location = new System.Drawing.Point(12, 210);
            this.gbxPruebaConexion.Name = "gbxPruebaConexion";
            this.gbxPruebaConexion.Size = new System.Drawing.Size(240, 100);
            this.gbxPruebaConexion.TabIndex = 0;
            this.gbxPruebaConexion.TabStop = false;
            this.gbxPruebaConexion.Text = "Prueba de Conexión:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(156, 27);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(70, 13);
            this.lblEstado.TabIndex = 7;
            this.lblEstado.Text = "Desconocido";
            // 
            // lblPuedeConectar
            // 
            this.lblPuedeConectar.AutoSize = true;
            this.lblPuedeConectar.Location = new System.Drawing.Point(6, 27);
            this.lblPuedeConectar.Name = "lblPuedeConectar";
            this.lblPuedeConectar.Size = new System.Drawing.Size(100, 13);
            this.lblPuedeConectar.TabIndex = 6;
            this.lblPuedeConectar.Text = "Puede conectarse?";
            // 
            // btnProbar
            // 
            this.btnProbar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProbar.Location = new System.Drawing.Point(49, 57);
            this.btnProbar.Name = "btnProbar";
            this.btnProbar.Size = new System.Drawing.Size(143, 23);
            this.btnProbar.TabIndex = 3;
            this.btnProbar.Text = "Probar Conexión";
            this.btnProbar.UseVisualStyleBackColor = true;
            this.btnProbar.Click += new System.EventHandler(this.btnProbar_Click);
            // 
            // gbxResultados
            // 
            this.gbxResultados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxResultados.Controls.Add(this.txtLog);
            this.gbxResultados.Controls.Add(this.txtRecibidoBinario);
            this.gbxResultados.Controls.Add(this.txtRespuesta);
            this.gbxResultados.Location = new System.Drawing.Point(12, 316);
            this.gbxResultados.Name = "gbxResultados";
            this.gbxResultados.Size = new System.Drawing.Size(743, 261);
            this.gbxResultados.TabIndex = 0;
            this.gbxResultados.TabStop = false;
            this.gbxResultados.Text = "Resultados:";
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.Location = new System.Drawing.Point(6, 179);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(731, 74);
            this.txtLog.TabIndex = 2;
            // 
            // txtRecibidoBinario
            // 
            this.txtRecibidoBinario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRecibidoBinario.Location = new System.Drawing.Point(6, 99);
            this.txtRecibidoBinario.Multiline = true;
            this.txtRecibidoBinario.Name = "txtRecibidoBinario";
            this.txtRecibidoBinario.ReadOnly = true;
            this.txtRecibidoBinario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRecibidoBinario.Size = new System.Drawing.Size(731, 74);
            this.txtRecibidoBinario.TabIndex = 2;
            // 
            // txtRespuesta
            // 
            this.txtRespuesta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRespuesta.Location = new System.Drawing.Point(6, 19);
            this.txtRespuesta.Multiline = true;
            this.txtRespuesta.Name = "txtRespuesta";
            this.txtRespuesta.ReadOnly = true;
            this.txtRespuesta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRespuesta.Size = new System.Drawing.Size(731, 74);
            this.txtRespuesta.TabIndex = 2;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 589);
            this.Controls.Add(this.gbxEnvio);
            this.Controls.Add(this.gbxPruebaConexion);
            this.Controls.Add(this.gbxResultados);
            this.Controls.Add(this.gbxConexion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCliente";
            this.Text = "Cliente";
            this.gbxConexion.ResumeLayout(false);
            this.gbxConexion.PerformLayout();
            this.gbxEnvio.ResumeLayout(false);
            this.gbxEnvio.PerformLayout();
            this.gbxPruebaConexion.ResumeLayout(false);
            this.gbxPruebaConexion.PerformLayout();
            this.gbxResultados.ResumeLayout(false);
            this.gbxResultados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxConexion;
        private System.Windows.Forms.Label lblPuerto;
        private System.Windows.Forms.Label lblIPServidor;
        private System.Windows.Forms.Button btnProbar;
        private System.Windows.Forms.Button btnResolver;
        private System.Windows.Forms.Label lblServidor;
        private System.Windows.Forms.TextBox txtPuerto;
        private System.Windows.Forms.TextBox txtIPServidor;
        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.GroupBox gbxEnvio;
        private System.Windows.Forms.GroupBox gbxPruebaConexion;
        private System.Windows.Forms.Label lblPuedeConectar;
        private System.Windows.Forms.GroupBox gbxResultados;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.CheckBox chkTexto;
        private System.Windows.Forms.Label lblDatosEnviados;
        private System.Windows.Forms.Label lblEnvio;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtBinarioEnviar;
        private System.Windows.Forms.Button btnActualizarBinario;
        private System.Windows.Forms.TextBox txtTextoAEnviar;
        private System.Windows.Forms.TextBox txtRespuesta;
        private System.Windows.Forms.Button bntConectar;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.TextBox txtRecibidoBinario;
    }
}

