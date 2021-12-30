using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    internal class Circle : Shape
    {
        private int x { get; set; }
        private int y { get; set; }
        private int radius { get; set; }

        public Circle(int x, int y, int radius, IDrawAPI drawAPI) 
        {
            this.drawAPI = drawAPI;
            this.radius = radius;
            this.y = y;
            this.x = x;
        }
        public override void Draw()
        {
            drawAPI.DrawCircle(this.x, this.y, this.radius);
        }
    }
}
