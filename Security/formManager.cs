using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Security
{
    public static class FormManager
    {
        public static void showUserForm(Form form)
        {
            frmUsers frmUsers = new frmUsers();
            frmUsers.MdiParent = form;
            frmUsers.Show();
        }
    }
}
