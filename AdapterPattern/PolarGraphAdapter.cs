using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    internal class PolarGraphAdapter : IGraph
    {
        private readonly PolarGraph _polarGraph;

        public PolarGraphAdapter(PolarGraph polarGraph)
        {
            _polarGraph = polarGraph;
        }
        public void Point(double x, double y)
        {
            double r = Math.Sqrt(x * x + y * y);
            double t = Math.Atan2(y, x);

            _polarGraph.Point(r, t);    
        }
    }
}
