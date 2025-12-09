using MtoMigracion.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MtoMigracion.Modelos;
namespace MtoMigracion.Interfaz
{
    public partial class CatalogoArticulos : Form
    {
        public CatalogoArticulos()
        {
            InitializeComponent();
            articulosRepository = new ArticulosRepository();
        }
        private readonly ArticulosRepository articulosRepository;
        private void LoadArticulos()
        {
            articulosDataGrid.DataSource = articulosRepository.GetAll().ToList();
        }

        public void LimpiarFormulario()
        {
            artID.Text = "";
            prvID.Text = "";
            nArt.Text = "";
            nPrv.Text = "";
            precio.Text = "";
            comboStatus1.Text = "";
        }
        private void CatalogoArticulos_Load(object sender, EventArgs e)
        {
            LoadArticulos();
            articulosDataGrid.Columns["Articulos"]!.Visible = false;

            articulosDataGrid.ReadOnly = true;
            articulosDataGrid.AllowUserToAddRows = false;
            articulosDataGrid.AllowUserToDeleteRows = false;

            articulosDataGrid.CellDoubleClick += ArticulosDataGrid_CellDoubleClick;
        }

        private void ArticulosDataGrid_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var articulo = (Articulo)articulosDataGrid.Rows[e.RowIndex].DataBoundItem!;
            artID.Text = articulo.ArticuloID.ToString();
            prvID.Text = articulo.ProveedorID.ToString();
            nArt.Text = articulo.Descripcion;
            nPrv.Text = articulo.Proveedor.Nombre;
            precio.Text = articulo.Precio;
            comboStatus1.Text = articulo.Status;
        }



     

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = 0;

            try
            {
                id = int.Parse(artID.Text);
            }
            catch (FormatException) { }

            var newArticulo = new Articulo
            {
                ArticuloID = id,
                ProveedorID = int.Parse(prvID.Text),
                Descripcion = nArt.Text,
                Precio = precio.Text,
                Status = comboStatus1.Text


            };

            System.Diagnostics.Debug.WriteLine(newArticulo);

            articulosRepository.Upsert(newArticulo);
            LimpiarFormulario();
            LoadArticulos();
        }

        private void limpiarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }
    }
}
