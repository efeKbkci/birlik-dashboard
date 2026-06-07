namespace Dashboard.Drivers.UI
{
    partial class DriversManagementViewHTML
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DriversManagementViewHTML));
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
            this.newDriverButton = new DevExpress.XtraEditors.SimpleButton();
            this.myHeader1 = new Dashboard.Shared.UI.ComponentFactory.MyHeader();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.tripTable = new DevExpress.XtraGrid.GridControl();
            this.dataTableView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.htmlContentControl3 = new DevExpress.XtraEditors.HtmlContentControl();
            this.svgImageCollection1 = new DevExpress.Utils.SvgImageCollection(this.components);
            this.htmlContentControl2 = new DevExpress.XtraEditors.HtmlContentControl();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).BeginInit();
            this.tablePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tripTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.htmlContentControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.htmlContentControl2)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.tablePanel1.Appearance.Options.UseBackColor = true;
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 55F)});
            this.tablePanel1.Controls.Add(this.tablePanel2);
            this.tablePanel1.Controls.Add(this.panelControl1);
            this.tablePanel1.Controls.Add(this.htmlContentControl2);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Padding = new System.Windows.Forms.Padding(24);
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 110F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 130F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F)});
            this.tablePanel1.Size = new System.Drawing.Size(1033, 734);
            this.tablePanel1.TabIndex = 1;
            // 
            // tablePanel2
            // 
            this.tablePanel1.SetColumn(this.tablePanel2, 0);
            this.tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 55F)});
            this.tablePanel2.Controls.Add(this.newDriverButton);
            this.tablePanel2.Controls.Add(this.myHeader1);
            this.tablePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel2.Location = new System.Drawing.Point(24, 24);
            this.tablePanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tablePanel2.Name = "tablePanel2";
            this.tablePanel1.SetRow(this.tablePanel2, 0);
            this.tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F)});
            this.tablePanel2.Size = new System.Drawing.Size(985, 90);
            this.tablePanel2.TabIndex = 3;
            // 
            // newDriverButton
            // 
            this.newDriverButton.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(55)))));
            this.newDriverButton.Appearance.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.newDriverButton.Appearance.ForeColor = System.Drawing.Color.White;
            this.newDriverButton.Appearance.Options.UseBackColor = true;
            this.newDriverButton.Appearance.Options.UseFont = true;
            this.newDriverButton.Appearance.Options.UseForeColor = true;
            this.tablePanel2.SetColumn(this.newDriverButton, 1);
            this.newDriverButton.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.newDriverButton.ImageOptions.ImageToTextIndent = 12;
            this.newDriverButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("newDriverButton.ImageOptions.SvgImage")));
            this.newDriverButton.Location = new System.Drawing.Point(785, 25);
            this.newDriverButton.Margin = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.newDriverButton.MaximumSize = new System.Drawing.Size(220, 40);
            this.newDriverButton.Name = "newDriverButton";
            this.tablePanel2.SetRow(this.newDriverButton, 0);
            this.newDriverButton.Size = new System.Drawing.Size(200, 40);
            this.newDriverButton.TabIndex = 1;
            this.newDriverButton.Text = "New Driver";
            this.newDriverButton.Click += new System.EventHandler(this.AddDriverButtonClicked);
            // 
            // myHeader1
            // 
            this.myHeader1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.myHeader1.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.myHeader1.Appearance.Options.UseBackColor = true;
            this.myHeader1.Appearance.Options.UseForeColor = true;
            this.tablePanel2.SetColumn(this.myHeader1, 0);
            this.myHeader1.Location = new System.Drawing.Point(3, 3);
            this.myHeader1.Name = "myHeader1";
            this.tablePanel2.SetRow(this.myHeader1, 0);
            this.myHeader1.Size = new System.Drawing.Size(763, 84);
            this.myHeader1.SubTitle = "Manage drivers status.";
            this.myHeader1.TabIndex = 0;
            this.myHeader1.Title = "Driver Management";
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.tablePanel1.SetColumn(this.panelControl1, 0);
            this.panelControl1.Controls.Add(this.tripTable);
            this.panelControl1.Controls.Add(this.htmlContentControl3);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(24, 246);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(0);
            this.panelControl1.Name = "panelControl1";
            this.tablePanel1.SetRow(this.panelControl1, 2);
            this.panelControl1.Size = new System.Drawing.Size(985, 464);
            this.panelControl1.TabIndex = 2;
            // 
            // tripTable
            // 
            this.tripTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tripTable.Location = new System.Drawing.Point(0, 60);
            this.tripTable.LookAndFeel.UseDefaultLookAndFeel = false;
            this.tripTable.MainView = this.dataTableView;
            this.tripTable.Margin = new System.Windows.Forms.Padding(0);
            this.tripTable.Name = "tripTable";
            this.tripTable.Size = new System.Drawing.Size(985, 404);
            this.tripTable.TabIndex = 8;
            this.tripTable.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dataTableView});
            // 
            // dataTableView
            // 
            this.dataTableView.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(198)))), ((int)(((byte)(208)))));
            this.dataTableView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dataTableView.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.dataTableView.Appearance.HeaderPanel.Options.UseFont = true;
            this.dataTableView.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.dataTableView.Appearance.HorzLine.Options.UseBackColor = true;
            this.dataTableView.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.dataTableView.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dataTableView.Appearance.Row.Options.UseBackColor = true;
            this.dataTableView.Appearance.Row.Options.UseFont = true;
            this.dataTableView.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.dataTableView.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dataTableView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.dataTableView.ColumnPanelRowHeight = 40;
            this.dataTableView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.status});
            this.dataTableView.GridControl = this.tripTable;
            this.dataTableView.Name = "dataTableView";
            this.dataTableView.OptionsBehavior.Editable = false;
            this.dataTableView.OptionsView.ShowGroupPanel = false;
            this.dataTableView.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.True;
            this.dataTableView.OptionsView.ShowIndicator = false;
            this.dataTableView.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            this.dataTableView.RowHeight = 40;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "First Name";
            this.gridColumn1.FieldName = "firstName";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 94;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Last Name";
            this.gridColumn2.FieldName = "lastName";
            this.gridColumn2.MinWidth = 25;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 94;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Phone Number";
            this.gridColumn3.FieldName = "phoneNumber";
            this.gridColumn3.MinWidth = 25;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            this.gridColumn3.Width = 94;
            // 
            // status
            // 
            this.status.Caption = "Status";
            this.status.FieldName = "status";
            this.status.MinWidth = 25;
            this.status.Name = "status";
            this.status.Visible = true;
            this.status.VisibleIndex = 0;
            this.status.Width = 94;
            // 
            // htmlContentControl3
            // 
            this.htmlContentControl3.Cursor = System.Windows.Forms.Cursors.Default;
            this.htmlContentControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.htmlContentControl3.HtmlImages = this.svgImageCollection1;
            this.htmlContentControl3.HtmlTemplate.Styles = resources.GetString("htmlContentControl3.HtmlTemplate.Styles");
            this.htmlContentControl3.HtmlTemplate.Template = resources.GetString("htmlContentControl3.HtmlTemplate.Template");
            this.htmlContentControl3.Location = new System.Drawing.Point(0, 0);
            this.htmlContentControl3.Margin = new System.Windows.Forms.Padding(0);
            this.htmlContentControl3.MaximumSize = new System.Drawing.Size(0, 60);
            this.htmlContentControl3.MinimumSize = new System.Drawing.Size(0, 60);
            this.htmlContentControl3.Name = "htmlContentControl3";
            this.htmlContentControl3.Size = new System.Drawing.Size(985, 60);
            this.htmlContentControl3.TabIndex = 7;
            // 
            // svgImageCollection1
            // 
            this.svgImageCollection1.Add("bus", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.bus"))));
            this.svgImageCollection1.Add("id", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.id"))));
            this.svgImageCollection1.Add("wrench", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.wrench"))));
            this.svgImageCollection1.Add("plus", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.plus"))));
            this.svgImageCollection1.Add("filter", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.filter"))));
            // 
            // htmlContentControl2
            // 
            this.tablePanel1.SetColumn(this.htmlContentControl2, 0);
            this.htmlContentControl2.Cursor = System.Windows.Forms.Cursors.Default;
            this.htmlContentControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmlContentControl2.HtmlImages = this.svgImageCollection1;
            this.htmlContentControl2.HtmlTemplate.Styles = resources.GetString("htmlContentControl2.HtmlTemplate.Styles");
            this.htmlContentControl2.HtmlTemplate.Template = resources.GetString("htmlContentControl2.HtmlTemplate.Template");
            this.htmlContentControl2.Location = new System.Drawing.Point(24, 114);
            this.htmlContentControl2.Margin = new System.Windows.Forms.Padding(0);
            this.htmlContentControl2.Name = "htmlContentControl2";
            this.tablePanel1.SetRow(this.htmlContentControl2, 1);
            this.htmlContentControl2.Size = new System.Drawing.Size(985, 132);
            this.htmlContentControl2.TabIndex = 1;
            // 
            // DriversManagementViewHTML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tablePanel1);
            this.Name = "DriversManagementViewHTML";
            this.Size = new System.Drawing.Size(1033, 734);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).EndInit();
            this.tablePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tripTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.htmlContentControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.htmlContentControl2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.HtmlContentControl htmlContentControl2;
        private DevExpress.Utils.SvgImageCollection svgImageCollection1;
        private DevExpress.Utils.Layout.TablePanel tablePanel2;
        private Shared.UI.ComponentFactory.MyHeader myHeader1;
        private DevExpress.XtraEditors.SimpleButton newDriverButton;
        private DevExpress.XtraGrid.GridControl tripTable;
        private DevExpress.XtraGrid.Views.Grid.GridView dataTableView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn status;
        private DevExpress.XtraEditors.HtmlContentControl htmlContentControl3;
    }
}
