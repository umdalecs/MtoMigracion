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
            button1 = new Button();
            button2 = new Button();
            panelContenido = new Panel();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(17, 12);
            button1.Name = "button1";
            button1.Size = new Size(215, 50);
            button1.TabIndex = 0;
            button1.Text = "VENTAS";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(238, 12);
            button2.Name = "button2";
            button2.Size = new Size(248, 50);
            button2.TabIndex = 1;
            button2.Text = "REPORTE DE VENTAS";
            button2.UseVisualStyleBackColor = true;
            // 
            // panelContenido
            // 
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
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "FMenuVentas";
            Text = "FMenuVentas";
            Load += FMenuVentas_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Panel panelContenido;
    }
}