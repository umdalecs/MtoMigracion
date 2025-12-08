namespace MtoMigracion.Proveedores
{
    partial class CatalogoProveedores
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            comboStatus = new ComboBox();
            label13 = new Label();
            txtEmail = new TextBox();
            label5 = new Label();
            txtRFC = new TextBox();
            label12 = new Label();
            txtNombre = new TextBox();
            label6 = new Label();
            txtDireccion = new TextBox();
            txtRazon = new TextBox();
            txtTelefono = new TextBox();
            txtID = new TextBox();
            proveedoresDataGrid = new DataGridView();
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            guardarToolStripMenuItem = new ToolStripMenuItem();
            limpiarToolStripMenuItem = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)proveedoresDataGrid).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 0;
            label1.Text = "Proveedor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 48);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 1;
            label2.Text = "Razón Social";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 77);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 2;
            label3.Text = "Dirección";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 133);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 3;
            label4.Text = "Teléfono";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboStatus);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtRFC);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Controls.Add(txtRazon);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(12, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 165);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos generales";
            // 
            // comboStatus
            // 
            comboStatus.AllowDrop = true;
            comboStatus.FormattingEnabled = true;
            comboStatus.Items.AddRange(new object[] { "Activo", "Inactivo" });
            comboStatus.Location = new Point(489, 106);
            comboStatus.Name = "comboStatus";
            comboStatus.Size = new Size(281, 23);
            comboStatus.TabIndex = 15;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(444, 109);
            label13.Name = "label13";
            label13.Size = new Size(39, 15);
            label13.TabIndex = 14;
            label13.Text = "Status";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(489, 74);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(281, 23);
            txtEmail.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(444, 77);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 12;
            label5.Text = "Email";
            // 
            // txtRFC
            // 
            txtRFC.Location = new Point(489, 45);
            txtRFC.Name = "txtRFC";
            txtRFC.Size = new Size(281, 23);
            txtRFC.TabIndex = 11;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(444, 48);
            label12.Name = "label12";
            label12.Size = new Size(28, 15);
            label12.TabIndex = 10;
            label12.Text = "RFC";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(273, 16);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(497, 23);
            txtNombre.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(206, 19);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 8;
            label6.Text = "Nombre";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(85, 74);
            txtDireccion.Multiline = true;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.ScrollBars = ScrollBars.Vertical;
            txtDireccion.Size = new Size(353, 50);
            txtDireccion.TabIndex = 7;
            // 
            // txtRazon
            // 
            txtRazon.Location = new Point(85, 45);
            txtRazon.Name = "txtRazon";
            txtRazon.Size = new Size(353, 23);
            txtRazon.TabIndex = 6;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(85, 130);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(227, 23);
            txtTelefono.TabIndex = 6;
            // 
            // txtID
            // 
            txtID.ImeMode = ImeMode.On;
            txtID.Location = new Point(85, 16);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(115, 23);
            txtID.TabIndex = 5;
            // 
            // proveedoresDataGrid
            // 
            proveedoresDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            proveedoresDataGrid.Location = new Point(12, 198);
            proveedoresDataGrid.Name = "proveedoresDataGrid";
            proveedoresDataGrid.Size = new Size(776, 240);
            proveedoresDataGrid.TabIndex = 7;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { guardarToolStripMenuItem, limpiarToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // guardarToolStripMenuItem
            // 
            guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            guardarToolStripMenuItem.Size = new Size(180, 22);
            guardarToolStripMenuItem.Text = "Guardar";
            guardarToolStripMenuItem.Click += GuardarToolStripMenuItem_Click;
            // 
            // limpiarToolStripMenuItem
            // 
            limpiarToolStripMenuItem.Name = "limpiarToolStripMenuItem";
            limpiarToolStripMenuItem.Size = new Size(180, 22);
            limpiarToolStripMenuItem.Text = "Limpiar";
            limpiarToolStripMenuItem.Click += LimpiarToolStripMenuItem_Click;
            // 
            // CatalogoProveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(proveedoresDataGrid);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "CatalogoProveedores";
            Text = "CatalogoProveedores";
            Load += CatalogoProveedores_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)proveedoresDataGrid).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox groupBox1;
        private TextBox txtNombre;
        private Label label6;
        private TextBox txtRazon;
        private TextBox txtTelefono;
        private TextBox txtID;
        private TextBox txtRFC;
        private Label label12;
        private TextBox txtDireccion;
        private Label label13;
        private TextBox txtEmail;
        private Label label5;
        private DataGridView proveedoresDataGrid;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem guardarToolStripMenuItem;
        private ComboBox comboStatus;
        private ToolStripMenuItem limpiarToolStripMenuItem;
    }
}