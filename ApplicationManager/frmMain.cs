using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Components;
using MetroFramework.Forms;
using Security;

namespace ApplicationManager
{
   public partial class frmMain : MetroForm
   {

        public frmMain()
        {
            InitializeComponent();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void resetPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Security.Form1 frmLogin = new Form1();
            frmLogin.MdiParent = this;
            frmLogin.Show();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManager.showUserForm(this);
        }

        private void userRolesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
           
        }

        private void monoFlat_TrackBar1_ValueChanged()
        {

        }

        private void systemToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
