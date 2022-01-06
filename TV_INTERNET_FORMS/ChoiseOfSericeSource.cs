using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServiceListSource;
using DB_TV_Internet_Billing;
using ServiceFromFile;

namespace TV_INTERNET_FORMS
{
    public partial class ChoiseOfSericeSource : Form
    {
        int client_ID;
        public ChoiseOfSericeSource(int client_id)
        {
            InitializeComponent();
            client_ID = client_id;
        }

        private void btn_DB_choice_Click(object sender, EventArgs e)
        {
            Service_Change change = new Service_Change(new DB_TV_Internet_Billinig(), client_ID);
            change.Show();
            this.Close();
        }

        private void btn_file_choice_Click(object sender, EventArgs e)
        {
            Service_Change change = new Service_Change(new FromFile(), client_ID);
            change.Show();
            this.Close();
        }
    }
}
