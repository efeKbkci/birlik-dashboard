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
    public partial class MyInformationCard : DevExpress.XtraEditors.XtraUserControl
    {
        private string _title = "Buton";
        private string _value = "0";
        private SvgImage _cardSvgIcon;

        [Category("Appearance")]
        public string TitleText
        {
            get => _title;
            set { _title = value; UpdateBinding(); }
        }

        [Category("Appearance")]
        public string ValueText
        {
            get => _value;
            set { _value = value; UpdateBinding(); }
        }

        [Category("Appearance")]
        [Editor("DevExpress.Utils.Design.SvgImageEditor, DevExpress.Design.v24.1", typeof(UITypeEditor))]
        public SvgImage CardSvgIcon
        {
            get => _cardSvgIcon;
            set { _cardSvgIcon = value; UpdateBinding(); }
        }

        public MyInformationCard()
        {
            InitializeComponent();
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
                Title = _title,
                Value = _value,
                Icon = _cardSvgIcon,
            };
        }
    }
}
