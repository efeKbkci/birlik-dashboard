using DevExpress.Utils.Html;
using DevExpress.Utils.Svg;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard.Shared.UI.ComponentFactory
{
    public partial class MySecondaryButton : DevExpress.XtraEditors.XtraUserControl
    {
        private string _buttonText = "Buton";
        private SvgImage _buttonSvgIcon;

        [Category("Appearance")]
        public string ButtonText
        {
            get => _buttonText;
            set { _buttonText = value; UpdateBinding(); }
        }

        [Category("Appearance")]
        [Editor("DevExpress.Utils.Design.SvgImageEditor, DevExpress.Design.v24.1", typeof(UITypeEditor))]
        public SvgImage ButtonSvgIcon
        {
            get => _buttonSvgIcon;
            set { _buttonSvgIcon = value; UpdateBinding(); }
        }

        public event EventHandler ButtonClick;

        public MySecondaryButton()
        {
            InitializeComponent();

            htmlContentControl1.ElementMouseClick += HtmlContentControl1_ElementMouseClick;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateBinding();
        }

        private void UpdateBinding()
        {
            if (htmlContentControl1 == null) return;

            htmlContentControl1.DataContext = new
            {
                Text = _buttonText,
                Icon = _buttonSvgIcon,
            };
        }

        private void HtmlContentControl1_ElementMouseClick(object sender, DxHtmlElementMouseEventArgs e)
        {
            if (e.ElementId == "btn-main")
            {
                ButtonClick?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
