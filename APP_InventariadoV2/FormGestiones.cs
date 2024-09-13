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

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formulario3 = new HomeForm();
            formulario3.Show();
        }

        private void Create()
        {
            SqlDataAdapter da = new SqlDataAdapter("select*from Productos", conn);
            DataTable dt1 = new DataTable();
            da.Fill(dt1);
            this.dataGridViewG.DataSource = dt1;
        }
        private void Delete()
        {

        }
        private void Uptade()
        {

        }
    }
}
