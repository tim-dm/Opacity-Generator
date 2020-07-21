using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpacEngine
{
    public static class OpacitySettings
    {        
        private static int _brightnessFactor = 25;

        public static int OpacityResolution { get; set; } = 128;
        public static string OpacityFormat { get; set; } = "png";
        public static string SavePath = $"{AppDomain.CurrentDomain.BaseDirectory}Opacities\\";

        public static int BrightnessFactor
        {
            get { return _brightnessFactor; }
            set
            {
                if (value == _brightnessFactor)
                    return;

                if (value < 1 || value > 127)
                    _brightnessFactor = 1;
                else
                    _brightnessFactor = value;
            }
        }        
    }
}
