namespace pregunta9
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.labelCI = new System.Windows.Forms.Label();
            this.txtCI = new System.Windows.Forms.TextBox();
            this.labelFecha = new System.Windows.Forms.Label();
            this.fechana = new System.Windows.Forms.DateTimePicker();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tipousText = new System.Windows.Forms.Label();
            this.comboTipous = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(350, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(466, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // labelNombre
            // 
            this.labelNombre.Location = new System.Drawing.Point(48, 79);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(100, 23);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(154, 76);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // labelCI
            // 
            this.labelCI.Location = new System.Drawing.Point(48, 119);
            this.labelCI.Name = "labelCI";
            this.labelCI.Size = new System.Drawing.Size(100, 23);
            this.labelCI.TabIndex = 3;
            this.labelCI.Text = "CI:";
            // 
            // txtCI
            // 
            this.txtCI.Location = new System.Drawing.Point(154, 119);
            this.txtCI.Name = "txtCI";
            this.txtCI.Size = new System.Drawing.Size(100, 20);
            this.txtCI.TabIndex = 4;
            // 
            // labelFecha
            // 
            this.labelFecha.Location = new System.Drawing.Point(48, 151);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(100, 23);
            this.labelFecha.TabIndex = 5;
            this.labelFecha.Text = "Fecha Nacimiento:";
            // 
            // fechana
            // 
            this.fechana.CustomFormat = "yyyy-MM-dd";
            this.fechana.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechana.Location = new System.Drawing.Point(154, 151);
            this.fechana.MinDate = new System.DateTime(1929, 12, 25, 0, 0, 0, 0);
            this.fechana.Name = "fechana";
            this.fechana.Size = new System.Drawing.Size(100, 20);
            this.fechana.TabIndex = 6;
            this.fechana.Value = new System.DateTime(1929, 12, 25, 0, 0, 0, 0);
            // 
            // labelTelefono
            // 
            this.labelTelefono.Location = new System.Drawing.Point(48, 191);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(100, 23);
            this.labelTelefono.TabIndex = 7;
            this.labelTelefono.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(154, 191);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 8;
            // 
            // labelPassword
            // 
            this.labelPassword.Location = new System.Drawing.Point(48, 231);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(100, 23);
            this.labelPassword.TabIndex = 9;
            this.labelPassword.Text = "Contraseña:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(154, 231);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 10;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(28, 324);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(122, 324);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 12;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(220, 324);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // tipousText
            // 
            this.tipousText.Location = new System.Drawing.Point(48, 273);
            this.tipousText.Name = "tipousText";
            this.tipousText.Size = new System.Drawing.Size(108, 27);
            this.tipousText.TabIndex = 14;
            this.tipousText.Text = "Tipo Usuario";
            // 
            // comboTipous
            // 
            this.comboTipous.FormattingEnabled = true;
            this.comboTipous.Items.AddRange(new object[] {
            "cliente",
            "administrador"});
            this.comboTipous.Location = new System.Drawing.Point(154, 270);
            this.comboTipous.Name = "comboTipous";
            this.comboTipous.Size = new System.Drawing.Size(121, 21);
            this.comboTipous.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 450);
            this.Controls.Add(this.comboTipous);
            this.Controls.Add(this.tipousText);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.labelCI);
            this.Controls.Add(this.txtCI);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.fechana);
            this.Controls.Add(this.labelTelefono);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnAgregar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label labelCI;
        private System.Windows.Forms.TextBox txtCI;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.DateTimePicker fechana;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label tipousText;
        private System.Windows.Forms.ComboBox comboTipous;
    }
}

