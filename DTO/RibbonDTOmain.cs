using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using Outlook = Microsoft.Office.Interop.Outlook;
using dialog = System.Windows.Forms;
using System.IO;
using System.Globalization;
using System.Windows.Forms;


namespace DTO
{
    public partial class RibbonDTOmain
    {
        private void RibbonDTOmain_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void btnMSGtypes_Click(object sender, RibbonControlEventArgs e)
        {
            Forms.Frm_MSGtyp_Settings frm_msgtypes_settins = new Forms.Frm_MSGtyp_Settings();
            frm_msgtypes_settins.Show();
        }
    }
}

// **** Infos ****
// Erstellen eines Ribbon, dass in Mails liegt. Vorgehensweise:
// 1. Ribbon erstellen, dass Controllid = TabMail ist (dazu auf Office stellen und TabCallendar oder TabMail einstellen)
// 2. Group erstellen, und Position festlegen unter Position: AfterOfficeId >> GroupCalender New (oder GoupMailNew)