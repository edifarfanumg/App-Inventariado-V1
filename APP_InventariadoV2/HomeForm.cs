namespace APP_InventariadoV2
{
    public partial class HomeForm : Form
    {
        private FormConsultas formConsultas; // Instancias únicas de los formularios
        private FormGestiones formGestiones;

        public HomeForm()
        {
            InitializeComponent();
        }

        private void btnConsult_Click(object sender, EventArgs e)
        {
            if (formConsultas == null || formConsultas.IsDisposed)
            {
                formConsultas = new FormConsultas();
                formConsultas.FormClosed += (s, args) => this.Show(); // Volver a mostrar el HomeForm al cerrar
            }

            this.Hide(); // Ocultar el HomeForm
            formConsultas.Show();
        }

        private void btnGestion_Click(object sender, EventArgs e)
        {
            if (formGestiones == null || formGestiones.IsDisposed)
            {
                formGestiones = new FormGestiones();
                formGestiones.FormClosed += (s, args) => this.Show(); // Volver a mostrar el HomeForm al cerrar
            }

            this.Hide(); // Ocultar el HomeForm
            formGestiones.Show();
        }
    }
}
