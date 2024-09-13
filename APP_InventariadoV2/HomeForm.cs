namespace APP_InventariadoV2
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }
        private void btnConsult_Click(object sender, EventArgs e)
        {
            Form formulario1 = new FormConsultas();
            formulario1.Show();
            
        }
        private void btnGestion_Click(object sender, EventArgs e)
        {
            Form formulario4 = new FormGestiones();
            formulario4.Show();
        }
    }
}
