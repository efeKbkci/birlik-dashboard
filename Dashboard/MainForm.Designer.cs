namespace Dashboard
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.title = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.itemTripManagement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.itemReservationManagement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.itemVehicleManagement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.itemDriverManagement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.itemStopManagement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.itemCompanyInfo = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            this.accordionControlElement8 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.itemLogOut = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // fluentDesignFormContainer1
            // 
            this.fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer1.Location = new System.Drawing.Point(400, 35);
            this.fluentDesignFormContainer1.Margin = new System.Windows.Forms.Padding(10);
            this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            this.fluentDesignFormContainer1.Size = new System.Drawing.Size(598, 764);
            this.fluentDesignFormContainer1.TabIndex = 0;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Appearance.AccordionControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(55)))));
            this.accordionControl1.Appearance.AccordionControl.Options.UseBackColor = true;
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.title,
            this.itemTripManagement,
            this.itemReservationManagement,
            this.itemVehicleManagement,
            this.itemDriverManagement,
            this.itemStopManagement,
            this.itemCompanyInfo,
            this.itemLogOut});
            this.accordionControl1.HtmlTemplates.Group.Styles = resources.GetString("accordionControl1.HtmlTemplates.Group.Styles");
            this.accordionControl1.HtmlTemplates.Group.Template = "<div class=\"header-box\">\r\n    <div class=\"title\">Birlik</div>\r\n    <div class=\"su" +
    "btitle\">Fleet Operations</div>\r\n</div>";
            this.accordionControl1.HtmlTemplates.GroupContent.Template = "<div class=\"header-box\">\r\n    <div class=\"title\">Logistics Pro</div>\r\n    <div cl" +
    "ass=\"subtitle\">Fleet Operations</div>\r\n</div>";
            this.accordionControl1.HtmlTemplates.Item.Styles = resources.GetString("accordionControl1.HtmlTemplates.Item.Styles");
            this.accordionControl1.HtmlTemplates.Item.Template = "<div class=\"menu-item\">\r\n    <img src=\"${Image}\" class=\"icon\" />\r\n    <div class=" +
    "\"text\">${Text}</div>\r\n</div>";
            this.accordionControl1.Location = new System.Drawing.Point(0, 35);
            this.accordionControl1.Margin = new System.Windows.Forms.Padding(10);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.OptionsHamburgerMenu.HighlightRootElements = DevExpress.Utils.DefaultBoolean.False;
            this.accordionControl1.OptionsMinimizing.AllowMinimizeMode = DevExpress.Utils.DefaultBoolean.False;
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(400, 764);
            this.accordionControl1.TabIndex = 1;
            // 
            // title
            // 
            this.title.Appearance.Default.Font = new System.Drawing.Font("Inter", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.title.Appearance.Default.ForeColor = System.Drawing.Color.White;
            this.title.Appearance.Default.Options.UseFont = true;
            this.title.Appearance.Default.Options.UseForeColor = true;
            this.title.Appearance.Hovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(55)))));
            this.title.Appearance.Hovered.ForeColor = System.Drawing.Color.White;
            this.title.Appearance.Hovered.Options.UseBackColor = true;
            this.title.Appearance.Hovered.Options.UseForeColor = true;
            this.title.Name = "title";
            this.title.VisibleInFooter = false;
            // 
            // itemTripManagement
            // 
            this.itemTripManagement.Appearance.Default.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.itemTripManagement.Appearance.Default.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.itemTripManagement.Appearance.Default.Options.UseFont = true;
            this.itemTripManagement.Appearance.Default.Options.UseForeColor = true;
            this.itemTripManagement.Appearance.Hovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(225)))));
            this.itemTripManagement.Appearance.Hovered.ForeColor = System.Drawing.Color.White;
            this.itemTripManagement.Appearance.Hovered.Options.UseBackColor = true;
            this.itemTripManagement.Appearance.Hovered.Options.UseForeColor = true;
            this.itemTripManagement.Height = 40;
            this.itemTripManagement.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("itemTripManagement.ImageOptions.SvgImage")));
            this.itemTripManagement.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.itemTripManagement.Name = "itemTripManagement";
            this.itemTripManagement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.itemTripManagement.Text = "Trip Management";
            // 
            // itemReservationManagement
            // 
            this.itemReservationManagement.Appearance.Default.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.itemReservationManagement.Appearance.Default.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.itemReservationManagement.Appearance.Default.Options.UseFont = true;
            this.itemReservationManagement.Appearance.Default.Options.UseForeColor = true;
            this.itemReservationManagement.Appearance.Hovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(225)))));
            this.itemReservationManagement.Appearance.Hovered.ForeColor = System.Drawing.Color.White;
            this.itemReservationManagement.Appearance.Hovered.Options.UseBackColor = true;
            this.itemReservationManagement.Appearance.Hovered.Options.UseForeColor = true;
            this.itemReservationManagement.Height = 40;
            this.itemReservationManagement.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("itemReservationManagement.ImageOptions.SvgImage")));
            this.itemReservationManagement.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.itemReservationManagement.Name = "itemReservationManagement";
            this.itemReservationManagement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.itemReservationManagement.Text = "Reservation Management";
            // 
            // itemVehicleManagement
            // 
            this.itemVehicleManagement.Appearance.Default.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.itemVehicleManagement.Appearance.Default.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.itemVehicleManagement.Appearance.Default.Options.UseFont = true;
            this.itemVehicleManagement.Appearance.Default.Options.UseForeColor = true;
            this.itemVehicleManagement.Appearance.Hovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(225)))));
            this.itemVehicleManagement.Appearance.Hovered.ForeColor = System.Drawing.Color.White;
            this.itemVehicleManagement.Appearance.Hovered.Options.UseBackColor = true;
            this.itemVehicleManagement.Appearance.Hovered.Options.UseForeColor = true;
            this.itemVehicleManagement.Height = 40;
            this.itemVehicleManagement.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("itemVehicleManagement.ImageOptions.SvgImage")));
            this.itemVehicleManagement.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.itemVehicleManagement.Name = "itemVehicleManagement";
            this.itemVehicleManagement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.itemVehicleManagement.Text = "Vehicle Management";
            // 
            // itemDriverManagement
            // 
            this.itemDriverManagement.Appearance.Default.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.itemDriverManagement.Appearance.Default.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.itemDriverManagement.Appearance.Default.Options.UseFont = true;
            this.itemDriverManagement.Appearance.Default.Options.UseForeColor = true;
            this.itemDriverManagement.Appearance.Hovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(225)))));
            this.itemDriverManagement.Appearance.Hovered.ForeColor = System.Drawing.Color.White;
            this.itemDriverManagement.Appearance.Hovered.Options.UseBackColor = true;
            this.itemDriverManagement.Appearance.Hovered.Options.UseForeColor = true;
            this.itemDriverManagement.Height = 40;
            this.itemDriverManagement.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("itemDriverManagement.ImageOptions.SvgImage")));
            this.itemDriverManagement.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.itemDriverManagement.Name = "itemDriverManagement";
            this.itemDriverManagement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.itemDriverManagement.Text = "Driver Management";
            // 
            // itemStopManagement
            // 
            this.itemStopManagement.Appearance.Default.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.itemStopManagement.Appearance.Default.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.itemStopManagement.Appearance.Default.Options.UseFont = true;
            this.itemStopManagement.Appearance.Default.Options.UseForeColor = true;
            this.itemStopManagement.Appearance.Hovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(225)))));
            this.itemStopManagement.Appearance.Hovered.ForeColor = System.Drawing.Color.White;
            this.itemStopManagement.Appearance.Hovered.Options.UseBackColor = true;
            this.itemStopManagement.Appearance.Hovered.Options.UseForeColor = true;
            this.itemStopManagement.Height = 40;
            this.itemStopManagement.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("itemStopManagement.ImageOptions.SvgImage")));
            this.itemStopManagement.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.itemStopManagement.Name = "itemStopManagement";
            this.itemStopManagement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.itemStopManagement.Text = "Stop Management";
            // 
            // itemCompanyInfo
            // 
            this.itemCompanyInfo.Appearance.Default.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.itemCompanyInfo.Appearance.Default.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.itemCompanyInfo.Appearance.Default.Options.UseFont = true;
            this.itemCompanyInfo.Appearance.Default.Options.UseForeColor = true;
            this.itemCompanyInfo.Appearance.Hovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(225)))));
            this.itemCompanyInfo.Appearance.Hovered.ForeColor = System.Drawing.Color.White;
            this.itemCompanyInfo.Appearance.Hovered.Options.UseBackColor = true;
            this.itemCompanyInfo.Appearance.Hovered.Options.UseForeColor = true;
            this.itemCompanyInfo.Height = 40;
            this.itemCompanyInfo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("itemCompanyInfo.ImageOptions.SvgImage")));
            this.itemCompanyInfo.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.itemCompanyInfo.Name = "itemCompanyInfo";
            this.itemCompanyInfo.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.itemCompanyInfo.Text = "Company Info";
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(998, 35);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.Form = this;
            // 
            // accordionControlElement8
            // 
            this.accordionControlElement8.Name = "accordionControlElement8";
            this.accordionControlElement8.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement8.Text = "Element2";
            // 
            // itemLogOut
            // 
            this.itemLogOut.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accordionControlElement1.ImageOptions.SvgImage")));
            this.itemLogOut.Name = "itemLogOut";
            this.itemLogOut.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.itemLogOut.Text = "Log Out";
            this.itemLogOut.Click += new System.EventHandler(this.LogOutButtonClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 799);
            this.ControlContainer = this.fluentDesignFormContainer1;
            this.Controls.Add(this.fluentDesignFormContainer1);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Name = "MainForm";
            this.NavigationControl = this.accordionControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FluentDesignForm1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement title;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement itemTripManagement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement itemReservationManagement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement itemVehicleManagement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement itemDriverManagement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement itemStopManagement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement itemCompanyInfo;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement8;
        private DevExpress.XtraBars.Navigation.AccordionControlElement itemLogOut;
    }
}