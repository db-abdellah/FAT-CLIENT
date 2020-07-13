using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using beta.Entities;
using System.Threading;

namespace beta.Forms
{
    public partial class ProjectControl : UserControl
    {
        private Projet _project;

        public ProjectControl(Projet project)
        {
            _project = project;
            InitializeComponent();
            title.Text = project.nomProjet;
            this.Focus();
           
        }

       
        private void showUploadForm(Projet project)
        {
            Control[] mainPanel = this.TopLevelControl.Controls.Find("mainPanel", true);
            mainPanel[0].Controls.Clear();
            Form uploadForm = new uploadForm(project);
            uploadForm.TopLevel = false;
            mainPanel[0].Controls.Add(uploadForm);
            uploadForm.Show();
        }

        

        private void title_MouseLeave(object sender, EventArgs e)
        {
            this.title.BackColor = Color.FromArgb(36, 0, 70);
        }

        private void title_MouseHover(object sender, EventArgs e)
        {

            this.title.BackColor = Color.FromArgb(157, 78, 221);
        }

        private void title_Click(object sender, EventArgs e)
        {
            showUploadForm(_project);
        }
    }
}
