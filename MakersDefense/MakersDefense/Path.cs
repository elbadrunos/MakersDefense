using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakersDefense
{
    class Path
    {
        private readonly MapLocation[] _path;

        public Path(MapLocation[] path)
        {
            _path = path;
        }
        public MapLocation getLocationAt(int pathStep)
        {
            return pathStep < _path.Length ? _path[pathStep] : null;
        }
    }
}
