
using Microsoft.EntityFrameworkCore;
using MtoMigracion.Modelos;
using MtoMigracion.Repositorios;

namespace MtoMigracion.Interfaz;

public partial class CatalogoClientes : Form
{
    private readonly ClientesRepository clienteRepository;
    public CatalogoClientes()
    {
        InitializeComponent();
        clienteRepository = new ClientesRepository();
    }

    private void LoadClientes()
    {
        clientesDataGrid.DataSource = clienteRepository.GetAll().ToList();
    }

    public void LimpiarFormulario()
    {
        txtID.Text = "";
        txtNombre.Text = "";
        txtRazon.Text = "";
        txtDireccion.Text = "";
        txtTelefono.Text = "";
        txtRFC.Text = "";
        comboStatus.Text = "";
    }

    private void CatalogoClientes_Load(object sender, EventArgs e)
    {
        LoadClientes();
        clientesDataGrid.Columns["NotasVenta"]!.Visible = false;

        clientesDataGrid.ReadOnly = true;
        clientesDataGrid.AllowUserToAddRows = false;
        clientesDataGrid.AllowUserToDeleteRows = false;

        clientesDataGrid.CellDoubleClick += ClientesDataGrid_CellDoubleClick;
    }

    private void ClientesDataGrid_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;

        var cliente = (Cliente)clientesDataGrid.Rows[e.RowIndex].DataBoundItem!;

        txtID.Text = cliente.ClienteID.ToString();
        txtNombre.Text = cliente.Nombre;
        txtRazon.Text = cliente.RazonSocial;
        txtDireccion.Text = cliente.Direccion;
        txtTelefono.Text = cliente.Telefono;
        txtRFC.Text = cliente.RFC;
        comboStatus.Text = cliente.Status;
    }

    private void GuardarToolStripMenuItem_Click(object sender, EventArgs e)
    {
        int id = 0;

        try
        {
            id = int.Parse(txtID.Text);
        }
        catch (FormatException) { }

        var newCliente = new Cliente
        {
            ClienteID = id,
            Nombre = txtNombre.Text,
            RazonSocial = txtRazon.Text,
            Direccion = txtDireccion.Text,
            Telefono = txtTelefono.Text,
            RFC = txtRFC.Text,
            Status = comboStatus.Text,
        };

        System.Diagnostics.Debug.WriteLine(newCliente);

        clienteRepository.Upsert(newCliente);
        LimpiarFormulario();
        LoadClientes();
    }

    private void LimpiarToolStripMenuItem_Click(object sender, EventArgs e)
    {
        LimpiarFormulario();
    }
}
