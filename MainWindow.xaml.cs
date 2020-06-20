using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Caps10y12
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string listaProductos;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            Productos produto = new Productos(Convert.ToInt32(ProductoIdTextBox.Text), DexcripcionTextBox.Text,
                Convert.ToInt32(CantidadTextBox.Text),Convert.ToDecimal(CostoTextBox.Text),Convert.ToDecimal(PrecioTextBox.Text));
            string listado = ($" Id: {produto.ProductoId}\n Descripcion: {produto.Descripcion}\n Cantidad: {produto.Cantidad}\n" +
                $"Costo: {produto.Costo}\n Precio: {produto.Precio}");
            listaProductos += listado;
            ListaProductosTextBox.Text = listaProductos;
        }
    }

    
    public class Productos 
    {
        public int ProductoId { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public decimal Costo { get; set; }
        public decimal Precio { get; set; }

        public Productos(int productoId, string descripcion, int cantidad, decimal costo, decimal precio)
        {
            ProductoId = productoId;
            Descripcion = descripcion;
            Cantidad = cantidad;
            Costo = costo;
            Precio = precio;
        }

    }

    public class Estudiante
    {
        public int EstudianteId { get; set; }
        public string Matricula { get; set; }
        public string Nombres { get; set; }
        public string Semestre { get; set; }

        public Estudiante(int estudianteId, string matricula, string nombres, string semestre)
        {
            EstudianteId = estudianteId;
            Matricula = matricula;
            Nombres = nombres;
            Semestre = semestre;
        }
    }
}
