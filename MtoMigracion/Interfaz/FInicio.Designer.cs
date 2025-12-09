
namespace Formulario1
{
    partial class FInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FInicio));
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
            txtConfirmarNuevaPassword = new TextBox();
            txtNuevaPassword = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox5 = new TextBox();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            txtPassword = new TextBox();
            txtUsuario = new TextBox();
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
            button1.Location = new Point(39, 41);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(131, 125);
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
            Proovedores.Location = new Point(39, 193);
            Proovedores.Margin = new Padding(3, 4, 3, 4);
            Proovedores.Name = "Proovedores";
            Proovedores.Size = new Size(131, 113);
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
            button2.Location = new Point(39, 336);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(131, 113);
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
            button3.Location = new Point(39, 471);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(131, 124);
            button3.TabIndex = 3;
            button3.Text = "Inventario";
            button3.TextAlign = ContentAlignment.BottomCenter;
            button3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Location = new Point(771, 57);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(229, 256);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveBorder;
            panel2.Location = new Point(3, 732);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1154, 24);
            panel2.TabIndex = 5;
            panel2.Paint += panel2_Paint;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(Proovedores);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button3);
            groupBox1.Enabled = false;
            groupBox1.Location = new Point(30, 24);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(206, 637);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(button6);
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(txtPassword);
            groupBox2.Controls.Add(txtUsuario);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(499, 620);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(466, 202);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Enter += groupBox2_Enter;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button8);
            groupBox3.Controls.Add(button9);
            groupBox3.Controls.Add(txtConfirmarNuevaPassword);
            groupBox3.Controls.Add(txtNuevaPassword);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label6);
            groupBox3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(33, 29);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(402, 163);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Visible = false;
            // 
            // button8
            // 
            button8.Location = new Point(308, 111);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(88, 31);
            button8.TabIndex = 6;
            button8.Text = "Cancelar";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(154, 111);
            button9.Margin = new Padding(3, 4, 3, 4);
            button9.Name = "button9";
            button9.Size = new Size(91, 31);
            button9.TabIndex = 5;
            button9.Text = "Guardar";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // txtConfirmarNuevaPassword
            // 
            txtConfirmarNuevaPassword.Location = new Point(154, 74);
            txtConfirmarNuevaPassword.Margin = new Padding(3, 4, 3, 4);
            txtConfirmarNuevaPassword.Name = "txtConfirmarNuevaPassword";
            txtConfirmarNuevaPassword.PasswordChar = '*';
            txtConfirmarNuevaPassword.Size = new Size(242, 23);
            txtConfirmarNuevaPassword.TabIndex = 4;
            // 
            // txtNuevaPassword
            // 
            txtNuevaPassword.Location = new Point(154, 45);
            txtNuevaPassword.Margin = new Padding(3, 4, 3, 4);
            txtNuevaPassword.Name = "txtNuevaPassword";
            txtNuevaPassword.PasswordChar = '*';
            txtNuevaPassword.Size = new Size(242, 23);
            txtNuevaPassword.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.No;
            label4.Location = new Point(10, 80);
            label4.Name = "label4";
            label4.Size = new Size(144, 17);
            label4.TabIndex = 2;
            label4.Text = "Confirmar contraseña";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.No;
            label5.Location = new Point(23, 45);
            label5.Name = "label5";
            label5.Size = new Size(126, 17);
            label5.TabIndex = 1;
            label5.Text = "Nueva Contraseña";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 25);
            label6.Name = "label6";
            label6.Size = new Size(0, 17);
            label6.TabIndex = 0;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(167, 70);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(244, 23);
            textBox5.TabIndex = 8;
            // 
            // button6
            // 
            button6.Enabled = false;
            button6.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(339, 135);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(34, 31);
            button6.TabIndex = 7;
            button6.Text = "...";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Enabled = false;
            button5.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(214, 135);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(119, 31);
            button5.TabIndex = 6;
            button5.Text = "Cerrar Sesion";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(105, 135);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(102, 31);
            button4.TabIndex = 5;
            button4.Text = "Aceptar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(105, 101);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(228, 23);
            txtPassword.TabIndex = 4;
            txtPassword.TextChanged += textBox2_TextChanged;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(105, 69);
            txtUsuario.Margin = new Padding(3, 4, 3, 4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(56, 23);
            txtUsuario.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 104);
            label3.Name = "label3";
            label3.Size = new Size(81, 17);
            label3.TabIndex = 2;
            label3.Text = "Contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 69);
            label2.Name = "label2";
            label2.Size = new Size(57, 17);
            label2.TabIndex = 1;
            label2.Text = "Usuario";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 29);
            label1.Name = "label1";
            label1.Size = new Size(52, 16);
            label1.TabIndex = 0;
            label1.Text = "LOGIN";
            label1.Click += label1_Click;
            // 
            // FInicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1078, 847);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FInicio";
            Text = "DISCOMSIN";
            Load += FInicio_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
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
        private TextBox txtPassword;
        private TextBox txtUsuario;
        private Button button6;
        private Button button5;
        private Button button4;
        private GroupBox groupBox3;
        private Button button8;
        private Button button9;
        private TextBox txtConfirmarNuevaPassword;
        private TextBox txtNuevaPassword;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox5;
    }
}
