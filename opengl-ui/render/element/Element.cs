﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opengl_ui.render.element
{
    abstract class Element
    {
        public abstract void onUpdate();
        public abstract void onRender();
    }
}
