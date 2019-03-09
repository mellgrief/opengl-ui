using opengl_ui.render.element;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opengl_ui.render.impl
{
    abstract class IScene
    {
        public List<Element> elements = new List<Element>();

        public abstract void onUpdate();
    }
}
