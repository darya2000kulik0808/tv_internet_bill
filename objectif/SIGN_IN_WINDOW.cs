using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clients;
using DB_TV_Internet_Billing;

namespace TV_INTERNET_FORMS
{
    public partial class SIGN_IN_WINDOW : Form
    {
        DB_TV_Internet_Billinig DataSet;

        public SIGN_IN_WINDOW()
        {
            InitializeComponent();
            DataSet = new DB_TV_Internet_Billinig();
        }

        private void btn_sign_in_Click(object sender, EventArgs e)
        {
            String login = tb_user_name_enter.Text;
            String pass = tb_password_enter.Text;

            foreach (Client member in DataSet.GetClients())
            {
                if (login == member.Client_login && pass == member.Client_password)
                {
                    Clients_Profile main = new Clients_Profile(member.ID_client);
                    this.Hide();
                    main.Show();
                }
            }
        }

        private void linkLabel_Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register_window reg = new Register_window();
            this.Hide();
            reg.Show();
        }

        private void SIGN_IN_WINDOW_Load(object sender, EventArgs e)
        {
            DB_TV_Internet_Billinig data = new DB_TV_Internet_Billinig();
            data.decrease_balance(DateTime.Now);
        }
    }
}
