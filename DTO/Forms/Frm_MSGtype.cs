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
    public partial class Frm_MSGtype : Form
    {
        // takes Arguments: DTO_Parentform (this), formmode("new", "edit", "delet")
        public Frm_MSGtype(Forms.Frm_MSGtyp_Settings DTO_ParentForm, string formmode)
        {
            InitializeComponent();
            this._DTO_ParentForm = DTO_ParentForm;
        }

        private Forms.Frm_MSGtyp_Settings _DTO_ParentForm;
    }
}
