﻿using opengl_ui.render;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opengl_ui
{
    class MainClass
    {
        public static void Main(String[] args)
        {
            using(RenderEngine re = new RenderEngine())
            {
                re.Run(60, 60);
            }
        }
    }
}
