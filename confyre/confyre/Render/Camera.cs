﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using confyre.Render.Position;

namespace confyre.Render {
    internal class Camera {
        internal Pos2 location;
        internal int zoom;

        internal Camera() { }
        internal Camera(Pos2 position) : this() { }
        internal Camera(Pos2 position, int zoom) : this(position) { this.zoom = zoom; }

        internal Pos2 ScreenToWorld(Pos2 screenLocation) => screenLocation / zoom + location;
        internal Pos2 WorldToScreen(Pos2 worldLocation) => (worldLocation - location) * zoom;
    }
}
