using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TcpClient
{
    public partial class form1 : Form
    {

        string ipAddress = "127.0.0.1";
        int port = 5001;
        Socket clientSocket;
        byte[] buffer = new byte[512 * 1024];

        public form1()
        {
            InitializeComponent();
        }

        private void form1_Load(object sender, EventArgs e)
        {

            ipAddressBox.Text = ipAddress;
            portBox.Text = port.ToString();
        }

        private void form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (clientSocket != null)
            {
                clientSocket.Close();
                clientSocket = null;

            }
        }

        private void connectButton_Click(object sender, EventArgs e)
        {

            try
            {
                ipAddress = ipAddressBox.Text;
                port = int.Parse(portBox.Text);

                IPAddress remoteIP = IPAddress.Parse(ipAddress);
                IPEndPoint remoteEP = new IPEndPoint(remoteIP, port);



                if (clientSocket != null)

                    clientSocket.Close();


                clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                clientSocket.Connect(remoteEP);

                AppendContent(string.Format("connect {0}:{1}", ipAddress, port));

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);

            }

        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(inputBox.Text))
                {
                    MessageBox.Show("please input content.");
                    return;
                }



                if (clientSocket == null || !clientSocket.Connected)   
                {
                    MessageBox.Show("please connect first.");
                    return;
                }



                AppendContent(inputBox.Text);

                byte[] bytes = Encoding.UTF8.GetBytes(inputBox.Text);
                inputBox.Text = "";



                clientSocket.Send(bytes);



                //int length = clientSocket.Receive(buffer);

                //string receivedContent = Encoding.UTF8.GetString(buffer, 0, length);

                //AppendContent(receivedContent);

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);

            }
        }

        private void AppendContent(string str)
        {
            if (string.IsNullOrEmpty(contentBox.Text))

                contentBox.Text = str;
            else

                contentBox.Text = string.Format("{0}\n{1}", contentBox.Text, str);

        }
    }
}
