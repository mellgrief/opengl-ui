using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using opengl_ui.render.element;
using opengl_ui.render.impl;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Input;
using OpenTK.Graphics.OpenGL;
using opengl_ui.render.scenes;

namespace opengl_ui.render
{
    class RenderEngine : GameWindow
    {

        public static IScene currentScene;

        public RenderEngine() : base(800, 800, GraphicsMode.Default, "ZMEYA")
        {
            setScene(new MainScene());
        }
        
        public static void setScene(IScene sc)
        {
            currentScene = sc;
        }

        protected override void OnLoad(EventArgs e)
        {
            GL.ClearColor(1, 1, 1, 100);
            GL.Enable(EnableCap.Blend);
            GL.BlendFunc(BlendingFactor.SrcAlpha, BlendingFactor.OneMinusSrcAlpha);
            GL.MatrixMode(MatrixMode.Projection);
            GL.Ortho(0, 800, 800, 0, double.MinValue, double.MaxValue);
            GL.MatrixMode(MatrixMode.Modelview);
        }

        protected override void OnKeyDown(KeyboardKeyEventArgs e)
        {
            
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            foreach (Element el in currentScene.elements) el.onUpdate();
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            foreach (Element el in currentScene.elements) el.onRender();
        }


    }
}
