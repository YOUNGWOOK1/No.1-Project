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
    public partial class ConnectSetPage : Form
    {

        public delegate void IpSendHandler(string data);
        public delegate void PortSendHandler(string data);
        public event IpSendHandler IpSendEvent;
        public event PortSendHandler PortSendEvent;
        public string ipAdress;
        public string port;



        public ConnectSetPage()
        {
            InitializeComponent();
       

        }

        private void IpAdressInPut_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; //비프음 제거.
                this.connectbutton_Click(sender, e);
            }
        }
        private void PortInput_keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; 
                this.connectbutton_Click(sender, e) ;
                
            }
        }
        public void ConnectSetPage_Load(object sender, EventArgs e)
        {

            IpAdressInPut.Text = Properties.Settings.Default.StartIP;
            PortInput.Text = Properties.Settings.Default.StartPort;



        }
       
        


        private void connectbutton_Click(object sender, EventArgs e)
        {
            IpSendEvent(IpAdressInPut.Text);
            PortSendEvent(PortInput.Text);
            Properties.Settings.Default.StartIP = IpAdressInPut.Text;
            Properties.Settings.Default.StartPort = PortInput.Text;
            Properties.Settings.Default.Save();
        }




    }
}

