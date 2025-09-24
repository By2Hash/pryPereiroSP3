namespace pryPereiroSP3
{
    public partial class frmGUI : Form
    {
        public frmGUI()
        {
            InitializeComponent();
        }

        

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
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        
        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
