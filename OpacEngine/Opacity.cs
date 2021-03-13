using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpacEngine
{
    public class Opacity
    {
        public int R { get; set; }
        public int G { get; set; }
        public int B { get; set; }

        public Opacity(int r, int g, int b)
        {
            R = r;
            G = g;
            B = b;
        }

        public string Hex
        {
            get => return R.ToString("X2") + G.ToString("X2") + B.ToString("X2");
        }

        public void Save()
        {
            string fileName = $"{AppDomain.CurrentDomain.BaseDirectory}Opacities\\{Hex}.{OpacitySettings.OpacityFormat}";

            Bitmap bitmap = new Bitmap(OpacitySettings.OpacityResolution, OpacitySettings.OpacityResolution);

            using (Graphics gfx = Graphics.FromImage(bitmap))
            {
                using (SolidBrush sb = new SolidBrush(Color.FromArgb(R, G, B)))
                {
                    gfx.FillRectangle(sb, 0, 0, OpacitySettings.OpacityResolution, OpacitySettings.OpacityResolution);
                }
            }

            Directory.CreateDirectory(OpacitySettings.SavePath);

            ImageFormat format = OpacitySettings.OpacityFormat == "png" ? ImageFormat.Png : ImageFormat.Jpeg;

            bitmap.Save(fileName, format);
        }
    }
}
