namespace Dashboard.Company.UI
{
    partial class CompanyManagementViewHTML
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyManagementViewHTML));
            this.svgImageCollection1 = new DevExpress.Utils.SvgImageCollection(this.components);
            this.htmlTemplateCollection1 = new DevExpress.Utils.Html.HtmlTemplateCollection();
            this.OverviewItemTemplate = new DevExpress.Utils.Html.HtmlTemplate();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.htmlContentControl4 = new DevExpress.XtraEditors.HtmlContentControl();
            this.htmlContentControl1 = new DevExpress.XtraEditors.HtmlContentControl();
            this.htmlContentControl2 = new DevExpress.XtraEditors.HtmlContentControl();
            this.htmlContentControl3 = new DevExpress.XtraEditors.HtmlContentControl();
            this.htmlTemplateCollection2 = new DevExpress.Utils.Html.HtmlTemplateCollection();
            this.ımageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.txtPhoneNumber = new DevExpress.XtraEditors.TextEdit();
            this.txtAddress = new DevExpress.XtraEditors.TextEdit();
            this.editButton = new DevExpress.XtraEditors.SimpleButton();
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.htmlContentControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.htmlContentControl1)).BeginInit();
            this.htmlContentControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.htmlContentControl2)).BeginInit();
            this.htmlContentControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.htmlContentControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ımageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // svgImageCollection1
            // 
            this.svgImageCollection1.Add("pencil", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.pencil"))));
            this.svgImageCollection1.Add("location", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.location"))));
            this.svgImageCollection1.Add("route", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.route"))));
            this.svgImageCollection1.Add("id", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.id"))));
            this.svgImageCollection1.Add("chart", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.chart"))));
            this.svgImageCollection1.Add("truck", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.truck"))));
            this.svgImageCollection1.Add("info", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.info"))));
            // 
            // htmlTemplateCollection1
            // 
            this.htmlTemplateCollection1.AddRange(new DevExpress.Utils.Html.HtmlTemplate[] {
            this.OverviewItemTemplate});
            // 
            // OverviewItemTemplate
            // 
            this.OverviewItemTemplate.Name = "OverviewItemTemplate";
            this.OverviewItemTemplate.Styles = resources.GetString("OverviewItemTemplate.Styles");
            this.OverviewItemTemplate.Template = resources.GetString("OverviewItemTemplate.Template");
            // 
            // tablePanel1
            // 
            this.tablePanel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.tablePanel1.Appearance.Options.UseBackColor = true;
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 60F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 40F)});
            this.tablePanel1.Controls.Add(this.htmlContentControl4);
            this.tablePanel1.Controls.Add(this.htmlContentControl1);
            this.tablePanel1.Controls.Add(this.htmlContentControl2);
            this.tablePanel1.Controls.Add(this.htmlContentControl3);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Padding = new System.Windows.Forms.Padding(24);
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 190F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F)});
            this.tablePanel1.Size = new System.Drawing.Size(1057, 777);
            this.tablePanel1.TabIndex = 2;
            // 
            // htmlContentControl4
            // 
            this.htmlContentControl4.AutoScroll = false;
            this.tablePanel1.SetColumn(this.htmlContentControl4, 1);
            this.htmlContentControl4.Cursor = System.Windows.Forms.Cursors.Default;
            this.htmlContentControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmlContentControl4.HtmlImages = this.svgImageCollection1;
            this.htmlContentControl4.HtmlTemplate.Styles = resources.GetString("htmlContentControl4.HtmlTemplate.Styles");
            this.htmlContentControl4.HtmlTemplate.Template = resources.GetString("htmlContentControl4.HtmlTemplate.Template");
            this.htmlContentControl4.Location = new System.Drawing.Point(629, 234);
            this.htmlContentControl4.Margin = new System.Windows.Forms.Padding(0);
            this.htmlContentControl4.Name = "htmlContentControl4";
            this.tablePanel1.SetRow(this.htmlContentControl4, 1);
            this.htmlContentControl4.Size = new System.Drawing.Size(404, 519);
            this.htmlContentControl4.TabIndex = 4;
            // 
            // htmlContentControl1
            // 
            this.htmlContentControl1.AutoScroll = false;
            this.tablePanel1.SetColumn(this.htmlContentControl1, 0);
            this.tablePanel1.SetColumnSpan(this.htmlContentControl1, 2);
            this.htmlContentControl1.Controls.Add(this.editButton);
            this.htmlContentControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.htmlContentControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmlContentControl1.HtmlImages = this.svgImageCollection1;
            this.htmlContentControl1.HtmlTemplate.Styles = resources.GetString("htmlContentControl1.HtmlTemplate.Styles");
            this.htmlContentControl1.HtmlTemplate.Template = resources.GetString("htmlContentControl1.HtmlTemplate.Template");
            this.htmlContentControl1.Location = new System.Drawing.Point(24, 24);
            this.htmlContentControl1.Margin = new System.Windows.Forms.Padding(0);
            this.htmlContentControl1.MaximumSize = new System.Drawing.Size(0, 195);
            this.htmlContentControl1.Name = "htmlContentControl1";
            this.tablePanel1.SetRow(this.htmlContentControl1, 0);
            this.htmlContentControl1.Size = new System.Drawing.Size(1009, 195);
            this.htmlContentControl1.TabIndex = 3;
            // 
            // htmlContentControl2
            // 
            this.htmlContentControl2.AutoScroll = false;
            this.tablePanel1.SetColumn(this.htmlContentControl2, 0);
            this.htmlContentControl2.Controls.Add(this.saveButton);
            this.htmlContentControl2.Controls.Add(this.txtAddress);
            this.htmlContentControl2.Controls.Add(this.txtPhoneNumber);
            this.htmlContentControl2.Controls.Add(this.txtEmail);
            this.htmlContentControl2.Controls.Add(this.txtName);
            this.htmlContentControl2.Cursor = System.Windows.Forms.Cursors.Default;
            this.htmlContentControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmlContentControl2.HtmlImages = this.svgImageCollection1;
            this.htmlContentControl2.HtmlTemplate.Styles = resources.GetString("htmlContentControl2.HtmlTemplate.Styles");
            this.htmlContentControl2.HtmlTemplate.Template = resources.GetString("htmlContentControl2.HtmlTemplate.Template");
            this.htmlContentControl2.Location = new System.Drawing.Point(24, 234);
            this.htmlContentControl2.Margin = new System.Windows.Forms.Padding(0, 0, 24, 0);
            this.htmlContentControl2.Name = "htmlContentControl2";
            this.tablePanel1.SetRow(this.htmlContentControl2, 1);
            this.htmlContentControl2.Size = new System.Drawing.Size(581, 519);
            this.htmlContentControl2.TabIndex = 2;
            // 
            // htmlContentControl3
            // 
            this.tablePanel1.SetColumn(this.htmlContentControl3, 1);
            this.htmlContentControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmlContentControl3.Location = new System.Drawing.Point(629, 24);
            this.htmlContentControl3.Margin = new System.Windows.Forms.Padding(0);
            this.htmlContentControl3.Name = "htmlContentControl3";
            this.tablePanel1.SetRow(this.htmlContentControl3, 0);
            this.htmlContentControl3.Size = new System.Drawing.Size(404, 210);
            this.htmlContentControl3.TabIndex = 1;
            // 
            // ımageCollection1
            // 
            this.ımageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ımageCollection1.ImageStream")));
            this.ımageCollection1.Images.SetKeyName(0, "sprinter_fleet.png");
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(44, 138);
            this.txtName.Margin = new System.Windows.Forms.Padding(0);
            this.txtName.Name = "txtName";
            this.txtName.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtName.Properties.Appearance.Options.UseBackColor = true;
            this.txtName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtName.Size = new System.Drawing.Size(493, 26);
            this.txtName.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(310, 233);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(0);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtEmail.Properties.Appearance.Options.UseBackColor = true;
            this.txtEmail.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtEmail.Size = new System.Drawing.Size(227, 26);
            this.txtEmail.TabIndex = 2;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(44, 233);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(0);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtPhoneNumber.Properties.Appearance.Options.UseBackColor = true;
            this.txtPhoneNumber.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtPhoneNumber.Size = new System.Drawing.Size(227, 26);
            this.txtPhoneNumber.TabIndex = 3;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(44, 328);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(0);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtAddress.Properties.Appearance.Options.UseBackColor = true;
            this.txtAddress.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtAddress.Size = new System.Drawing.Size(493, 26);
            this.txtAddress.TabIndex = 4;
            // 
            // editButton
            // 
            this.editButton.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.editButton.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.editButton.Appearance.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.editButton.Appearance.ForeColor = System.Drawing.Color.White;
            this.editButton.Appearance.Options.UseBackColor = true;
            this.editButton.Appearance.Options.UseFont = true;
            this.editButton.Appearance.Options.UseForeColor = true;
            this.editButton.AppearanceHovered.Options.UseBackColor = true;
            this.editButton.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.editButton.ImageOptions.ImageToTextIndent = 12;
            this.editButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editButton.ImageOptions.SvgImage")));
            this.editButton.Location = new System.Drawing.Point(838, 179);
            this.editButton.Name = "editButton";
            this.editButton.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.editButton.Size = new System.Drawing.Size(119, 28);
            this.editButton.TabIndex = 1;
            this.editButton.Text = "Edit Profile";
            this.editButton.Click += new System.EventHandler(this.EditButtonClicked);
            // 
            // saveButton
            // 
            this.saveButton.Appearance.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saveButton.Appearance.Options.UseFont = true;
            this.saveButton.Location = new System.Drawing.Point(399, 423);
            this.saveButton.Name = "saveButton";
            this.saveButton.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.saveButton.Size = new System.Drawing.Size(124, 29);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save Changes";
            this.saveButton.Click += new System.EventHandler(this.SaveButtonClicked);
            // 
            // CompanyManagementViewHTML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tablePanel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "CompanyManagementViewHTML";
            this.Size = new System.Drawing.Size(1057, 777);
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.htmlContentControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.htmlContentControl1)).EndInit();
            this.htmlContentControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.htmlContentControl2)).EndInit();
            this.htmlContentControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.htmlContentControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ımageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.Utils.SvgImageCollection svgImageCollection1;
        private DevExpress.Utils.Html.HtmlTemplateCollection htmlTemplateCollection1;
        private DevExpress.Utils.Html.HtmlTemplate OverviewItemTemplate;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.HtmlContentControl htmlContentControl3;
        private DevExpress.Utils.Html.HtmlTemplateCollection htmlTemplateCollection2;
        private DevExpress.XtraEditors.HtmlContentControl htmlContentControl2;
        private DevExpress.XtraEditors.HtmlContentControl htmlContentControl4;
        private DevExpress.XtraEditors.HtmlContentControl htmlContentControl1;
        private DevExpress.Utils.ImageCollection ımageCollection1;
        private DevExpress.XtraEditors.TextEdit txtAddress;
        private DevExpress.XtraEditors.TextEdit txtPhoneNumber;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.SimpleButton editButton;
        private DevExpress.XtraEditors.SimpleButton saveButton;
    }
}
