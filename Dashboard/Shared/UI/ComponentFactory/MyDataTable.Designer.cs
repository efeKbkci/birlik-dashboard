namespace Dashboard.Shared.UI.ComponentFactory
{
    partial class MyDataTable
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
            this.dataTable = new DevExpress.XtraGrid.GridControl();
            this.dataTableView = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTable
            // 
            this.dataTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataTable.Location = new System.Drawing.Point(0, 0);
            this.dataTable.LookAndFeel.UseDefaultLookAndFeel = false;
            this.dataTable.MainView = this.dataTableView;
            this.dataTable.Margin = new System.Windows.Forms.Padding(0);
            this.dataTable.Name = "dataTable";
            this.dataTable.Size = new System.Drawing.Size(792, 672);
            this.dataTable.TabIndex = 4;
            this.dataTable.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.dataTableView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.dataTableView.ColumnPanelRowHeight = 40;
            this.dataTableView.GridControl = this.dataTable;
            this.dataTableView.Name = "dataTableView";
            this.dataTableView.OptionsBehavior.Editable = false;
            this.dataTableView.OptionsView.ShowGroupPanel = false;
            this.dataTableView.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.True;
            this.dataTableView.OptionsView.ShowIndicator = false;
            this.dataTableView.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            this.dataTableView.RowHeight = 40;
            // 
            // MyDataTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataTable);
            this.Name = "MyDataTable";
            this.Size = new System.Drawing.Size(792, 672);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dataTable;
        private DevExpress.XtraGrid.Views.Grid.GridView dataTableView;
    }
}
