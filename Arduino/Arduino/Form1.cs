using System.Windows.Forms;
using System.IO.Ports;
using Arduino.Entidades;

namespace Arduino
{
    public partial class Form1 : Form
    {
        SerialPort puertoArduino;
        ClsSensonres cls = null;
        System.Windows.Forms.Timer loop;
        private string datos { get; set; }
        public Form1()
        {
            InitializeComponent();
            puertoArduino = new SerialPort("COM9");
            puertoArduino.BaudRate = 9600;
            puertoArduino.Parity = Parity.None;
            puertoArduino.StopBits = StopBits.One;
            puertoArduino.DataBits = 8;

            loop = new System.Windows.Forms.Timer();
            loop.Interval = 500;
            loop.Tick += Loop_Tick;
            loop.Start();

            cls = new ClsSensonres();
        }

        private void Loop_Tick(object? sender, EventArgs e)
        {
            txtDatos.Text = datos;
            txtTempPot.Text = cls.strTem + " °C";
            txtHumedad.Text = cls.strHum;
            txtTemTeclado.Text = cls.strTemTeclado + " °C";

            if (cls.EstatusHum)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                txtEstatusHS.Text = "Apagado";
            }
            else
            {
                //txtEstatusHum.Text = "Apagado";
                pictureBox2.Visible = true;
                pictureBox1.Visible = false;
                txtEstatusHS.Text = "Encendido";
            }

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (btnConectar.Text == "Conectar" && !puertoArduino.IsOpen)
            {
                try
                {
                    puertoArduino.Open();
                    puertoArduino.DataReceived += PuertoArduino_DataReceived;
                    btnConectar.Text = "Desconectar";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo conectar a arduino");
                }

            }
            else
            {
                puertoArduino.Close();
                btnConectar.Text = "Conectar";
            }
        }

        private void PuertoArduino_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            datos = puertoArduino.ReadLine();
            string[] substrings = datos.Split('/');
            if (substrings.Length == 5)
            {
                if (substrings[0] == "~")
                {
                    
                    cls.strTem = substrings[1];
                    cls.strHum = substrings[2];
                    cls.strTemTeclado = substrings[3];
                    cls.obtenerValores();
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (cls.EstatusHum)
            {
                cls.EstatusHum = false;
                pictureBox1.Image = Properties.Resources.off;
            }
            else
            {
                cls.EstatusHum = true;
                pictureBox1.Image = Properties.Resources.on;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}