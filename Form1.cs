using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Diagnostics;

namespace torreta
{
    public partial class Form1 : Form
    {
        static SerialPort _serialPort;
        public Stopwatch watch { get; set; }
        public void SerialConnect()
        {
            try
            {
                _serialPort = new SerialPort();
                _serialPort.PortName = cmbPorts.SelectedItem.ToString();
                _serialPort.BaudRate = 9600;
                _serialPort.Open();

                lblOnOff.ForeColor = Color.Green;
                lblOnOff.Text = "ON";
                _serialPort.WriteLine("owo");
                
            }
            catch {
                lblOnOff.ForeColor = Color.Red;
                lblOnOff.Text = "ERROR"; 
            }
            
        }
        public Form1()
        {
            InitializeComponent();
            lblMousePos.ForeColor = Color.Red;
            lblScreenSize.Text = screen.Size + "";
            lblScreenPos.Text = this.Location + "";


            // Get a list of serial port names.
            string[] ports = SerialPort.GetPortNames();
            cmbPorts.DataSource = ports;

            watch = Stopwatch.StartNew();
        }

        private void screen_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = new Cursor(Cursor.Current.Handle);
            //Obtener la posicion absoluta del mouse
            int posX = Cursor.Position.X;
            int posY = Cursor.Position.Y;

            //Obtener tamaño y posicion de la ventana
            int windowPosX = this.Location.X;
            int windowPosY = this.Location.Y;

            int screenWidth = screen.Width;
            int screenHeight = screen.Height;

            

            //Convertir la posicion del mouse en relativa a la ventana
            posX -= windowPosX+7;
            posY -= windowPosY+31;

            //Mostrar los datos
            lblMousePos.Text = "X:" + posX + " Y:" + posY;

            //Mapear la posicion al angulo de rotacion del servo
            posX = 180 - (posX / (screenWidth / 180));
            posY = posY / (screenHeight / 180);

            
            if(watch.ElapsedMilliseconds > 15)
            {
                watch = Stopwatch.StartNew();
                if (lblOnOff.Text == "ON")
                {
                    //Enviar la posicion al Serial
                    _serialPort.Write("X" + posX + "Y" + posY);
                }
            }
            

            lblConsola.Text = ("X" + posX + "Y" + posY);
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            lblScreenSize.Text = screen.Size + "";

        }

        private void Form1_Move(object sender, EventArgs e)
        {
            lblScreenPos.Text = this.Location + "";

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            SerialConnect();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(lblOnOff.Text == "ON")
            {
                try
                {
                    _serialPort.Write("X90Y90");
                    lblOnOff.ForeColor = Color.Red;
                    lblOnOff.Text = "OFF";
                }
                finally {
                    _serialPort.Close();
                }
            }
        }
    }
}
