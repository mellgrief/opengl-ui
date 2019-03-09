using OpenTK.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opengl_ui.utils
{
    class ColorUtils
    {
        public static Color4 ToRGBA(int HEX)
        {
            if ((HEX & -67108864) == 0)
            {
                HEX |= -16777216;
            }

            float red = (float)(HEX >> 16 & 255) / 255.0F;
            float blue = (float)(HEX >> 8 & 255) / 255.0F;
            float green = (float)(HEX & 255) / 255.0F;
            float alpha = (float)(HEX >> 24 & 255) / 255.0F;
            return new Color4(red, green, blue, alpha);
        }
    }
}
