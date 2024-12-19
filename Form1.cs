using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace SDR_Play_Remote
{
    
    public partial class Form1 : Form
    {
        private SerialPort serialPort;
                  
        bool ptt;

        public Form1()
        {
            InitializeComponent();
            this.serialPort = new SerialPort("COM28", 9600, Parity.None, 8, StopBits.One);
            this.serialPort.Open();

            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(PttHandler);

        }




        private void btnCloseClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSendmsgClick(object sender, EventArgs e)
        {
            string server = "192.168.178.60";
            int port = 27299;
            // TCP-Client einrichten und verbinden
            TcpClient client = new TcpClient(server, port);
                       

            //Nachrichten in Bytes konvertieren
            string message = "TX";
            byte[] data = Encoding.ASCII.GetBytes(message);

            // Datenstream abrufen und Nachrichten senden
            NetworkStream stream = client.GetStream();
            stream.Write(data, 0, data.Length);

            // Verbindung schließen
            stream.Close();
            client.Close();
        }

        private void InitCom(object sender, EventArgs e)
        {
            
           
        }

        private void PttHandler(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            byte[] buffer = new byte[2]; // Buffer für 2 einzelne Zeichen
            int bytesRead = serialPort.Read(buffer, 0, 2);
            if (bytesRead > 1)
            {
                if ((buffer[0] == (byte)'T') && (buffer[1] == (byte)'X'))
                {
                    string server = "192.168.178.60";
                    int port = 27299;
                    // TCP-Client einrichten und verbinden
                    TcpClient client = new TcpClient(server, port);


                    //Nachrichten in Bytes konvertieren
                    string message = "TX";
                    byte[] data = Encoding.ASCII.GetBytes(message);

                    textBox1.Text = "TX Aktiv";

                    // Datenstream abrufen und Nachrichten senden
                    NetworkStream stream = client.GetStream();
                    stream.Write(data, 0, data.Length);

                    // Verbindung schließen
                    stream.Close();
                    client.Close();
                    serialPort.DiscardInBuffer();
                    ptt = true;
                    label1.BackColor = Color.Red;
                }
                if((buffer[0] == (byte)'R') && (buffer[1] == (byte)'X'))
                {

                    string server = "192.168.178.60";
                    int port = 27299;
                    // TCP-Client einrichten und verbinden
                    TcpClient client = new TcpClient(server, port);


                    //Nachrichten in Bytes konvertieren
                    string message = "RX";
                    byte[] data = Encoding.ASCII.GetBytes(message);

                    textBox1.Text = "RX Aktiv";

                    // Datenstream abrufen und Nachrichten senden
                    NetworkStream stream = client.GetStream();
                    stream.Write(data, 0, data.Length);

                    // Verbindung schließen
                    stream.Close();
                    client.Close();
                    serialPort.DiscardInBuffer();
                    ptt = false;
                    label1.BackColor = Color.Green;
                }
                
            }
            
        }

        private void LNAcheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (LNAcheckBox1.Checked)
            {
                // Code für den Fall, dass die CheckBox aktiviert ist
                string server = "192.168.178.60";
                int port = 27299;
                // TCP-Client einrichten und verbinden
                TcpClient client = new TcpClient(server, port);


                //Nachrichten in Bytes konvertieren
                string message = "LNA1";
                byte[] data = Encoding.ASCII.GetBytes(message);
                                

                // Datenstream abrufen und Nachrichten senden
                NetworkStream stream = client.GetStream();
                stream.Write(data, 0, data.Length);

                // Verbindung schließen
                stream.Close();
                client.Close();
            }
            else
            {
                // Code für den Fall, dass die CheckBox nicht aktiviert ist
                string server = "192.168.178.60";
                int port = 27299;
                // TCP-Client einrichten und verbinden
                TcpClient client = new TcpClient(server, port);


                //Nachrichten in Bytes konvertieren
                string message = "LNA0";
                byte[] data = Encoding.ASCII.GetBytes(message);


                // Datenstream abrufen und Nachrichten senden
                NetworkStream stream = client.GetStream();
                stream.Write(data, 0, data.Length);

                // Verbindung schließen
                stream.Close();
                client.Close();
            }
        }

        private void radioButtonANT1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonANT1.Checked)
            {
                // Code für den Fall, dass die CheckBox aktiviert ist
                string server = "192.168.178.60";
                int port = 27299;
                // TCP-Client einrichten und verbinden
                TcpClient client = new TcpClient(server, port);


                //Nachrichten in Bytes konvertieren
                string message = "ANT11";
                byte[] data = Encoding.ASCII.GetBytes(message);


                // Datenstream abrufen und Nachrichten senden
                NetworkStream stream = client.GetStream();
                stream.Write(data, 0, data.Length);

                // Verbindung schließen
                stream.Close();
                client.Close();
            }
            else
            {
                // Code für den Fall, dass die CheckBox nicht aktiviert ist
                string server = "192.168.178.60";
                int port = 27299;
                // TCP-Client einrichten und verbinden
                TcpClient client = new TcpClient(server, port);


                //Nachrichten in Bytes konvertieren
                string message = "ANT10";
                byte[] data = Encoding.ASCII.GetBytes(message);


                // Datenstream abrufen und Nachrichten senden
                NetworkStream stream = client.GetStream();
                stream.Write(data, 0, data.Length);

                // Verbindung schließen
                stream.Close();
                client.Close();
            }
        }

        private void radioButtonANT2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonANT2.Checked)
            {
                // Code für den Fall, dass die CheckBox aktiviert ist
                string server = "192.168.178.60";
                int port = 27299;
                // TCP-Client einrichten und verbinden
                TcpClient client = new TcpClient(server, port);


                //Nachrichten in Bytes konvertieren
                string message = "ANT21";
                byte[] data = Encoding.ASCII.GetBytes(message);


                // Datenstream abrufen und Nachrichten senden
                NetworkStream stream = client.GetStream();
                stream.Write(data, 0, data.Length);

                // Verbindung schließen
                stream.Close();
                client.Close();
            }
            else
            {
                // Code für den Fall, dass die CheckBox nicht aktiviert ist
                string server = "192.168.178.60";
                int port = 27299;
                // TCP-Client einrichten und verbinden
                TcpClient client = new TcpClient(server, port);


                //Nachrichten in Bytes konvertieren
                string message = "ANT20";
                byte[] data = Encoding.ASCII.GetBytes(message);


                // Datenstream abrufen und Nachrichten senden
                NetworkStream stream = client.GetStream();
                stream.Write(data, 0, data.Length);

                // Verbindung schließen
                stream.Close();
                client.Close();
            }
        }

        private void radioButtonANT3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonANT3.Checked)
            {
                // Code für den Fall, dass die CheckBox aktiviert ist
                string server = "192.168.178.60";
                int port = 27299;
                // TCP-Client einrichten und verbinden
                TcpClient client = new TcpClient(server, port);


                //Nachrichten in Bytes konvertieren
                string message = "ANT31";
                byte[] data = Encoding.ASCII.GetBytes(message);


                // Datenstream abrufen und Nachrichten senden
                NetworkStream stream = client.GetStream();
                stream.Write(data, 0, data.Length);

                // Verbindung schließen
                stream.Close();
                client.Close();
            }
            else
            {
                // Code für den Fall, dass die CheckBox nicht aktiviert ist
                string server = "192.168.178.60";
                int port = 27299;
                // TCP-Client einrichten und verbinden
                TcpClient client = new TcpClient(server, port);


                //Nachrichten in Bytes konvertieren
                string message = "ANT30";
                byte[] data = Encoding.ASCII.GetBytes(message);


                // Datenstream abrufen und Nachrichten senden
                NetworkStream stream = client.GetStream();
                stream.Write(data, 0, data.Length);

                // Verbindung schließen
                stream.Close();
                client.Close();
            }
        }
    }
}
