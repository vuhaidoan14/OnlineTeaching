using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_OnlineTeaching
{
    public partial class FrmClassList : Form
    {
        public FrmClassList()
        {
            InitializeComponent();
        }

        private void btnFrmClassList_Room_Click(object sender, EventArgs e)
        {
            //Declare the menu items and the shortcut menu.
            MenuItem[] menuItems = new MenuItem[]{
                new MenuItem("Creat Room"),
                new MenuItem("Remove Room"), 
                new MenuItem("Change Password")};

            ContextMenu buttonMenu = new ContextMenu(menuItems);
            buttonMenu.Show(btnFrmClassList_Room, new System.Drawing.Point(0, 40));
        }

        private void btnFrmClassList_User_Click(object sender, EventArgs e)
        {
            //Declare the menu items and the shortcut menu.
            MenuItem[] menuItems = new MenuItem[]{
                new MenuItem("Change Password"),
                new MenuItem("Remove User")};

            ContextMenu buttonMenu = new ContextMenu(menuItems);
            buttonMenu.Show(btnFrmClassList_User, new System.Drawing.Point(0, 0));
        }
    }
}
