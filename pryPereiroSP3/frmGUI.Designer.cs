namespace pryPereiroSP3
{
    partial class frmGUI
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
            pnlControles = new Panel();
            txtDescripción = new TextBox();
            lblSigno = new Label();
            txtPrecio = new TextBox();
            txtNumRepuesto = new TextBox();
            cmbOrigen = new ComboBox();
            cmbMarca = new ComboBox();
            lblPrecio = new Label();
            lblDescripcion = new Label();
            NumRepuesto = new Label();
            lblOrigen = new Label();
            lblMarca = new Label();
            lblIngreso = new Label();
            pnlControles.SuspendLayout();
            SuspendLayout();
            // 
            // pnlControles
            // 
            pnlControles.BorderStyle = BorderStyle.Fixed3D;
            pnlControles.Controls.Add(txtDescripción);
            pnlControles.Controls.Add(lblSigno);
            pnlControles.Controls.Add(txtPrecio);
            pnlControles.Controls.Add(txtNumRepuesto);
            pnlControles.Controls.Add(cmbOrigen);
            pnlControles.Controls.Add(cmbMarca);
            pnlControles.Controls.Add(lblPrecio);
            pnlControles.Controls.Add(lblDescripcion);
            pnlControles.Controls.Add(NumRepuesto);
            pnlControles.Controls.Add(lblOrigen);
            pnlControles.Controls.Add(lblMarca);
            pnlControles.Location = new Point(12, 22);
            pnlControles.Name = "pnlControles";
            pnlControles.Size = new Size(311, 286);
            pnlControles.TabIndex = 0;
            // 
            // txtDescripción
            // 
            txtDescripción.Location = new Point(146, 208);
            txtDescripción.MaxLength = 50;
            txtDescripción.Multiline = true;
            txtDescripción.Name = "txtDescripción";
            txtDescripción.Size = new Size(152, 63);
            txtDescripción.TabIndex = 10;
            // 
            // lblSigno
            // 
            lblSigno.AutoSize = true;
            lblSigno.Font = new Font("Segoe UI", 10F);
            lblSigno.Location = new Point(204, 162);
            lblSigno.Name = "lblSigno";
            lblSigno.Size = new Size(17, 19);
            lblSigno.TabIndex = 9;
            lblSigno.Text = "$";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(221, 161);
            txtPrecio.MaxLength = 12;
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(77, 23);
            txtPrecio.TabIndex = 8;
            txtPrecio.TextChanged += txtPrecio_TextChanged;
            // 
            // txtNumRepuesto
            // 
            txtNumRepuesto.Location = new Point(251, 118);
            txtNumRepuesto.MaxLength = 6;
            txtNumRepuesto.Name = "txtNumRepuesto";
            txtNumRepuesto.Size = new Size(47, 23);
            txtNumRepuesto.TabIndex = 7;
            txtNumRepuesto.KeyPress += txtNumRepuesto_KeyPress;
            // 
            // cmbOrigen
            // 
            cmbOrigen.FormattingEnabled = true;
            cmbOrigen.Items.AddRange(new object[] { "(N) Nacional", "(I) Importado" });
            cmbOrigen.Location = new Point(198, 73);
            cmbOrigen.Name = "cmbOrigen";
            cmbOrigen.Size = new Size(100, 23);
            cmbOrigen.TabIndex = 6;
            cmbOrigen.SelectedIndexChanged += cmbOrigen_SelectedIndexChanged;
            // 
            // cmbMarca
            // 
            cmbMarca.FormattingEnabled = true;
            cmbMarca.Items.AddRange(new object[] { "(P) Peugeot", "(F) Fiat ", "(R) Renault" });
            cmbMarca.Location = new Point(198, 28);
            cmbMarca.Name = "cmbMarca";
            cmbMarca.Size = new Size(100, 23);
            cmbMarca.TabIndex = 5;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(26, 164);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 4;
            lblPrecio.Text = "Precio";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(26, 208);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(69, 15);
            lblDescripcion.TabIndex = 3;
            lblDescripcion.Text = "Descripción";
            // 
            // NumRepuesto
            // 
            NumRepuesto.AutoSize = true;
            NumRepuesto.Location = new Point(26, 121);
            NumRepuesto.Name = "NumRepuesto";
            NumRepuesto.Size = new Size(119, 15);
            NumRepuesto.TabIndex = 2;
            NumRepuesto.Text = "Numero de Repuesto";
            // 
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.Location = new Point(26, 76);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(43, 15);
            lblOrigen.TabIndex = 1;
            lblOrigen.Text = "Origen";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(26, 31);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(40, 15);
            lblMarca.TabIndex = 0;
            lblMarca.Text = "Marca";
            // 
            // lblIngreso
            // 
            lblIngreso.AutoSize = true;
            lblIngreso.Location = new Point(14, 4);
            lblIngreso.Name = "lblIngreso";
            lblIngreso.Size = new Size(95, 15);
            lblIngreso.TabIndex = 1;
            lblIngreso.Text = "Ingreso de Datos";
            // 
            // frmGUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 318);
            Controls.Add(lblIngreso);
            Controls.Add(pnlControles);
            Name = "frmGUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ingreso de Repuesto";
            pnlControles.ResumeLayout(false);
            pnlControles.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlControles;
        private Label NumRepuesto;
        private Label lblOrigen;
        private Label lblMarca;
        private ComboBox cmbMarca;
        private Label lblPrecio;
        private Label lblDescripcion;
        private ComboBox cmbOrigen;
        private TextBox txtNumRepuesto;
        private TextBox txtPrecio;
        private Label lblSigno;
        private TextBox txtDescripción;
        private Label lblIngreso;
    }
}
