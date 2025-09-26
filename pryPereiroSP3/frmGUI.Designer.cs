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
            btnLimpiar = new Button();
            txtPrecio = new TextBox();
            btnCargar = new Button();
            txtNumRepuesto = new TextBox();
            cmbOrigen = new ComboBox();
            cmbMarca = new ComboBox();
            lblPrecio = new Label();
            lblDescripcion = new Label();
            NumRepuesto = new Label();
            lblOrigen = new Label();
            lblMarca = new Label();
            lblIngreso = new Label();
            pnlConsulta = new Panel();
            btnLimpiarConsulta = new Button();
            lstConsulta = new ListBox();
            btnConsultar = new Button();
            rdbImportado = new RadioButton();
            rdbNacional = new RadioButton();
            comboBox2 = new ComboBox();
            label2 = new Label();
            lblConsulta = new Label();
            pnlCarga.SuspendLayout();
            pnlConsulta.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCarga
            // 
            pnlCarga.BackColor = SystemColors.GradientActiveCaption;
            pnlCarga.BorderStyle = BorderStyle.Fixed3D;
            pnlCarga.Controls.Add(txtDescripción);
            pnlCarga.Controls.Add(lblSigno);
            pnlCarga.Controls.Add(btnLimpiar);
            pnlCarga.Controls.Add(txtPrecio);
            pnlCarga.Controls.Add(btnCargar);
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
            pnlCarga.Size = new Size(571, 294);
            pnlCarga.TabIndex = 0;
            // 
            // txtDescripción
            // 
            txtDescripción.Location = new Point(266, 185);
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
            lblSigno.Location = new Point(318, 154);
            lblSigno.Name = "lblSigno";
            lblSigno.Size = new Size(17, 19);
            lblSigno.TabIndex = 9;
            lblSigno.Text = "$";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(467, 73);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(341, 156);
            txtPrecio.MaxLength = 12;
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(77, 23);
            txtPrecio.TabIndex = 8;
            txtPrecio.TextChanged += txtPrecio_TextChanged;
            txtPrecio.KeyPress += txtPrecio_KeyPress;
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(467, 28);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(75, 23);
            btnCargar.TabIndex = 2;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // txtNumRepuesto
            // 
            txtNumRepuesto.Location = new Point(371, 113);
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
            cmbOrigen.Items.AddRange(new object[] { "N", "I" });
            cmbOrigen.Location = new Point(318, 74);
            cmbOrigen.Name = "cmbOrigen";
            cmbOrigen.Size = new Size(100, 23);
            cmbOrigen.TabIndex = 6;
            cmbOrigen.SelectedIndexChanged += cmbOrigen_SelectedIndexChanged;
            // 
            // cmbMarca
            // 
            cmbMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMarca.FormattingEnabled = true;
            cmbMarca.Items.AddRange(new object[] { "P", "F", "R" });
            cmbMarca.Location = new Point(318, 31);
            cmbMarca.Name = "cmbMarca";
            cmbMarca.Size = new Size(100, 23);
            cmbMarca.TabIndex = 5;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(76, 156);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 4;
            lblPrecio.Text = "Precio";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(76, 188);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(69, 15);
            lblDescripcion.TabIndex = 3;
            lblDescripcion.Text = "Descripción";
            // 
            // NumRepuesto
            // 
            NumRepuesto.AutoSize = true;
            NumRepuesto.Location = new Point(76, 113);
            NumRepuesto.Name = "NumRepuesto";
            NumRepuesto.Size = new Size(119, 15);
            NumRepuesto.TabIndex = 2;
            NumRepuesto.Text = "Numero de Repuesto";
            // 
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.Location = new Point(76, 73);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(43, 15);
            lblOrigen.TabIndex = 1;
            lblOrigen.Text = "Origen";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(76, 31);
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
            // pnlConsulta
            // 
            pnlConsulta.BackColor = SystemColors.GradientActiveCaption;
            pnlConsulta.BorderStyle = BorderStyle.Fixed3D;
            pnlConsulta.Controls.Add(btnLimpiarConsulta);
            pnlConsulta.Controls.Add(lstConsulta);
            pnlConsulta.Controls.Add(btnConsultar);
            pnlConsulta.Controls.Add(rdbImportado);
            pnlConsulta.Controls.Add(rdbNacional);
            pnlConsulta.Controls.Add(comboBox2);
            pnlConsulta.Controls.Add(label2);
            pnlConsulta.Location = new Point(12, 337);
            pnlConsulta.Name = "pnlConsulta";
            pnlConsulta.Size = new Size(571, 295);
            pnlConsulta.TabIndex = 4;
            // 
            // btnLimpiarConsulta
            // 
            btnLimpiarConsulta.Location = new Point(467, 82);
            btnLimpiarConsulta.Name = "btnLimpiarConsulta";
            btnLimpiarConsulta.Size = new Size(75, 23);
            btnLimpiarConsulta.TabIndex = 7;
            btnLimpiarConsulta.Text = "Limpiar";
            btnLimpiarConsulta.UseVisualStyleBackColor = true;
            btnLimpiarConsulta.Click += btnLimpiarConsulta_Click;
            // 
            // lstConsulta
            // 
            lstConsulta.FormattingEnabled = true;
            lstConsulta.ItemHeight = 15;
            lstConsulta.Items.AddRange(new object[] { "." });
            lstConsulta.Location = new Point(76, 164);
            lstConsulta.Name = "lstConsulta";
            lstConsulta.Size = new Size(342, 109);
            lstConsulta.TabIndex = 12;
            lstConsulta.SelectedIndexChanged += lstConsulta_SelectedIndexChanged;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(467, 33);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 23);
            btnConsultar.TabIndex = 6;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // rdbImportado
            // 
            rdbImportado.AutoSize = true;
            rdbImportado.Location = new Point(76, 109);
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
            rdbNacional.Location = new Point(76, 71);
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
            comboBox2.Items.AddRange(new object[] { "P", "F", "R" });
            comboBox2.Location = new Point(318, 34);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(100, 23);
            comboBox2.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 34);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 7;
            label2.Text = "Marca";
            // 
            // lblConsulta
            // 
            lblConsulta.AutoSize = true;
            lblConsulta.Location = new Point(12, 319);
            lblConsulta.Name = "lblConsulta";
            lblConsulta.Size = new Size(54, 15);
            lblConsulta.TabIndex = 5;
            lblConsulta.Text = "Consulta";
            // 
            // frmGUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(595, 644);
            Controls.Add(lblConsulta);
            Controls.Add(pnlConsulta);
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
        private ListBox lstConsulta;
    }
}
