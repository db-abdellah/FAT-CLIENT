using beta.Buisness;
using beta.Buisness.Imp;
using beta.Entities;
using beta.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace beta
{
    public partial class mainForm : Form
    {
        private List<Projet> projectList = new List<Projet>();
        public static  Utilisateur utilisateur = new Utilisateur();
        private Time timeForm;
        public static Label title;
        public mainForm(Utilisateur user)
        {
            GC.Collect();
            InitializeComponent();
            utilisateur = user;
            populateList();
            
           


            //Initialise Time Form
            timeForm = new Time();
            timeForm.TopLevel = false;
            setTimeForm();


            userName.Text = utilisateur.nomUtilisateur;
            //Hiding Form Bar
            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }

        //Populate Project List
        private void populateList()
        {
            ProjetBusiness projetB = new ProjetBusinessImp();
            projectList = projetB.getProjetsList(utilisateur);

        }

        //Close Window button
        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Minimize Window button
        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //Drag Form Setup
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        
        // Show All user's projects
        private void projectsBtn_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            topLabel.Text = "List des projets :";
            topLabel.Visible = true;
            Form form = new ListOfProjects(projectList);
            form.TopLevel = false;
            mainPanel.Controls.Add(form);
            form.Show();
        }


       
        //On user Image Click
        private void userImage_Click(object sender, EventArgs e)
        {
            setTimeForm();
        }
        
      
        //Adding Time Form to main panel
        private void setTimeForm()
        {
            mainPanel.Controls.Clear();
            topLabel.Visible = false;
            mainPanel.Controls.Add(timeForm);
            timeForm.Show();
        }

        private void mainPanel_ControlAdded(object sender, ControlEventArgs e)
        {
           Control[] form= mainPanel.Controls.Find("uploadForm",false);
            if (form.Length == 1)
            {
                uploadForm uploadForm = (uploadForm)form[0];
                topLabel.Text = uploadForm.projectTitle;

            }
           
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new login_Interface();
            form.ShowDialog();
            this.Close();
            GC.Collect();
        }
    }
}
