using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Design;
using System.Drawing;
using Tengine.Utils;

namespace Tengine
{

    class Canvas : Form {
        public Canvas() {
            this.DoubleBuffered = true;
        }
    }

    public abstract class Tengine
    {
        private Vector2D screenSize = new Vector2D(512, 512);
        private string title;
        private Canvas window = null;

        public Tengine(Vector2D screenSize, string title) {
            
            this.screenSize = screenSize;
            this.title = title;

            window = new Canvas();
            window.Size = new Size((int)screenSize.x, (int)screenSize.y);
            window.Text = title;

            Application.Run(window);

        }

        public abstract void onLoad();

    }

}
