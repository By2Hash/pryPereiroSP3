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
            lstConsulta.Items.Add(cargarRepuestos.marca + " - - - " + cargarRepuestos.origen + " - - -" + cargarRepuestos.numeroRepuesto + " - - - "+ cargarRepuestos.precio + " - - - " + cargarRepuestos.descripcion);




        }

        private void lstConsulta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNumRepuesto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
