using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jose_Caso_de_Uso
{
    public partial class Form1 : Form
    {
        List<Orden> ordenes = new List<Orden>();

        public Form1()
        {
            InitializeComponent();

            Orden orden1 = new Orden();
            orden1.NumeroOrdenInterna = 12345678;
            orden1.NumeroOrdenExterna = 123;
            orden1.Producto = "Lapicera";
            orden1.FechaCreacion = DateTime.Now.AddDays(-1);
            orden1.FechaModificacion = DateTime.Now;
            orden1.Cliente = "Cliente 1";
            orden1.Cantidad = 2;
            orden1.ListoParaEntrega = true;
            orden1.Estado = EstadoEnum.SELECCIONADO;
            ordenes.Add(orden1);

            Orden orden2 = new Orden();
            orden2.NumeroOrdenInterna = 12345672;
            orden2.NumeroOrdenExterna = 456;
            orden2.Producto = "Lapicera 2";
            orden2.FechaCreacion = DateTime.Now.AddDays(-2);
            orden2.FechaModificacion = DateTime.Now;
            orden2.Cliente = "Cliente 2";
            orden2.Cantidad = 3;
            orden2.ListoParaEntrega = false;
            orden2.Estado = EstadoEnum.EN_SELECCION;
            ordenes.Add(orden2);

            Orden orden3 = new Orden();
            orden3.NumeroOrdenInterna = 12345673;
            orden3.NumeroOrdenExterna = 789;
            orden3.Producto = "Lapicera 3";
            orden3.FechaCreacion = DateTime.Now.AddDays(-3);
            orden3.FechaModificacion = DateTime.Now;
            orden3.Cliente = "Cliente 3";
            orden3.Cantidad = 4;
            orden3.ListoParaEntrega = true;
            orden3.Estado = EstadoEnum.EN_SELECCION;
            ordenes.Add(orden3);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            foreach (var orden in ordenes)
            {
                ListViewItem item = new ListViewItem();
                item.Text = orden.NumeroOrdenInterna.ToString();
                item.SubItems.Add(orden.NumeroOrdenExterna.ToString());
                item.SubItems.Add(orden.Producto);
                item.SubItems.Add(orden.Cantidad.ToString());
                item.SubItems.Add(orden.FechaCreacion.ToString());
                item.SubItems.Add(orden.Estado.ToString());
                item.SubItems.Add(orden.Cliente);
                item.SubItems.Add(orden.ListoParaEntrega ? "si" : "no");
                item.SubItems.Add(orden.FechaModificacion.ToString());
                item.Tag = orden;
                listView1.Items.Add(item);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Orden orden = (Orden) listView1.SelectedItems[0].Tag;
            new Form2(orden).ShowDialog();
        }
    }
}
