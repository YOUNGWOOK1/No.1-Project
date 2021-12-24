using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestProgram
{


    public partial class Form1 : Form
    {
        

        static public string connectPort;
        static public string connectIpAddress;
        int 1;



        public Form1()
        {
            InitializeComponent();
           
         }

        private void connection_setting_Click(object sender, EventArgs e)
        {
            ConnectSetPage connect_set_page = new ConnectSetPage();
            connect_set_page.IpSendEvent += new ConnectSetPage.IpSendHandler(IpReciveEvent);
            connect_set_page.PortSendEvent += new ConnectSetPage.PortSendHandler(PortReciveEvent);
            connect_set_page.Show();
           
         }


        public void Form1_Load(object sender, EventArgs e)
        {

           


        }
        private void IpReciveEvent(string data)
        {
            label1.Text = data;
            connectIpAddress = data;


        }
        private void PortReciveEvent(string data)
        {
           
            label2.Text = data;
            connectPort = data;
        }


    }
}
        