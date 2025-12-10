using Microsoft.EntityFrameworkCore;
using MtoMigracion.Core;
using MtoMigracion.Interfaz;
using MtoMigracion.Modelos;

namespace MtoMigracion.Interfaz;

public partial class FInicio : Form
{
    public FInicio()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        var catalogoClientes = new CatalogoClientes();
        catalogoClientes.Show();
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

    private void FInicio_Load(object sender, EventArgs e)
    {
        this.AcceptButton = button4;
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void button4_Click(object sender, EventArgs e)
    {
        var ctx = AppDbContextFactory.GetDbContext();

        string user = txtUsuario.Text.Trim();
        string passPlano = txtPassword.Text.Trim();

        if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(passPlano))
        {
            MessageBox.Show("Ingrese usuario y contraseña.");
            return;
        }

        string passEncriptada = "";
        var conn = ctx.Database.GetDbConnection();
        ctx.Database.OpenConnection();

        using (var cmd = conn.CreateCommand())
        {
            cmd.CommandText = "SELECT dbo.Encriptado(@pass)";
            var p = cmd.CreateParameter();
            p.ParameterName = "@pass";
            p.Value = passPlano;
            cmd.Parameters.Add(p);
            passEncriptada = cmd.ExecuteScalar()?.ToString() ?? "";
        }

        var usuario = ctx.Usuarios
            .FirstOrDefault(u =>
                u.UsuarioId.ToString() == user &&
                u.Contrasena == passEncriptada);

        if (usuario == null)
        {
            MessageBox.Show("Usuario o contraseña incorrectos.");
            return;
        }

        groupBox1.Enabled = true;
        button5.Enabled = true;
        button6.Enabled = true;
        button4.Enabled = false;
        txtUsuario.ReadOnly = true;
        txtPassword.ReadOnly = true;
    }
    private void limpiarCampos()
    {
        txtUsuario.Text = "";
        txtPassword.Text = "";
    }
    private void button8_Click(object sender, EventArgs e)
    {

        button5_Click(sender, e);
        groupBox3.Visible = false;
    }
    private void button5_Click(object sender, EventArgs e)
    {
        groupBox1.Enabled = false;
        txtUsuario.Focus();
        limpiarCampos();
        button5.Enabled = false;
        button6.Enabled = false;
        button4.Enabled = true;
        txtUsuario.ReadOnly = false;
        txtPassword.ReadOnly = false;
    }

    private void button6_Click(object sender, EventArgs e)
    {
        groupBox3.Visible = true;

    }
    private void button9_Click(object sender, EventArgs e)
    {
        var ctx = AppDbContextFactory.GetDbContext();

        string nueva = txtNuevaPassword.Text.Trim();
        string confirmar = txtConfirmarNuevaPassword.Text.Trim();
        string user = txtUsuario.Text.Trim();

        if (string.IsNullOrEmpty(nueva) || string.IsNullOrEmpty(confirmar))
        {
            MessageBox.Show("Complete todos los campos.");
            return;
        }

        if (nueva != confirmar)
        {
            MessageBox.Show("Las contraseñas no coinciden.");
            return;
        }

        string nuevaEnc = "";
        var conn = ctx.Database.GetDbConnection();
        ctx.Database.OpenConnection();

        using (var cmd = conn.CreateCommand())
        {
            cmd.CommandText = "SELECT dbo.Encriptado(@pass)";
            var p = cmd.CreateParameter();
            p.ParameterName = "@pass";
            p.Value = nueva;
            cmd.Parameters.Add(p);
            nuevaEnc = cmd.ExecuteScalar()?.ToString() ?? "";
        }

        var usuario = ctx.Usuarios.FirstOrDefault(u => u.UsuarioId == user);
        if (usuario == null)
        {
            MessageBox.Show("Usuario no encontrado.");
            return;
        }

        usuario.Contrasena = nuevaEnc;
        ctx.SaveChanges();

        MessageBox.Show("Contraseña actualizada.");
        groupBox3.Visible = false;
        txtNuevaPassword.Text = "";
        txtConfirmarNuevaPassword.Text = "";
        button5_Click(sender, e);
    }

    private void Ventas_Click(object sender, EventArgs e)
    {
        var form = new FMenuVentas();
        form.Show();
    }

    private void Proovedores_Click(object sender, EventArgs e)
    {
        var catalogoProveedores = new CatalogoProveedores();
        catalogoProveedores.Show();
    }

    private void button3_Click(object sender, EventArgs e)
    {
			var catalogoArticulos = new CatalogoArticulos();
			catalogoArticulos.Show();
		}
}