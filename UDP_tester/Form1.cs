using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace UDP_tester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        byte[] data = new byte[1024];
        IPEndPoint RemoteEndPoint;
        IPEndPoint localPoint;
        Socket server;
        int counter = 0;
        // event
        SocketAsyncEventArgs ev;

        private void Form1_Load(object sender, EventArgs e)
        {
            // localhost address
            textBox_Local_IP.Text = Dns.GetHostByName(Dns.GetHostName()).AddressList[0].ToString();

            // UDP client socket
            server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            // event
            ev = new SocketAsyncEventArgs();

            // local por bind (local port listening)
            localPoint = new IPEndPoint(IPAddress.Any, Convert.ToInt32(textBox_Local_Port.Text));
            try
            {
                server.Bind(localPoint);
            }
            catch (Exception ex)
            {
                if (ex.HResult == -2147467259) // local port already assigned
                {
                    // create a new random number
                    Random rnd = new Random();
                    int r = rnd.Next(3000, 6000);
                    textBox_Local_Port.Text = Convert.ToString(r);
                    localPoint = new IPEndPoint(IPAddress.Any, r);
                    server.Bind(localPoint);

                }
                else
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.HResult);
                }

            }
            
            //Console.WriteLine("waiting for a client....");

            // define the event linked to the socket
            ev.AcceptSocket = server;
            ev.Completed += OnReceive;
            ev.RemoteEndPoint = new IPEndPoint(IPAddress.Any, 0);
            ev.SetBuffer(new byte[1024], 0, 1024);

            udpRecv(ev);
        }

        private void udpRecv(SocketAsyncEventArgs udpRecvArg)
        {
            bool synchronous = false;
            try
            {
                synchronous = !udpRecvArg.AcceptSocket.ReceiveFromAsync(udpRecvArg);
            }
            catch (Exception e)
            {
                Console.WriteLine("recvUdp()\n" + e.ToString());
                return;
            }
            if (synchronous)
                OnReceive(this, udpRecvArg);
        }

        private void OnReceive(object sender, SocketAsyncEventArgs e)
        {
            string rec_msg;
            rec_msg = Encoding.ASCII.GetString(e.Buffer, 0, e.BytesTransferred);
            IPEndPoint ep = (IPEndPoint) e.RemoteEndPoint;
            //Console.WriteLine(rec_msg);
            AppendText(textBox_Message_Received, rec_msg);
            AppendText(textBox_Sender, ep.Address + ":" + ep.Port);

            udpRecv(ev);  // restart the reception of a new packet
        }

        delegate void SetTextCallback(TextBox textBox, string text);
        private void SetText(TextBox textBox, string text)
        {
            if (textBox.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { textBox, text });
            }
            else
            {
                textBox.Text = text;
            }
        }

        delegate void AppendTextCallback(TextBox textBox, string text);
        private void AppendText(TextBox textBox, string text)
        {
            if (textBox.InvokeRequired)
            {
                AppendTextCallback d = new AppendTextCallback(AppendText);
                this.Invoke(d, new object[] { textBox, text });
            }
            else
            {
                textBox.AppendText("\r\n" + text );
                textBox.ScrollToCaret();
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            string welcome = textBox_Message_Send.Text + " " + Convert.ToString(counter) + "\0";
            data = Encoding.ASCII.GetBytes(welcome);
            server.SendTo(data, data.Length, SocketFlags.None, RemoteEndPoint);
            textBox5.Text = Convert.ToString(counter);
            counter++;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Enabled = checkBox1.Checked;
            RemoteEndPoint = new IPEndPoint(IPAddress.Parse(textBox_Remote_IP.Text), Convert.ToInt32(textBoxRemote_Port.Text));

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            timer1.Interval = Convert.ToInt32(textBox2.Text);
        }

        private void buttonSetLocalPort_Click(object sender, EventArgs e)
        {
            server.Close();
            Form1_Load(this, e);

        }

        private void checkBox_Multicast_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox_Multicast.Checked == true)
            {
                IPAddress ip = IPAddress.Parse(textBox_Multicast_IP.Text);
                server.SetSocketOption(SocketOptionLevel.IP,
                    SocketOptionName.AddMembership,
                        new MulticastOption(ip, IPAddress.Any));
            }
            else
            {
                IPAddress ip = IPAddress.Parse(textBox_Multicast_IP.Text);
                server.SetSocketOption(SocketOptionLevel.IP,
                    SocketOptionName.DropMembership,
                        new MulticastOption(ip, IPAddress.Any));
            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBox_Message_Received.Clear();
            textBox_Sender.Clear();
        }

    }
}
