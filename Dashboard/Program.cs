using Dashboard.Company.UI;
using Dashboard.Login.Services;
using Dashboard.Login.UI;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using DevExpress.Utils.Svg;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Dashboard
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // 1. GÖRSEL MOTORU AYAĞA KALDIRIYORUZ (Kesinlikle en üstte olmalı)
            DevExpress.XtraEditors.WindowsFormsSettings.SetDPIAware(); // Yazıların ve ikonların bulanıklaşmasını engeller
            DevExpress.XtraEditors.WindowsFormsSettings.ForceDirectXPaint(); // Tırtıklı çizgileri jilet gibi yapar
            DevExpress.XtraEditors.WindowsFormsSettings.EnableFormSkins();
            DevExpress.XtraEditors.WindowsFormsSettings.DefaultFont = new System.Drawing.Font("Inter", 9.5F, System.Drawing.FontStyle.Regular);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Uygulamanın global font motorunu Inter olarak set ediyoruz
            DevExpress.XtraEditors.WindowsFormsSettings.DefaultFont = new System.Drawing.Font("Inter", 9.5F, System.Drawing.FontStyle.Regular);

            // Yüksek çözünürlüklü ekranlarda (DPI) fontların pürüzsüz görünmesi için DirectX motorunu tetikliyoruz
            DevExpress.XtraEditors.WindowsFormsSettings.ForceDirectXPaint();

            // 1. Önce WXI temasını aktif ediyoruz.
            UserLookAndFeel.Default.SetSkinStyle(SkinStyle.WXI);

            // new LoginView()
            Application.Run(new LoginView());
        }
    }
}
