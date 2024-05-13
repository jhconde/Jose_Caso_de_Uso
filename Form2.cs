namespace Jose_Caso_de_Uso
{
    public partial class Form2 : Form
    {
        Orden orden;

        public Form2(Orden orden)
        {
            this.orden = orden;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            estadoCombobox.Items.Add(EstadoEnum.EN_SELECCION);
            estadoCombobox.Items.Add(EstadoEnum.SELECCIONADO);

            seleccionOrdenInternaTextbox.Text = orden.NumeroOrdenInterna.ToString();
            numeroOrdenExternaTextbox.Text = orden.NumeroOrdenExterna.ToString();
            tipoProductoTextbox.Text = orden.Producto;
            cantidadTextbox.Text = orden.Cantidad.ToString();
            clienteTextbox.Text = orden.Cliente;
            estadoCombobox.Text = orden.Estado.ToString();
            listoEntregaCheckbox.Checked = orden.ListoParaEntrega;
            fechaModicacionDatepicker.Value = orden.FechaModificacion;
            fechaCreacionDatepicker.Value = orden.FechaCreacion;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
