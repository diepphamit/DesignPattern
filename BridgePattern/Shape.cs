using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    internal abstract class Shape
    {
        public IDrawAPI drawAPI { get; set; }

        public abstract void Draw();
    }
}
