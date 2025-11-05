namespace prySilvaSP3
{
    public partial class frmTurnos : Form
    {
        public frmTurnos()
        {
            InitializeComponent();
        }

        public struct TURNO
        {
            public int NumeroTurno;
            public string Dominio;
            public int AñoFabricacion;
            public string Titular;
        };

        const int MAX = 50;
        public TURNO[] turnos;
        public int cantTurnos = 0;

        private void limpiarCarga()
        {
            txtNroTurno.Clear();
            txtDominio.Clear();
            numAñoFabricacion.Value = 2025;
            txtTitular.Clear();
        }

        private void frmTurnos_Load(object sender, EventArgs e)
        {
            turnos = new TURNO[MAX];
            cantTurnos = 0;

            limpiarCarga();
            txtCantidadTurnos.Clear();
            txtAñoMasAntiguo.Clear();
            txtDominio6Caracteres.Clear();
        }

        private void txtNroTurno_KeyPress(object sender, KeyPressEventArgs e)
        {
            // NO es un dígito y NO es Backspace ?
            if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtDominio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLower(e.KeyChar)) // es una minúscula ?            
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
            }

            // NO es una letra o dígito y NO es Backspace ?            
            if (!Char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private bool buscarTurno(int num)
        {
            bool existe = false;
            int i = 0;

            while (i < cantTurnos)
            {
                if (num == turnos[i].NumeroTurno)
                {
                    existe = true;
                    break;
                }
                i++;
            }
            return existe;
        }

        private bool validaciones()
        {
            bool resultado = false;

            if (txtNroTurno.Text != "" && txtDominio.Text != "" && txtTitular.Text != "")
            {
                if (txtDominio.Text.Length >= 6)
                {
                    if (!buscarTurno(int.Parse(txtNroTurno.Text)))
                    {
                        resultado = true;
                    }
                    else
                    {
                        MessageBox.Show("El Número de Turno ingresado ya existe",
                            "Registro de turnos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("El Dominio debe tener 6 o 7 caracteres",
                        "Registro de turnos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Debe completar los datos faltantes", "Registro de turnos",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return resultado;
        }

        private void cmdRegistrar_Click(object sender, EventArgs e)
        {
            if (validaciones())
            {
                turnos[cantTurnos].NumeroTurno = int.Parse(txtNroTurno.Text);
                turnos[cantTurnos].Dominio = txtDominio.Text;
                turnos[cantTurnos].AñoFabricacion = int.Parse(numAñoFabricacion.Value.ToString());
                turnos[cantTurnos].Titular = txtTitular.Text;
                cantTurnos++;

                if (cantTurnos == MAX)
                {
                    MessageBox.Show("Se completó la capacidad de carga de datos",
                        "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    cmdRegistrar.Enabled = false;
                }
                limpiarCarga();
            }
        }

        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            // primer consulta: cantidad de turnos registrados                       
            txtCantidadTurnos.Text = cantTurnos.ToString();

            // segunda consulta: el menor valor del campo 'AñoFabricacion'            
            int menor = int.MaxValue;
            int i;

            for (i = 0; i < cantTurnos; i++)
            {
                if (turnos[i].AñoFabricacion < menor)
                {
                    menor = turnos[i].AñoFabricacion;
                }
            }

            txtAñoMasAntiguo.Text = menor.ToString();

            // tercera consulta: cantidad de vehículos con dominio de 6 caracteres            
            int cantVehiculos = 0;

            for (i = 0; i < cantTurnos; i++)
            {
                if (turnos[i].Dominio.Length == 6)
                {
                    cantVehiculos++;
                }
            }

            txtDominio6Caracteres.Text = cantVehiculos.ToString();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}