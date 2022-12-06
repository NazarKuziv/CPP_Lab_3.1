using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CPP_Lab_3._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SimpleTcpClient client;

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new SimpleTcpClient();
            client.StringEncoder = Encoding.UTF8;
            client.DataReceived += Client_DataRecieved;
            client.Connect("127.0.0.1", 8910);

        }

        private void Client_DataRecieved(object sender, SimpleTCP.Message e)
        {
            label.Invoke((MethodInvoker)delegate ()
            {
                label.Text = e.MessageString.Trim('');
            });
        }


        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            client.Disconnect();
        }

        private void Send_button_Click(object sender, EventArgs e)
        {  
            client.WriteLineAndGetReply(Message_tBox.Text, TimeSpan.FromSeconds(1));
        }
    }
}
