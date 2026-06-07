using Dashboard.Login.Interfaces;
using Dashboard.Login.Services;
using Dashboard.Shared;
using DevExpress.Internal.WinApi.Windows.UI.Notifications;
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

namespace Dashboard.Login.UI
{
    public partial class LoginView : XtraForm
    {
        private readonly IAuthService _authService = new AuthApiService(); 

        public LoginView()
        {
            InitializeComponent();
        }

        private async void LoginButtonClick(object sender, EventArgs e)
        {
            string emailOrPhone = txtEmailOrPhone.Text;
            string password = txtPassword.Text;

            if (emailOrPhone == "" || password == "")
            {
                XtraMessageBox.Show("Please fill the all blanks.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Arka arkaya butona tıklanmasını önlüyoruz.
            loginButton.Enabled = false;
            loginButton.Text = "Signing In...";

            var (isSuccess, errorMessage, userSession) = await _authService.LoginAsync(emailOrPhone, password);

            loginButton.Enabled = true;
            loginButton.Text = "Sign In";

            if (isSuccess)
            {
                GlobalState.Session = userSession;
                NavigateMainForm();
            }
            else
            {
                XtraMessageBox.Show(errorMessage, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NavigateMainForm()
        {
            MainForm anaForm = new MainForm();

            // 3. HAYATİ KOD: Ana form çarpıdan (X) kapatılırsa, gizli kalan Login formunu da tamamen kapat!
            // Bu kodu yazmazsanız, ana formu kapatsanız bile uygulamanız görev yöneticisinde gizlice çalışmaya devam eder.
            anaForm.FormClosed += (s, args) => this.Close();

            // 4. Ana formu ekranda göster
            anaForm.Show();

            // 5. İçinde bulunduğumuz Login formunu gizle
            this.Hide();
        }
    }
}