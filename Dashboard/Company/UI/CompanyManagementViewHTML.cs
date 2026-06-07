using Birlik.Shared.DTOs;
using Dashboard.Company.Interfaces;
using Dashboard.Company.Services;
using Dashboard.Shared;
using Dashboard.Shared.Http;
using Dashboard.Shared.Interfaces;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.Native;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Dashboard.Company.UI
{
    public partial class CompanyManagementViewHTML : DevExpress.XtraEditors.XtraUserControl, IRefreshable
    {
        private readonly ICompanyManagementService _companyService = new CompanyManagementApiService();
        private Dictionary<string, string> _originalValues = [];

        public CompanyManagementViewHTML()
        {
            InitializeComponent();
            EnableEditing(false);
        }

        public async Task RefreshDataAsync()
        {
            await LoadCompanyManagementDataAsync();
        }

        private async Task LoadCompanyManagementDataAsync()
        {
            IOverlaySplashScreenHandle handle = null;

            try
            {
                handle = SplashScreenManager.ShowOverlayForm(this);

                int currentCompanyId = GlobalState.Session.CompanyDto.Id;

                var pageData = await _companyService.GetPageDataAsync(currentCompanyId);

                if (pageData != null)
                {
                    htmlContentControl1.DataContext = new
                    {
                        CompanyName = pageData.CompanyName,
                        Location = pageData.Location,
                        Status = pageData.Status
                    };

                    txtName.Text = pageData.CompanyName;
                    txtEmail.Text = pageData.Email;
                    txtPhoneNumber.Text = pageData.ContactPhone;
                    txtAddress.Text = pageData.Location;

                    htmlContentControl4.DataContext = new
                    {
                        Vehicles = pageData.TotalVehicles,
                        Drivers = pageData.TotalDrivers,
                        Reservations = pageData.TotalReservations,
                    };
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Firma verileri yüklenirken bir hata oluştu: {ex.Message}", "Bağlantı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (handle != null)
                    SplashScreenManager.CloseOverlayForm(handle);
            }
        }

        private void EditButtonClicked(object sender, EventArgs e)
        {
            // Değişim kontrolü
            _originalValues.Clear();

            _originalValues.Add("Name", txtName.Text.Trim());
            _originalValues.Add("PhoneNumber", txtPhoneNumber.Text.Trim());
            _originalValues.Add("Email", txtEmail.Text.Trim());
            _originalValues.Add("Address", txtAddress.Text.Trim());

            EnableEditing(true);
        }

        private async void SaveButtonClicked(object sender, EventArgs e)
        {
            CompanyPatchDto patchDto = new();

            // Aalanları orijinal halleriyle kıyasla (Yalnızca değişenleri DTO'ya yaz)
            if (txtName.Text.Trim() != _originalValues["Name"])
                patchDto.CompanyName = txtName.Text.Trim();

            if (txtPhoneNumber.Text.Trim() != _originalValues["PhoneNumber"])
                patchDto.ContactPhone = txtPhoneNumber.Text.Trim();

            if (txtEmail.Text.Trim() != _originalValues["Email"])
                patchDto.Email = txtEmail.Text.Trim();

            if (txtAddress.Text.Trim() != _originalValues["Address"])
                patchDto.Location = txtAddress.Text.Trim();

            int companyId = GlobalState.Session.CompanyDto.Id;

            try
            {
                await _companyService.UpdatePageDataAsync(companyId, patchDto);

                htmlContentControl1.DataContext = new
                {
                    CompanyName = txtName.Text,
                    Location = txtAddress.Text,
                };

            } 
            catch (ApiException apiExp)
            {
                XtraMessageBox.Show($"Firma verileri güncellenirken bir hata oluştu: {apiExp.InnerException}", "Bağlantı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex) 
            {
                XtraMessageBox.Show($"Firma verileri güncellenirken bir hata oluştu: {ex.InnerException}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                XtraMessageBox.Show("Changes saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EnableEditing(false);
            }
        }

        private void EnableEditing(bool editingMode)
        {
            editButton.Enabled = !editingMode;

            // 2. Save Changes Butonu (HtmlContentControl içindeki buton)
            // Sadece düzenleme modundayken aktif olmalı
            saveButton.Enabled = editingMode;

            // 3. İçerideki TextEdit Alanları
            // Eğer düzenleme modu aktifse (true), ReadOnly (Salt Okunur) kapalı (false) olmalıdır.
            txtName.ReadOnly = !editingMode;
            txtPhoneNumber.ReadOnly = !editingMode;
            txtEmail.ReadOnly = !editingMode;
            txtAddress.ReadOnly = !editingMode;
        }
    }
}
