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
    public partial class MyHeader : DevExpress.XtraEditors.XtraUserControl
    {
        private string _title = "Title";
        private string _subTitle = "Subtitle";


        [Category("Appearance")]
        public string Title
        {
            get => _title;
            set { _title = value; UpdateBinding(); }
        }

        [Category("Appearance")]
        public string SubTitle
        {
            get => _subTitle;
            set { _subTitle = value; UpdateBinding(); }
        }
        public MyHeader()
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
                Subtitle = _subTitle,
            };
        }
    }
}
