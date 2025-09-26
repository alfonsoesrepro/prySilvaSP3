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
            gbTurnos = new GroupBox();
            txtTitular = new TextBox();
            numAño = new NumericUpDown();
            txtDominio = new TextBox();
            txtNumero = new TextBox();
            lblTitular = new Label();
            lblAño = new Label();
            lblDominio = new Label();
            lblNumero = new Label();
            cmdRegistrar = new Button();
            cmdSalir = new Button();
            gbEstadisticas = new GroupBox();
            txtCantDom = new TextBox();
            txtAñoAntiguo = new TextBox();
            txtCant = new TextBox();
            lblCantDom = new Label();
            lblAñoAntiguo = new Label();
            lblCant = new Label();
            cmdConsultar = new Button();
            gbTurnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numAño).BeginInit();
            gbEstadisticas.SuspendLayout();
            SuspendLayout();
            // 
            // gbTurnos
            // 
            gbTurnos.Controls.Add(txtTitular);
            gbTurnos.Controls.Add(numAño);
            gbTurnos.Controls.Add(txtDominio);
            gbTurnos.Controls.Add(txtNumero);
            gbTurnos.Controls.Add(lblTitular);
            gbTurnos.Controls.Add(lblAño);
            gbTurnos.Controls.Add(lblDominio);
            gbTurnos.Controls.Add(lblNumero);
            gbTurnos.Location = new Point(12, 12);
            gbTurnos.Name = "gbTurnos";
            gbTurnos.Size = new Size(414, 192);
            gbTurnos.TabIndex = 0;
            gbTurnos.TabStop = false;
            gbTurnos.Text = "Registro de Turnos";
            // 
            // txtTitular
            // 
            txtTitular.Location = new Point(138, 144);
            txtTitular.Name = "txtTitular";
            txtTitular.Size = new Size(247, 23);
            txtTitular.TabIndex = 7;
            // 
            // numAño
            // 
            numAño.Location = new Point(138, 105);
            numAño.Name = "numAño";
            numAño.Size = new Size(59, 23);
            numAño.TabIndex = 6;
            // 
            // txtDominio
            // 
            txtDominio.Location = new Point(138, 70);
            txtDominio.Name = "txtDominio";
            txtDominio.Size = new Size(115, 23);
            txtDominio.TabIndex = 5;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(138, 34);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(78, 23);
            txtNumero.TabIndex = 4;
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
            // 
            // cmdSalir
            // 
            cmdSalir.Location = new Point(446, 102);
            cmdSalir.Name = "cmdSalir";
            cmdSalir.Size = new Size(98, 32);
            cmdSalir.TabIndex = 2;
            cmdSalir.Text = "Salir";
            cmdSalir.UseVisualStyleBackColor = true;
            // 
            // gbEstadisticas
            // 
            gbEstadisticas.Controls.Add(txtCantDom);
            gbEstadisticas.Controls.Add(txtAñoAntiguo);
            gbEstadisticas.Controls.Add(txtCant);
            gbEstadisticas.Controls.Add(lblCantDom);
            gbEstadisticas.Controls.Add(lblAñoAntiguo);
            gbEstadisticas.Controls.Add(lblCant);
            gbEstadisticas.Location = new Point(12, 218);
            gbEstadisticas.Name = "gbEstadisticas";
            gbEstadisticas.Size = new Size(414, 141);
            gbEstadisticas.TabIndex = 3;
            gbEstadisticas.TabStop = false;
            gbEstadisticas.Text = "Estadísticas";
            // 
            // txtCantDom
            // 
            txtCantDom.Location = new Point(249, 101);
            txtCantDom.Name = "txtCantDom";
            txtCantDom.Size = new Size(63, 23);
            txtCantDom.TabIndex = 5;
            // 
            // txtAñoAntiguo
            // 
            txtAñoAntiguo.Location = new Point(249, 64);
            txtAñoAntiguo.Name = "txtAñoAntiguo";
            txtAñoAntiguo.Size = new Size(63, 23);
            txtAñoAntiguo.TabIndex = 4;
            // 
            // txtCant
            // 
            txtCant.Location = new Point(249, 27);
            txtCant.Name = "txtCant";
            txtCant.Size = new Size(63, 23);
            txtCant.TabIndex = 3;
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
            // 
            // frmTurnos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 371);
            Controls.Add(cmdConsultar);
            Controls.Add(gbEstadisticas);
            Controls.Add(cmdSalir);
            Controls.Add(cmdRegistrar);
            Controls.Add(gbTurnos);
            Name = "frmTurnos";
            Text = "Auto Test";
            gbTurnos.ResumeLayout(false);
            gbTurnos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numAño).EndInit();
            gbEstadisticas.ResumeLayout(false);
            gbEstadisticas.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbTurnos;
        private NumericUpDown numAño;
        private TextBox txtDominio;
        private TextBox txtNumero;
        private Label lblTitular;
        private Label lblAño;
        private Label lblDominio;
        private Label lblNumero;
        private TextBox txtTitular;
        private Button cmdRegistrar;
        private Button cmdSalir;
        private GroupBox gbEstadisticas;
        private TextBox txtCantDom;
        private TextBox txtAñoAntiguo;
        private TextBox txtCant;
        private Label lblCantDom;
        private Label lblAñoAntiguo;
        private Label lblCant;
        private Button cmdConsultar;
    }
}
