using DevExpress.Utils.Html;
using DevExpress.Utils.Svg;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard.Shared.UI.ComponentFactory
{
    using System;
    using System.ComponentModel;
    using System.Drawing.Design; // SVG Seçici arayüzü için gerekli
    using System.Windows.Forms;
    using DevExpress.XtraEditors;
    using DevExpress.Utils; // SvgImageCollection için gerekli
    using DevExpress.Utils.Html;
    using DevExpress.Utils.Svg;

    [ToolboxItem(true)]
    public partial class MyPrimaryButton : UserControl
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

        public MyPrimaryButton()
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
