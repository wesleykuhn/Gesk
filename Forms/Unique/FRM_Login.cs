using Gesk.Library;
using Gesk.Library.Entities;
using System;
using System.Windows.Forms;

namespace Gesk.Forms.Unique
{
    public partial class FRM_Login : Bases.Default
    {
        public FRM_Login()
        {
            InitializeComponent();

            this.ReadyForm();

            this.UnableResize();
        }

        private void BTN_Login_Click(object sender, EventArgs e)
        {
            /*
            bool auth = false;

            foreach (User user in Global.Users)
            {
                if (user.Auth(TXT_User.Text.TrimStart().TrimEnd(), TXT_Password.Text.TrimStart().TrimEnd()))
                {
                    auth = true;
                    break;
                }
            }

            if (!auth)
            {
                MessageBox.Show("Por favor, verifique o usuário e senha digitados e tente novamente.", "Login Inválido");

                return;
            }
            else
            {

            }
            */

            this.Enabled = false;
            this.Hide();

            ErrorsCare.AntiInvalidInstance = false;

            FRM_Main frmMain = new FRM_Main();
            frmMain.ShowDialog();

            this.Enabled = true;
            this.Show();
        }

        private void TXT_Password_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) BTN_Login_Click(this, new EventArgs());
        }

        private void TXT_User_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) BTN_Login_Click(this, new EventArgs());
        }
    }
}
