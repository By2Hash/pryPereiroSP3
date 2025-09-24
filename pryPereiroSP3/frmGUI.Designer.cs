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
            pnlCarga = new Panel();
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
            btnCargar = new Button();
            btnLimpiar = new Button();
            pnlConsulta = new Panel();
            lsbConsulta = new ListBox();
            rdbImportado = new RadioButton();
            rdbNacional = new RadioButton();
            comboBox2 = new ComboBox();
            label2 = new Label();
            lblConsulta = new Label();
            btnConsultar = new Button();
            btnLimpiarConsulta = new Button();
            pnlCarga.SuspendLayout();
            pnlConsulta.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCarga
            // 
            pnlCarga.BorderStyle = BorderStyle.Fixed3D;
            pnlCarga.Controls.Add(txtDescripción);
            pnlCarga.Controls.Add(lblSigno);
            pnlCarga.Controls.Add(txtPrecio);
            pnlCarga.Controls.Add(txtNumRepuesto);
            pnlCarga.Controls.Add(cmbOrigen);
            pnlCarga.Controls.Add(cmbMarca);
            pnlCarga.Controls.Add(lblPrecio);
            pnlCarga.Controls.Add(lblDescripcion);
            pnlCarga.Controls.Add(NumRepuesto);
            pnlCarga.Controls.Add(lblOrigen);
            pnlCarga.Controls.Add(lblMarca);
            pnlCarga.Location = new Point(12, 22);
            pnlCarga.Name = "pnlCarga";
            pnlCarga.Size = new Size(311, 287);
            pnlCarga.TabIndex = 0;
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
            txtPrecio.KeyPress += txtPrecio_KeyPress;
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
            cmbOrigen.DropDownStyle = ComboBoxStyle.DropDownList;
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
            cmbMarca.DropDownStyle = ComboBoxStyle.DropDownList;
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
            // btnCargar
            // 
            btnCargar.Location = new Point(339, 22);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(75, 23);
            btnCargar.TabIndex = 2;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(339, 73);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // pnlConsulta
            // 
            pnlConsulta.BorderStyle = BorderStyle.Fixed3D;
            pnlConsulta.Controls.Add(lsbConsulta);
            pnlConsulta.Controls.Add(rdbImportado);
            pnlConsulta.Controls.Add(rdbNacional);
            pnlConsulta.Controls.Add(comboBox2);
            pnlConsulta.Controls.Add(label2);
            pnlConsulta.Location = new Point(12, 339);
            pnlConsulta.Name = "pnlConsulta";
            pnlConsulta.Size = new Size(311, 307);
            pnlConsulta.TabIndex = 4;
            // 
            // lsbConsulta
            // 
            lsbConsulta.FormattingEnabled = true;
            lsbConsulta.ItemHeight = 15;
            lsbConsulta.Items.AddRange(new object[] { "." });
            lsbConsulta.Location = new Point(23, 154);
            lsbConsulta.Name = "lsbConsulta";
            lsbConsulta.Size = new Size(263, 139);
            lsbConsulta.TabIndex = 12;
            // 
            // rdbImportado
            // 
            rdbImportado.AutoSize = true;
            rdbImportado.Location = new Point(23, 108);
            rdbImportado.Name = "rdbImportado";
            rdbImportado.Size = new Size(81, 19);
            rdbImportado.TabIndex = 11;
            rdbImportado.TabStop = true;
            rdbImportado.Text = "Importado";
            rdbImportado.UseVisualStyleBackColor = true;
            // 
            // rdbNacional
            // 
            rdbNacional.AutoSize = true;
            rdbNacional.Location = new Point(23, 73);
            rdbNacional.Name = "rdbNacional";
            rdbNacional.Size = new Size(72, 19);
            rdbNacional.TabIndex = 10;
            rdbNacional.TabStop = true;
            rdbNacional.Text = "Nacional";
            rdbNacional.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "(P) Peugeot", "(F) Fiat ", "(R) Renault" });
            comboBox2.Location = new Point(198, 32);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(100, 23);
            comboBox2.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 35);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 7;
            label2.Text = "Marca";
            // 
            // lblConsulta
            // 
            lblConsulta.AutoSize = true;
            lblConsulta.Location = new Point(12, 317);
            lblConsulta.Name = "lblConsulta";
            lblConsulta.Size = new Size(54, 15);
            lblConsulta.TabIndex = 5;
            lblConsulta.Text = "Consulta";
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(339, 339);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 23);
            btnConsultar.TabIndex = 6;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarConsulta
            // 
            btnLimpiarConsulta.Location = new Point(339, 389);
            btnLimpiarConsulta.Name = "btnLimpiarConsulta";
            btnLimpiarConsulta.Size = new Size(75, 23);
            btnLimpiarConsulta.TabIndex = 7;
            btnLimpiarConsulta.Text = "Limpiar";
            btnLimpiarConsulta.UseVisualStyleBackColor = true;
            btnLimpiarConsulta.Click += btnLimpiarConsulta_Click;
            // 
            // frmGUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 676);
            Controls.Add(btnLimpiarConsulta);
            Controls.Add(btnConsultar);
            Controls.Add(lblConsulta);
            Controls.Add(pnlConsulta);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCargar);
            Controls.Add(lblIngreso);
            Controls.Add(pnlCarga);
            Name = "frmGUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ingreso de Repuesto";
            Load += frmGUI_Load;
            pnlCarga.ResumeLayout(false);
            pnlCarga.PerformLayout();
            pnlConsulta.ResumeLayout(false);
            pnlConsulta.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlCarga;
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
        private Button btnCargar;
        private Button btnLimpiar;
        private Panel pnlConsulta;
        private Label lblConsulta;
        private Button btnConsultar;
        private Button btnLimpiarConsulta;
        private ComboBox comboBox2;
        private Label label2;
        private RadioButton rdbImportado;
        private RadioButton rdbNacional;
        private ListBox lsbConsulta;
    }
}
