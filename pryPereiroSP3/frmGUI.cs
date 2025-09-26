namespace pryPereiroSP3
{
    public partial class frmGUI : Form
    {
        public frmGUI()
        {
            InitializeComponent();
        }

        int[] vecRepuesto = new int[100];
        string Descripción;
        float Precio;

        int Indice = 0;






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
            txtNumRepuesto.Clear();
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
                vecRepuesto[Indice] = Convert.ToInt32(txtNumRepuesto.Text);
                Descripción = txtDescripción.Text;
                Precio = Convert.ToInt32(txtPrecio.Text);
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
            lstConsulta.Items.Add(Indice + " - - - " + Descripción + " - - - " + "$" +Precio);
            



        }

        private void lstConsulta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
