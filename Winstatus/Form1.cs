using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winstatus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Status_Click(object sender, EventArgs e)
        {
           // if (sender.Equals(this.newToolStripMenuItem))
           if(this.newToolStripMenuItem.Equals(sender))
            {
                this.StatusLabel1.Text = "file";
            }else if (sender.Equals(this.openToolStripMenuItem))
            {
                this.StatusLabel1.Text = "open";
            }else if (sender.Equals(this.saveToolStripMenuItem))
            {
                this.StatusLabel1.Text = "save";
            }
            else
            {
                this.StatusLabel1.Text = "exit";
            }
        }
    }
}
