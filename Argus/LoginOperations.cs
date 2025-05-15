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
    public class LoginOperations
    {
        private Timer fadeTimer;
        private float Opacity { get; set; }
        private bool FadingIn { get; set; }
        private int CurrentImageIndex { get; set; }
        private Image[] Images { get; set; }
        private Image CurrentImage { get; set; }
        private DateTime FadeOutStart { get; set; }

        private Login form;
        public LoginOperations(Login form)
        {
            this.form = form;
            InitializeFadeEffect();
        }

        public void InitializeFadeEffect()
        {
            fadeTimer = new Timer
            {
                Interval = 50
            };
            fadeTimer.Tick += FadeTimer_Tick;
            fadeTimer.Start();
        }

        public void HandleFadeTimerTick(object sender, EventArgs e)
        {
            if (FadingIn)
            {
                Opacity += 0.05f;
                if (Opacity >= 1)
                {
                    Opacity = 1;
                    FadingIn = false;
                    FadeOutStart = DateTime.Now;
                }
            }
            else if ((DateTime.Now - FadeOutStart).TotalMilliseconds < 3000)
            {
            }
            else
            {
                Opacity -= 0.05f;
                if (Opacity <= 0)
                {
                    Opacity = 0;
                    FadingIn = true;
                    CurrentImageIndex = (CurrentImageIndex + 1) % Images.Length;
                    CurrentImage = Images[CurrentImageIndex];
                }
            }

            form.Invalidate(new Rectangle(0, 0, form.Width, form.Height));
        }

        private void FadeTimer_Tick(object sender, EventArgs e)
        {
            HandleFadeTimerTick(sender, e);
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
