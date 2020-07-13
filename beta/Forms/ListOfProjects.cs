using beta.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace beta.Forms
{
    public partial class ListOfProjects : Form
    {
        public ListOfProjects(List<Projet> projectList)
        {
            InitializeComponent();
            populatePanel(projectList);

        }

        private void populatePanel(List<Projet> projectList)
        {
            foreach(Projet p in projectList)
            {
                ProjectControl control = new ProjectControl(p);
                flowLayoutPanel.Controls.Add(control);
                control = null;
            }
        }

       
    }
}
