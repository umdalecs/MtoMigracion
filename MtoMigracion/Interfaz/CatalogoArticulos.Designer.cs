namespace MtoMigracion.Interfaz
{
    partial class CatalogoArticulos 
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            comboStatus1 = new ComboBox();
            artID = new TextBox();
            precio = new TextBox();
            label7 = new Label();
            label6 = new Label();
            nPrv = new TextBox();
            label4 = new Label();
            prvID = new TextBox();
            label3 = new Label();
            nArt = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            articulosDataGrid = new DataGridView();
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            guardarToolStripMenuItem1 = new ToolStripMenuItem();
            limpiarToolStripMenuItem1 = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)articulosDataGrid).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboStatus1);
            groupBox1.Controls.Add(artID);
            groupBox1.Controls.Add(precio);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(nPrv);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(prvID);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(nArt);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(15, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(942, 261);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos generales ";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // comboStatus1
            // 
            comboStatus1.FormattingEnabled = true;
            comboStatus1.Items.AddRange(new object[] { "En stock", "No Stock" });
            comboStatus1.Location = new Point(76, 167);
            comboStatus1.Name = "comboStatus1";
            comboStatus1.Size = new Size(126, 28);
            comboStatus1.TabIndex = 15;
            // 
            // artID
            // 
            artID.Location = new Point(122, 31);
            artID.Name = "artID";
            artID.Size = new Size(151, 27);
            artID.TabIndex = 14;
            // 
            // precio
            // 
            precio.Location = new Point(77, 127);
            precio.Name = "precio";
            precio.Size = new Size(125, 27);
            precio.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 170);
            label7.Name = "label7";
            label7.Size = new Size(53, 20);
            label7.TabIndex = 11;
            label7.Text = "Status ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 130);
            label6.Name = "label6";
            label6.Size = new Size(54, 20);
            label6.TabIndex = 10;
            label6.Text = "Precio ";
            // 
            // nPrv
            // 
            nPrv.Location = new Point(425, 70);
            nPrv.Name = "nPrv";
            nPrv.Size = new Size(428, 27);
            nPrv.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(299, 73);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 6;
            label4.Text = "N. Proveedor";
            label4.Click += label4_Click;
            // 
            // prvID
            // 
            prvID.Location = new Point(124, 70);
            prvID.Name = "prvID";
            prvID.Size = new Size(149, 27);
            prvID.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 73);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 4;
            label3.Text = "ID proveedor ";
            label3.Click += label3_Click;
            // 
            // nArt
            // 
            nArt.Location = new Point(425, 31);
            nArt.Name = "nArt";
            nArt.Size = new Size(428, 27);
            nArt.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(299, 34);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 2;
            label2.Text = "N. Articulo";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 34);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 0;
            label1.Text = "ID de articulo";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(12, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(957, 261);
            panel1.TabIndex = 0;
            // 
            // articulosDataGrid
            // 
            articulosDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            articulosDataGrid.Location = new Point(12, 319);
            articulosDataGrid.Margin = new Padding(3, 4, 3, 3);
            articulosDataGrid.Name = "articulosDataGrid";
            articulosDataGrid.RowHeadersWidth = 51;
            articulosDataGrid.Size = new Size(945, 188);
            articulosDataGrid.TabIndex = 1;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(969, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { guardarToolStripMenuItem1, limpiarToolStripMenuItem1 });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(77, 24);
            archivoToolStripMenuItem.Text = "Archivo ";
            // 
            // guardarToolStripMenuItem1
            // 
            guardarToolStripMenuItem1.Name = "guardarToolStripMenuItem1";
            guardarToolStripMenuItem1.Size = new Size(224, 26);
            guardarToolStripMenuItem1.Text = "Guardar ";
            guardarToolStripMenuItem1.Click += guardarToolStripMenuItem_Click;
            // 
            // limpiarToolStripMenuItem1
            // 
            limpiarToolStripMenuItem1.Name = "limpiarToolStripMenuItem1";
            limpiarToolStripMenuItem1.Size = new Size(224, 26);
            limpiarToolStripMenuItem1.Text = "Limpiar ";
            limpiarToolStripMenuItem1.Click += limpiarToolStripMenuItem1_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // CatalogoArticulos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 561);
            Controls.Add(groupBox1);
            Controls.Add(articulosDataGrid);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Name = "CatalogoArticulos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Catalog de Articulos";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)articulosDataGrid).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private Panel panel1;
        private DataGridView articulosDataGrid;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem guardarToolStripMenuItem1;
        private ToolStripMenuItem limpiarToolStripMenuItem1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox nArt;
        private TextBox nPrv;
        private Label label4;
        private TextBox prvID;
        private TextBox precio;
        private Label label7;
        private Label label6;
        private TextBox artID;
        private ContextMenuStrip contextMenuStrip1;
        private ComboBox comboStatus1;
    }
}