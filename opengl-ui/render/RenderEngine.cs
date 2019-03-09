using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using opengl_ui.render.element;
using opengl_ui.render.impl;
using OpenTK;
using OpenTK.Graphics;

namespace opengl_ui.render
{
    class RenderEngine : GameWindow
    {

        public static IScene currentScene;
        public static List<Element> elements = new List<Element>();

        public RenderEngine() : base(800, 800, GraphicsMode.Default, "ZMEYA")
        {

        }
        
        public static void setScene(IScene sc)
        {
            currentScene = sc;
        }

    }
}
