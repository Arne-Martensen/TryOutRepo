using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using obd=ObjectDefinitions.Geometry;

namespace Utils.Geometry
{
     class PointUtil
    {

        public static double Distance(obd.Point p1, obd.Point p2)
        {
            return Math.Sqrt(Math.Pow(p2.x - p1.x, 2) + Math.Pow(p2.y - p1.y, 2));
        }

    }
}
