namespace MtoMigracion.Interfaz
{
    partial class FMenuVentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnVentas = new Button();
            btnReportes = new Button();
            panelContenido = new Panel();
            SuspendLayout();
            // 
            // btnVentas
            // 
            btnVentas.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVentas.Location = new Point(17, 12);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(215, 50);
            btnVentas.TabIndex = 0;
            btnVentas.Text = "VENTAS";
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnReportes
            // 
            btnReportes.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReportes.Location = new Point(238, 12);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(248, 50);
            btnReportes.TabIndex = 1;
            btnReportes.Text = "REPORTE DE VENTAS";
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnReportes_Click;
            // 
            // panelContenido
            // 
            panelContenido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelContenido.BackColor = SystemColors.ControlLight;
            panelContenido.Location = new Point(12, 90);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(1320, 854);
            panelContenido.TabIndex = 2;
            // 
            // FMenuVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1344, 982);
            Controls.Add(panelContenido);
            Controls.Add(btnReportes);
            Controls.Add(btnVentas);
            Name = "FMenuVentas";
            Text = "FMenuVentas";
            WindowState = FormWindowState.Maximized;
            Load += FMenuVentas_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnVentas;
        private Button btnReportes;
        private Panel panelContenido;
    }
}