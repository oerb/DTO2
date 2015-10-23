namespace DTO
{
    partial class RibbonDTOmain : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public RibbonDTOmain()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RibbonDTOmain));
            this.tabdto1 = this.Factory.CreateRibbonTab();
            this.grpMail = this.Factory.CreateRibbonGroup();
            this.btnMSG = this.Factory.CreateRibbonButton();
            this.btnMSGtypes = this.Factory.CreateRibbonButton();
            this.grpApointment = this.Factory.CreateRibbonGroup();
            this.btnDayPlan = this.Factory.CreateRibbonButton();
            this.grpSettings = this.Factory.CreateRibbonGroup();
            this.btnInfo = this.Factory.CreateRibbonButton();
            this.btnUserSettings = this.Factory.CreateRibbonButton();
            this.btnAdminSettings = this.Factory.CreateRibbonButton();
            this.tabdto1.SuspendLayout();
            this.grpMail.SuspendLayout();
            this.grpApointment.SuspendLayout();
            this.grpSettings.SuspendLayout();
            // 
            // tabdto1
            // 
            this.tabdto1.Groups.Add(this.grpMail);
            this.tabdto1.Groups.Add(this.grpApointment);
            this.tabdto1.Groups.Add(this.grpSettings);
            this.tabdto1.Label = "DTO";
            this.tabdto1.Name = "tabdto1";
            // 
            // grpMail
            // 
            this.grpMail.Items.Add(this.btnMSG);
            this.grpMail.Items.Add(this.btnMSGtypes);
            this.grpMail.Label = "Mail";
            this.grpMail.Name = "grpMail";
            // 
            // btnMSG
            // 
            this.btnMSG.Image = ((System.Drawing.Image)(resources.GetObject("btnMSG.Image")));
            this.btnMSG.Label = "Meldung";
            this.btnMSG.Name = "btnMSG";
            this.btnMSG.ShowImage = true;
            // 
            // btnMSGtypes
            // 
            this.btnMSGtypes.Image = ((System.Drawing.Image)(resources.GetObject("btnMSGtypes.Image")));
            this.btnMSGtypes.Label = "MSG Typen";
            this.btnMSGtypes.Name = "btnMSGtypes";
            this.btnMSGtypes.ShowImage = true;
            // 
            // grpApointment
            // 
            this.grpApointment.Items.Add(this.btnDayPlan);
            this.grpApointment.Label = "Termin";
            this.grpApointment.Name = "grpApointment";
            // 
            // btnDayPlan
            // 
            this.btnDayPlan.Image = ((System.Drawing.Image)(resources.GetObject("btnDayPlan.Image")));
            this.btnDayPlan.Label = "Tagesbericht";
            this.btnDayPlan.Name = "btnDayPlan";
            this.btnDayPlan.ShowImage = true;
            // 
            // grpSettings
            // 
            this.grpSettings.Items.Add(this.btnInfo);
            this.grpSettings.Items.Add(this.btnUserSettings);
            this.grpSettings.Items.Add(this.btnAdminSettings);
            this.grpSettings.Label = "Einstellungen";
            this.grpSettings.Name = "grpSettings";
            // 
            // btnInfo
            // 
            this.btnInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnInfo.Image")));
            this.btnInfo.Label = "Info";
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.ShowImage = true;
            // 
            // btnUserSettings
            // 
            this.btnUserSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnUserSettings.Image")));
            this.btnUserSettings.Label = "Benutzer";
            this.btnUserSettings.Name = "btnUserSettings";
            this.btnUserSettings.ShowImage = true;
            // 
            // btnAdminSettings
            // 
            this.btnAdminSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnAdminSettings.Image")));
            this.btnAdminSettings.Label = "Admin";
            this.btnAdminSettings.Name = "btnAdminSettings";
            this.btnAdminSettings.ShowImage = true;
            // 
            // RibbonDTOmain
            // 
            this.Name = "RibbonDTOmain";
            this.RibbonType = "Microsoft.Outlook.Explorer";
            this.Tabs.Add(this.tabdto1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.ribbonDTO_Load);
            this.tabdto1.ResumeLayout(false);
            this.tabdto1.PerformLayout();
            this.grpMail.ResumeLayout(false);
            this.grpMail.PerformLayout();
            this.grpApointment.ResumeLayout(false);
            this.grpApointment.PerformLayout();
            this.grpSettings.ResumeLayout(false);
            this.grpSettings.PerformLayout();

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonGroup grpMail;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnMSG;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup grpApointment;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnDayPlan;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup grpSettings;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnUserSettings;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnAdminSettings;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnMSGtypes;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnInfo;
        internal Microsoft.Office.Tools.Ribbon.RibbonTab tabdto1;
    }

    partial class ThisRibbonCollection
    {
        internal RibbonDTOmain ribbonDTO
        {
            get { return this.GetRibbon<RibbonDTOmain>(); }
        }
    }
}
