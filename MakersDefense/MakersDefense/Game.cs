using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakersDefense
{
    class Game
    {
        static void Main(string[] args)
        {
            Map map = new Map(8,5);

            try
            {

                Path path = new Path(
                new[]
                {
                    new MapLocation(0, 2, map),
                    new MapLocation(1, 2, map),
                    new MapLocation(2, 2, map),
                    new MapLocation(3, 2, map),
                    new MapLocation(4, 2, map),
                    new MapLocation(5, 2, map),
                    new MapLocation(6, 2, map),
                    new MapLocation(7, 2, map)
                });
                MapLocation location = path.getLocationAt(9);
                               
                    Console.WriteLine(location.X + "," + location.Y);

            }
            catch(OutOfBoundsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (mdexception ex)
            {
                Console.WriteLine("Exception 2 : "+ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception 3 : "+ex.Message);
            }


            //Point point = new Point(8,5);
            //bool isOnMap = map.onMap(point);
            //Console.WriteLine(isOnMap);

            //Console.WriteLine(point.distanceTo(4,3));
            //Console.WriteLine();

            //MapLocation point2 = new MapLocation(8, 5);
            //isOnMap = map.onMap(point2);
            //Console.WriteLine(isOnMap);

            //Console.WriteLine(point2.distanceTo(7, 5));
        }
    }
}
