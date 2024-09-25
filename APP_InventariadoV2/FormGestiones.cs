using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_InventariadoV2
{
    public partial class FormGestiones : Form
    {
        SqlConnection conn = new SqlConnection("server=DESKTOP-DENLCDT; database=BaseProductos; integrated security=true");
        public FormGestiones()
        {
            InitializeComponent();
        }

        private void btnAgreg_Click(object sender, EventArgs e)
        {
            Create();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();  // Ocultamos este formulario
            HomeForm homeForm = (HomeForm)Application.OpenForms["HomeForm"];  // Buscamos la instancia de HomeForm

            if (homeForm != null)
            {
                homeForm.Show();  // Si ya está abierto, lo mostramos
            }
            else
            {
                HomeForm newHomeForm = new HomeForm();  // Si no está abierto, creamos uno nuevo
                newHomeForm.Show();
            }
        }

        private void Create()
        {
            try
            {
                using (conn)
                {
                    conn.Open();
                    string query = "INSERT INTO Productos (Id_Producto, Nombre, Descripcion, Categoria, Precio, Stock, Proveedor, Fecha_Ingreso, Fecha_Ultima_Actualizacion) " +
                                   "VALUES (@Id_Producto, @Nombre, @Descripcion, @Categoria, @Precio, @Stock, @Proveedor, @Fecha_Ingreso, @Fecha_Ultima_Actualizacion)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("ID_Producto", textBoxID.Text);
                    cmd.Parameters.AddWithValue("@Nombre", textBoxName.Text);
                    cmd.Parameters.AddWithValue("@Descripcion", textBoxDescrip.Text);
                    cmd.Parameters.AddWithValue("@Categoria", textBoxCategori.Text);
                    cmd.Parameters.AddWithValue("@Precio", decimal.Parse(textBoxPrice.Text)); // Asegúrate de que el precio sea un decimal
                    cmd.Parameters.AddWithValue("@Stock", int.Parse(textBoxStock.Text)); // Asegúrate de que el stock sea un entero
                    cmd.Parameters.AddWithValue("@Proveedor", textBoxProveedor.Text);
                    cmd.Parameters.AddWithValue("@Fecha_Ingreso", DateTime.Parse(textBoxIngreso.Text));
                    cmd.Parameters.AddWithValue("@Fecha_Ultima_Actualizacion", DateTime.Parse(textBoxActu.Text));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Producto agregado con éxito");
                    RefreshDataGridView(); // Método para refrescar el DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el producto: " + ex.Message);
            }
        }

        private void Delete()
        {
            try
            {
                using (conn)
                {
                    conn.Open();
                    string query = "DELETE FROM Productos WHERE Id_Producto = @Id_Producto";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id_Producto", int.Parse(textBoxID.Text)); // Asegúrate de que el ID sea un entero
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Producto eliminado con éxito");
                    RefreshDataGridView(); // Método para refrescar el DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el producto: " + ex.Message);
            }
        }

        private void Update() // Cambia Uptade a Update
        {
            try
            {
                using (conn)
                {
                    conn.Open();
                    string query = "UPDATE Productos SET Nombre = @Nombre, Descripcion = @Descripcion, Categoria = @Categoria, " +
                                   "Precio = @Precio, Stock = @Stock, Proveedor = @Proveedor, Fecha_Ingreso = @Fecha_Ingreso, " +
                                   "Fecha_Ultima_Actualizacion = @Fecha_Ultima_Actualizacion WHERE Id_Producto = @Id_Producto";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id_Producto", int.Parse(textBoxID.Text)); // Asegúrate de que el ID sea un entero
                    cmd.Parameters.AddWithValue("@Nombre", textBoxName.Text);
                    cmd.Parameters.AddWithValue("@Descripcion", textBoxDescrip.Text);
                    cmd.Parameters.AddWithValue("@Categoria", textBoxCategori.Text);
                    cmd.Parameters.AddWithValue("@Precio", decimal.Parse(textBoxPrice.Text)); // Asegúrate de que el precio sea un decimal
                    cmd.Parameters.AddWithValue("@Stock", int.Parse(textBoxStock.Text)); // Asegúrate de que el stock sea un entero
                    cmd.Parameters.AddWithValue("@Proveedor", textBoxProveedor.Text);
                    cmd.Parameters.AddWithValue("@Fecha_Ingreso", DateTime.Parse(textBoxIngreso.Text));
                    cmd.Parameters.AddWithValue("@Fecha_Ultima_Actualizacion", DateTime.Parse(textBoxActu.Text));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Producto actualizado con éxito");
                    RefreshDataGridView(); // Método para refrescar el DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el producto: " + ex.Message);
            }
        }

        private void RefreshDataGridView()
        {
            try
            {
                using (conn)
                {
                    conn.Open();
                    string query = "SELECT * FROM Productos";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridViewG.DataSource = dt; // Asignamos el DataTable como fuente de datos
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al refrescar el DataGridView: " + ex.Message);
            }
        }
    }
}
