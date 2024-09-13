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
        SqlConnection conn = new SqlConnection("server=DESKTOP-DENLCDT; database=BaseProductos; integrated security=true");
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
            Form formulario2 = new HomeForm();
            formulario2.Show();
        }
        private void CargarData()
        {
            SqlDataAdapter da = new SqlDataAdapter("select*from Productos", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.dataGridView1.DataSource = dt;
        }
    }
}
