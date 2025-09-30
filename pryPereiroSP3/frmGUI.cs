namespace pryPereiroSP3
{
    public partial class frmGUI : Form
    {
        public frmGUI()
        {
            InitializeComponent();
        }
        struct Repuesto
        {
            public string marca; //P , R, F
            public string origen; // I, N
            public int numeroRepuesto;
            public float precio;
            public string descripcion;
        }

        Repuesto[] vecRepuesto = new Repuesto[100];
        int Indice = 0;

        Repuesto cargarRepuestos = new Repuesto();




        private void cmbOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void txtNumRepuesto_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }


        }

        private void txtPrecio_TextChanged(object sender, KeyPressEventArgs e)
        {

        }


        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void frmGUI_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cmbMarca.SelectedIndex = 0;
            cmbOrigen.SelectedIndex = 0;
            txtNumRepuesto.Clear();
            txtPrecio.Clear();
            txtDescripción.Clear();
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }


        }

        private void btnLimpiarConsulta_Click(object sender, EventArgs e)
        {
            cmbMarca.SelectedIndex = 0;
            lstConsulta.Items.Clear();


        }


        private void btnCargar_Click(object sender, EventArgs e)
        {

            if (Indice <= vecRepuesto.Length)
            {
                cargarRepuestos.marca = cmbMarca.Text;
                cargarRepuestos.origen = cmbOrigen.Text;
                cargarRepuestos.numeroRepuesto = txtNumRepuesto.TextLength;
                cargarRepuestos.precio = Convert.ToInt32(txtPrecio.Text);
                cargarRepuestos.descripcion = txtDescripción.Text;
                vecRepuesto[Indice] = cargarRepuestos;


                Indice++;


                txtDescripción.Clear();
                txtNumRepuesto.Clear();
                txtPrecio.Clear();
                cmbMarca.SelectedIndex = 0;
                cmbOrigen.SelectedIndex = 0;


            }
            else
            {
                MessageBox.Show("Ya no se puede cargar mas repuestos");
            }
        }




        private void btnConsultar_Click(object sender, EventArgs e)
        {
            
                lstConsulta.Items.Add("Marca: " + cargarRepuestos.marca + " - - " + "Origen: " + cargarRepuestos.origen + " - - " + "Cantidad: " + cargarRepuestos.numeroRepuesto + " - - " + "Precio: " + cargarRepuestos.precio + " - - " + "Descripción: " + cargarRepuestos.descripcion);
            
            


        }

        private void lstConsulta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNumRepuesto_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void lblConsulta_Click(object sender, EventArgs e)
        {

        }

        private void ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(cmbMarca.Text) ||
                string.IsNullOrWhiteSpace(cmbOrigen.Text) ||
                string.IsNullOrWhiteSpace(txtNumRepuesto.Text) ||
                string.IsNullOrWhiteSpace(txtPrecio.Text) ||
                string.IsNullOrWhiteSpace(txtDescripción.Text))
            {
                btnCargar.Enabled = false;
            }
            else
            {
                ActicarBotonCargar(null, null);
            }

        }

        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidarCampos();

        }


        private void ActicarBotonCargar(object sender, EventArgs e)
        {

            btnCargar.Enabled = true;
        }

        private void txtDescripción_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void ActivarCampoConsulta()
        {
            if (Indice == 0 )
            {
                MessageBox.Show("No hay datos cargados");
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(cmbMarcaConsulta.Text) && (rdbNacional.Checked || rdbImportado.Checked))
                    btnConsultar.Enabled = true;
                else
                    btnConsultar.Enabled = false;
            }
        }
        private void ActivarBotonConsultar(object sender, EventArgs e)
        {
            btnConsultar.Enabled = true;
        }

        private void cmbMarcaConsulta_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActivarCampoConsulta();
        }

        private void rdbNacional_CheckedChanged(object sender, EventArgs e)
        {
            ActivarCampoConsulta();
        }

        private void rdbImportado_CheckedChanged(object sender, EventArgs e)
        {
            ActivarCampoConsulta();
        }
    }
}
