using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakersDefense
{
    class MapLocation : Point
    {
        public MapLocation(int x, int y, Map map) : base(x,y)
        {
            if (!map.onMap(this))
            {
                throw new OutOfBoundsException("tidak ada point nya");
            }
        }
    }
}
