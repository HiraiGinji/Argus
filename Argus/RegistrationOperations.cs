using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Argus
{
    public class RegistrationOperations
    {
        private Timer fadeTimer;
        private float Opacity { get; set; }
        private bool FadingIn { get; set; }
        private int CurrentImageIndex { get; set; }
        private Image[] Images { get; set; }
        private Image CurrentImage { get; set; }
        private DateTime FadeOutStart { get; set; }

        private RegistrationForm form;

        public RegistrationOperations(RegistrationForm form)
        {
            this.form = form;
        }

        public void ChangeCityCMB(ComboBox CmbRegion, ComboBox CmbCity)
        {
            string[] regions =
            {
        "Region I – Ilocos Region",
        "Region II – Cagayan Valley",
        "Region III – Central Luzon",
        "Region IV‑A – CALABARZON",
        "MIMAROPA Region",
        "Region V – Bicol Region",
        "Region VI – Western Visayas",
        "Region VII – Central Visayas",
        "Region VIII – Eastern Visayas",
        "Region IX – Zamboanga Peninsula",
        "Region X – Northern Mindanao",
        "Region XI – Davao Region",
        "Region XII – SOCCSKSARGEN",
        "Region XIII – Caraga",
        "NCR – National Capital Region",
        "CAR – Cordillera Administrative Region",
        "BARMM – Bangsamoro Autonomous Region in Muslim Mindanao"
    };

            string[][] cities =
            {
        new[] { "Ilocos Norte", "Ilocos Sur", "La Union", "Pangasinan" },
        new[] { "Batanes", "Cagayan", "Isabela", "Nueva Vizcaya", "Quirino" },
        new[] { "Angeles", "Aurora", "Bataan", "Bulacan", "Nueva Ecija", "Olongapo", "Pampanga", "Tarlac", "Zambales" },
        new[] { "Batangas", "Cavite", "Lucena", "Laguna", "Quezon", "Rizal" },
        new[] { "Marinduque", "Occidental Mindoro", "Oriental Mindoro", "Palawan", "Puerto Princesa", "Romblon" },
        new[] { "Albay", "Camarines Norte", "Camarines Sur", "Catanduanes", "Masbate", "Sorsogon" },
        new[] { "Aklan", "Antique", "Bacolod", "Capiz", "Guimaras", "Iloilo", "Iloilo City", "Negros Occidental" },
        new[] { "Bohol", "Cebu", "Cebu City", "Lapu-Lapu", "Mandaue", "Negros Oriental", "Siquijor" },
        new[] { "Biliran", "Eastern Samar", "Leyte", "Northern Samar", "Samar", "Southern Leyte", "Tacloban" },
        new[] { "Isabela City", "Zamboanga City", "Zamboanga del Norte", "Zamboanga del Sur", "Zamboanga Sibugay" },
        new[] { "Bukidnon", "Cagayan de Oro", "Camiguin", "Iligan", "Lanao del Norte", "Misamis Occidental", "Misamis Oriental" },
        new[] { "Davao de Oro", "Davao City", "Davao del Norte", "Davao del Sur", "Davao Occidental", "Davao Oriental" },
        new[] { "Cotabato", "Cotabato City", "General Santos", "Sarangani", "South Cotabato", "Sultan Kudarat" },
        new[] { "Agusan del Norte", "Agusan del Sur", "Butuan", "Dinagat Islands", "Surigao del Norte", "Surigao del Sur" },
        new[] { "Caloocan", "Las Piñas", "Makati", "Malabon", "Mandaluyong", "Manila", "Marikina", "Muntinlupa", "Navotas", "Parañaque", "Pasay", "Pasig", "Pateros", "Quezon City", "San Juan", "Taguig", "Valenzuela" },
        new[] { "Abra", "Apayao", "Baguio", "Benguet", "Ifugao", "Kalinga", "Mountain Province" },
        new[] { "Basilan", "Lanao del Sur", "Maguindanao", "Sulu", "Tawi-Tawi" }
    };

            int selectedIndex = CmbRegion.SelectedIndex;

            if (selectedIndex >= 0 && selectedIndex < regions.Length)
            {
                CmbCity.Items.Clear();
                CmbCity.Items.AddRange(cities[selectedIndex]);
            }
        }


        public void HandleFormPaint(object sender, PaintEventArgs e)
        {
            if (CurrentImage != null)
            {
                Graphics g = e.Graphics;

                g.Clear(Color.Transparent);

                ColorMatrix colorMatrix = new ColorMatrix
                {
                    Matrix33 = Opacity
                };

                ImageAttributes attributes = new ImageAttributes();
                attributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                g.DrawImage(
                    CurrentImage,
                    new Rectangle(0, 0, form.Width, form.Height),
                    0, 0, CurrentImage.Width, CurrentImage.Height,
                    GraphicsUnit.Pixel,
                    attributes
                );
            }
        }
    }
}