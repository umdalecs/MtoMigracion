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
        public FMenuVentas()
        {
            InitializeComponent();
        }

        private void AbrirEnPanel(Form formHijo)
        {
            panelContenido.Controls.Clear();
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            panelContenido.Controls.Add(formHijo);
            formHijo.Show();
        }

        private void FMenuVentas_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirEnPanel(new FV001());
        }
    }
}
