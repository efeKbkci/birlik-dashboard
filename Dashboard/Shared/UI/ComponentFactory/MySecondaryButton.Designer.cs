namespace Dashboard.Shared.UI.ComponentFactory
{
    partial class MySecondaryButton
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MySecondaryButton));
            this.htmlContentControl1 = new DevExpress.XtraEditors.HtmlContentControl();
            ((System.ComponentModel.ISupportInitialize)(this.htmlContentControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // htmlContentControl1
            // 
            this.htmlContentControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.htmlContentControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmlContentControl1.HtmlTemplate.Styles = resources.GetString("htmlContentControl1.HtmlTemplate.Styles");
            this.htmlContentControl1.HtmlTemplate.Template = "<div class=\"container\">\r\n\t<div id=\"btn-main\" class=\"btn\">\r\n    \t<img class=\"btn-i" +
    "con\" src=\"${Icon}\" />\r\n    \t<span class=\"btn-text\">${Text}</span>\r\n\t</div>\r\n</di" +
    "v>";
            this.htmlContentControl1.Location = new System.Drawing.Point(0, 0);
            this.htmlContentControl1.Margin = new System.Windows.Forms.Padding(0);
            this.htmlContentControl1.Name = "htmlContentControl1";
            this.htmlContentControl1.Size = new System.Drawing.Size(200, 48);
            this.htmlContentControl1.TabIndex = 0;
            // 
            // MySecondaryButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.htmlContentControl1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "MySecondaryButton";
            this.Size = new System.Drawing.Size(200, 48);
            ((System.ComponentModel.ISupportInitialize)(this.htmlContentControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.HtmlContentControl htmlContentControl1;
    }
}
