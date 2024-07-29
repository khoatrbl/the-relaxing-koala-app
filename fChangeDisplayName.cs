using RestaurantIS.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantIS
{
    public partial class fChangeDisplayName : Form
    {
        private string username;

        public string Username { get => username; set => username = value; }

        public fChangeDisplayName(string username)
        {
            this.username = username;
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            ChangeDisplayName();
            this.Close();
        }

        private void ChangeDisplayName()
        {
            string newName = txbChangeDisplayName.Text;

            AccountDAO.InstanceOfAccountDAO.ChangeDisplayName(username, newName);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
