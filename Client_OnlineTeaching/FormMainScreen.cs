using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_OnlineTeaching
{
    public partial class FrmMainScreen : Form
    {
        public FrmMainScreen()
        {
            InitializeComponent();
        }

        private void FrmMainScreen_Load(object sender, EventArgs e)
        {
            rtbShowText.Enabled = false;
            getLocalIpAddress();
        }

        private void btnCall_Click(object sender, EventArgs e)
        {
            //Declare the menu items and the shortcut menu.
            MenuItem[] menuItems = new MenuItem[]{
                new MenuItem("Make Call"),
                new MenuItem("Hang Up")};

            ContextMenu buttonMenu = new ContextMenu(menuItems);
            buttonMenu.Show(btnCall, new System.Drawing.Point(0, 30));
        }

        private void btnChat_Click(object sender, EventArgs e)
        {
            //Declare the menu items and the shortcut menu.
            MenuItem[] menuItems = new MenuItem[]{
                new MenuItem("Allow Student Chat"),
                new MenuItem("Don't Allow Student Chat")};

            ContextMenu buttonMenu = new ContextMenu(menuItems);
            buttonMenu.Show(btnChat, new System.Drawing.Point(0, 30));
        }

        private void btnAudio_Click(object sender, EventArgs e)
        {
            //Declare the menu items and the shortcut menu.
            MenuItem[] menuItems = new MenuItem[]{
                new MenuItem("Raise hand"),
                new MenuItem("Lower hand")};

            ContextMenu buttonMenu = new ContextMenu(menuItems);
            buttonMenu.Show(btnAudio, new System.Drawing.Point(0, 30));
        }

        private void btnVideo_Click(object sender, EventArgs e)
        {
            //Declare the menu items and the shortcut menu.
            MenuItem[] menuItems = new MenuItem[]{
                new MenuItem("Show webcam"),
                new MenuItem("Don't show webcam"),
                new MenuItem("Share desktop"),
                new MenuItem("View desktop")};

            ContextMenu buttonMenu = new ContextMenu(menuItems);
            buttonMenu.Show(btnVideo, new System.Drawing.Point(0, 30));
        }

        private void getLocalIpAddress()
        {
            String strHostName = string.Empty;
            // Getting Ip address of local machine...
            // First get the host name of local machine.
            strHostName = Dns.GetHostName();
            txtIpAddress.Text = ("Local Machine's Host Name: " + strHostName);
            // Then using host name, get the IP address list..
            IPHostEntry ipEntry = Dns.GetHostEntry(strHostName);
            IPAddress[] addr = ipEntry.AddressList;
            txtIpAddress.AppendText(" - " + addr[2]);
        }

    }
}
