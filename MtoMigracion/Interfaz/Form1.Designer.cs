
namespace Formulario1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            Proovedores = new Button();
            button2 = new Button();
            button3 = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            button8 = new Button();
            button9 = new Button();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(34, 31);
            button1.Name = "button1";
            button1.Size = new Size(103, 94);
            button1.TabIndex = 0;
            button1.Text = "Clientes";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Proovedores
            // 
            Proovedores.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Proovedores.Image = (Image)resources.GetObject("Proovedores.Image");
            Proovedores.ImageAlign = ContentAlignment.TopCenter;
            Proovedores.Location = new Point(34, 145);
            Proovedores.Name = "Proovedores";
            Proovedores.Size = new Size(103, 85);
            Proovedores.TabIndex = 1;
            Proovedores.Text = "Proveedores";
            Proovedores.TextAlign = ContentAlignment.BottomCenter;
            Proovedores.UseVisualStyleBackColor = true;
            Proovedores.Click += button2_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.TopCenter;
            button2.Location = new Point(34, 249);
            button2.Name = "button2";
            button2.Size = new Size(103, 85);
            button2.TabIndex = 2;
            button2.Text = "Ventas";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.TopCenter;
            button3.Location = new Point(34, 352);
            button3.Name = "button3";
            button3.Size = new Size(103, 85);
            button3.TabIndex = 3;
            button3.Text = "Inventario";
            button3.TextAlign = ContentAlignment.BottomCenter;
            button3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Location = new Point(675, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 192);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveBorder;
            panel2.Location = new Point(3, 549);
            panel2.Name = "panel2";
            panel2.Size = new Size(1010, 18);
            panel2.TabIndex = 5;
            panel2.Paint += panel2_Paint;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(Proovedores);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button3);
            groupBox1.Location = new Point(26, 18);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(180, 478);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(button6);
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(467, 445);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(414, 167);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Enter += groupBox2_Enter;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button8);
            groupBox3.Controls.Add(button9);
            groupBox3.Controls.Add(textBox3);
            groupBox3.Controls.Add(textBox4);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label6);
            groupBox3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(29, 19);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(352, 122);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            // 
            // button8
            // 
            button8.Cursor = Cursors.No;
            button8.Location = new Point(212, 83);
            button8.Name = "button8";
            button8.Size = new Size(77, 23);
            button8.TabIndex = 6;
            button8.Text = "Cancelar";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Cursor = Cursors.No;
            button9.Location = new Point(122, 83);
            button9.Name = "button9";
            button9.Size = new Size(80, 23);
            button9.TabIndex = 5;
            button9.Text = "Guardar";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // textBox3
            // 
            textBox3.Cursor = Cursors.No;
            textBox3.Location = new Point(122, 57);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(212, 20);
            textBox3.TabIndex = 4;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Cursor = Cursors.No;
            textBox4.Location = new Point(122, 31);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(212, 20);
            textBox4.TabIndex = 3;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.No;
            label4.Location = new Point(9, 60);
            label4.Name = "label4";
            label4.Size = new Size(107, 13);
            label4.TabIndex = 2;
            label4.Text = "Confirmar contraseña";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.No;
            label5.Location = new Point(20, 34);
            label5.Name = "label5";
            label5.Size = new Size(96, 13);
            label5.TabIndex = 1;
            label5.Text = "Nueva Contraseña";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 19);
            label6.Name = "label6";
            label6.Size = new Size(0, 13);
            label6.TabIndex = 0;
            // 
            // button6
            // 
            button6.Location = new Point(297, 101);
            button6.Name = "button6";
            button6.Size = new Size(30, 23);
            button6.TabIndex = 7;
            button6.Text = "...";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(187, 101);
            button5.Name = "button5";
            button5.Size = new Size(104, 23);
            button5.TabIndex = 6;
            button5.Text = "Cerrar Sesion";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(78, 101);
            button4.Name = "button4";
            button4.Size = new Size(103, 23);
            button4.TabIndex = 5;
            button4.Text = "Aceptar";
            button4.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(78, 75);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(330, 20);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(78, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(330, 20);
            textBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 78);
            label3.Name = "label3";
            label3.Size = new Size(61, 13);
            label3.TabIndex = 2;
            label3.Text = "Contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 52);
            label2.Name = "label2";
            label2.Size = new Size(43, 13);
            label2.TabIndex = 1;
            label2.Text = "Usuario";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 19);
            label1.Name = "label1";
            label1.Size = new Size(40, 13);
            label1.TabIndex = 0;
            label1.Text = "LOGIN";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(943, 635);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button button1;
        private Button Proovedores;
        private Button button2;
        private Button button3;
        private Panel panel1;
        private Panel panel2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button6;
        private Button button5;
        private Button button4;
        private GroupBox groupBox3;
        private Button button8;
        private Button button9;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
