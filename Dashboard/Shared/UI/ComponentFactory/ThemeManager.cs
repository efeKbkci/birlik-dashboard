namespace Dashboard.Shared.UI.ComponentFactory
{
    public static class ThemeManager
    {
        // Projenin genel CSS kütüphanesi

        public static string ButtonCss => @"
            /* HTML ve BODY etiketlerinin ekranın tamamını kaplamasını sağlıyoruz */
            html, body {
                margin: 0;
                padding: 0;
                width: 100%;
                overflow: hidden;
            }

            .btn {
                display: flex;
                flex-direction: row;
                align-items: center;
                justify-content: center;

                padding: 10px 12px; 
        
                margin: 0px;
                border-radius: 4px;
                cursor: pointer;
                font-family: 'Segoe UI';
                font-size: 14px; 
                font-weight: 500;
            }

            .btn-icon {
                width: 16px;
                height: 16px;
                margin-right: 12px; 
            }

            .btn-primary {
                background-color: #001937;
                color: #FFFFFF;
                border: 1px solid #001937;
            }
    
            .btn-primary:hover {
                background-color: #1E293B;
            }

            .btn-secondary {
                background-color: #FFFFFF;
                color: #001937;
                border: 1px solid #C3C6D0;
            }
    
            .btn-secondary:hover {
                background-color: #F3F4F6;
            }
        ";

        public static string TextEditCss => @"
             /* TEXT EDIT TASARIMI */
            .text-edit-wrapper {
                position: absolute;
                top: 0; bottom: 0; left: 0; right: 0;
                display: flex;
                align-items: center;
                border: 1px solid #C3C6D0;
                border-radius: 4px;
                background-color: #FFFFFF;
            }
    
            /* Üzerine gelindiğinde veya tıklandığında kenarlık rengini koyulaştır */
            .text-edit-wrapper:hover, .text-edit-wrapper:focus-within {
                border: 1px solid #001937;
            }

            /* DevExpress'in html içine gömeceği input (metin kutusu) ayarları */
            .text-edit-input {
                width: 100%;
                border: none;
                background-color: transparent;
                font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
                font-size: 13px;
                color: #001937;
                margin-left: 8px; /* gap kullanmadığımız için sağ-sol boşlukları margin ile veriyoruz */
                margin-right: 8px;
                outline: none;
            }
        ";
    }
}
