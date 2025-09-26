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
            lstConsulta = new ListBox();
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
            pnlCarga.BackColor = SystemColors.GradientActiveCaption;
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
            pnlCarga.Location = new Point(17, 37);
            pnlCarga.Margin = new Padding(4, 5, 4, 5);
            pnlCarga.Name = "pnlCarga";
            pnlCarga.Size = new Size(459, 476);
            pnlCarga.TabIndex = 0;
            // 
            // txtDescripción
            // 
            txtDescripción.Location = new Point(209, 347);
            txtDescripción.Margin = new Padding(4, 5, 4, 5);
            txtDescripción.MaxLength = 50;
            txtDescripción.Multiline = true;
            txtDescripción.Name = "txtDescripción";
            txtDescripción.Size = new Size(215, 102);
            txtDescripción.TabIndex = 10;
            // 
            // lblSigno
            // 
            lblSigno.AutoSize = true;
            lblSigno.Font = new Font("Segoe UI", 10F);
            lblSigno.Location = new Point(291, 270);
            lblSigno.Margin = new Padding(4, 0, 4, 0);
            lblSigno.Name = "lblSigno";
            lblSigno.Size = new Size(23, 28);
            lblSigno.TabIndex = 9;
            lblSigno.Text = "$";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(316, 268);
            txtPrecio.Margin = new Padding(4, 5, 4, 5);
            txtPrecio.MaxLength = 12;
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(108, 31);
            txtPrecio.TabIndex = 8;
            txtPrecio.TextChanged += txtPrecio_TextChanged;
            txtPrecio.KeyPress += txtPrecio_KeyPress;
            // 
            // txtNumRepuesto
            // 
            txtNumRepuesto.Location = new Point(359, 197);
            txtNumRepuesto.Margin = new Padding(4, 5, 4, 5);
            txtNumRepuesto.MaxLength = 6;
            txtNumRepuesto.Name = "txtNumRepuesto";
            txtNumRepuesto.Size = new Size(65, 31);
            txtNumRepuesto.TabIndex = 7;
            txtNumRepuesto.KeyPress += txtNumRepuesto_KeyPress;
            // 
            // cmbOrigen
            // 
            cmbOrigen.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOrigen.FormattingEnabled = true;
            cmbOrigen.Items.AddRange(new object[] { "(N) Nacional", "(I) Importado" });
            cmbOrigen.Location = new Point(283, 122);
            cmbOrigen.Margin = new Padding(4, 5, 4, 5);
            cmbOrigen.Name = "cmbOrigen";
            cmbOrigen.Size = new Size(141, 33);
            cmbOrigen.TabIndex = 6;
            cmbOrigen.SelectedIndexChanged += cmbOrigen_SelectedIndexChanged;
            // 
            // cmbMarca
            // 
            cmbMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMarca.FormattingEnabled = true;
            cmbMarca.Items.AddRange(new object[] { "P", "F", "R" });
            cmbMarca.Location = new Point(283, 47);
            cmbMarca.Margin = new Padding(4, 5, 4, 5);
            cmbMarca.Name = "cmbMarca";
            cmbMarca.Size = new Size(141, 33);
            cmbMarca.TabIndex = 5;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(37, 273);
            lblPrecio.Margin = new Padding(4, 0, 4, 0);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(60, 25);
            lblPrecio.TabIndex = 4;
            lblPrecio.Text = "Precio";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(37, 347);
            lblDescripcion.Margin = new Padding(4, 0, 4, 0);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(104, 25);
            lblDescripcion.TabIndex = 3;
            lblDescripcion.Text = "Descripción";
            // 
            // NumRepuesto
            // 
            NumRepuesto.AutoSize = true;
            NumRepuesto.Location = new Point(37, 202);
            NumRepuesto.Margin = new Padding(4, 0, 4, 0);
            NumRepuesto.Name = "NumRepuesto";
            NumRepuesto.Size = new Size(181, 25);
            NumRepuesto.TabIndex = 2;
            NumRepuesto.Text = "Numero de Repuesto";
            // 
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.Location = new Point(37, 127);
            lblOrigen.Margin = new Padding(4, 0, 4, 0);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(66, 25);
            lblOrigen.TabIndex = 1;
            lblOrigen.Text = "Origen";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(37, 52);
            lblMarca.Margin = new Padding(4, 0, 4, 0);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(60, 25);
            lblMarca.TabIndex = 0;
            lblMarca.Text = "Marca";
            // 
            // lblIngreso
            // 
            lblIngreso.AutoSize = true;
            lblIngreso.Location = new Point(20, 7);
            lblIngreso.Margin = new Padding(4, 0, 4, 0);
            lblIngreso.Name = "lblIngreso";
            lblIngreso.Size = new Size(149, 25);
            lblIngreso.TabIndex = 1;
            lblIngreso.Text = "Ingreso de Datos";
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(499, 37);
            btnCargar.Margin = new Padding(4, 5, 4, 5);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(107, 38);
            btnCargar.TabIndex = 2;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(499, 122);
            btnLimpiar.Margin = new Padding(4, 5, 4, 5);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(107, 38);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // pnlConsulta
            // 
            pnlConsulta.BackColor = SystemColors.GradientActiveCaption;
            pnlConsulta.BorderStyle = BorderStyle.Fixed3D;
            pnlConsulta.Controls.Add(lstConsulta);
            pnlConsulta.Controls.Add(rdbImportado);
            pnlConsulta.Controls.Add(rdbNacional);
            pnlConsulta.Controls.Add(comboBox2);
            pnlConsulta.Controls.Add(label2);
            pnlConsulta.Location = new Point(671, 37);
            pnlConsulta.Margin = new Padding(4, 5, 4, 5);
            pnlConsulta.Name = "pnlConsulta";
            pnlConsulta.Size = new Size(443, 476);
            pnlConsulta.TabIndex = 4;
            // 
            // lstConsulta
            // 
            lstConsulta.FormattingEnabled = true;
            lstConsulta.ItemHeight = 25;
            lstConsulta.Items.AddRange(new object[] { "." });
            lstConsulta.Location = new Point(33, 257);
            lstConsulta.Margin = new Padding(4, 5, 4, 5);
            lstConsulta.Name = "lstConsulta";
            lstConsulta.Size = new Size(374, 179);
            lstConsulta.TabIndex = 12;
            // 
            // rdbImportado
            // 
            rdbImportado.AutoSize = true;
            rdbImportado.Location = new Point(33, 180);
            rdbImportado.Margin = new Padding(4, 5, 4, 5);
            rdbImportado.Name = "rdbImportado";
            rdbImportado.Size = new Size(123, 29);
            rdbImportado.TabIndex = 11;
            rdbImportado.TabStop = true;
            rdbImportado.Text = "Importado";
            rdbImportado.UseVisualStyleBackColor = true;
            // 
            // rdbNacional
            // 
            rdbNacional.AutoSize = true;
            rdbNacional.Location = new Point(33, 122);
            rdbNacional.Margin = new Padding(4, 5, 4, 5);
            rdbNacional.Name = "rdbNacional";
            rdbNacional.Size = new Size(105, 29);
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
            comboBox2.Location = new Point(283, 53);
            comboBox2.Margin = new Padding(4, 5, 4, 5);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(141, 33);
            comboBox2.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 58);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(60, 25);
            label2.TabIndex = 7;
            label2.Text = "Marca";
            // 
            // lblConsulta
            // 
            lblConsulta.AutoSize = true;
            lblConsulta.Location = new Point(671, 7);
            lblConsulta.Margin = new Padding(4, 0, 4, 0);
            lblConsulta.Name = "lblConsulta";
            lblConsulta.Size = new Size(81, 25);
            lblConsulta.TabIndex = 5;
            lblConsulta.Text = "Consulta";
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(1125, 37);
            btnConsultar.Margin = new Padding(4, 5, 4, 5);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(107, 38);
            btnConsultar.TabIndex = 6;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnLimpiarConsulta
            // 
            btnLimpiarConsulta.Location = new Point(1122, 122);
            btnLimpiarConsulta.Margin = new Padding(4, 5, 4, 5);
            btnLimpiarConsulta.Name = "btnLimpiarConsulta";
            btnLimpiarConsulta.Size = new Size(107, 38);
            btnLimpiarConsulta.TabIndex = 7;
            btnLimpiarConsulta.Text = "Limpiar";
            btnLimpiarConsulta.UseVisualStyleBackColor = true;
            btnLimpiarConsulta.Click += btnLimpiarConsulta_Click;
            // 
            // frmGUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1245, 540);
            Controls.Add(btnLimpiarConsulta);
            Controls.Add(btnConsultar);
            Controls.Add(lblConsulta);
            Controls.Add(pnlConsulta);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCargar);
            Controls.Add(lblIngreso);
            Controls.Add(pnlCarga);
            Margin = new Padding(4, 5, 4, 5);
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
