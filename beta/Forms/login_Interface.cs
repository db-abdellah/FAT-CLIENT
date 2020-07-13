using beta.Buisness;
using beta.Business.Imp;
using beta.Entities;
using beta.Handlers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace beta
{
    public partial class login_Interface : Form
    {
        public login_Interface()
        {
            InitializeComponent();
            //Hiding Form Bar
            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            string s = "\u2022";
            password.PasswordChar = s[0];
        }
        //Load;

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {


            seConnecter(username.Text, password.Text);
           

        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void seConnecter(String username, String password)
        {
            infoError.Visible = false;
            if (username == "")
            {
                infoError.Text = "Veuillez entrer le nom d'utilisateur";
                infoError.Visible = true;
            }
            else if (password== "")

            {
                infoError.Text = "Veuillez entrer le mot de passe";
                infoError.Visible = true;


            }//authorizing
            else if (username!= "" && password != "")
            {
                if (ConnectionHandler.Instance.testConnction())
                {
                    UtilisiateurBusiness utilBusiness = new UtilisateurBusinessImp();
                    Utilisateur utilisateur = utilBusiness.connecterUtilisateur(username, password);


                    if (utilisateur == null)
                    {

                        infoError.Text = "Le nom d'utilisateur ou le mot de passe entré est incorrect";
                        infoError.Visible = true;
                    }
                    else
                    {
                        getMainForm(utilisateur);
                    }
                }
                else
                {
                    infoError.Text = "Erreur de connexion ";
                    infoError.Visible = true;
                }



            }



        }

        private void getMainForm(Utilisateur utilisateur)
        {
            this.Hide();
            Form form = new mainForm(utilisateur);
            form.ShowDialog();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
