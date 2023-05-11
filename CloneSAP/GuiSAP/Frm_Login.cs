using System;
using System.Windows.Forms;
using SAPLib.Funcions;
using SAPLib.Functions;
using SAPLib.Models;

namespace GuiSAP
{

    public partial class Frm_Login : Form
    {   
        UserLogado userlogado = new UserLogado();
        
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void txb_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_Password_TextChanged(object sender, EventArgs e)
        {

        }

        private async void Btn_Login_Click(object sender, EventArgs e)
        {

            var username = txb_username.Text;
            var password = txb_Password.Text;
            string token = await Request.RequestLogin(username, password);
            (string username, string id) valores = Decode.decodeToken(token);

            userlogado.Token = token;
            userlogado.Id = valores.id;
            userlogado.Name = valores.username;
            bool result = token == null;
            if (!result)
            {
                this.Hide();
                Frm_Home home = new Frm_Home();
                home.Show();
            }

        }

        private async void Frm_Login_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.Handled = e.SuppressKeyPress = true;
                var username = txb_username.Text;
                var password = txb_Password.Text;
                string token = await Request.RequestLogin(username, password);
                (string username, string id) valores = Decode.decodeToken(token);

                userlogado.Token = token;
                userlogado.Id = valores.id;
                userlogado.Name = valores.username;
                bool result = token == null;
                if (!result)
                {
                    this.Hide();
                    Frm_Home home = new Frm_Home();
                    home.Show();
                }

            }
        }

        private void txb_username_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
    
}
