namespace Arduino
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnConectar = new Button();
            txtDatos = new TextBox();
            txtTempPot = new TextBox();
            txtHumedad = new TextBox();
            label1 = new Label();
            label2 = new Label();
            imageList1 = new ImageList(components);
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            txtEstatusHS = new TextBox();
            label3 = new Label();
            txtTemTeclado = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(12, 12);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(98, 47);
            btnConectar.TabIndex = 0;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click;
            // 
            // txtDatos
            // 
            txtDatos.Location = new Point(492, 368);
            txtDatos.Name = "txtDatos";
            txtDatos.Size = new Size(296, 23);
            txtDatos.TabIndex = 1;
            txtDatos.Visible = false;
            // 
            // txtTempPot
            // 
            txtTempPot.Location = new Point(165, 108);
            txtTempPot.Name = "txtTempPot";
            txtTempPot.Size = new Size(167, 23);
            txtTempPot.TabIndex = 2;
            // 
            // txtHumedad
            // 
            txtHumedad.Location = new Point(549, 397);
            txtHumedad.Name = "txtHumedad";
            txtHumedad.Size = new Size(222, 23);
            txtHumedad.TabIndex = 3;
            txtHumedad.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 90);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 4;
            label1.Text = "Temperatura";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 180);
            label2.Name = "label2";
            label2.Size = new Size(130, 15);
            label2.TabIndex = 5;
            label2.Text = "Estatus Humedad/Seco";
            label2.Click += label2_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "humedo.png");
            imageList1.Images.SetKeyName(1, "seco.png");
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(229, 180);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 101);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(229, 180);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(107, 101);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // txtEstatusHS
            // 
            txtEstatusHS.Location = new Point(367, 203);
            txtEstatusHS.Name = "txtEstatusHS";
            txtEstatusHS.Size = new Size(131, 23);
            txtEstatusHS.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(401, 85);
            label3.Name = "label3";
            label3.Size = new Size(115, 15);
            label3.TabIndex = 9;
            label3.Text = "Temperatura teclado";
            // 
            // txtTemTeclado
            // 
            txtTemTeclado.Location = new Point(492, 108);
            txtTemTeclado.Name = "txtTemTeclado";
            txtTemTeclado.Size = new Size(167, 23);
            txtTemTeclado.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtTemTeclado);
            Controls.Add(label3);
            Controls.Add(txtEstatusHS);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtHumedad);
            Controls.Add(txtTempPot);
            Controls.Add(txtDatos);
            Controls.Add(btnConectar);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConectar;
        private TextBox txtDatos;
        private TextBox txtTempPot;
        private TextBox txtHumedad;
        private Label label1;
        private Label label2;
        private ImageList imageList1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox txtEstatusHS;
        private Label label3;
        private TextBox txtTemTeclado;
    }
}