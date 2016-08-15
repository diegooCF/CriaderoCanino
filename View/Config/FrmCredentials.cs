using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.Config
{
    public partial class FrmCredentials : Form
    {
        public FrmCredentials()
        {
            InitializeComponent();
        }

        private void FrmCredentials_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            chkGuestHelp.SetToolTip(chkGuest, "Acceder como invitado solo proporcionara permisos de consulta");
        }

        private void chkGuest_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGuest.Checked)
            {
                txtUser.Enabled = false;
                txtPassword.Enabled = false;
                chkGuest.Location = new Point(56, 67);
                lblAdvice.Visible = true;
            }
            else
            {
                txtUser.Enabled = true;
                txtPassword.Enabled = true;
                DataBaseConnection.StrConnection.UserID = null;
                DataBaseConnection.StrConnection.Password = null;
                lblAdvice.Visible = false;
                chkGuest.Location = new Point(56, 86);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //TODO Move this code to corresponding project
            if(chkGuest.Checked || (!string.IsNullOrWhiteSpace(txtUser.Text) && !string.IsNullOrWhiteSpace(txtPassword.Text)))
            {
                try
                {
                    if(chkGuest.Checked)
                    {
                        DataBaseConnection.StrConnection.UserID = "standard";
                        DataBaseConnection.StrConnection.Password = "standard";
                    }
                    else
                    {
                        DataBaseConnection.StrConnection.UserID = txtUser.Text;
                        DataBaseConnection.StrConnection.Password = txtPassword.Text;
                    }                
                    DataBaseConnection.MainConnection.OpenConnection();
                    DataBaseConnection.MainConnection.CloseConnection();
                    FrmMain form = new FrmMain();
                    form.Show();
                    Hide();
                }
                catch
                {
                    MessageBox.Show("Usuario o contraseña incorrectos", "Error de inicio de sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DataBaseConnection.MainConnection.CloseConnection();
                }
            }
            else
            {
                MessageBox.Show("Uno de los campos ingresados es invalido", "Error de inicio de sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
