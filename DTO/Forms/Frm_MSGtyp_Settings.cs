using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DTO.Forms
{
    public partial class Frm_MSGtyp_Settings : Form
    {
        public Frm_MSGtyp_Settings()
        {
            InitializeComponent();
        }

        private void tsb_create_msgtyp_Click(object sender, EventArgs e)
        {
            Forms.Frm_MSGtype frm_New_MSGTYPE = new Frm_MSGtype(this, "new");
            DialogResult result = frm_New_MSGTYPE.ShowDialog();
        }

        private void tsb_edit_Click(object sender, EventArgs e)
        {
            Forms.Frm_MSGtype frm_New_MSGTYPE = new Frm_MSGtype(this, "edit");
            DialogResult result = frm_New_MSGTYPE.ShowDialog();
        }

        private void tsb_delete_Click(object sender, EventArgs e)
        {
            Forms.Frm_MSGtype frm_New_MSGTYPE = new Frm_MSGtype(this, "delet");
            DialogResult result = frm_New_MSGTYPE.ShowDialog();
        }
    }
}
