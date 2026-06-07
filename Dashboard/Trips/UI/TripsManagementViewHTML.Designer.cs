namespace Dashboard.Trips.UI
{
    partial class TripsManagementViewHTML
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TripsManagementViewHTML));
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.htmlContentControl2 = new DevExpress.XtraEditors.HtmlContentControl();
            this.svgImageCollection1 = new DevExpress.Utils.SvgImageCollection(this.components);
            this.tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dateButton = new DevExpress.XtraEditors.SimpleButton();
            this.createTripButton = new DevExpress.XtraEditors.SimpleButton();
            this.myHeader1 = new Dashboard.Shared.UI.ComponentFactory.MyHeader();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.tripTable = new DevExpress.XtraGrid.GridControl();
            this.dataTableView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tripId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.route = new DevExpress.XtraGrid.Columns.GridColumn();
            this.departure = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vehicle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.driver = new DevExpress.XtraGrid.Columns.GridColumn();
            this.status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.htmlContentControl3 = new DevExpress.XtraEditors.HtmlContentControl();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.htmlContentControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).BeginInit();
            this.tablePanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tripTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.htmlContentControl3)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.tablePanel1.Appearance.Options.UseBackColor = true;
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 55F)});
            this.tablePanel1.Controls.Add(this.htmlContentControl2);
            this.tablePanel1.Controls.Add(this.tablePanel2);
            this.tablePanel1.Controls.Add(this.panelControl1);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Padding = new System.Windows.Forms.Padding(24);
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 80F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 166F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F)});
            this.tablePanel1.Size = new System.Drawing.Size(1084, 734);
            this.tablePanel1.TabIndex = 0;
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
            this.htmlContentControl2.MaximumSize = new System.Drawing.Size(0, 135);
            this.htmlContentControl2.Name = "htmlContentControl2";
            this.tablePanel1.SetRow(this.htmlContentControl2, 1);
            this.htmlContentControl2.Size = new System.Drawing.Size(1036, 135);
            this.htmlContentControl2.TabIndex = 7;
            // 
            // svgImageCollection1
            // 
            this.svgImageCollection1.Add("bus", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.bus"))));
            this.svgImageCollection1.Add("id", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.id"))));
            this.svgImageCollection1.Add("route", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.route"))));
            this.svgImageCollection1.Add("timer", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.timer"))));
            this.svgImageCollection1.Add("plus", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.plus"))));
            this.svgImageCollection1.Add("calendar", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.calendar"))));
            this.svgImageCollection1.Add("download", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.download"))));
            this.svgImageCollection1.Add("filter", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.filter"))));
            // 
            // tablePanel2
            // 
            this.tablePanel1.SetColumn(this.tablePanel2, 0);
            this.tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 50F)});
            this.tablePanel2.Controls.Add(this.flowLayoutPanel1);
            this.tablePanel2.Controls.Add(this.myHeader1);
            this.tablePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel2.Location = new System.Drawing.Point(24, 24);
            this.tablePanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tablePanel2.Name = "tablePanel2";
            this.tablePanel1.SetRow(this.tablePanel2, 0);
            this.tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F)});
            this.tablePanel2.Size = new System.Drawing.Size(1036, 90);
            this.tablePanel2.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tablePanel2.SetColumn(this.flowLayoutPanel1, 1);
            this.flowLayoutPanel1.Controls.Add(this.dateButton);
            this.flowLayoutPanel1.Controls.Add(this.createTripButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(650, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.tablePanel2.SetRow(this.flowLayoutPanel1, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(386, 90);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // dateButton
            // 
            this.dateButton.Appearance.BackColor = System.Drawing.Color.White;
            this.dateButton.Appearance.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateButton.Appearance.ForeColor = System.Drawing.Color.Black;
            this.dateButton.Appearance.Options.UseBackColor = true;
            this.dateButton.Appearance.Options.UseFont = true;
            this.dateButton.Appearance.Options.UseForeColor = true;
            this.dateButton.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.dateButton.ImageOptions.ImageToTextIndent = 12;
            this.dateButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("dateButton.ImageOptions.SvgImage")));
            this.dateButton.Location = new System.Drawing.Point(0, 0);
            this.dateButton.Margin = new System.Windows.Forms.Padding(0);
            this.dateButton.MaximumSize = new System.Drawing.Size(150, 40);
            this.dateButton.Name = "dateButton";
            this.dateButton.Size = new System.Drawing.Size(150, 40);
            this.dateButton.TabIndex = 1;
            this.dateButton.Text = "Today, Oct 24";
            // 
            // createTripButton
            // 
            this.createTripButton.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(55)))));
            this.createTripButton.Appearance.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.createTripButton.Appearance.ForeColor = System.Drawing.Color.White;
            this.createTripButton.Appearance.Options.UseBackColor = true;
            this.createTripButton.Appearance.Options.UseFont = true;
            this.createTripButton.Appearance.Options.UseForeColor = true;
            this.createTripButton.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.createTripButton.ImageOptions.ImageToTextIndent = 12;
            this.createTripButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("createTripButton.ImageOptions.SvgImage")));
            this.createTripButton.Location = new System.Drawing.Point(166, 0);
            this.createTripButton.Margin = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.createTripButton.MaximumSize = new System.Drawing.Size(220, 40);
            this.createTripButton.Name = "createTripButton";
            this.createTripButton.Size = new System.Drawing.Size(220, 40);
            this.createTripButton.TabIndex = 0;
            this.createTripButton.Text = "Create New Schedule";
            this.createTripButton.Click += new System.EventHandler(this.NewTripButtonClicked);
            // 
            // myHeader1
            // 
            this.myHeader1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.myHeader1.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.myHeader1.Appearance.Options.UseBackColor = true;
            this.myHeader1.Appearance.Options.UseForeColor = true;
            this.tablePanel2.SetColumn(this.myHeader1, 0);
            this.myHeader1.Location = new System.Drawing.Point(3, 3);
            this.myHeader1.MaximumSize = new System.Drawing.Size(0, 90);
            this.myHeader1.MinimumSize = new System.Drawing.Size(0, 90);
            this.myHeader1.Name = "myHeader1";
            this.tablePanel2.SetRow(this.myHeader1, 0);
            this.myHeader1.Size = new System.Drawing.Size(644, 90);
            this.myHeader1.SubTitle = "Manage daily intercity bus routes and operations.";
            this.myHeader1.TabIndex = 0;
            this.myHeader1.Title = "Trip Management";
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.tablePanel1.SetColumn(this.panelControl1, 0);
            this.panelControl1.Controls.Add(this.tripTable);
            this.panelControl1.Controls.Add(this.htmlContentControl3);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(24, 249);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Padding = new System.Windows.Forms.Padding(0, 18, 0, 0);
            this.tablePanel1.SetRow(this.panelControl1, 2);
            this.panelControl1.Size = new System.Drawing.Size(1036, 461);
            this.panelControl1.TabIndex = 0;
            // 
            // tripTable
            // 
            this.tripTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tripTable.Location = new System.Drawing.Point(0, 93);
            this.tripTable.LookAndFeel.UseDefaultLookAndFeel = false;
            this.tripTable.MainView = this.dataTableView;
            this.tripTable.Margin = new System.Windows.Forms.Padding(0);
            this.tripTable.Name = "tripTable";
            this.tripTable.Size = new System.Drawing.Size(1036, 368);
            this.tripTable.TabIndex = 6;
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
            this.dataTableView.Appearance.Row.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.dataTableView.Appearance.Row.Options.UseBackColor = true;
            this.dataTableView.Appearance.Row.Options.UseFont = true;
            this.dataTableView.Appearance.Row.Options.UseForeColor = true;
            this.dataTableView.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.dataTableView.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dataTableView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.dataTableView.ColumnPanelRowHeight = 40;
            this.dataTableView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.tripId,
            this.route,
            this.departure,
            this.vehicle,
            this.driver,
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
            // tripId
            // 
            this.tripId.AppearanceCell.Options.UseTextOptions = true;
            this.tripId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.tripId.AppearanceHeader.Options.UseTextOptions = true;
            this.tripId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.tripId.Caption = "Trip ID";
            this.tripId.FieldName = "Id";
            this.tripId.MinWidth = 25;
            this.tripId.Name = "tripId";
            this.tripId.Visible = true;
            this.tripId.VisibleIndex = 0;
            this.tripId.Width = 94;
            // 
            // route
            // 
            this.route.Caption = "Route";
            this.route.FieldName = "RouteName";
            this.route.MinWidth = 25;
            this.route.Name = "route";
            this.route.Visible = true;
            this.route.VisibleIndex = 1;
            this.route.Width = 94;
            // 
            // departure
            // 
            this.departure.Caption = "Departure";
            this.departure.FieldName = "DepartureTime";
            this.departure.MinWidth = 25;
            this.departure.Name = "departure";
            this.departure.Visible = true;
            this.departure.VisibleIndex = 2;
            this.departure.Width = 94;
            // 
            // vehicle
            // 
            this.vehicle.Caption = "Vehicle";
            this.vehicle.FieldName = "VehiclePlate";
            this.vehicle.MinWidth = 25;
            this.vehicle.Name = "vehicle";
            this.vehicle.Visible = true;
            this.vehicle.VisibleIndex = 3;
            this.vehicle.Width = 94;
            // 
            // driver
            // 
            this.driver.Caption = "Driver";
            this.driver.FieldName = "DriverName";
            this.driver.MinWidth = 25;
            this.driver.Name = "driver";
            this.driver.Visible = true;
            this.driver.VisibleIndex = 4;
            this.driver.Width = 94;
            // 
            // status
            // 
            this.status.Caption = "Status";
            this.status.FieldName = "Status";
            this.status.MinWidth = 25;
            this.status.Name = "status";
            this.status.Visible = true;
            this.status.VisibleIndex = 5;
            this.status.Width = 94;
            // 
            // htmlContentControl3
            // 
            this.htmlContentControl3.Cursor = System.Windows.Forms.Cursors.Default;
            this.htmlContentControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.htmlContentControl3.HtmlImages = this.svgImageCollection1;
            this.htmlContentControl3.HtmlTemplate.Styles = resources.GetString("htmlContentControl3.HtmlTemplate.Styles");
            this.htmlContentControl3.HtmlTemplate.Template = resources.GetString("htmlContentControl3.HtmlTemplate.Template");
            this.htmlContentControl3.Location = new System.Drawing.Point(0, 18);
            this.htmlContentControl3.Margin = new System.Windows.Forms.Padding(0);
            this.htmlContentControl3.Name = "htmlContentControl3";
            this.htmlContentControl3.Size = new System.Drawing.Size(1036, 75);
            this.htmlContentControl3.TabIndex = 5;
            // 
            // TripsManagementViewHTML
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tablePanel1);
            this.Name = "TripsManagementViewHTML";
            this.Size = new System.Drawing.Size(1084, 734);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.htmlContentControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).EndInit();
            this.tablePanel2.ResumeLayout(false);
            this.tablePanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tripTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.htmlContentControl3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.Utils.SvgImageCollection svgImageCollection1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.HtmlContentControl htmlContentControl3;
        private DevExpress.XtraGrid.GridControl tripTable;
        private DevExpress.XtraGrid.Views.Grid.GridView dataTableView;
        private DevExpress.Utils.Layout.TablePanel tablePanel2;
        private Shared.UI.ComponentFactory.MyHeader myHeader1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton createTripButton;
        private DevExpress.XtraEditors.SimpleButton dateButton;
        private DevExpress.XtraEditors.HtmlContentControl htmlContentControl2;
        private DevExpress.XtraGrid.Columns.GridColumn tripId;
        private DevExpress.XtraGrid.Columns.GridColumn route;
        private DevExpress.XtraGrid.Columns.GridColumn departure;
        private DevExpress.XtraGrid.Columns.GridColumn vehicle;
        private DevExpress.XtraGrid.Columns.GridColumn driver;
        private DevExpress.XtraGrid.Columns.GridColumn status;
    }
}
