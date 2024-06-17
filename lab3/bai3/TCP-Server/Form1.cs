using SuperSimpleTcp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCP_Server
{
    public partial class Form1 : Form
    {
        private TcpListener server;
        private Thread listenThread;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            try
            {
                IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
                int port = int.Parse("8080");

                server = new TcpListener(ipAddress, port);
                server.Start();

                listenThread = new Thread(ListenForClients);
                listenThread.Start();

                AddMessageToDisplay("Server is running...");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ListenForClients()
        {
            try
            {
                while (true)
                {
                    TcpClient client = server.AcceptTcpClient();
                    Thread clientThread = new Thread(HandleClientComm);
                    clientThread.Start(client);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HandleClientComm(object client)
        {
            TcpClient tcpClient = (TcpClient)client;
            NetworkStream clientStream = tcpClient.GetStream();
            byte[] message = new byte[4096];
            int bytesRead;

            try
            {
                while ((bytesRead = clientStream.Read(message, 0, message.Length)) != 0)
                {
                    // Convert received bytes to string
                    string dataReceived = Encoding.ASCII.GetString(message, 0, bytesRead);
                    AddMessageToDisplay("Received from client: " + dataReceived);

                    // Echo back to client
                    byte[] response = Encoding.ASCII.GetBytes("Server received: " + dataReceived);
                    clientStream.Write(response, 0, response.Length);
                    clientStream.Flush();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                tcpClient.Close();
            }
        }

        private void AddMessageToDisplay(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(AddMessageToDisplay), message);
                return;
            }

            ReceivedMessagesListBox.Items.Add(message);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (server != null)
            {
                server.Stop();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
