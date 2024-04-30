using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pregunta9
{
    public partial class Form1 : Form
    {
        private int idUsuarioSeleccionado;
        public Form1()
        {
            InitializeComponent();
            btnAgregar.Enabled = true;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = false;
            ConfigurarDataGridView();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            abcuser.WebService1SoapClient ws = new abcuser.WebService1SoapClient();
            dataGridView1.DataSource = ws.usuarios().Tables[0];
        }
        private void ConfigurarDataGridView()
        {
            DataGridViewButtonColumn btnBorrar = new DataGridViewButtonColumn
            {
                HeaderText = "Borrar",
                Text = "Borrar",
                UseColumnTextForButtonValue = true,
                Name = "btnBorrar"
            };

            DataGridViewButtonColumn btnModificar = new DataGridViewButtonColumn
            {
                HeaderText = "Modificar",
                Text = "Modificar",
                UseColumnTextForButtonValue = true,
                Name = "btnModificar"
            };
            dataGridView1.Columns.Add(btnBorrar);
            dataGridView1.Columns.Add(btnModificar);
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && (e.ColumnIndex == dataGridView1.Columns["btnBorrar"].Index || e.ColumnIndex == dataGridView1.Columns["btnModificar"].Index))
            {
                int idUsuario = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                abcuser.WebService1SoapClient ws = new abcuser.WebService1SoapClient();
                if (e.ColumnIndex == dataGridView1.Columns["btnBorrar"].Index)
                {
                    ws.EliminarUsuario(idUsuario);
                    dataGridView1.DataSource = ws.usuarios().Tables[0];
                }
                else if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "btnModificar")
                {
                    string nombre = dataGridView1.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
                    string ci = dataGridView1.Rows[e.RowIndex].Cells["ci"].Value.ToString();
                    DateTime fechaNacimiento = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["fecha"].Value);
                    int telefono = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["telefono"].Value);
                    string password = dataGridView1.Rows[e.RowIndex].Cells["pwd"].Value.ToString();
                    txtNombre.Text = nombre;
                    txtCI.Text = ci;
                    fechana.Value = fechaNacimiento;
                    txtTelefono.Text = telefono.ToString();
                    txtPassword.Text = password;
                    btnAgregar.Enabled = false;
                    btnModificar.Enabled = true;
                    btnCancelar.Enabled = true;
                    idUsuarioSeleccionado = idUsuario;
                }
                dataGridView1.DataSource = ws.usuarios().Tables[0];
            }
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos())
            {
                return;
            }
            string nombre = txtNombre.Text;
            string ci = txtCI.Text;
            DateTime fecha = fechana.Value;
            int telefono = Convert.ToInt32(txtTelefono.Text);
            string pwd = txtPassword.Text;
            string tipoUs = comboTipous.SelectedItem.ToString();
            abcuser.WebService1SoapClient ws = new abcuser.WebService1SoapClient();
            bool usuarioExiste = ws.VerificarUsuarioExiste(nombre, ci);

            if (usuarioExiste)
            {
                MessageBox.Show("El usuario ya existe. Por favor, verifica los datos de entrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ws.AgregarUsuario(nombre, tipoUs, ci, fecha, telefono, pwd);
            dataGridView1.DataSource = ws.usuarios().Tables[0];
            Reload();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos())
            {
                return;
            }
            string nombre = txtNombre.Text;
            string ci = txtCI.Text;
            DateTime fecha = fechana.Value;
            int telefono = Convert.ToInt32(txtTelefono.Text);
            string pwd = txtPassword.Text;
            string tipoUs = comboTipous.SelectedItem.ToString();
            abcuser.WebService1SoapClient ws = new abcuser.WebService1SoapClient();
            ws.ModificarUsuario(idUsuarioSeleccionado,nombre,tipoUs, ci, fecha, telefono, pwd);
            dataGridView1.DataSource = ws.usuarios().Tables[0];
            Reload();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Reload();
        }
        private void Reload()
        {
            txtNombre.Text = string.Empty;
            txtCI.Text = string.Empty;
            fechana.Value = new System.DateTime(1929, 12, 25, 0, 0, 0, 0);
            txtTelefono.Text = string.Empty;
            txtPassword.Text = string.Empty;
            comboTipous.SelectedIndex = -1;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = false;
            btnAgregar.Enabled = true;
 
        }
        private bool ValidarDatos()
        {
            if (string.IsNullOrEmpty(txtNombre.Text) ||
                string.IsNullOrEmpty(txtCI.Text) ||
                string.IsNullOrEmpty(txtTelefono.Text) ||
                comboTipous.SelectedIndex == -1) { 
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}