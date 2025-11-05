namespace prySilvaSP3
{
    partial class frmTurnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTurnos));
            grpRegistro = new GroupBox();
            txtTitular = new TextBox();
            numAñoFabricacion = new NumericUpDown();
            txtDominio = new TextBox();
            txtNroTurno = new TextBox();
            lblTitular = new Label();
            lblAño = new Label();
            lblDominio = new Label();
            lblNumero = new Label();
            cmdRegistrar = new Button();
            cmdSalir = new Button();
            grpConsulta = new GroupBox();
            txtDominio6Caracteres = new TextBox();
            txtAñoMasAntiguo = new TextBox();
            txtCantidadTurnos = new TextBox();
            lblCantDom = new Label();
            lblAñoAntiguo = new Label();
            lblCant = new Label();
            cmdConsultar = new Button();
            grpRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numAñoFabricacion).BeginInit();
            grpConsulta.SuspendLayout();
            SuspendLayout();
            // 
            // grpRegistro
            // 
            grpRegistro.Controls.Add(txtTitular);
            grpRegistro.Controls.Add(numAñoFabricacion);
            grpRegistro.Controls.Add(txtDominio);
            grpRegistro.Controls.Add(txtNroTurno);
            grpRegistro.Controls.Add(lblTitular);
            grpRegistro.Controls.Add(lblAño);
            grpRegistro.Controls.Add(lblDominio);
            grpRegistro.Controls.Add(lblNumero);
            grpRegistro.Location = new Point(12, 12);
            grpRegistro.Name = "grpRegistro";
            grpRegistro.Size = new Size(414, 192);
            grpRegistro.TabIndex = 0;
            grpRegistro.TabStop = false;
            grpRegistro.Text = "Registro de Turnos";
            // 
            // txtTitular
            // 
            txtTitular.Location = new Point(138, 144);
            txtTitular.MaxLength = 30;
            txtTitular.Name = "txtTitular";
            txtTitular.Size = new Size(247, 23);
            txtTitular.TabIndex = 7;
            // 
            // numAñoFabricacion
            // 
            numAñoFabricacion.Location = new Point(138, 105);
            numAñoFabricacion.Maximum = new decimal(new int[] { 2025, 0, 0, 0 });
            numAñoFabricacion.Minimum = new decimal(new int[] { 1950, 0, 0, 0 });
            numAñoFabricacion.Name = "numAñoFabricacion";
            numAñoFabricacion.Size = new Size(59, 23);
            numAñoFabricacion.TabIndex = 6;
            numAñoFabricacion.Value = new decimal(new int[] { 1950, 0, 0, 0 });
            // 
            // txtDominio
            // 
            txtDominio.Location = new Point(138, 70);
            txtDominio.MaxLength = 7;
            txtDominio.Name = "txtDominio";
            txtDominio.Size = new Size(115, 23);
            txtDominio.TabIndex = 5;
            txtDominio.KeyPress += txtDominio_KeyPress;
            // 
            // txtNroTurno
            // 
            txtNroTurno.Location = new Point(138, 34);
            txtNroTurno.MaxLength = 5;
            txtNroTurno.Name = "txtNroTurno";
            txtNroTurno.Size = new Size(78, 23);
            txtNroTurno.TabIndex = 4;
            txtNroTurno.KeyPress += txtNroTurno_KeyPress;
            // 
            // lblTitular
            // 
            lblTitular.AutoSize = true;
            lblTitular.Location = new Point(16, 147);
            lblTitular.Name = "lblTitular";
            lblTitular.Size = new Size(40, 15);
            lblTitular.TabIndex = 3;
            lblTitular.Text = "Titular";
            // 
            // lblAño
            // 
            lblAño.AutoSize = true;
            lblAño.Location = new Point(16, 107);
            lblAño.Name = "lblAño";
            lblAño.Size = new Size(93, 15);
            lblAño.TabIndex = 2;
            lblAño.Text = "Año Fabricación";
            // 
            // lblDominio
            // 
            lblDominio.AutoSize = true;
            lblDominio.Location = new Point(16, 73);
            lblDominio.Name = "lblDominio";
            lblDominio.Size = new Size(53, 15);
            lblDominio.TabIndex = 1;
            lblDominio.Text = "Dominio";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(16, 37);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(101, 15);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Número de Turno";
            // 
            // cmdRegistrar
            // 
            cmdRegistrar.Location = new Point(446, 30);
            cmdRegistrar.Name = "cmdRegistrar";
            cmdRegistrar.Size = new Size(98, 34);
            cmdRegistrar.TabIndex = 1;
            cmdRegistrar.Text = "Registrar";
            cmdRegistrar.UseVisualStyleBackColor = true;
            cmdRegistrar.Click += cmdRegistrar_Click;
            // 
            // cmdSalir
            // 
            cmdSalir.Location = new Point(446, 102);
            cmdSalir.Name = "cmdSalir";
            cmdSalir.Size = new Size(98, 32);
            cmdSalir.TabIndex = 2;
            cmdSalir.Text = "Salir";
            cmdSalir.UseVisualStyleBackColor = true;
            cmdSalir.Click += cmdSalir_Click;
            // 
            // grpConsulta
            // 
            grpConsulta.Controls.Add(txtDominio6Caracteres);
            grpConsulta.Controls.Add(txtAñoMasAntiguo);
            grpConsulta.Controls.Add(txtCantidadTurnos);
            grpConsulta.Controls.Add(lblCantDom);
            grpConsulta.Controls.Add(lblAñoAntiguo);
            grpConsulta.Controls.Add(lblCant);
            grpConsulta.Location = new Point(12, 218);
            grpConsulta.Name = "grpConsulta";
            grpConsulta.Size = new Size(414, 141);
            grpConsulta.TabIndex = 3;
            grpConsulta.TabStop = false;
            grpConsulta.Text = "Estadísticas";
            // 
            // txtDominio6Caracteres
            // 
            txtDominio6Caracteres.Location = new Point(249, 101);
            txtDominio6Caracteres.Name = "txtDominio6Caracteres";
            txtDominio6Caracteres.ReadOnly = true;
            txtDominio6Caracteres.Size = new Size(63, 23);
            txtDominio6Caracteres.TabIndex = 5;
            // 
            // txtAñoMasAntiguo
            // 
            txtAñoMasAntiguo.Location = new Point(249, 64);
            txtAñoMasAntiguo.Name = "txtAñoMasAntiguo";
            txtAñoMasAntiguo.ReadOnly = true;
            txtAñoMasAntiguo.Size = new Size(63, 23);
            txtAñoMasAntiguo.TabIndex = 4;
            // 
            // txtCantidadTurnos
            // 
            txtCantidadTurnos.Location = new Point(249, 27);
            txtCantidadTurnos.Name = "txtCantidadTurnos";
            txtCantidadTurnos.ReadOnly = true;
            txtCantidadTurnos.Size = new Size(63, 23);
            txtCantidadTurnos.TabIndex = 3;
            // 
            // lblCantDom
            // 
            lblCantDom.AutoSize = true;
            lblCantDom.Location = new Point(16, 104);
            lblCantDom.Name = "lblCantDom";
            lblCantDom.Size = new Size(207, 15);
            lblCantDom.TabIndex = 2;
            lblCantDom.Text = "Cantidad con dominio de 6 caracteres";
            // 
            // lblAñoAntiguo
            // 
            lblAñoAntiguo.AutoSize = true;
            lblAñoAntiguo.Location = new Point(16, 72);
            lblAñoAntiguo.Name = "lblAñoAntiguo";
            lblAñoAntiguo.Size = new Size(119, 15);
            lblAñoAntiguo.TabIndex = 1;
            lblAñoAntiguo.Text = "Año del más Antiguo";
            // 
            // lblCant
            // 
            lblCant.AutoSize = true;
            lblCant.Location = new Point(16, 35);
            lblCant.Name = "lblCant";
            lblCant.Size = new Size(110, 15);
            lblCant.TabIndex = 0;
            lblCant.Text = "Cantidad de Turnos";
            // 
            // cmdConsultar
            // 
            cmdConsultar.Location = new Point(446, 228);
            cmdConsultar.Name = "cmdConsultar";
            cmdConsultar.Size = new Size(97, 32);
            cmdConsultar.TabIndex = 4;
            cmdConsultar.Text = "Consultar";
            cmdConsultar.UseVisualStyleBackColor = true;
            cmdConsultar.Click += cmdConsultar_Click;
            // 
            // frmTurnos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 371);
            Controls.Add(cmdConsultar);
            Controls.Add(grpConsulta);
            Controls.Add(cmdSalir);
            Controls.Add(cmdRegistrar);
            Controls.Add(grpRegistro);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmTurnos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Auto Test";
            Load += frmTurnos_Load;
            grpRegistro.ResumeLayout(false);
            grpRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numAñoFabricacion).EndInit();
            grpConsulta.ResumeLayout(false);
            grpConsulta.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpRegistro;
        private NumericUpDown numAñoFabricacion;
        private TextBox txtDominio;
        private TextBox txtNroTurno;
        private Label lblTitular;
        private Label lblAño;
        private Label lblDominio;
        private Label lblNumero;
        private TextBox txtTitular;
        private Button cmdRegistrar;
        private Button cmdSalir;
        private GroupBox grpConsulta;
        private TextBox txtDominio6Caracteres;
        private TextBox txtAñoMasAntiguo;
        private TextBox txtCantidadTurnos;
        private Label lblCantDom;
        private Label lblAñoAntiguo;
        private Label lblCant;
        private Button cmdConsultar;
    }
}
