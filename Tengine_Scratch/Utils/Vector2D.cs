using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tengine.Utils
{
    public class Vector2D
    {
        public float x {
            get;
            set;
        }

        public float y {
            get;
            set;
        }

        public Vector2D(float x = 0, float y = 0) {
            this.x = x;
            this.y = y;
        }

    }
}
