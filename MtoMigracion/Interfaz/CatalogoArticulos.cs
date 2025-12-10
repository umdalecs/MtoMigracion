using MtoMigracion.Repositorios;
using MtoMigracion.Modelos;

namespace MtoMigracion.Interfaz;

public partial class CatalogoArticulos : Form
{
    private readonly ArticulosRepository articulosRepository;
    private readonly ProveedoresRepository proveedoresRepository;

    private int IDProveedorSeleccionado = 0;

    public CatalogoArticulos()
    {
        InitializeComponent();
        articulosRepository = new ArticulosRepository();
        proveedoresRepository = new ProveedoresRepository();
    }
    private void LoadArticulos()
    {
        articulosDataGrid.DataSource = articulosRepository.GetAll().ToList();
    }

    private void LoadProveedores()
    {
        var proveedorIds = proveedoresRepository
            .GetAll()
            .Select(p => p.ProveedorID)
            .ToList();

        comboBox1.DataSource = proveedorIds;
    }

    public void LimpiarFormulario()
    {
        txtIDArticulo.Text = "";
        txtNombre.Text = "";
        txtNombreProveedor.Text = "";
        precio.Text = "";
        comboStatus1.Text = "";
    }
    private void CatalogoArticulos_Load(object sender, EventArgs e)
    {
        LoadArticulos();
        // Oculta los navigation properties (Cosas de entity Framework)
        articulosDataGrid.Columns["Proveedor"]!.Visible = false;
        articulosDataGrid.Columns["DetallesNotaVenta"]!.Visible = false;

        articulosDataGrid.ReadOnly = true;
        articulosDataGrid.AllowUserToAddRows = false;
        articulosDataGrid.AllowUserToDeleteRows = false;

        articulosDataGrid.CellDoubleClick += ArticulosDataGrid_CellDoubleClick;
        LoadProveedores();
    }

    private void ArticulosDataGrid_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;
        var articulo = (Articulo)articulosDataGrid.Rows[e.RowIndex].DataBoundItem!;
        txtIDArticulo.Text = articulo.ArticuloID.ToString();
        txtNombre.Text = articulo.Descripcion;
        txtNombreProveedor.Text = articulo.Proveedor.Nombre;
        precio.Text = articulo.Precio;
        comboStatus1.Text = articulo.Status;
    }

    private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
    {
        int id = 0;

        try
        {
            id = int.Parse(txtIDArticulo.Text);
        }
        catch (FormatException) { }

        var newArticulo = new Articulo
        {
            ArticuloID = id,
            ProveedorID = IDProveedorSeleccionado,

            Descripcion = txtNombre.Text,
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

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        int index = comboBox1.SelectedIndex;
        IDProveedorSeleccionado = (int)comboBox1.Items[index]!;
    }
}
