using MtoMigracion.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MtoMigracion.Interfaz
{
    public partial class FMenuVentas : Form
    {
        // =========================================================
        // 1. VARIABLES GLOBALES DEL FORMULARIO (Equivalente a tus 'Dim' en VB)
        // =========================================================
        
        // Mantenemos la instancia viva para no perder los datos escritos
        private FV001 formVentas;
        
        // Descomentar esto cuando tengas el archivo FV002 creado:
        // private FV002 formReportes; 

        public FMenuVentas()
        {
            InitializeComponent();
        }

        // =========================================================
        // 2. CARGA DEL FORMULARIO (Equivalente a 'MyBase.Load' en VB)
        // =========================================================
        private void FMenuVentas_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            // Inicializamos las ventanas UNA SOLA VEZ
            formVentas = new FV001();
            
            // Descomentar cuando exista FV002:
            // formReportes = new FV002();

            // Las preparamos y metemos al panel (ocultas)
            PrepararVentana(formVentas);

            // Descomentar cuando exista FV002:
            // PrepararVentana(formReportes);

            // OPCIONAL: Mostrar ventas automáticamente al abrir
            MostrarVentana(formVentas);
        }

        // =========================================================
        // 3. MÉTODOS AUXILIARES (Tu lógica de configuración)
        // =========================================================
        private void PrepararVentana(Form f)
        {
            // Configuración para que el Form actúe como un control dentro del panel
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            f.Visible = false; // Nacen ocultos para no encimarse

            // Agregamos al panel
            panelContenido.Controls.Add(f);
        }

        // Equivalente a tu método 'oculta(ByVal f As String)' en VB,
        // pero optimizado para objetos C#
        private void MostrarVentana(Form ventanaAMostrar)
        {
            // 1. Ocultamos todo lo que haya en el panel
            foreach (Control c in panelContenido.Controls)
            {
                if (c is Form)
                {
                    c.Visible = false;
                }
            }

            // 2. Mostramos solo el que queremos
            if (ventanaAMostrar != null)
            {
                ventanaAMostrar.Visible = true;
                ventanaAMostrar.BringToFront(); // Traer al frente
            }
        }

        // =========================================================
        // 4. EVENTOS DE BOTONES
        // =========================================================

        private void btnVentas_Click(object sender, EventArgs e)
        {
            // Muestra la instancia que ya tenemos en memoria (no crea una nueva)
            MostrarVentana(formVentas);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            // Descomentar esto cuando tengas FV002:
            // MostrarVentana(formReportes);
            
            // Mensaje temporal hasta que crees la vista de reportes
            MessageBox.Show("El módulo de reportes (FV002) aún no ha sido agregado al proyecto.");
        }
    }
}