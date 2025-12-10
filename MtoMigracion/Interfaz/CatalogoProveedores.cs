
using Microsoft.EntityFrameworkCore;
using MtoMigracion.Modelos;
using MtoMigracion.Repositorios;

namespace MtoMigracion.Interfaz;

public partial class CatalogoProveedores : Form
{
    private readonly ProveedoresRepository proveedorRepository;
    public CatalogoProveedores()
    {
        InitializeComponent();
        proveedorRepository = new ProveedoresRepository();
    }

    private void LoadProveedores()
    {
        proveedoresDataGrid.DataSource = proveedorRepository.GetAll().ToList();
    }

    public void LimpiarFormulario()
    {
        txtID.Text = "";
        txtNombre.Text = "";
        txtRazon.Text = "";
        txtDireccion.Text = "";
        txtTelefono.Text = "";
        txtRFC.Text = "";
        txtEmail.Text = "";
        comboStatus.Text = "";
    }

    private void CatalogoProveedores_Load(object sender, EventArgs e)
    {
        LoadProveedores();
        proveedoresDataGrid.Columns["Articulos"]!.Visible = false;

        proveedoresDataGrid.ReadOnly = true;
        proveedoresDataGrid.AllowUserToAddRows = false;
        proveedoresDataGrid.AllowUserToDeleteRows = false;

        proveedoresDataGrid.CellDoubleClick += ProveedoresDataGrid_CellDoubleClick;
    }

    private void ProveedoresDataGrid_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;

        var proveedor = (Proveedor)proveedoresDataGrid.Rows[e.RowIndex].DataBoundItem!;

        txtID.Text = proveedor.ProveedorID.ToString();
        txtNombre.Text = proveedor.Nombre;
        txtRazon.Text = proveedor.RazonSocial;
        txtDireccion.Text = proveedor.Direccion;
        txtTelefono.Text = proveedor.Telefono;
        txtRFC.Text = proveedor.RFC;
        txtEmail.Text = proveedor.Email;
        comboStatus.Text = proveedor.Status;
    }

    private void GuardarToolStripMenuItem_Click(object sender, EventArgs e)
    {
        int id = 0;

        try
        {
            id = int.Parse(txtID.Text);
        }
        catch (FormatException) { }

        var newProveedor = new Proveedor
        {
            ProveedorID = id,
            Nombre = txtNombre.Text,
            RazonSocial = txtRazon.Text,
            Direccion = txtDireccion.Text,
            Telefono = txtTelefono.Text,
            RFC = txtRFC.Text,
            Email = txtEmail.Text,
            Status = comboStatus.Text,
        };

        System.Diagnostics.Debug.WriteLine(newProveedor);

        proveedorRepository.Upsert(newProveedor);
        LimpiarFormulario();
        LoadProveedores();
    }

    private void LimpiarToolStripMenuItem_Click(object sender, EventArgs e)
    {
        LimpiarFormulario();
    }
}
