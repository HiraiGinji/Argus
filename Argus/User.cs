using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Argus
{
    public partial class User : Form
    {
        bool SidebarExtend;
        settersGetters sgValues = new settersGetters();
        public User()
        {
            InitializeComponent();
        }

        private void User_Load(object sender, EventArgs e)
        {

            SidebarExtend = Sidebar.Width == Sidebar.MaximumSize.Width;
            addProdBtn();
        }

        private void Sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SideBarTimer_Tick(object sender, EventArgs e)
        {
            if (SidebarExtend)
            {
                Sidebar.Width -= 10;
                if (Sidebar.Width == Sidebar.MinimumSize.Width)
                {
                    SidebarExtend = false;
                    SideBarTimer.Stop();
                }
            }
            else
            {
                Sidebar.Width += 10;
                if (Sidebar.Width == Sidebar.MaximumSize.Width)
                {
                    SidebarExtend = true;
                    SideBarTimer.Stop();
                }
            }
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            SideBarTimer.Start();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_logout_user_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                new Login().Show();

                sgValues.sg_uid = null;
                sgValues.sg_user = null;

                this.Hide();
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_addproduct_user_Click(object sender, EventArgs e)
        {
            addProdBtn();
        }

        public void addProdBtn()
        {
            ContentPanel.Controls.Clear();
            POS_SystemControl posControl = new POS_SystemControl();
            posControl.Dock = DockStyle.Fill;
            ContentPanel.Controls.Add(posControl);
        }

        private void btn_search_user_Click(object sender, EventArgs e)
        {
            ContentPanel.Controls.Clear();
            SearchUserControl searchControl = new SearchUserControl();
            searchControl.Dock = DockStyle.Fill;
            ContentPanel.Controls.Add(searchControl);
        }

        private void ContentPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void header_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
