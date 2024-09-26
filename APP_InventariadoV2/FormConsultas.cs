using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace APP_InventariadoV2
{
    public partial class FormConsultas : Form
    {
        private readonly string connectionString = "server=DESKTOP-DENLCDT; database=BaseProductos; integrated security=true";

        public FormConsultas()
        {
            InitializeComponent();
        }

        private void btnConsultarP_Click(object sender, EventArgs e)
        {
            CargarData();
        }

        private void RegreCons_Click(object sender, EventArgs e)
        {
            this.Hide();  // Ocultamos el formulario actual
            HomeForm homeForm = (HomeForm)Application.OpenForms["HomeForm"]; // Buscamos la instancia abierta de HomeForm

            if (homeForm != null)
            {
                homeForm.Show(); // Mostramos la instancia existente
            }
            else
            {
                HomeForm newHomeForm = new HomeForm(); // Si no está abierta, creamos una nueva
                newHomeForm.Show();
            }
        }

        private void CargarData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open(); // Abrir conexión
                    string query = "SELECT * FROM Productos";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt); // Llenar el DataTable
                    this.dataGridView1.DataSource = dt; // Asignar el DataTable al DataGridView
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show("Error al cargar los datos desde la base de datos: " + sqlEx.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inesperado: " + ex.Message);
                }
            } // La conexión se cierra automáticamente cuando se sale del bloque using
        }
    }
}

