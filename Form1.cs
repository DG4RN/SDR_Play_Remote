using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace SDR_Play_Remote
{

    public partial class Form1 : Form
    {
        private SerialPort serialPort;
               
        private TcpClient client = new TcpClient("192.168.178.60", 27299);
        private NetworkStream stream;
        private Thread receiveThread;

        

        public Form1()
        {
            InitializeComponent();
            this.serialPort = new SerialPort("COM28", 9600, Parity.None, 8, StopBits.One);
            this.serialPort.Open();

            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(PttHandler);
            
        }

        private void ReceiveMessages()
        {
            try
            {
                while (true)
                {
                    // Buffer für eingehende Daten
                    byte[] buffer = new byte[256];
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    if (bytesRead > 0)
                    {
                        string response = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                        // Füge die empfangene Nachricht zur Textbox hinzu
                        textBox3.Clear();
                        textBox3.Invoke((MethodInvoker)delegate
                        {
                            textBox3.AppendText("\n:" + response + Environment.NewLine);
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                // Setze den Verbindungsstatus
                //labelStatus.Invoke((MethodInvoker)delegate
                {
                    textBox3.AppendText("Link lost" +ex.Message);
                }
                
            }
        }


        private void btnCloseClick(object sender, EventArgs e)
        {
            NetworkStream stream = client.GetStream();
            stream.Close();
            client.Close();
            Application.Exit();
        }

        private void btnSendmsgClick(object sender, EventArgs e)
        {
            //Nachrichten in Bytes konvertieren
            string message = "TX";
            byte[] data = Encoding.ASCII.GetBytes(message);

            // Datenstream abrufen und Nachrichten senden
            NetworkStream stream = client.GetStream();
            stream.Write(data, 0, data.Length);

          
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
                   //Nachrichten in Bytes konvertieren
                    string message = "TX";
                    byte[] data = Encoding.ASCII.GetBytes(message);

                    textBox1.Text = "TX Aktiv";

                    // Datenstream abrufen und Nachrichten senden
                    NetworkStream stream = client.GetStream();
                    stream.Write(data, 0, data.Length);

                 
                    serialPort.DiscardInBuffer();
                    
                    label1.BackColor = Color.Red;
                }
                if ((buffer[0] == (byte)'R') && (buffer[1] == (byte)'X'))
                {
                    //Nachrichten in Bytes konvertieren
                    string message = "RX";
                    byte[] data = Encoding.ASCII.GetBytes(message);

                    textBox1.Text = "RX Aktiv";

                    // Datenstream abrufen und Nachrichten senden
                    NetworkStream stream = client.GetStream();
                    stream.Write(data, 0, data.Length);

                    
                    serialPort.DiscardInBuffer();
                    
                    label1.BackColor = Color.Green;
                }

            }

        }

        private void LNAcheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (LNAcheckBox1.Checked)
            {
                // Code für den Fall, dass die CheckBox aktiviert ist
               
                //Nachrichten in Bytes konvertieren
                string message = "LNA1";
                byte[] data = Encoding.ASCII.GetBytes(message);


                // Datenstream abrufen und Nachrichten senden
                NetworkStream stream = client.GetStream();
                stream.Write(data, 0, data.Length);

                
            }
            else
            {
                // Code für den Fall, dass die CheckBox nicht aktiviert ist
               
                //Nachrichten in Bytes konvertieren
                string message = "LNA0";
                byte[] data = Encoding.ASCII.GetBytes(message);


                // Datenstream abrufen und Nachrichten senden
                NetworkStream stream = client.GetStream();
                stream.Write(data, 0, data.Length);

                
            }
        }

        private void radioButtonANT1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonANT1.Checked)
            {
                // Code für den Fall, dass die CheckBox aktiviert ist
              
                //Nachrichten in Bytes konvertieren
                string message = "ANT11";
                byte[] data = Encoding.ASCII.GetBytes(message);


                // Datenstream abrufen und Nachrichten senden
                NetworkStream stream = client.GetStream();
                stream.Write(data, 0, data.Length);

                
            }
            else
            {
                // Code für den Fall, dass die CheckBox nicht aktiviert ist
               
                //Nachrichten in Bytes konvertieren
                string message = "ANT10";
                byte[] data = Encoding.ASCII.GetBytes(message);


                // Datenstream abrufen und Nachrichten senden
                NetworkStream stream = client.GetStream();
                stream.Write(data, 0, data.Length);

                
            }
        }

        private void radioButtonANT2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonANT2.Checked)
            {
                // Code für den Fall, dass die CheckBox aktiviert ist
                
                //Nachrichten in Bytes konvertieren
                string message = "ANT21";
                byte[] data = Encoding.ASCII.GetBytes(message);


                // Datenstream abrufen und Nachrichten senden
                NetworkStream stream = client.GetStream();
                stream.Write(data, 0, data.Length);

                
            }
            else
            {
                // Code für den Fall, dass die CheckBox nicht aktiviert ist
                
                //Nachrichten in Bytes konvertieren
                string message = "ANT20";
                byte[] data = Encoding.ASCII.GetBytes(message);


                // Datenstream abrufen und Nachrichten senden
                NetworkStream stream = client.GetStream();
                stream.Write(data, 0, data.Length);

                
            }
        }

        private void radioButtonANT3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonANT3.Checked)
            {
                // Code für den Fall, dass die CheckBox aktiviert ist
                
                //Nachrichten in Bytes konvertieren
                string message = "ANT31";
                byte[] data = Encoding.ASCII.GetBytes(message);


                // Datenstream abrufen und Nachrichten senden
                NetworkStream stream = client.GetStream();
                stream.Write(data, 0, data.Length);

                
            }
            else
            {
                // Code für den Fall, dass die CheckBox nicht aktiviert ist
                
                //Nachrichten in Bytes konvertieren
                string message = "ANT30";
                byte[] data = Encoding.ASCII.GetBytes(message);


                // Datenstream abrufen und Nachrichten senden
                NetworkStream stream = client.GetStream();
                stream.Write(data, 0, data.Length);

                
            }
        }

        private void btnClose_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(btnClose, "Stop of Programm");
        }

        private void radioButtonANT1_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(radioButtonANT1, "Switch Input SDR to Antenna 1");
        }

        private void radioButtonANT2_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(radioButtonANT2, "Switch Input SDR to Antenna 2");
        }

        private void radioButtonANT3_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(radioButtonANT3, "Switch Input SDR to Antenna 3");
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                
                // Erhalte den NetworkStream
                stream = client.GetStream();

                // Starte den Empfang-Thread
                receiveThread = new Thread(ReceiveMessages);
                receiveThread.Start();

                // Setze den Verbindungsstatus
                buttonConnect.Text = "linked";
            }
            catch (Exception ex)
            {
                buttonConnect.Text = ("Error" + ex.Message);
            }
        }
    }
}
