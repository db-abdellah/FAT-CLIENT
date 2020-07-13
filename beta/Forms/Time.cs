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
    public partial class Time : Form
    {
        public Time()
        {
            InitializeComponent();
            updateTime();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            updateTime();
           
        }
        private void updateTime()
        {
            dateLabel.Text = DateTime.Now.ToLongDateString();
            timeLabel.Text = DateTime.Now.ToShortTimeString();
        }
    }
}
