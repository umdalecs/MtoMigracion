namespace MtoMigracion.Interfaz;

public partial class MenuInicio : Form
{
    public MenuInicio()
    {
        InitializeComponent();
    }

    private void ClientesButton_Click(object sender, EventArgs e)
    {
        var catalogoClientes = new CatalogoClientes();
        catalogoClientes.Show();
    }

    private void ProveedoresButton_Click(object sender, EventArgs e)
    {
        var catalogoProveedores = new CatalogoProveedores();
        catalogoProveedores.Show();
    }

    private void VentasButton_Click(object sender, EventArgs e)
    {

    }

    private void InventarioButton_Click(object sender, EventArgs e)
    {
        var catalogoArticulos = new CatalogoArticulos();
        catalogoArticulos.Show();
    }

    private void panel2_Paint(object sender, PaintEventArgs e)
    {

    }

    private void groupBox1_Enter(object sender, EventArgs e)
    {

    }

    private void groupBox2_Enter(object sender, EventArgs e)
    {

    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {

    }

    
}
